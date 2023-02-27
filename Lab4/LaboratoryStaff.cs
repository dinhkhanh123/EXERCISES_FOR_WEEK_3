using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
     class LaboratoryStaff : Employee
    {
        protected double monthlySalary;

        public LaboratoryStaff(string name, int birthYear, string degree, double monthlySalary) 
            : base(name, birthYear, degree, "Laboratory Staff")
        {
            this.monthlySalary = monthlySalary;
        }

        public override double CalculateSalary(int daysWorked)
        {
            return monthlySalary;
        }
    }
}
