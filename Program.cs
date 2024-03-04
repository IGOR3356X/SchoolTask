using SchoolTask.Entities;
using SchoolTask.Realization;
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
            InputStud inputStud = new InputStud();
            Console.WriteLine("Добро пожалоать в приложение 'Школа'\nВыерите действие\n1. Добавить ученика\n2. Вывести всех учителей");
            var user_input = Convert.ToInt32(Console.ReadLine());


            if (user_input == 1)
            {
                inputStud.Inputinfo();
            }

            Console.ReadKey();
        }
    }
}
