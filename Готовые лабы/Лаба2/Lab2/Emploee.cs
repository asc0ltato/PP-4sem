using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Emploee
    {
        public string empName { get; set; }
        public string empVac { get; set; }

        public Emploee(string empName, string empVac)
        {
            this.empName = empName;
            this.empVac = empVac;
        }
    }
}
