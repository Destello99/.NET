using System.Transactions;

namespace Assignment_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no. of employees :");
            int n=int.Parse(Console.ReadLine());
            Employee[] emp = new Employee[n];
            List<Employee> list = new List<Employee>();
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Enter name and salary of emp");
                list.Add(new Employee(Console.ReadLine(),int.Parse(Console.ReadLine())));
            }
            for(int i=0;i<n ;i++) {
                emp[i] = list[i];
            }
          for(int i=0;i<n ;i++) {
                Console.WriteLine(emp[i]);
            }
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public Employee(string Name, int Salary)
        {
            this.Name = Name;
            this.Salary = Salary;
        }

        public override string ToString()
        {
            return "Name :" + this.Name + "  Salary:" + this.Salary;
        }
    }
}