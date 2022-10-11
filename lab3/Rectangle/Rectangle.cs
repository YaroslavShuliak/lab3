using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangle
    {
        private double side1, side2;
        public double Side1
        {
            set { side1 = value; }
            get { return side1; }
        }
        public double Side2
        {
            set { side2 = value; }
            get { return side2; }
        }
        double area;
        private double AreaCalculator()
        {
            area = this.side1 * this.side2;
            return area;
        }
        public double Area
        {
            get { return AreaCalculator(); }
        }
        private double perimiter;
        private double PerimeterCalculator()
        {
            perimiter = (this.side1 + this.side2) * 2;
            return perimiter;
        }
        public double Perimiter
        {
            get { return PerimeterCalculator(); }
        }
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("Введiть першу сторону:");
            rectangle.Side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введiть другу сторону:");
            rectangle.Side2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Периметр: {rectangle.Perimiter}");
            Console.WriteLine($"Площа: {rectangle.Area}");
        }
    }
}
