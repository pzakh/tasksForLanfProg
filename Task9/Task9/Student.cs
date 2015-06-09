using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    public struct Student : IComparable
    {
        public Student(string name, int yearOfBirth, string homeAddress, string school)
            : this()
        {
            Name = name;
            YearOfBirth = yearOfBirth;
            HomeAddress = homeAddress;
            School = school;
        }

        public string Name { get; private set; }
        public int YearOfBirth { get; private set; }
        public string HomeAddress { get; private set; }
        public string School { get; private set; }

        public int CompareTo(object obj)
        {
            return YearOfBirth.CompareTo(((Student)obj).YearOfBirth);
        }

        public override string ToString()
        {
            return string.Format("{0}; {1}; {2}; {3}",
                                 Name, YearOfBirth, HomeAddress, School);
        }
    }
}
