using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTask.Realization
{
    internal class File
    {
        public static string SaveStud()
        {
            string Put = "D:\\JSON Save\\SaveStud.json";
            return Put;
        }
        
        public static string SaveTeacher()
        {
            string Put = "D:\\JSON Save\\SaveTeacher.json";
            return Put;
        }

        public static string SaveGrade()
        {
            string Put = "D:\\JSON Save\\SaveGrade.json";
            return Put;
        }
    }
}
