using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    public abstract class Figure
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public abstract void show();
        public abstract double square();
        public abstract double perimetr();
    }
}
