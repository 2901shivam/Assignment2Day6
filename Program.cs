using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Day6
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            OurClass Hr = new OurClass();
            Hr.display(workingHours: 8, workingdays: 30);
            OurClass Admin = new OurClass();
            Admin.display(workingHours: 8, workingdays: 30, projecthandel: 3);
            OurClass SoftwareDeveloper = new OurClass();
            SoftwareDeveloper.display(workingHours: 8, workingdays: 30, projecthandel: 4, extra: 5);
        }
    }
}
