using Newtonsoft.Json;
using SchoolTask.Entities;
using SchoolTask.Realization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTask.JsonSaver
{
    internal class Save
    {
        File file = new File();
        void GG()
        {
            var String = JsonController.DeserializeObject<Student>(file.GetFile());
        }
    }
}
