using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Code1
{

    public class Code1 
    {
        public static void Main()
        {
        	Console.WriteLine("Basic Arithmetic Program");
        	Console.WriteLine("Input two numbers starting from 1 ");
			Console.WriteLine("Input two numbers:");
			int A = Convert.ToInt32(Console.ReadLine());
			int B = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Sum:" + (A+B));
			Console.WriteLine("Difference:" + (A-B));
			Console.WriteLine("Divide or quotient:" + (A/B));
			Console.WriteLine("Multiply:" + (A*B));
			Console.WriteLine("Percentage:" + (A%B));
			Console.WriteLine("Exponential:" + Math.Pow(A,B));
			Console.Read();
			
        }
    }
}
