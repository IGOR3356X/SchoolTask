using SchoolTask.Entities;
using SchoolTask.JsonSaver;
using SchoolTask.Realization;
using System;

namespace SchoolTask
{
    internal class Program
    {
        public static void Main()
        {
            var save = new Save();
            // save.NewInpGrade();
            var data = new DBClass();
            Inputic.GG();
            Console.ReadKey();
        }
    }
}
