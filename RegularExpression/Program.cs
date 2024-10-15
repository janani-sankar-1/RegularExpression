using System;
using System.Text.RegularExpressions;


namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex("^[A-Za-z]*$");
            Console.WriteLine("Enter a value:");
            string inputValue=Console.ReadLine();
            bool result=regex.IsMatch(inputValue);
            Console.WriteLine(result);
            if(result==true )
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.ReadKey();
            //[0-9]
            //[a-z]
            //[A-z]
            //[1,2,3]
            //\d --> 1,2,3,4,5,6,7,8,9,0
            //\w --> a
            //\s --> white space

        }
    }
}
