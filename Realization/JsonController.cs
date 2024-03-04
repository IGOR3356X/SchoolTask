using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTask.Realization
{
    public class JsonController
    {
        public void SerializeObject(object obj,string path)
        {
            if (obj == null) return;

            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(path))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, obj);
            }
        }

        public T DeserializeObject<T> (string path)
        {
            if (string.IsNullOrWhiteSpace(path)) return default;

            T obj;
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader rd = new StreamReader(path))
            using (JsonReader reader = new JsonTextReader(rd))
            {
                obj = serializer.Deserialize<T>(reader);
            }
            return obj;
        }
    }
}
