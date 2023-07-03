namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            Employee e= new Employee();
            e.Name = "Pranay";
            e.EmpNo = 1;
            e.DeptNo = 1;
            e.Basic = 25000;
            Console.WriteLine(" name of employee"+e.Name);
            Console.WriteLine("employee number is " + e.EmpNo);
            Console.WriteLine("department number is"+e.DeptNo);
            Console.WriteLine("basic salary is" + e.Basic);
            Console.WriteLine("total salary is"+e.getSalary(e.Basic));
        }
    }

    public class Employee
    {
        private string name;

        public string Name
        {
            set
            {
                if (value.Trim().Length == 0)
                {
                    Console.Write("invalid name");
                }
                else
                {
                    name = value;
                }
            }
            get
            {
                return name;
            }

        }
        private int empNo;

        public int EmpNo
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("in valid employee number");
                }
                else
                {
                    empNo = value;
                }
            }
            get { return empNo; }
        }
        private short deptNo;

        public short DeptNo
        {
            set
            {
                if (value > 0)
                {
                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("invalid department number");
                }
            }
            get { return deptNo; }
        }
        private decimal basic;

        public decimal Basic
        {
            set
            {
                if(value>=10000 && value <= 800000)
                {
                    basic= value;
                }
                else
                {
                    Console.WriteLine("basic out of range");
                }
            }
            get { return basic; }
        }
        public decimal getSalary(decimal basic)
        {   decimal salary = 0;
            salary = basic +(decimal) 0.1 * basic + (decimal)0.5 * basic;
            return salary;
        }
    }
}