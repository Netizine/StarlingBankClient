using System;
using System.Collections;
using System.Reflection;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    public class StringValuedEnumConverter : JsonConverter
    {
        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The json writer</param>
        /// <param name="value">The value to write</param>
        /// <param name="serializer">The calling serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }

            //handle string valued enums in dictionaries
            if (value is IDictionary)
            {
                writer.WriteStartObject();
                foreach (object keyValuePair in value as IDictionary)
                {
                    var entry = (DictionaryEntry)keyValuePair;
                    writer.WritePropertyName(entry.Key.ToString());
                    WriteStringValue(writer, entry.Value);
                }

                writer.WriteEndObject();
            }
            //handle string valued enums in lists
            else if (value is IEnumerable)
            {
                writer.WriteStartArray();
                foreach (object item in value as IEnumerable) WriteStringValue(writer, item);
                writer.WriteEndArray();
            }
            //handle string valued enums
            else
                WriteStringValue(writer, value);
        }

        /// <summary>
        /// Loads and writes the string value against a given enum element
        /// </summary>
        /// <param name="value">The string valued enum element value</param>
        private static void WriteStringValue(JsonWriter writer, object value)
        {
            System.Type enumHelperType = loadHelperType(value.GetType());
            MethodInfo enumHelperMethod = enumHelperType.GetRuntimeMethod("ToValue", new[] {value.GetType()});
            object stringValue = enumHelperMethod.Invoke(null, new object[] {value});
            if (stringValue != null)
                writer.WriteValue(stringValue);
            else
                writer.WriteNull();
        }

        /// <summary>
        /// Load the enum helper class against a given enum type
        /// </summary>
        /// <param name="enumType">The enum type to locate the helper</param>
        /// <returns>System.Type of the helper class for the given enum type</returns>
        private static System.Type loadHelperType(System.Type enumType)
        {
            var isNullableGeneric = enumType.GetTypeInfo().IsGenericType && enumType.GetGenericTypeDefinition() == typeof(Nullable<>);
            Assembly assembly = isNullableGeneric ? Nullable.GetUnderlyingType(enumType).GetTypeInfo().Assembly : enumType.GetTypeInfo().Assembly;
            var enumHelperClassName = $"{(isNullableGeneric ? Nullable.GetUnderlyingType(enumType).FullName : enumType.FullName)}Helper";
            System.Type enumHelperType = assembly.GetType(enumHelperClassName);
            if (enumHelperType == null)
                throw new InvalidCastException("Unable to load enum helper for casting value");
            return enumHelperType;
        }

        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The json reader</param>
        /// <param name="objectType">Type of the object to be read</param>
        /// <param name="existingValue">The existing value of object being read</param>
        /// <param name="serializer">The calling serializer</param>
        /// <returns>The object value as enum element</returns>
        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;
            try
            {
                if (reader.TokenType == JsonToken.String)
                {
                    var enumStringValue = reader.Value.ToString();
                    System.Type enumHelperType = loadHelperType(objectType);
                    MethodInfo enumHelperMethod = enumHelperType.GetRuntimeMethod("ParseString", new[] {typeof(string)});
                    object parsed = enumHelperMethod.Invoke(null, new object[] {enumStringValue});
                    return parsed;
                }
            }
            catch
            {
                throw new InvalidCastException($"Unable to cast value {reader.Value} to enum type {objectType.Name}");
            }

            throw new InvalidCastException($"Unexpected token {reader.TokenType} when parsing enum.");
        }

        /// <summary>
        /// Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns>
        /// <c>true</c> if this instance can convert the specified object type; otherwise, <c>false</c>.
        /// </returns>
        public override bool CanConvert(System.Type objectType)
        {
            System.Type toCheck = objectType;
            System.Type[] genericArgs = objectType.GenericTypeArguments;
            if (genericArgs != null && genericArgs.Length > 0)
                toCheck = genericArgs[genericArgs.Length - 1];
            object[] attributes = toCheck.GetTypeInfo().GetCustomAttributes(typeof(JsonConverterAttribute), false);
            if (attributes == null)
                return false;
            foreach (object converterAttrib in attributes)
            {
                if (attributes == null)
                    continue;
                foreach (object attribute in attributes)
                {
                    System.Type converterrType = (attribute as JsonConverterAttribute).ConverterType;
                    if (converterrType.FullName.Equals(GetType().FullName))
                        return true;
                }
            }

            return false;
        }
    }
}
