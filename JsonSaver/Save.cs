using SchoolTask.Entities;
using SchoolTask.Realization;
using System;
using System.Collections.Generic;

namespace SchoolTask.JsonSaver
{
    internal class Save
    {
        internal void InpStud(String Name, String ClassStud)
        {
            DBClass.Instanse.Student.Add(new Student()
            {
                Name = Name,
                ClassStud = ClassStud,
                Academic_Preformance = new Academic_performance { Math = 0, Russian_Language = 0, PE = 0 },
                Id = DBClass.Instanse.Student.Count
            });
        }

        public void InpTeacher(String Name, String Subject, String Class)
        {
            DBClass.Instanse.Teachers.Add(new Teacher()
            {
                Name = Name,
                NumberClass = Class,
                Subject = Subject,
                ID = DBClass.Instanse.Teachers.Count
            });
        }

        public void NewInpGrade()
        {
            var StudList = DBClass.Instanse.Student;

            Console.WriteLine("Введите ID студента: ");
            var id = Convert.ToInt32(Console.ReadLine());
            var student = StudList.Find(s => s.Id == id);

            Console.Write("Введите оценку по Математике: ");
            var MarkMath = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите оценку по Русскому языку: ");
            var MarkRus = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите оценку по Физкультуре: ");
            var MarkPE = Convert.ToInt32(Console.ReadLine());

            student.Academic_Preformance.Add(new Academic_performance
            {
                Math = MarkMath,
                Russian_Language = MarkRus,
                PE = MarkPE
            });
            
        }
    }
}

//public void InpGrade()
//{
//    var StringUS = JsonController.DeserializeObject<List<Academic_preformance>>(File.SaveGrade());
//    var GradList = new List<Academic_preformance>();
//    var StringAS = JsonController.DeserializeObject<List<Student>>(File.SaveStud());
//    var StudList = new List<Student>();


//    if ((StringUS != null) && (StringAS != null))
//    {
//        foreach (var t in StringUS)
//            GradList.Add(t);
//        foreach (var s in StringAS)
//            StudList.Add(s);

//        Console.WriteLine("Выбери ученика");
//        for (int i = 0; i < StringAS.Count; i++)
//        {
//            Student s = StringAS[i];
//            StudList.Add(s);
//            Console.WriteLine($"{i + 1}. {StudList[i].Name}");
//        }
//        var UserChois = Convert.ToInt32(Console.ReadLine());
//        if ((UserChois - 1) <= StudList.Count)
//        {
//            var SelectedStud = StudList[UserChois - 1];
//            Console.Write("Введите оценку по Математике: ");
//            var MarkMath = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Введите оценку по Русскому языку");
//            var MarkRus = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Введите оценку по Физкультуре: ");
//            var MarkPE = Convert.ToInt32(Console.ReadLine());

//            //var Search = StudList.Find(item => item.Name == Name);
//            GradList.Add(new Academic_preformance { Id = StringUS.Last().Id + 1, Name = SelectedStud.Name, Math = MarkMath, Russian_Language = MarkRus, PE = MarkPE });

//            JsonController.SerializeObject(GradList, File.SaveGrade());
//        }
//        else
//            Console.WriteLine("Вы вели неверный индекс ученика");
//    }
//    else if ((StringUS != null) && (StringAS == null))
//        Console.WriteLine("Ни одного ученика не зарегестрирав");
//    else if ((StringUS == null) && (StringAS != null))
//    {
//        Console.WriteLine("Выбери ученика");
//        for (int i = 0; i < StringAS.Count; i++)
//        {
//            Student s = StringAS[i];
//            StudList.Add(s);
//            Console.WriteLine($"{i + 1}, {StudList[i].Name}");
//        }
//        var UserChois = Convert.ToInt32(Console.ReadLine());
//        string SelectedStud = "";
//        if ((UserChois + 1) <= StudList.Count)
//        {
//            SelectedStud = StudList[UserChois - 1].Name;
//            Console.Write("Введите оценку по Математике: ");
//            var MarkMath = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Введите оценку по Русскому языку");
//            var MarkRus = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Введите оценку по Физкультуре: ");
//            var MarkPE = Convert.ToInt32(Console.ReadLine());

//            //var Search = StudList.Where(item => item.Name.ToLower() == Name.ToLower()).ToList()[0];
//            //Console.WriteLine(Search.Name);
//            GradList.Add(new Academic_preformance { Math = MarkMath, Russian_Language = MarkRus, PE = MarkPE });

//            JsonController.SerializeObject(GradList, File.SaveGrade());
//        }
//        else
//            Console.WriteLine("Вы ввели неверный индекс ученика");
//    }
//    else
//        Console.WriteLine("Рандомная ошибка");
//}
