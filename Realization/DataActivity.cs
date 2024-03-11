using SchoolTask.Entities;
using System;
using System.Collections.Generic;

namespace SchoolTask.Realization
{
    internal class DataActivity
    {
        public void OutStud()
        {
            var StringUS = JsonController.DeserializeObject<List<Student>>(File.SaveStud());
            var StudList = new List<Student>();

            if (StringUS != null)
                foreach (var s in StringUS)
                    StudList.Add(s);
            else
                Console.WriteLine("Учеников пока нет!");

            for (int i = 0; i < StudList.Count; i++)
            {
                Student Students = StudList[i];
                Console.WriteLine($"{i + 1}. ID={Students.Id},Имя={Students.Name},Класс={Students.ClassStud}");
            }
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

            for (int i = 0; i < TeacherList.Count; i++)
            {
                Teacher Teachers = TeacherList[i];
                Console.WriteLine($"{i + 1}. ID = {Teachers.ID}, Имя = {Teachers.Name}, Предмет = {Teachers.Subject}, Класс = {Teachers.NumberClass}");
            }
        }
        public void DeleteStud(int id)
        {
            var StringUS = JsonController.DeserializeObject<List<Student>>(File.SaveStud());
            var StudList = new List<Student>();

            if (StringUS != null)
                foreach (var t in StringUS)
                    StudList.Add(t);
            Console.WriteLine("Вы уверены y/n ?");
            var UserAnsver = Console.ReadKey().Key;
            switch (UserAnsver)
            {
                case ConsoleKey.Y:
                    StudList.RemoveAt(id);
                    JsonController.SerializeObject(StudList, File.SaveStud());
                    break;
                case ConsoleKey.N:
                    return;
                default:
                    Console.WriteLine("Вы нажали не ту клавишу");
                    break;
            }
        }
        public void GetGrade()
        {
            var StringUS = JsonController.DeserializeObject<List<Academic_preformance>>(File.SaveGrade());
            var GradList = new List<Academic_preformance>();

            foreach (var t in StringUS)
                GradList.Add(t);

            foreach (var t in GradList)
                Console.WriteLine($"ИД = {t.Id}, Имя = {t.Name}, Оценка Математика = {t.Math}, Оценка Рус = {t.Russian_Language}, Оценка Физ-Ра = {t.PE}");
        }
    }
}
