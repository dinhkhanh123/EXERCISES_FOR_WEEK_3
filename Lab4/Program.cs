using System;
using System.Collections.Generic;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khoi tao 
            Scientist scientist1 = new Scientist("nguyen van a", 1972, "PhD", "Senior Scientist", 10, 20, 100);
            Scientist scientist2 = new Scientist("nguyen van b", 1972, "Master", "Junior Scientist", 5, 25, 80);
            Manager manager = new Manager("Peter Lee", 1975, "PhD", "Department Manager", 22, 120);
            LaboratoryStaff staff1 = new LaboratoryStaff("Jane Doe", 1990, "Bachelor", 2000);
            LaboratoryStaff staff2 = new LaboratoryStaff("Bob Lee", 1995, "Bachelor", 1800);

            // Tạo danh sách nhân viên
            List<Employee> employees = new List<Employee>();
            employees.Add(scientist1);
            employees.Add(scientist2);
            employees.Add(staff1);
            employees.Add(staff2);
            employees.Add(manager);

            // Tính tổng lương và in ra màn hình
            double totalScientistSalary = 0;
            double totalManagerSalary = 0;
            double totalStaffSalary = 0;
           
            foreach (Employee emp in employees)
            {
                if(emp is Scientist)
                {
                    totalScientistSalary += emp.CalculateSalary(100);
                }
                if(emp is Manager)
                {
                    totalManagerSalary += emp.CalculateSalary(120);
                }
                if(emp is LaboratoryStaff)
                {
                    totalStaffSalary += emp.CalculateSalary(0);
                }
            }
            // in ket qua ra man hinh
            Console.WriteLine("Total salary for Scientists: " + totalScientistSalary);
            Console.WriteLine("Total salary for Managers: " + totalManagerSalary);
            Console.WriteLine("Total salary for Laboratory Staff: " + totalStaffSalary);
        }
    }
}
