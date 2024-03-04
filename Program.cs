using SchoolTask.Entities;
using SchoolTask.Realization;
using System;

namespace SchoolTask
{
    internal class Program
    {
        static void Main()
        {
            GG();
            Console.ReadKey();
        }

        static void GG()
        {
            File GetFile = new File();
            JsonController controller = new JsonController();

            InputStud inputStud = new InputStud();
            Console.WriteLine("Добро пожалоать в приложение 'Школа'\nВыерите действие\n1. Добавить ученика\n2. Вывести всех учителей");
            var user_input = Convert.ToInt32(Console.ReadLine());

            switch (user_input.ToString())
            {
                case "1":
                    inputStud.Inputinfo();
                    break;
                case "2":
                    controller.SerializeObject(Console.ReadLine(), GetFile.GetFile());
                    break;
                case "3":
                    break;
            }
        }

        public class Inputic
        {

        }
    }
}
