using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allLines = File.ReadAllLines("input.txt");
            Student[] students = new Student[allLines.Length];
            for (int index = 0; index < allLines.Length; index++)
            {
                string line = allLines[index];
                string[] fields = line.Split(';');
                Student student = new Student(fields[0], Convert.ToInt32(fields[1]), fields[2], fields[3]);
                students[index] = student;
            }
            Array.Sort(students);
            foreach (Student student in students)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }
            string[] linesToSave = new string[students.Length];
            for (int i = 0; i < students.Length; i++)
            {
                Student student = students[i];
                linesToSave[i] = student.ToString();
            }
            File.WriteAllLines("output.txt", linesToSave);
            Console.ReadKey();
        }
        }
    }
}
