using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    public class Circle : Figure
    {
        private double r;

        public Circle(string name, double r)
        {
            this.Name = name;
            this.r = r;
        }
        private Circle() { }
        public override void show()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Radius: {0}", r);
            Console.WriteLine("Square: {0}", square());
            Console.WriteLine("Circumference: {0}", perimetr());

        }
        public override double square()
        {
            return Math.PI * r * r;
        }
        public override double perimetr()
        {
            return 2 * Math.PI * r;
        }
    }
}
