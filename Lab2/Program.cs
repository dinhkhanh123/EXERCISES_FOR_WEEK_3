using System;
using System.Collections.Generic;

namespace Lab2
{
    class Student
    {

        private int Sid;
        private string Name;
        private string Faculty;
        private float Mark;

        public Student()
        {
        }

        public Student(int sid, string name, string faculty, float mark)
        {
            Sid = sid;
            Name = name;
            Faculty = faculty;
            Mark = mark;
        }

        public int GetStudentID()
        {
            return Sid;
        }

        public void SetStudentID(int sid)
        {
            Sid = sid;
        }

        public string GetNameStudent()
        {
            return Name;
        }

        public void SetNameStudent(string name)
        {
            Name = name;
        }

        public string GetFacultyStudent()
        {
            return Faculty;
        }

        public void SetFacultyStudent(string faculty)
        {
            Faculty = faculty;
        }

        public float GetMarkStudent()
        {
            return Mark;
        }

        public void SetMarkStudent(float mark)
        {
            Mark = mark;
        }

      

        public void Show()
        {
            Console.WriteLine($"Ma sinh vien: {Sid}");
            Console.WriteLine($"Ten sinh vien: {Name}");
            Console.WriteLine($"Khoa : {Faculty}");
            Console.WriteLine($"Diem trung binh : {Mark}");
        }

    }


   
     class Program
    {

        static void Nhap1SV(out Student sv)
        {
            int sid;
            string name, faculty;
            float mark;

            Console.Write("Nhap ma sinh vien: ");
            sid = int.Parse(Console.ReadLine());

            Console.Write("Nhap ten sinh vien: ");
            name = Console.ReadLine();

            Console.Write("Nhap khoa: ");
            faculty = Console.ReadLine();

            Console.Write("Nhap diem trung binh: ");
            mark = float.Parse(Console.ReadLine());

            sv = new Student(sid, name, faculty, mark);
        }
        static void NhapDS(out Student[] dssv, out int n)
        {
            Console.Write("Nhap so luong sinh vien: ");
            n = int.Parse(Console.ReadLine());
            dssv = new Student[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap thong tin sinh vien thu {i + 1}: ");
                Nhap1SV(out dssv[i]);
            }
        }

        static void XuatDS(Student[] dssv, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Thong tin sinh vien thu {i + 1}: ");
                dssv[i].Show();
            }
        }
        static void Main(string[] args)
        {

            Student[] Dssv;
            int n;

            NhapDS(out Dssv, out n);
            Console.WriteLine("--------------Xuat danh sach sinh vien------------");
            XuatDS(Dssv, n);


        }
    }
}
