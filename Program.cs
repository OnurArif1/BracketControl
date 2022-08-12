using System;
using System.Collections.Generic;
using System.Text;
namespace exsample21
{
    class Program
    {
        static void Main(string[] args)
        {
            string aritmetik1 = "(1+2)+(4*8)+9";  
            string aritmetik2 = "(1+2))+(4*8)+9";    
            string aritmetik3 = "((1+2)+(4*8)+9";    
            string aritmetik4 = "(((((((()))))))))";
            string aritmetik5 = Console.ReadLine();
            Console.WriteLine("aritmetik bir sayı girin:"+aritmetik5);
            var stack = new Check();
            Console.WriteLine(stack.BracketControl(aritmetik1));
            Console.WriteLine(stack.BracketControl(aritmetik2));
            Console.WriteLine(stack.BracketControl(aritmetik3));
            Console.WriteLine(stack.BracketControl(aritmetik4));
            Console.WriteLine(stack.BracketControl(aritmetik5));
        }
    }
}
