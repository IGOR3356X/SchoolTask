using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SchoolTask.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ClassStud { get; set; }
    }

    class MyList: Student
    {
        public List<Student> Items { get; set; }
    }

    class InputStud: Student
    {
        File file = new File();
        Student GetStudent = new Student();
        public void Inputinfo()
        {
            Console.WriteLine("Введите ид/Имя/Класс");
            Console.Write("ID: ");
            var InputId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Имя: ");
            var InputName = Convert.ToString(Console.ReadLine());
            Console.Write("Класс: ");
            var InputClassStud = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"{Id} {Name} {ClassStud}");

            var list = new List<Student>
            {
                new Student {Id = InputId, Name = InputName, ClassStud = InputClassStud}
            };

            var myList = new MyList { Items = list };

            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(file.GetFile()))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, myList);
            }

            using (StreamReader rd = new StreamReader(file.GetFile()))
            using (JsonReader reader = new JsonTextReader(rd))
            {
                MyList myList1 = serializer.Deserialize<MyList>(reader);

                foreach (var item in myList.Items)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}
