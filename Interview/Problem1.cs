using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public static  class Problem1
    {
        public static void Run()
        {
            Console.WriteLine("Problem 1 result ");
            string numbers = "3, 11, s, 4, 19, -5, +5, 77";
            Console.WriteLine($"{numbers} = {sum(numbers)}");
            numbers = "1,9,4,101,R1,8,";
            Console.WriteLine($"{numbers} = {sum(numbers)}");


        } 
        /// <summary>
        /// Given a string of numers sperated by comma
        /// the input may contain characters 
        /// Example 1:
        /// Input: str = "3,11,s,4,19,-5,+5,77"
        /// Output: 114 
        /// Example 2:
        /// Input: str = "1,9,4,101,R1,8,"
        /// Output: 123 
        /// </summary>
        /// <param name="numbers"></param> 
        /// <returns>Integer</returns>
        public static int sum(string numbers)
        {
            int sum = 0;
            //implement here; 
            return sum;
        }
      
    }
}
