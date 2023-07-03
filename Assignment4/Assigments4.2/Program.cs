/*
        Create an array of Employee class objects
        Accept details for all Employees
        Display the Employee with highest Salary
        Accept EmpNo to be searched. Display all details for that employee.
*/

namespace Assigments4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee [] empArray = new Employee[2];


            /*Employee emp = new Employee(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()),Convert.ToDecimal(Console.ReadLine()));*/
            Console.WriteLine("Enter data for 3 emp : name,age, salray");
            for (int i = 0; i < empArray.Length; i++)
            {
                empArray[i] = new Employee(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToDecimal(Console.ReadLine()));
            }

            foreach(Employee emp in empArray)
            {
                Console.WriteLine(emp.Name+" "+emp.Age+" "+emp.Salary);
            }
        }
    }

    class Employee
    {
        private string? name;
        private int age;
        public decimal Salary;

        public string? Name
        {
            get {
                return name;
            }
            set {
                if(value.Length > 0)
                        name = value;
                else
                        Console.WriteLine("name shouls not be null");
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 65)
                    age = value;
                else
                    Console.WriteLine("employee age should not be greater than 65");
            }
        }

        //Constructor

        public Employee(string name, int age, decimal Salary)
        {
            this.name = name;
            this.age = age;
            this.Salary = Salary;
        }
    }
}