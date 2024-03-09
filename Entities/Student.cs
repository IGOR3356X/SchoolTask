﻿using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Serialization;
using System;

namespace SchoolTask.Entities
{
    [Serializable]
    internal class Student
    {
        public int Id;
        public string Name;
        public string ClassStud;
        public Academic_preformance academic_Preformance;
    }
}

    //class MyList: Student
    //{
    //    public List<Student> Items { get; set; }
    //}

    //class InputStud: Student
    //{
    //    File file = new File();
    //    Student GetStudent = new Student();
    //    public void Inputinfo()
    //    {
    //        Console.WriteLine("Введите ид/Имя/Класс");
    //        Console.Write("ID: ");
    //        var InputId = Convert.ToInt32(Console.ReadLine());
    //        Console.Write("Имя: ");
    //        var InputName = Convert.ToString(Console.ReadLine());
    //        Console.Write("Класс: ");
    //        var InputClassStud = Convert.ToString(Console.ReadLine());
    //        Console.WriteLine($"{Id} {Name} {ClassStud}");

    //        var list = new List<Student>
    //        {
    //            new Student {Id = InputId, Name = InputName, ClassStud = InputClassStud}
    //        };

    //        var myList = new MyList { Items = list };

    //        JsonSerializer serializer = new JsonSerializer();
    //        serializer.NullValueHandling = NullValueHandling.Ignore;

    //        using (StreamWriter sw = new StreamWriter(file.GetFile()))
    //        using (JsonWriter writer = new JsonTextWriter(sw))
    //        {
    //            serializer.Serialize(writer, myList);
    //        }

    //        using (StreamReader rd = new StreamReader(file.GetFile()))
    //        using (JsonReader reader = new JsonTextReader(rd))
    //        {
    //            MyList myList1 = serializer.Deserialize<MyList>(reader);

    //            foreach (var item in myList.Items)
    //            {
    //                Console.WriteLine(item.Name);
    //            }
    //        }
    //    }
    //}

    //class Input
    //{
    //    public void Veru()
    //    {
    //        Console.WriteLine("Введите ид/Имя/Класс");
    //        Console.Write("ID: ");
    //        var InputId = Convert.ToInt32(Console.ReadLine());
    //        Console.Write("Имя: ");
    //        var InputName = Convert.ToString(Console.ReadLine());
    //        Console.Write("Класс: ");
    //        var InputClassStud = Convert.ToString(Console.ReadLine());
    //    }
    //}


