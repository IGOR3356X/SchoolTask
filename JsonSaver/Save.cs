using SchoolTask.Entities;
using SchoolTask.Realization;
using System;
using System.Collections.Generic;

namespace SchoolTask.JsonSaver
{
    internal class Save
    {
        File file = new File();
        public void SaveGG()
        {
            var StringUS = JsonController.DeserializeObject<List<Student>>(file.GetFile());
            var List = new List<Student>();
            if (StringUS != null)
            {
                foreach (var s in StringUS)
                {
                    List.Add(s);
                }
            }
            JsonController.SerializeObject(List, file.GetFile());
            foreach (var Student in List)
            {
                Console.WriteLine($"{Student.Id},{Student.Name},{Student.ClassStud}");
            }
        }
    }
}
