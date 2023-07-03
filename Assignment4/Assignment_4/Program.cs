/*
    CDAC has certain number of batches. each batch has certain number of students
        accept number of batches. for each batch accept number of students.
        create an array to store mark for each student (1 student has only 1 subject mark)
        accept the marks.
        display the marks
.*/

namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of batches:");
            int batch = Convert.ToInt32(Console.ReadLine());

            int[][] batches = new int[batch][];

            for( int i=0; i<batches.Length; i++)
            {
                Console.WriteLine($"Enter number of Students in batch{i}");
                int Students = Convert.ToInt32(Console.ReadLine());
                batches[i] = new int[Students];

                for (int j=0; j < Students; j++)
                {
                    batches[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //end of input

            Console.WriteLine("Students are:");
            for(int i=0; i<batches.Length;i++)
            {
                for(int j=0; j < batches[i].Length; j++)
                {
                    Console.WriteLine(batches[i][j]);
                }
            }
        }
    }
}