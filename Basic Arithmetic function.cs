using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace MyFirstTest
{

    public class Test 
    {
        public static void Main()
        {
        	Console.WriteLine("Basic Arithmetic Program");
        	Console.WriteLine("Input two numbers starting from 1 ");
			Console.WriteLine("Input two numbers:");
			int A = Convert.ToInt16(Console.ReadLine());
			int B = Convert.ToInt16(Console.ReadLine());
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