using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace com.telstra.messaging.Utils
{
    internal class CustomArrayConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(List<T>));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (existingValue != null)
            {
                JToken token = JToken.Load(reader);
                List<T> result = (existingValue as List<T>) ?? new List<T>();

                if (token.Type == JTokenType.Array)
                {
                    List<T> deserializedList = token.ToObject<List<T>>() ?? new List<T>();
                    if (deserializedList != null)
                        result.AddRange(deserializedList);
                }
                else
                {
                    T? item = token.ToObject<T>();  // Change to T?
                    if (item != null)
                        result.Add(item);
                }

                return result;
            }

            return existingValue ?? new object();
        }



        public override bool CanWrite
        {
            get
            {
                return true;
            }
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value is List<T> list)
            {
                if (list.Count == 1)
                {
                    value = list[0];
                }
            }
            else
            {
                value = null;
            }

            serializer.Serialize(writer, value);
        }
    }
}