using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожалоать в приложение 'Школа'\nВыерите действие");
            Console.ReadKey();
            Console.WriteLine("1. Добавить ученика\n2. Вывести всех учителей");
            var user_input = Convert.ToInt32(Console.ReadLine());
            if (user_input == 1)
            {
                Console.WriteLine("Введите ид/Имя/Класс");
                Console.Write("ID");
                var ID = Convert.ToInt32(Console.ReadLine());
                Console.Write("Имя");
                var Name = Convert.ToString(Console.ReadLine());
                Console.Write("Класс");
                var ClassStud = Convert.ToString(Console.ReadLine());

            }
        }
    }
}
