using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    public class Rectangle : Figure
    {
        private double width;
        private double height;
 
        public Rectangle(string name, double height,double width)
        {
            this.Name = name;
            this.width = width;
            this.height = height;
        }
        private Rectangle(){}
        public override void show()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Height: {0}", height);
            Console.WriteLine("Square: {0}", square());
            Console.WriteLine("Perimetr: {0}", perimetr());
 
        }
        public override double square()
        {
            return width * height;
        }
        public override double perimetr()
        {
            return 2 * (width + height);
        }
    }
    }
