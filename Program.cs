using SchoolTask.Entities;
using SchoolTask.JsonSaver;
using SchoolTask.Realization;
using System;
using System.Collections.Generic;

namespace SchoolTask
{
    internal class Program
    {
        public static void Main()
        {
            var save = new Save();
            //var file = new File();
            //var student = new Student() { Id = 1, Name = "Polina Kitskan", ClassStud = "IS 222/1" };
            //JsonController.SerializeObject(student, file.GetFile());
            //JsonController.DeserializeObject<Student>(file.GetFile());
            save.SaveGG();
            //Inputic.GG();
            Console.ReadKey();
        }


    }
    public class Inputic
    {
        internal static void GG()
        {
            File file = new File();
            //Academic_preformance academ = new Academic_preformance();
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
                    JsonController.SerializeObject(Gege, file.GetFile());
                    var Ban = JsonController.DeserializeObject<Student>(file.GetFile());
                    Console.WriteLine($"Ваш ID:{Ban.Id},Ваше Имя:{Ban.Name},Ваш Класс:{Ban.ClassStud}");
                    break;
                case "2":

                    break;
                case "3":
                    break;
            }
        }
    }
}
