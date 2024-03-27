using Newtonsoft.Json.Bson;
using SchoolTask.Entities;
using SchoolTask.JsonSaver;
using System;

namespace SchoolTask.Realization
{
    public class Inputic
    {
        private static readonly Save GetSave = new Save();
        private static readonly DataActivity GetActivity = new DataActivity();
        private static readonly DBClass data = new DBClass();
        internal static void GG()
        {
            while (true)
            {
                data.Load();
                Console.WriteLine("Добро пожалоать в приложение 'Школа'" +
                    "\nВыерите действие:" +
                    "\n1. Добавить ученика" +
                    "\n2. Добавить учителя" +
                    "\n3. Вывести всех учеников" +
                    "\n4. Вывести всех учителей" +
                    "\n5. Отчислить ученика" +
                    "\n6. Добавить оценки ученику" +
                    "\n7. Вывести успеваемость" +
                    "\nG.Сенить цвет консоли на зелёный" +
                    "\nB. Выход");

                var user_input = Console.ReadKey();
                switch (user_input.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        AddStudent();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        AddTeacher();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        GetActivity.OutStud();
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        GetActivity.OutTeacher();
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        DelStud();
                        break;
                    case ConsoleKey.D6:
                        Console.Clear();
                        AddGrade();
                        break;
                    case ConsoleKey.D7:
                        Console.Clear();
                        GetGrade();
                        break;
                    case ConsoleKey.D8:
                        break;
                    case ConsoleKey.G:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Clear();
                        break;
                    case ConsoleKey.B:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Вы нажали неправильную кнопку!");
                        break;
                }
                Console.WriteLine("Нажмите любую клавижу для продолжения...");
                data.Save();
                Console.ReadKey();
                Console.Clear();
            }
        }
        private static void AddStudent()
        {
            Console.Write("Напиши Имя: ");
            var StudName = Convert.ToString(Console.ReadLine());
            Console.Write("Напиши Класс: ");
            var StudClass = Convert.ToString(Console.ReadLine());
            GetSave.InpStud(StudName, StudClass);
        }
        private static void AddTeacher()
        {
            Console.Clear();
            Console.Write("Напишите Фамилия.И.О: ");
            var TeacherName = Convert.ToString(Console.ReadLine());
            Console.Write("Напишите предмет учителя: ");
            var TeacherSub = Convert.ToString(Console.ReadLine());
            Console.Write("Введите класс закреплённый за учителем: ");
            var TeacherClass = Convert.ToString(Console.ReadLine());
            GetSave.InpTeacher(TeacherName, TeacherSub, TeacherClass);
        }
        private static void DelStud()
        {
            GetActivity.OutStud();
            var DelInput = Convert.ToInt32(Console.ReadLine()) - 1;
            GetActivity.DeleteStud(DelInput);
        }
        private static void AddGrade()
        {
            GetActivity.OutStud();
            Console.WriteLine("Выберите студента ");
            var id = Convert.ToInt32(Console.ReadLine()) - 1;
            GetSave.NewInpGrade(id);
        }
        private static void GetGrade()
        {
            GetActivity.OutStud();
            Console.WriteLine("Выбери ученика");
            var id = Convert.ToInt32(Console.ReadLine()) - 1;
            GetActivity.SelGrade(id);
        }
    }
}
