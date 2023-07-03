namespace Assignment_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Employee> my = new Dictionary<int,Employee>();
            bool flag = false;
            while (!flag) {
                Console.WriteLine("Add emp 1)yes 2)no");
                int op=int.Parse(Console.ReadLine());
                if(op==1)
                {
                    Console.WriteLine("Enter emp no,name,salary");
                  Employee e=  new Employee(int.Parse(Console.ReadLine()), Console.ReadLine(), int.Parse(Console.ReadLine()))
                    my.Add(e.Empno,e);
                }
                else
                {
                    flag=true;
                }
            }

           foreach (Employee e in my)
            {
                Console.WriteLine(e);
            }
        }
    }
    public class Employee
    {
        public int Empno { set; get; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public Employee(int empno, string Name, int Salary)
        {
            Empno = empno;
            this.Name = Name;
            this.Salary = Salary;
        }

        public override string ToString()
        {
            return "Name :" + this.Name + "Salary:" + this.Salary;
        }

    }
}