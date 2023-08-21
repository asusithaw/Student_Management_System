using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql_Crud.Models
{
    class Student
    {
        public virtual int ID { get; set; }
        public virtual string StudentName { get; set; }
        public virtual string SinhalaText { get; set; }
        public virtual string Reg { get; set; }
        public virtual string Class { get; set; }
        public virtual string Section { get; set; }

        public Student()
        {

        }

        public Student(string name, string sinhalaname, string reg, string @class, string section)
        {
            SinhalaText = sinhalaname;
            StudentName = name;
            Reg = reg;
            Class = @class;
            Section = section;
        }
    }
}
