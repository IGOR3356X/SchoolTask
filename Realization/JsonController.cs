﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;

namespace SchoolTask.Realization
{
    public class JsonController
    {
        public static void SerializeObject(object obj, string path)
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

        public static T DeserializeObject<T>(string path)
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
