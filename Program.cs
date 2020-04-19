using System;

namespace Дроби
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(1, 2);
            Fraction fraction2 = new Fraction(1, 3);
            Fraction fraction3 = new Fraction(1, 5);
            var result = (fraction3 - fraction1) * fraction3;
            Console.WriteLine(result);
            var result1 = fraction1 + fraction2;
            Console.WriteLine(result1);
            var result2 = fraction1 ^ 3;
            Console.WriteLine(result2);
            Console.WriteLine(fraction1 > fraction2);
            Console.WriteLine(fraction1 < fraction2);

        }
    }
}
