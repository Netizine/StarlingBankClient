using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using StarlingBank.Models;
using Type = System.Type;
namespace StarlingBank.Utilities
{
    public static class APIHelper
    {
        //DateTime format to use for parsing and converting dates
        public static string DateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";
        /// <summary>
        /// JSON Serialization of a given object.
        /// </summary>
        /// <param name="obj">The object to serialize into JSON</param>
        /// <param name="converter">The converter to use for date time conversion</param>
        /// <returns>The serialized Json string representation of the given object</returns>
        public static string JsonSerialize(object obj, JsonConverter converter = null)
        {
            if (null == obj)
                return null;
            var settings = new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            if (converter == null)
                settings.Converters.Add(new IsoDateTimeConverter());
            else
                settings.Converters.Add(converter);
            return JsonConvert.SerializeObject(obj, Formatting.None, settings);
        }
        /// <summary>
        /// JSON Deserialization of the given json string.
        /// </summary>
        /// <param name="json">The json string to deserialize</param>
        /// <param name="converter">The converter to use for date time conversion</param>
        /// <typeparam name="T">The type of the object to desialize into</typeparam>
        /// <returns>The deserialized object</returns>
        public static T JsonDeserialize<T>(string json, JsonConverter converter = null)
        {
            if (string.IsNullOrWhiteSpace(json))
                return default(T);
            if (converter == null)
                return JsonConvert.DeserializeObject<T>(json, new IsoDateTimeConverter());
            else
                return JsonConvert.DeserializeObject<T>(json, converter);
        }
        /// <summary>
        /// Replaces template parameters in the given url
        /// </summary>
        /// <param name="queryUrl">The query url string to replace the template parameters</param>
        /// <param name="parameters">The parameters to replace in the url</param>
        public static void AppendUrlWithTemplateParameters
            (StringBuilder queryBuilder, IEnumerable<KeyValuePair<string, object>> parameters)
        {
            //perform parameter validation
            if (null == queryBuilder)
                throw new ArgumentNullException("queryBuilder");
            if (null == parameters)
                return;
            //iterate and replace parameters
            foreach (KeyValuePair<string, object> pair in parameters)
            {
                var replaceValue = string.Empty;
                //load element value as string
                if (null == pair.Value)
                    replaceValue = "";
                else if (pair.Value is ICollection)
                    replaceValue = flattenCollection(pair.Value as ICollection, ArrayDeserialization.NONE, '/', false);
                else if (pair.Value is DateTime)
                    replaceValue = ((DateTime)pair.Value).ToString(DateTimeFormat);
                else if (pair.Value is DateTimeOffset)
                    replaceValue = ((DateTimeOffset)pair.Value).ToString(DateTimeFormat);
                else
                    replaceValue = pair.Value.ToString();
                replaceValue = Uri.EscapeUriString(replaceValue);
                //find the template parameter and replace it with its value
                queryBuilder.Replace($"{{{pair.Key}}}", replaceValue);
            }
        }
        /// <summary>
        /// Appends the given set of parameters to the given query string
        /// </summary>
        /// <param name="queryUrl">The query url string to append the parameters</param>
        /// <param name="parameters">The parameters to append</param>
        public static void AppendUrlWithQueryParameters
            (StringBuilder queryBuilder, IEnumerable<KeyValuePair<string, object>> parameters, ArrayDeserialization arrayDeserializationFormat = ArrayDeserialization.UN_INDEXED, char separator = '&')
        {
            //perform parameter validation
            if (null == queryBuilder)
                throw new ArgumentNullException("queryBuilder");
            if (null == parameters)
                return;
            //does the query string already has parameters
            var hasParams = (IndexOf(queryBuilder, "?") > 0);
            //iterate and append parameters
            foreach (KeyValuePair<string, object> pair in parameters)
            {
                //ignore null values
                if (pair.Value == null)
                    continue;
                //if already has parameters, use the &amp; to append new parameters
                queryBuilder.Append((hasParams) ? '&' : '?');
                //indicate that now the query has some params
                hasParams = true;
                string paramKeyValPair;
                //load element value as string
                if (pair.Value is ICollection)
                    paramKeyValPair = flattenCollection(pair.Value as ICollection, arrayDeserializationFormat, separator, true, pair.Key);
                else if (pair.Value is DateTime)
                    paramKeyValPair = $"{Uri.EscapeDataString(pair.Key)}={((DateTime)pair.Value).ToString(DateTimeFormat)}";
                else if (pair.Value is DateTimeOffset)
                    paramKeyValPair = $"{Uri.EscapeDataString(pair.Key)}={((DateTimeOffset)pair.Value).ToString(DateTimeFormat)}";
                else
                    paramKeyValPair = $"{Uri.EscapeDataString(pair.Key)}={Uri.EscapeDataString(pair.Value.ToString())}";
                //append keyval pair for current parameter
                queryBuilder.Append(paramKeyValPair);
            }
        }
        /// <summary>
        /// StringBuilder extension method to implement IndexOf functionality.
        /// This does a StringComparison.Ordinal kind of comparison.
        /// </summary>
        /// <param name="stringBuilder">The string builder to find the index in</param>
        /// <param name="strCheck">The string to locate in the string builder</param>
        /// <returns>The index of string inside the string builder</returns>
        private static int IndexOf(StringBuilder stringBuilder, string strCheck)
        {
            if (stringBuilder == null)
                throw new ArgumentNullException("stringBuilder");
            if (strCheck == null)
                return 0;
            //iterate over the input
            for (var inputCounter = 0; inputCounter < stringBuilder.Length; inputCounter++)
            {
                int matchCounter;
                //attempt to locate a potential match
                for (matchCounter = 0;
                        (matchCounter < strCheck.Length)
                        && (inputCounter + matchCounter < stringBuilder.Length)
                        && (stringBuilder[inputCounter + matchCounter] == strCheck[matchCounter]);
                    matchCounter++) ;
                //verify the match
                if (matchCounter == strCheck.Length)
                    return inputCounter;
            }
            return -1;
        }
        /// <summary>
        /// Validates and processes the given query Url to clean empty slashes
        /// </summary>
        /// <param name="queryBuilder">The given query Url to process</param>
        /// <returns>Clean Url as string</returns>
        public static string GetUrl(StarlingClient starlingClient, StringBuilder queryBuilder)
        {
            //convert to immutable string
            var baseUrl = starlingClient.Environment == ServerEnvironment.PRODUCTION ? "https://api.starlingbank.com/" : "https://api-sandbox.starlingbank.com/";
            var url = baseUrl + queryBuilder.ToString();
            //ensure that the urls are absolute
            Match match = Regex.Match(url, "^https?://[^/]+");
            if (!match.Success)
                throw new ArgumentException("Invalid Url format.");
            //remove redundant forward slashes
            var index = url.IndexOf('?');
            var protocol = match.Value;
            var query = url.Substring(protocol.Length, (index == -1 ? url.Length : index) - protocol.Length);
            query = Regex.Replace(query, "//+", "/");
            var parameters = index == -1 ? "" : url.Substring(index);
            //return process url
            return string.Concat(protocol, query, parameters);;
        }
        /// <summary>
        /// Used for flattening a collection of objects into a string 
        /// </summary>
        /// <param name="array">Array of elements to flatten</param>
        /// <param name="fmt">Format string to use for array flattening</param>
        /// <param name="separator">Separator to use for string concat</param>
        /// <returns>Representative string made up of array elements</returns>
        private static string flattenCollection(ICollection array, ArrayDeserialization fmt, char separator,
            bool urlEncode, string key = "")
        {
            var builder = new StringBuilder();
            var format = string.Empty;
            if (fmt == ArrayDeserialization.UN_INDEXED)
                format = $"{key}[]={{0}}{{1}}";
            else if (fmt == ArrayDeserialization.INDEXED)
                format = $"{key}[{{2}}]={{0}}{{1}}";
            else if (fmt == ArrayDeserialization.PLAIN)
                format = $"{key}={{0}}{{1}}";
            else if (fmt == ArrayDeserialization.CSV || fmt == ArrayDeserialization.PSV ||
                     fmt == ArrayDeserialization.TSV)
            {
                builder.Append($"{key}=");
                format = "{0}{1}";
            }
            else
                format = "{0}{1}";
            //append all elements in the array into a string
            var index = 0;
            foreach (var element in array)
                builder.AppendFormat(format, getElementValue(element, urlEncode), separator, index++);
            //remove the last separator, if appended
            if ((builder.Length > 1) && (builder[builder.Length - 1] == separator))
                builder.Length -= 1;
            return builder.ToString();
        }
        private static string getElementValue(object element, bool urlEncode)
        {
            string elemValue = null;
            //replace null values with empty string to maintain index order
            if (null == element)
                elemValue = string.Empty;
            else if (element is DateTime)
                elemValue = ((DateTime) element).ToString(DateTimeFormat);
            else if (element is DateTimeOffset)
                elemValue = ((DateTimeOffset) element).ToString(DateTimeFormat);
            else
                elemValue = element.ToString();
            if (urlEncode)
                elemValue = Uri.EscapeDataString(elemValue);
            return elemValue;
        }
        public static List<KeyValuePair<string, object>> PrepareFormFieldsFromObject(
            string name, object value, List<KeyValuePair<string, object>> keys = null, PropertyInfo propInfo = null, ArrayDeserialization arrayDeserializationFormat = ArrayDeserialization.UN_INDEXED)
        {
            keys = keys ?? new List<KeyValuePair<string, object>>();
            if (value == null)
            {
                return keys;
            }
            else if (value is Stream)
            {
                keys.Add(new KeyValuePair<string, object>(name,value));
                return keys;
            }
            else if (value is JObject)
            {
                var valueAccept = (value as JObject);
                foreach (var property in valueAccept.Properties())
                {
                    var pKey = property.Name;
                    object pValue = property.Value;
                    var fullSubName = name + '[' + pKey + ']';
                    PrepareFormFieldsFromObject(fullSubName, pValue, keys, propInfo,arrayDeserializationFormat);
                }
            }
            else if (value is IList)
            {
                var enumerator = ((IEnumerable) value).GetEnumerator();
                var hasNested = false;
                while (enumerator.MoveNext())
                {
                    var subValue = enumerator.Current;
                    if (subValue != null && (subValue is JObject || subValue is IList || subValue is IDictionary || !(subValue.GetType().Namespace.StartsWith("System"))))
                    {
                        hasNested = true;
                        break;
                    }
                }
                var i = 0;
                enumerator.Reset();
                while (enumerator.MoveNext())
                {
                    var fullSubName = name + '[' + i + ']';
                    if (!hasNested && arrayDeserializationFormat == ArrayDeserialization.UN_INDEXED)
                        fullSubName = name + "[]";
                    else if (!hasNested && arrayDeserializationFormat == ArrayDeserialization.PLAIN)
                        fullSubName = name;
                    var subValue = enumerator.Current;
                    if (subValue == null) continue;
                    PrepareFormFieldsFromObject(fullSubName, subValue, keys, propInfo,arrayDeserializationFormat);
                    i++;
                }
            }
            else if (value is JToken)
            {
                keys.Add(new KeyValuePair<string, object>(name, value.ToString()));
            }
            else if (value is Enum)
            {
                Assembly thisAssembly = typeof(APIHelper).GetTypeInfo().Assembly;
                var enumTypeName = value.GetType().FullName;
                Type enumHelperType = thisAssembly.GetType($"{enumTypeName}Helper");
                object enumValue = (int) value;
                if (enumHelperType != null)
                {
                    //this enum has an associated helper, use that to load the value
                    MethodInfo enumHelperMethod = enumHelperType.GetRuntimeMethod("ToValue", new[] { value.GetType() });
                    if (enumHelperMethod != null)
                        enumValue = enumHelperMethod.Invoke(null, new object[] {value});
                }
                keys.Add(new KeyValuePair<string, object>(name, enumValue));
            }
            else if (value is IDictionary)
            {
                var obj = (IDictionary) value;
                foreach (var sName in obj.Keys)
                {
                    var subName = sName.ToString();
                    var subValue = obj[subName];
                    var fullSubName = string.IsNullOrWhiteSpace(name) ? subName : name + '[' + subName + ']';
                    PrepareFormFieldsFromObject(fullSubName, subValue, keys, propInfo,arrayDeserializationFormat);
                }
            }
            else if (!(value.GetType().Namespace.StartsWith("System")))
            {
                //Custom object Iterate through its properties
                var enumerator = value.GetType().GetRuntimeProperties().GetEnumerator();
                PropertyInfo pInfo = null;
                var t = new JsonPropertyAttribute().GetType();
                while (enumerator.MoveNext())
                {
                    pInfo = enumerator.Current as PropertyInfo;
                    var jsonProperty = (JsonPropertyAttribute) pInfo.GetCustomAttributes(t, true).FirstOrDefault();
                    var subName = (jsonProperty != null) ? jsonProperty.PropertyName : pInfo.Name;
                    var fullSubName = string.IsNullOrWhiteSpace(name) ? subName : name + '[' + subName + ']';
                    var subValue = pInfo.GetValue(value, null);
                    PrepareFormFieldsFromObject(fullSubName, subValue, keys, pInfo,arrayDeserializationFormat);
                }
            }
            else if (value is DateTime)
            {
                string convertedValue = null;
                object[] pInfo = null;
                if(propInfo!=null)
                    pInfo = propInfo.GetCustomAttributes(true);
                if (pInfo != null)
                {
                    foreach (var attr in pInfo)
                    {
                        var converterAttr = attr as JsonConverterAttribute;
                        if (converterAttr != null)
                            convertedValue =
                                JsonSerialize(value,
                                    (JsonConverter)
                                        Activator.CreateInstance(converterAttr.ConverterType,
                                            converterAttr.ConverterParameters)).Replace("\"", "");
                    }
                }
                keys.Add(new KeyValuePair<string, object>(name, (convertedValue) ?? ((DateTime)value).ToString(DateTimeFormat))); 
            }
            else
            {
                keys.Add(new KeyValuePair<string, object>(name,value));
            }
            return keys;
        }
        /// <summary>
        /// Add/update entries with the new dictionary.
        /// </summary>
        /// <param name="dictionary"></param>
        /// <param name="dictionary2"></param>
        public static void Add(this Dictionary<string, object> dictionary, Dictionary<string, object> dictionary2)
        {
            foreach (var kvp in dictionary2)
            {
                dictionary[kvp.Key] = kvp.Value;
            }
        }
        public static Dictionary<string, string> GetRequestHeaders(StarlingClient starlingClient, bool excludeAcceptHeader = false)
        {
            Dictionary<string, string> headers;
            if (excludeAcceptHeader)
            {
                headers = new Dictionary<string, string>();
            }
            else
            {
                headers = new Dictionary<string, string>
                {
                    {"accept", "application/json"}
                };
            }
            headers.Add("Authorization", $"Bearer {starlingClient.OAuthAccessToken}");
            return headers;
        }
        public static Dictionary<string, string> GetContentRequestHeaders(StarlingClient starlingClient, bool includeAcceptType = false)
        {
            Dictionary<string, string> headers;
            if (includeAcceptType)
            {
                headers = new Dictionary<string, string>
                {
                    { "accept", "application/json" },
                    { "content-type", "application/json; charset=utf-8" }
                };
            }
            else
            {
                headers = new Dictionary<string, string>
                {
                    { "content-type", "application/json; charset=utf-8" }
                };
            }
            headers.Add("Authorization", $"Bearer {starlingClient.OAuthAccessToken}");
            return headers;
        }
    }
}
