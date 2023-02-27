using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap3
{
     class Student : People
    {
        public string Faculty { get; set; }
        public float Mark { get; set; }



        public Student() : base()
        {

        }

        public Student(int id,string name,string faculty, float mark) : base()
        {
            Id = id;
            Name = name;
            Faculty = faculty;
            Mark = mark;
        }


        public void Show()
        {
            Console.WriteLine($"Ma sinh vien: {Id}");
            Console.WriteLine($"Ho va ten: {Name}");
            Console.WriteLine($"Khoa: {Faculty}");
            Console.WriteLine($"Ma sinh vien: {Mark}");
           
        }
    }


}
