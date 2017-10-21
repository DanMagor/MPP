using System;
using System.Collections.Generic;

namespace Assignment8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var input = System.IO.File.ReadAllText(@"input.txt");
            var parser = new Parser(input);
            var expressionTree = parser.Parse();
            System.IO.File.WriteAllText(@"output.txt","Parsed:" + expressionTree.ToJson());
	    
        }
    }
}