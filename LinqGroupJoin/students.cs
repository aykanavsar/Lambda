using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqGroupJoin
{
    public class Student
    {
        public int studentId { get; set; }
        public string studentName { get; set; }
        public int sclassId { get; set; }

    }

    public class Sinif
    {
        public int classId { get; set; }
        public string className { get; set; }
    }
}
