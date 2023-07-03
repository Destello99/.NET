namespace EventHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            try
            {
                Student a = new Student(1, "aaa");
                Student b = new Student(2, "bbb");
                Student c = new Student(3, "ccc");

                Console.WriteLine(a + "\n" + b);
                Subject java = new Subject("Java");
                Subject dbms = new Subject("DBMS");
                a.addSubject(java);
                a.addSubject(dbms);
                a.displaySubjects();

                Console.WriteLine();
                a.getSubject("Java").Marks = 88;
                a.getSubject("DBMS").Marks = 86;


                a.changeMarks(a.getSubject(java), 12);
                a.displaySubjects();
            }
            catch (Exception e)
            {
                Console.WriteLine("In Exception catch block");
                Console.WriteLine(e.Message);
            }
           
            
        }
    }

    public delegate int Del1(int x, int y);

    public class Class1
    {
        public static int Add(int x, int y)
        {
            return x+ y;
        }
    }
}