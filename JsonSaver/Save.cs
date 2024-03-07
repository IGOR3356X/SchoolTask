using SchoolTask.Entities;
using SchoolTask.Realization;
using System;
using System.Collections.Generic;

namespace SchoolTask.JsonSaver
{
    internal class Save
    {
        file file = new file();
        public void SaveGG()
        {
            var StringUS = JsonController.DeserializeObject<Student>(file.GetFile());
            var List = new List<Student>();
            List.Add(new Student { Id = 5, Name = "GG", ClassStud = "GG22" });
            JsonController.SerializeObject(List, file.GetFile());
            foreach (var Student in List)
            {
                Console.WriteLine(Student.Id);
            }
        }
    }
}
