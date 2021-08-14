using System;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        { 
            try
            {
                Console.WriteLine("Problem 1 Start");
                Problem1.Run();
                Console.WriteLine("Problem 1 End");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in running problem 2 :" + e);
            }
            try
            {
                Console.WriteLine("Problem 2 Start");
                Problem2.Run();
                Console.WriteLine("Problem 2 End");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception in running problem 2 :" + e);
            }
           
        }
    }
}
