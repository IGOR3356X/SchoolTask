namespace SchoolTask.Entities
{
    internal class Teacher
    {
        int ID { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        string Patronymic { get; set; }
        string Subject { get; set; }
        int NumberClass { get; set; }

        public Teacher(int iD, string name, string surname, string patronymic, string subject, int numberClass)
        {
            ID = iD;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Subject = subject;
            NumberClass = numberClass;
        }
    }

}
