using SchoolTask.Entities;
using SchoolTask.Realization;
using System;
using System.Collections.Generic;

namespace SchoolTask.JsonSaver
{
    internal class Save
    { 
        public void InpStud(int ID, String Name, String ClassStud)
        {
            var StringUS = JsonController.DeserializeObject<List<Student>>(File.SaveStud());
            var StudList = new List<Student>();

            if (StringUS != null)
                foreach (var s in StringUS)
                    StudList.Add(s);

            StudList.Add(new Student {Id = ID,Name = Name,ClassStud = ClassStud });
            JsonController.SerializeObject(StudList, File.SaveStud());
            foreach (var Student in StudList)
                Console.WriteLine($"{Student.Id},{Student.Name},{Student.ClassStud}");
        }

        public void InpTeacher(int Id,String Name, String Subject,String Class)
        {
            var StringUS = JsonController.DeserializeObject<List<Teacher>>(File.SaveTeacher());
            var TeacherList = new List<Teacher>();

            if (StringUS != null)
                foreach (var t  in StringUS)
                    TeacherList.Add(t);

            TeacherList.Add(new Teacher { ID = Id, Name = Name, Subject = Subject, NumberClass = Class });
            JsonController.SerializeObject(TeacherList, File.SaveTeacher());

            foreach (var Teacher in TeacherList)
                Console.WriteLine($"{Teacher.ID}, {Teacher.Name}, {Teacher.Subject}, {Teacher.NumberClass}");
        }

        public void OutStud()
        {
            var StringUS = JsonController.DeserializeObject<List<Student>>(File.SaveStud());
            var StudList = new List<Student>();

            if (StringUS != null)
                foreach (var s in StringUS)
                    StudList.Add(s);
            else
                Console.WriteLine("Учеников пока нет!");

            foreach (var Students in StudList)
                Console.WriteLine($"{Students.Id}, {Students.Name}, {Students.ClassStud}");
        }

        public void OutTeacher()
        {
            var StringUS = JsonController.DeserializeObject<List<Teacher>>(File.SaveTeacher());
            var TeacherList = new List<Teacher>();

            if (StringUS != null)
                foreach (var t in StringUS)
                    TeacherList.Add(t);
            else
                Console.WriteLine("Учителей пока нет!");

            foreach (var Teachers in TeacherList)
                Console.WriteLine($"{Teachers.ID}, {Teachers.Name}, {Teachers.Subject}, {Teachers.Subject}");
        }
    }
}
