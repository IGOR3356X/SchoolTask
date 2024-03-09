using SchoolTask.JsonSaver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTask.Realization
{
    public class Inputic
    {
        internal static void GG()
        {
            var SaveFile = new Save();


            Console.WriteLine("Добро пожалоать в приложение 'Школа'" +
                "\nВыерите действие" +
                "\n1. Добавить ученика" +
                "\n2. Добавить ученика" +
                "\n3. Вывести всех учеников" +
                "\n4. Вывести всех учителей");
            var user_input = Console.ReadKey();

            switch (user_input.Key)
            {
                case ConsoleKey.D1:
                    Console.Write("Напиши ID: ");
                    var StudID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Напиши Имя: ");
                    var StudName = Convert.ToString(Console.ReadLine());
                    Console.Write("Напиши Класс: ");
                    var StudClass = Convert.ToString(Console.ReadLine());
                    SaveFile.InpStud(StudID, StudName, StudClass);
                    break;
                case ConsoleKey.D2:
                    Console.Write("Напишиите ИД: ");
                    var TeacherID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Напишите Фамилия.И.О: ");
                    var TeacherName = Convert.ToString(Console.ReadLine());
                    Console.Write("Напишите предмет учителя: ");
                    var TeacherSub = Convert.ToString(Console.ReadLine());
                    Console.Write("Введите класс закреплённый за учителем: ");
                    var TeacherClass = Convert.ToString(Console.ReadLine());
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("");
                    SaveFile.OutStud();
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("");
                    SaveFile.OutTeacher();
                    break;
                default:
                    Console.WriteLine("Вы нажали неправильную кнопку!");
                    break;
            }
        }
    }
}
