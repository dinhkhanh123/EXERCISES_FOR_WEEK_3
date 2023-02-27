using System;
using System.Runtime.Intrinsics.Arm;

namespace Lab1
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
        public int StudentID{get { return Sid; } set { Sid = value; }}

        public string NameStudent{get { return Name; } set { Name = value; }}

        public string FacultyStudent{get { return Faculty; }  set{Faculty = value; }}

        public float MarkStudent{get { return Mark; }set { Mark = value; }}

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
        static void Main(string[] args)
        {
            Student[] Dssv;
            int n;
            Console.Write("Nhap so luong sv: ");
            n = int.Parse(Console.ReadLine());
            Dssv = new Student[n];
            Console.WriteLine("-------------Nhap thong tin sinh vien--------------");
            for (int i = 0; i < n; i++)
            {
              Dssv[i] = new Student();
                Console.Write("Nhap ma sinh vien {0}: ",i+1);
                Dssv[i].StudentID = int.Parse(Console.ReadLine());

                Console.Write("Nhap ten sinh vien : ");
                Dssv[i].NameStudent = Console.ReadLine();

                Console.Write("Nhap khoa : ");
                Dssv[i].FacultyStudent = Console.ReadLine();

                Console.Write("Nhap diem trung binh : ");
                Dssv[i].MarkStudent = float.Parse(Console.ReadLine());  
            }

            Console.WriteLine("--------------Xuat danh sach sinh vien------------");
            foreach (Student sv in Dssv)
            {
                sv.Show();
            }

        }
    }
}
