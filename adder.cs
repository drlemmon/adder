using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
		double a, b;

		a = Convert.ToDouble( args[0] );
		b = Convert.ToDouble( args[1] );
		Console.WriteLine("Your result: " + a + " + " + b + " = " + (a+b));
	}
    }
}
