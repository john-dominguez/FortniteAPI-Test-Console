using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
namespace Library
{
    public class Serializer
    {
        public static void Serialize(Object type, int val, string filename= "C:\\Users\\John\\Coding\\_Revature\\testing\\Api_Test\\data2.json")
        {
            JsonSerializer serializer = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            };

            
            using (StreamWriter streamWriter = new StreamWriter(filename))
            using (JsonWriter writer = new JsonTextWriter(streamWriter))
            {
                Console.WriteLine(writer.ToString());
                serializer.Serialize(writer, type);
            }
        }

        public static string Serialize<T>(T type)
        {
            return JsonConvert.SerializeObject(type);
        }

        public static List<T> Deserialize<T>(string filename)
        {
            var jsonFile = File.ReadAllText(filename);
            return JsonConvert.DeserializeObject<List<T>>(jsonFile);
        }
       
    }
}
