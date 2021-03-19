using System;

//  While Loops | C# | Tutorial 18


namespace CSharpExercises_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //int index = 1;
            //while (index <= 5)
            //{
            //    Console.WriteLine(index);
            //    index++;

            //}


            // do while loop will run at least 1 time 
            int index = 6;
            do
            {
                Console.WriteLine(index);
                index++;

            } while (index <= 5);

            Console.ReadLine();
        }
    }
}
