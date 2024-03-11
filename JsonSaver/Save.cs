using SchoolTask.Entities;
using SchoolTask.Realization;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolTask.JsonSaver
{
    internal class Save
    {
        public void InpStud(String Name, String ClassStud)
        {
            var StringUS = JsonController.DeserializeObject<List<Student>>(File.SaveStud());
            var StudList = new List<Student>();

            if (StringUS != null)
            {
                foreach (var s in StringUS)
                    StudList.Add(s);
                StudList.Add(new Student { Id = StringUS.Last().Id + 1, Name = Name, ClassStud = ClassStud });
            }
            else
                StudList.Add(new Student { Id = 0, Name = Name, ClassStud = ClassStud });

            JsonController.SerializeObject(StudList, File.SaveStud());
        }

        public void InpTeacher(String Name, String Subject, String Class)
        {
            var StringUS = JsonController.DeserializeObject<List<Teacher>>(File.SaveTeacher());
            var TeacherList = new List<Teacher>();

            if (StringUS != null)
            {
                foreach (var t in StringUS)
                    TeacherList.Add(t);
                TeacherList.Add(new Teacher { ID = StringUS.Last().ID + 1, Name = Name, Subject = Subject, NumberClass = Class });
            }
            else
                TeacherList.Add(new Teacher { ID = 0, Name = Name, Subject = Subject, NumberClass = Class });

            JsonController.SerializeObject(TeacherList, File.SaveTeacher());
        }

        public void NewInpGrade()
        {

        }
        public void InpGrade()
        {
            var StringUS = JsonController.DeserializeObject<List<Academic_preformance>>(File.SaveGrade());
            var GradList = new List<Academic_preformance>();
            var StringAS = JsonController.DeserializeObject<List<Student>>(File.SaveStud());
            var StudList = new List<Student>();


            if ((StringUS != null) && (StringAS != null))
            {
                foreach (var t in StringUS)
                    GradList.Add(t);
                foreach (var s in StringAS)
                    StudList.Add(s);

                Console.WriteLine("Выбери ученика");
                for (int i = 0; i < StringAS.Count; i++)
                {
                    Student s = StringAS[i];
                    StudList.Add(s);
                    Console.WriteLine($"{i + 1}. {StudList[i].Name}");
                }
                var UserChois = Convert.ToInt32(Console.ReadLine());
                if ((UserChois - 1) <= StudList.Count)
                {
                    var SelectedStud = StudList[UserChois - 1];
                    Console.Write("Введите оценку по Математике: ");
                    var MarkMath = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите оценку по Русскому языку");
                    var MarkRus = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите оценку по Физкультуре: ");
                    var MarkPE = Convert.ToInt32(Console.ReadLine());

                    //var Search = StudList.Find(item => item.Name == Name);
                    GradList.Add(new Academic_preformance { Id = StringUS.Last().Id + 1, Name = SelectedStud.Name, Math = MarkMath, Russian_Language = MarkRus, PE = MarkPE });

                    JsonController.SerializeObject(GradList, File.SaveGrade());
                }
                else
                    Console.WriteLine("Ввы вели неверный индекс ученика");
            }
            else if ((StringUS != null) && (StringAS == null))
                Console.WriteLine("Ни одного ученика не зарегестрирав");
            else if ((StringUS == null) && (StringAS != null))
            {
                Console.WriteLine("Выбери ученика");
                for (int i = 0; i < StringAS.Count; i++)
                {
                    Student s = StringAS[i];
                    StudList.Add(s);
                    Console.WriteLine($"{i + 1}, {StudList[i].Name}");
                }
                var UserChois = Convert.ToInt32(Console.ReadLine());
                string SelectedStud = "";
                if ((UserChois + 1) <= StudList.Count)
                {
                    SelectedStud = StudList[UserChois - 1].Name;
                    Console.Write("Введите оценку по Математике: ");
                    var MarkMath = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите оценку по Русскому языку");
                    var MarkRus = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите оценку по Физкультуре: ");
                    var MarkPE = Convert.ToInt32(Console.ReadLine());

                    //var Search = StudList.Where(item => item.Name.ToLower() == Name.ToLower()).ToList()[0];
                    //Console.WriteLine(Search.Name);
                    GradList.Add(new Academic_preformance { Id = 0, Name = SelectedStud, Math = MarkMath, Russian_Language = MarkRus, PE = MarkPE });

                    JsonController.SerializeObject(GradList, File.SaveGrade());
                }
                else
                    Console.WriteLine("Вы ввели неверный индекс ученика");
            }
            else
                Console.WriteLine("Рандомная ошибка");
        }
    }
}
