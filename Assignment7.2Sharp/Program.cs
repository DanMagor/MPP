using System;
using System.Collections.Generic;

namespace Assignment7_2

{
internal class Program
{
    public static void Main(string[] args)
    {
		string input = ReadLine(); 
		Parser parser = new Parser(input);
		Expression expressionTree = parser.parse();
	    
    }
}
}