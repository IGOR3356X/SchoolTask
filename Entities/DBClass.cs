using SchoolTask.Realization;
using System;
using System.Collections.Generic;
using System.IO;

namespace SchoolTask.Entities
{
    [Serializable]
    internal class DBClass
    {
        [NonSerialized]
        public static DBClass Instanse;
        public DBClass()
        {
            Student = new List<Student>();
            Teachers = new List<Teacher>();
            Instanse = this;
        }

        public void Load()
        {
            var path = CeateFile.SaveStud();
            if (!File.Exists(path))
                return;
            var data = JsonController.DeserializeObject<DBClass>(path);
            Student = data.Student;
            Teachers = data.Teachers;
            //foreach (var g in data.Student)

        }

        public void Save()
        {
            var path = CeateFile.SaveStud();
            JsonController.SerializeObject(this, path);
        }

        public List<Student> Student;
        public List<Teacher> Teachers;
    }
}
