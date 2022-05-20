using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excepciones_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                int num1;
                int num2;
                Console.Write("Enter a number: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("enter another number: ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine(num1 / num2);
                Console.ReadLine();
            }
            catch(DivideByZeroException e)
            {
                Console.Write(e.Message);
                
            }
            catch(FormatException e)
            {
                Console.Write(e.Message);
            }
        }
        

    }
}
