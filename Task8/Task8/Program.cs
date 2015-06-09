using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figure = new List<Figure>();
            Console.WriteLine("Enter file name : ");
            string fileName = Console.ReadLine();
            if (!File.Exists(fileName))
            {
                Console.WriteLine("File not found " + fileName);
                Console.ReadLine();
                return;
            }
            string str = null;
            using (StreamReader sr = new StreamReader(fileName))
            {
                str = sr.ReadToEnd();
            }
            string[] par = str.Split('\n');
            int i = 0;
            while (i < par.Length)
            {
                switch (par[i][0])
                {
                    case 'r':
                        {
                            figure.Add(new Rectangle(par[i], Convert.ToDouble(par[++i]), Convert.ToDouble(par[++i])));
                            i++;
                            break;
                        }
                    case 'c':
                        {
                            figure.Add(new Circle(par[i], Convert.ToDouble(par[++i])));
                            i++;
                            break;
                        }
                    case 't':
                        {
                            figure.Add(new Triangle(par[i], Convert.ToDouble(par[++i]), Convert.ToDouble(par[++i])));
                            i++;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Default");
                            i++;
                            break;
                        }
                }

            }

            foreach (Figure f in figure)
                f.show();
            Console.ReadLine();
            }

         
    }
}
