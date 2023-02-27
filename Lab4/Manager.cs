using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
         class Manager : Employee
        {
            protected int daysWorked;      // Số ngày công trong tháng
            protected double salaryLevel;  // Bậc lương

            public Manager(string name, int birthYear, string degree, string position,int daysWorked,double salaryLevel)
                : base(name, birthYear, degree, position)
            {
                this.daysWorked = daysWorked;
                this.salaryLevel = salaryLevel;
            }

            public override double CalculateSalary(int daysWorked)
            {
                return daysWorked * salaryLevel;
            }
        }
}
