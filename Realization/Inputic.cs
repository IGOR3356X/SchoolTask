using SchoolTask.JsonSaver;
using System;

namespace SchoolTask.Realization
{
    public class Inputic
    {
        internal static void GG()
        {
            var SaveFile = new Save();
            var DataActivity = new DataActivity();

            while (true)
            {
                Console.WriteLine("Добро пожалоать в приложение 'Школа'" +
                    "\nВыерите действие:" +
                    "\n1. Добавить ученика" +
                    "\n2. Добавить учителя" +
                    "\n3. Вывести всех учеников" +
                    "\n4. Вывести всех учителей" +
                    "\n5. Отчислить ученика" +
                    "\n6. Добавить оценки ученику" +
                    "\n7. Вывести успеваемость");

                var user_input = Console.ReadKey();
                switch (user_input.Key)
                {
                    case ConsoleKey.D1:
                        //Console.Write("Напиши ID: ");
                        //var StudID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        Console.Write("Напиши Имя: ");
                        var StudName = Convert.ToString(Console.ReadLine());
                        Console.Write("Напиши Класс: ");
                        var StudClass = Convert.ToString(Console.ReadLine());
                        SaveFile.InpStud(StudName, StudClass);
                        break;
                    case ConsoleKey.D2:
                        //Console.Write("Напишиите ИД: ");
                        //var TeacherID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        Console.Write("Напишите Фамилия.И.О: ");
                        var TeacherName = Convert.ToString(Console.ReadLine());
                        Console.Write("Напишите предмет учителя: ");
                        var TeacherSub = Convert.ToString(Console.ReadLine());
                        Console.Write("Введите класс закреплённый за учителем: ");
                        var TeacherClass = Convert.ToString(Console.ReadLine());
                        SaveFile.InpTeacher(TeacherName, TeacherSub, TeacherClass);
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("");
                        DataActivity.OutStud();
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine("");
                        DataActivity.OutTeacher();
                        break;
                    case ConsoleKey.D5:
                        Console.WriteLine("");
                        DataActivity.OutStud();
                        var DelInput = Convert.ToInt32(Console.ReadLine()) - 1;
                        DataActivity.DeleteStud(DelInput);
                        break;
                    case ConsoleKey.D6:
                        Console.WriteLine("");
                        SaveFile.InpGrade();
                        break;
                    case ConsoleKey.D7:
                        Console.WriteLine("");
                        DataActivity.GetGrade();
                        break;
                    default:
                        Console.WriteLine("Вы нажали неправильную кнопку!");
                        break;
                }
                Console.WriteLine("Нажмите любую клавижу для продолжения...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
