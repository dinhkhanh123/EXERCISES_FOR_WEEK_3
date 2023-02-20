using System;
using System.Collections.Generic;

namespace EXERCISES_FOR_WEEK_3
{
    internal class Program
    {
        abstract class Shape
        {
            protected double x;
            protected double y;

            public Shape(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public void Move(double dx, double dy)
            {
                x+=dx;
                y+=dy;
            }

             public abstract void Show();
        }

        class Line : Shape
        {
            private double x2;
            private double y2;

            public Line(double x1, double y1,double x2, double y2) : base(x1,y1)
            {
                this.x2 = x2;
                this.y2 = y2;
            }

            public override void Show()
            {
                Console.WriteLine("Line: ({0},{1})-({2},{3})",x,y,x2,y2);
            }

            public override string ToString()
            {
                return "Line: (" + x + "," + y + ")-(" + x2 + "," + y2 + ")";
            }
        }

        class Circle : Shape
        {
            private double radius;

            public Circle(double x, double y ,double radius) : base(x,y)
            {
                this.radius = radius;
            }

            public override void Show()
            {
                Console.WriteLine("Circle: ({0},{1}), r={2}",x,y,radius);
            }

            public override string ToString()
            {
                return "Circle: (" + x + "," + y + "), r=" + radius;
            }
        }

        class Rectangle : Shape
        {
            private double x2;
            private double y2;
            private double x3;
            private double y3;

            public Rectangle(double x1, double y1, double x2, double y2, double x3, double y3) : base(x1,y1)
            {
                this.x2 = x2;
                this.y2 = y2;
                this.x3 = x3;
                this.y3 = y3;
            }

            public override void Show()
            {
                Console.WriteLine("Rectangle: ({0},{1})-({2},{3})-({4},{5})", x, y, x2, y2, x3, y3);
            }

            public override string ToString()
            {
                return "Rectangle: (" + x + "," + y + ")-(" + x2 + "," + y2 + ")-(" + x3 + "," + y3 + ")";
            }
        }

        class PolyLine : Shape
        {
            private List<double> xList = new List<double>();
            private List<double> yList = new List<double>();

            public PolyLine(int x, int y) : base(x, y)
            {
            }

            public void AddPoint(int x, int y)
            {
                xList.Add(x);
                yList.Add(y);
            }

            public override void Show()
            {
                Console.Write("PolyLine: ({0},{1})", x, y);
                for (int i = 0; i < xList.Count; i++)
                {
                    Console.Write("-({0},{1})", xList[i], yList[i]);
                }
                Console.WriteLine();
            }

            public override string ToString()
            {
                string result = "PolyLine: (" + x + "," + y + ")";
                for (int i = 0; i < xList.Count; i++)
                {
                    result += "-(" + xList[i] + "," + yList[i] + ")";
                }
                return result;
            }
        }





        static void Main(string[] args)
        {
            Line line = new Line(0, 0, 10, 10);
            line.Show();
            Console.WriteLine(line);

            Circle circle = new Circle(5, 5, 3);
            circle.Show();
            Console.WriteLine(circle);

            Rectangle rect = new Rectangle(0, 0, 10, 0, 10, 5);
            rect.Show();
            Console.WriteLine(rect);

            PolyLine poly = new PolyLine(0, 0);
            poly.AddPoint(5, 5);
            poly.AddPoint(10, 10);
            poly.AddPoint(15, 5);
            poly.Show();
            Console.WriteLine(poly);

            // Move shapes
            line.Move(5, 5);
            circle.Move(-2, 3);
            rect.Move(-5, -5);
            poly.Move(10, 10);

            // Show updated shapes
            line.Show();
            Console.WriteLine(line);

            circle.Show();
            Console.WriteLine(circle);

            rect.Show();
            Console.WriteLine(rect);

            poly.Show();
            Console.WriteLine(poly);
        }
    }
}
