using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your First Name :");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Please Enter Your Last Name :");
            string LastrName = Console.ReadLine();

           // Console.WriteLine("Hello " + UserName);
            Console.WriteLine("Hello {0} {1}",FirstName ,LastrName  );

            //Console.WriteLine("Enter First Number :");
            // string num1 = Console.ReadLine();
            // Console.WriteLine("Enter Secand Number :");
            // string num2 = Console.ReadLine();
            // Convert.ToInt16(num1);
            // Convert.ToInt16(num2);
            // string  result = num1 + num2;
            // Convert.ToInt16(result);
            // Console.WriteLine(result);

            int Myvalue =7;
            Console.Write(" (0)", Myvalue);




        }
    }
}
