using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace StarlingBank.Utilities
{
    public class UnixDateTimeConverter : DateTimeConverterBase
    {
        public DateTimeStyles DateTimeStyles { get; set; } = DateTimeStyles.RoundtripKind;
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            double text;
            if (value is DateTime)
            {
                var dateTime = (DateTime)value;
                if ((DateTimeStyles & DateTimeStyles.AdjustToUniversal) == DateTimeStyles.AdjustToUniversal
                    || (DateTimeStyles & DateTimeStyles.AssumeUniversal) == DateTimeStyles.AssumeUniversal)
                {
                    dateTime = dateTime.ToUniversalTime();
                }
                text = dateTime.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            }
            else
            {
                throw new JsonSerializationException("Unexpected value when converting date. Expected DateTime.");
            }
            writer.WriteValue(text);
        }
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.Integer)
            {
                throw new JsonSerializationException("Unexpected token");
            }
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(double.Parse(reader.Value.ToString()));
        }
    }
}