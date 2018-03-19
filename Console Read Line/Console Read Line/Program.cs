using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Read_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Enter Your Name.");
                var _name = Console.ReadLine(); // Initializes the user's name, this will be referenced later on.
                Console.WriteLine("How Old Are You?");
                var _age = Console.ReadLine(); // Initializes the user's age, this will be referenced later on.

                Console.WriteLine("Hello {0}, You Are {1} Years Old", _name, _age);
            }
            finally
            {
                Console.WriteLine(System.Environment.NewLine);
                Console.WriteLine("Please Exit The Program.");    
            }
        }
    }
}
