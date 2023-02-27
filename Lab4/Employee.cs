using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
     class Employee
    {
        protected string name;     // Họ tên nhân viên
        protected int birthYear;   // Năm sinh
        protected string degree;   // Bằng cấp
        protected string position; // Chức vụ
        public Employee(string name, int birthYear, string degree, string position)
        {
            this.name = name;
            this.birthYear = birthYear;
            this.degree = degree;
            this.position = position;
        }

        // Phương thức tính lương - phuong thuc ao-(bị nạp chồng - bị đè) bởi lớp kế thừa.
        public virtual double CalculateSalary(int daysWorked)
        {
            return 0;
        }


    }


}
