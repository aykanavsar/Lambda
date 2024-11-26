using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public class Person : IComparable<Person>

    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public int CompareTo(Person? other)
        {
            int result = 0;
            if (Id > other.Id)
            {
                result = 1;
            }

            else if (Id < other.Id)
            {
                result = -1;

            }

            return result;  
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
