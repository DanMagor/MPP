using System;
using System.Collections.Generic;

namespace Assignment72
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine(); 
            Parser parser = new Parser(input);
            Expression expressionTree = parser.Parse();
            Console.WriteLine("Parsing was success!");
	    
        }
    }
}