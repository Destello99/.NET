using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandling
{
    internal class Student
    {
        private string name;
        public string Name
        {
            get { return name; }
            set 
            {
                if (value != null && value.Length >= 3)
                    name = value;
                else
                    throw new InvalidInputException("Student Name should have at least 3 characters");
            }
        }

        private int rollNo;
        public int RollNo
        {
            get { return rollNo; }
            set
            {
                if (value > 0)
                {
                    rollNo = value;
                }                  
                else
                    throw new InvalidInputException("Student Rollno should be positive");
            }
        }

        private List<Subject> subjects = new List<Subject>();
        public List<Subject> Subjects 
        {
            get { return  subjects; }
        }

        public StudentFailed studentFailed;

        public Student(int rollNo, string name = "student")
        {
            Name = name;
            RollNo = rollNo;
            //this.subjects = subjects;
        }

        public override string ToString()
        {
            return "RollNo: "+RollNo+",\tName: "+Name;
        }

        public override bool Equals(object? obj)
        {
            return this.RollNo.Equals(((Student)obj).RollNo);
        }

        public void addSubject(Subject subject)
        {
            if (!Subjects.Contains(subject))
            {
                subjects.Add(subject);
                Console.WriteLine($"Subject {subject.Name} added ");
            }             
            else
                Console.WriteLine($"Subject{subject.Name} Already exits");
        }

        public void removeSubject(Subject subject)
        {
            subjects.RemoveAll(s=>s.Equals(subject));
            Console.WriteLine(subject.Name+" removed ");

        }

        public Subject getSubject(string name)
        {
            if (this.Subjects.Contains(new Subject(name)))
                return this.Subjects.Find(s => s.Name.Equals(name));
            else
                return null;
        }

        public Subject getSubject(Subject sb)
        {
            if (this.Subjects.Contains(sb))
                return this.Subjects.Find(s => s.Name.Equals(sb.Name));

            else
                return null;
        }


        public void displaySubjects()
        {
            foreach (Subject subject in subjects)
            {
                Console.WriteLine(subject.ToString());
            }
        }


        public void changeMarks(Subject subject, double marks)
        {
            subject.Marks = marks;
        }
    }

    public delegate Subject StudentFailed();
}
