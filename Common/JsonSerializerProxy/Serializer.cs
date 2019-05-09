using Newtonsoft.Json;
using Orm.Framework.Services;
using System;

namespace JsonSerializerProxy
{
    public class Serializer : IJsonSerializer
    {
        private JsonConverter[] JavaScriptConverters = new JsonConverter[] { new DateTimeConverter() };
        private readonly JsonSerializerSettings settings;

        public Serializer()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                Converters = this.JavaScriptConverters,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            this.settings = settings;
        }

        public T Deserialize<T>(string json) =>
            (!string.IsNullOrWhiteSpace(json) ? JsonConvert.DeserializeObject<T>(json) : default(T));

        public object Deserialize(string json, Type targetType) =>
            JsonConvert.DeserializeObject(json, targetType);

        public string Serialize(object data) =>
            JsonConvert.SerializeObject(data, this.settings);
    }
}
