using SchoolTask.Entities;
using SchoolTask.Realization;
using System;

namespace SchoolTask
{
    internal class Program
    {
        static void Main()
        {
            var student = new Student() { Id = 1, Name = "Polina Kitskan", ClassStud = "IS 222/1" };
            var jsonSer = new JsonController();
            var file = new File();
            JsonController.SerializeObject(student, file.GetFile());
            var ban = JsonController.DeserializeObject<Student>(file.GetFile());

            GG();
            Console.WriteLine();
            Console.ReadKey();
            //Console.ReadKey();
        }
        static void GG()
        {
            File GetFile = new File();
            Academic_preformance academ = new Academic_preformance();
            //var getStud = new Input();

            Console.WriteLine("Добро пожалоать в приложение 'Школа'\nВыерите действие\n1. Добавить ученика\n2. Вывести всех учителей");
            var user_input = Convert.ToInt32(Console.ReadLine());

            switch (user_input.ToString())
            {
                case "1":
                    Console.Write("Напиши ID: ");
                    var ID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Напиши Имя: ");
                    var Name = Convert.ToString(Console.ReadLine());
                    Console.Write("Напиши Класс: ");
                    var Class = Convert.ToString(Console.ReadLine());
                    var Gege = new Student { Id = ID, Name = Name, ClassStud = Class };
                    JsonController.SerializeObject(Gege, GetFile.GetFile());
                    var Ban =JsonController.DeserializeObject<Student>(GetFile.GetFile());
                    Console.WriteLine($"Ваше ID: {Ban.Id},Ваше Имя:{Ban.Name},Ваш Класс:{Ban.ClassStud}");
                    break;
                case "2":
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
