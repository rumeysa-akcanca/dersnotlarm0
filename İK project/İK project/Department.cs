using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İK_project
{
     class Department
    {

        public List<Employee> employees { set; get; }
        public Manager HeadOF { get; set; }
        public int ID{ get;  }
        public String  Name { get; set; }
        int idcounter;
        public Department()
        {

        }
        public Department(Employee employee, Manager headOF, int ID, string name)
        {
            List<Employee> employees = new List<Employee>();
            HeadOF = headOF;
            Name = name;
            ID += idcounter;
        }


    }
}
