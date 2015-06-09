using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    public class Triangle : Figure
    {
        private double basis;
        private double height;

        public Triangle(string name, double height, double basis)
        {
            this.Name = name;
            this.basis = basis;
            this.height = height;
        }
        private Triangle() { }
        public override void show()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Basis: {0}", basis);
            Console.WriteLine("Height: {0}", height);
            Console.WriteLine("Square: {0}", square());
            Console.WriteLine("Perimetr: {0}", perimetr());

        }
        public override double square()
        {
            return 0.5 * (basis * height);
        }
        public override double perimetr()
        {
            return Math.Sqrt(Math.Pow(0.5 * basis, 2) + Math.Pow(height, 2)) * 2 + height;
        }
    }
}
