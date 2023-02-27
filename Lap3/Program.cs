using System;
using System.Collections;
using System.Data;

namespace Lap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList dssv = new ArrayList();
            Console.WriteLine("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());


            Console.WriteLine("-------------Nhap thong tin sinh vien--------------");
            for (int i = 0; i < n; i++)
            {
                Student sv = new Student();
                Console.WriteLine("Nhap ma sinh vien thu {0} : ",i+1);
                sv.Id = int.Parse(Console.ReadLine());

                Console.WriteLine("Nhap ten sinh vien:");
                sv.Name = Console.ReadLine();

                Console.WriteLine("Nhap khoa: ");
                sv.Faculty = Console.ReadLine();

                Console.WriteLine("Nhap diem trun binh : ");
                sv.Mark = float.Parse(Console.ReadLine());

                dssv.Add(sv);
              
            }

            Console.WriteLine("-------------Danh sach sinh vien-------------");
            foreach (Student s in dssv)
            {
             
                s.Show();   
            }
        }
    }
}
