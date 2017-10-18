using System;
using System.Collections.Generic;

namespace Assignment8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine(); 
            var parser = new Parser(input);
            var expressionTree = parser.Parse();
            long result = expressionTree.Calculate();
            Console.WriteLine(result);
	    
        }
    }
}