using Assignment3;
namespace Assingmnet_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Employee e1 = new Manager();
            e1.Name = "Tim cook";
            e1.DeptNo = 1;
            e1.BaseSalary = 1568453.36m;
            //m for decimal
            e1.insert();
            e1.update();
            e1.delete();
            Console.WriteLine(e1.GetNetSalary(e1.BaseSalary));

            Manager mrg = new Manager();
            mrg.Designation = "CEO of Appple";
            mrg.Name = e1.Name;
            mrg.BaseSalary = e1.BaseSalary;
            mrg.insert();
           
            Console.WriteLine(mrg.GetNetSalary(mrg.BaseSalary));
        }
    }
}

namespace Assignment3
{

    internal abstract class Employee : IDbFunctions
    {
        public static int empNo;
        private string name;
        private short deptNo;
        private  decimal baseSalary;
        private int empID;

        protected Employee()
        {
            empID = empNo++;
        }

        public decimal BaseSalary
        {
            get { return baseSalary; }
            set
            {
                if (value > 0 && value > 1000000)
                    baseSalary = value;
                else
                    Console.WriteLine("Enter proper base salary");
            }
        }
        public short DeptNo
        {
            get
            {
                return deptNo;
            }
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("valus should be greather than zero");
            }
        }
        public abstract decimal GetNetSalary(decimal basic);

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > 0)
                    name = value;
                else
                    Console.WriteLine("name can't be null");
            }
        }

        public void delete()
        {
            Console.WriteLine("delete form Employee");
        }

        public void insert()
        {
            Console.WriteLine("insert form Employee");
        }

        public void update()
        {
            Console.WriteLine("update form Employee");
        }
    }

    //Manager Class
    internal class Manager : Employee , IDbFunctions
    {
        private string designation; 
        public string Designation
        {
            get
            {
                return designation;
            }
            set
            {
                if (value.Length > 0)
                    designation = value;
                else Console.WriteLine("Designation can't be null");
            }
        }
        public new void delete()
        {
            Console.WriteLine("delete form Manager");
        }

        public new void insert()
        {
            Console.WriteLine("insert form Manager");
        }

        public new void update()
        {
            Console.WriteLine("update form Manager");
        }


        //Override method
        public override decimal GetNetSalary(decimal basic)
        {
            //Net salary for Manager
            return BaseSalary * (decimal)0.2;
        }
    }
    //Manager Class END

    //GeneralManager Class

    internal class GeneralManager : Manager, IDbFunctions
    {
        private string? Perks { get; set; }

        public GeneralManager()
        {
            Console.WriteLine("This is GeneralManager Consrtructor");
        }
        public new void delete()
        {
            Console.WriteLine("delete form GeneralManager");
        }

        public new void insert()
        {
            Console.WriteLine("insert form GeneralManager");
        }

        public new void update()
        {
            Console.WriteLine("update form GeneralManager");
        }
        public override decimal GetNetSalary(decimal basic)
        {
            return BaseSalary * (decimal)0.9;
        }
    }
    //GeneralManager Class END

    //CEO class
    internal class CEO : Employee , IDbFunctions
    {
        //TODO constructor
        public CEO()
        {
            Console.WriteLine("This is CEO constructor");
        }

        public new void delete()
        {
            Console.WriteLine("delete form CEO");
        }

        public new void insert()
        {
            Console.WriteLine("insert form CEO");
        }

        public new void update()
        {
            Console.WriteLine("update form CEO");
        }
        // sealed : this method can't be override further more
        public sealed override decimal GetNetSalary(decimal basic)
        {
            return BaseSalary * (decimal) 0.9;
        }
    }
    //CEO class END
    interface IDbFunctions
    {
        public void insert();
        public void update();
        public void delete();
    }
}