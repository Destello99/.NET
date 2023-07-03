using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandling
{
    public class Subject
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value != null && value != "")
                    name = value;
                else
                    throw new InvalidInputException("Subject Name can not be null");
            }
        }

        public static double PassingMarks { get; set; }

        private double marks;
        public double Marks 
        {
            get { return marks; }
            set
            {
                if (value >= 0)
                    marks = value;
                else
                    throw new InvalidInputException("Marks can not be negative");
            }
        }

        public Subject(string name="default", double marks=0, int passingMarks=40)
        {
            this.Name = name;
            this.Marks = marks;
            PassingMarks = passingMarks;
        }

        public override string ToString()
        {
            return Name + ",\t " + Marks;
        }

        public override bool Equals(object? obj)
        {
            return this.Name.Equals(((Subject)obj).Name);
        }
    }

    //public delegate Subject StudentFailed();
}
