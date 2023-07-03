namespace Asignment_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no. of emp");
            int n = int.Parse(Console.ReadLine());
            Employee[] arr = new Employee[n];
            // Console.WriteLine("Enter name and salary of emp");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter name and salary of emp");
                Employee e = new Employee(Console.ReadLine(), int.Parse(Console.ReadLine()));
                arr[i] = e;
            }
            List<Employee> list = new List<Employee>();
            foreach(Employee c in arr) 
            {
              list.Add(c);
            }
            for(int i=0; i<list.Count; i++)
            {
                Console.WriteLine(list[i]);
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