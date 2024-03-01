using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTask.Entities
{
    internal class Student
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public string ClassStud { get; protected set; }
    }

    class AddInfo : Student
    {
        public AddInfo(int id, string name, string classStud)
        {
            Id = id; 
            Name = name; 
            ClassStud = classStud;
        }
        

        public void Inputinfo()
        {
            
        }
    }
}
