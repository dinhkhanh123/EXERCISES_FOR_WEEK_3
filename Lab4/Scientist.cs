using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Scientist : Employee
    {
        protected int papersPublished; // Số bài báo đã công bố
        protected int daysWorked;      // Số ngày công trong tháng
        protected double salaryLevel;  // Bậc lương

        // Phương thức khởi tạo
        public Scientist(string name, int birthYear, string degree, string position,
            int papersPublished,int daysWorked,double salaryLevel) : base(name, birthYear, degree, position)
        {
            this.papersPublished = papersPublished;
            this.daysWorked = daysWorked;
            this.salaryLevel = salaryLevel;
        }

        // Override phương thức tính lương
        public override double CalculateSalary(int daysWorked)
        {
            return daysWorked * salaryLevel;
        }
    }
}
