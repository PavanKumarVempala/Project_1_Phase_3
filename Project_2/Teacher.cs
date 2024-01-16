using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    
        public class Teacher
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string ClassAndSection { get; set; }

            public override string ToString()
            {
                return $"{ID}, {Name}, {ClassAndSection}";
            }
        }
}
