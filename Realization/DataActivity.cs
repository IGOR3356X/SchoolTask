using SchoolTask.Entities;
using System;
using System.Collections.Generic;

namespace SchoolTask.Realization
{
    internal class DataActivity
    {
        public void OutStud()
        {
            //var StringUS = JsonController.DeserializeObject<List<Student>>(File.SaveStud());

            var StudList = DBClass.Instanse.Student;

            if (StudList.Count == 0)
            {
                Console.WriteLine("Учеников пока нет!");
                return;
            }
            for (int i = 0; i < StudList.Count; i++)
            {
                Student Students = StudList[i];
                Console.WriteLine($"{i + 1}. ID={Students.Id},Имя={Students.Name},Класс={Students.ClassStud}");
            }
        }

        public void OutTeacher()
        {
            var TeacherList = DBClass.Instanse.Teachers;

            if (TeacherList.Count == 0)
            {
                Console.WriteLine("Учителей пока нет!");
            }

            for (int i = 0; i < TeacherList.Count; i++)
            {
                Teacher Teacher = TeacherList[i];
                Console.WriteLine($"{ i + 1}. ID = { Teacher.ID},ФИО = { Teacher.Name},Класс = { Teacher.NumberClass},Предмет = {Teacher.Subject}");
            }
        }
        public void DeleteStud(int id)
        {
            var StudList = DBClass.Instanse.Student;

            if (StudList.Count == 0)
            {
                Console.WriteLine("Учеников нет!");
                return;
            }
            Console.WriteLine("Вы уверены y/n ?");
            var UserAnsver = Console.ReadKey().Key;
            switch (UserAnsver)
            {
                case ConsoleKey.Y:
                    StudList.RemoveAt(id);
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
            var StringUS = JsonController.DeserializeObject<List<Academic_performance>>(CeateFile.SaveGrade());
            var GradList = new List<Academic_performance>();

            foreach (var t in StringUS)
                GradList.Add(t);

            foreach (var t in GradList)
                Console.WriteLine($"Оценка Математика = {t.Math}, Оценка Рус = {t.Russian_Language}, Оценка Физ-Ра = {t.PE}");
        }
    }
}
