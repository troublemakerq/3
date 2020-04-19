using System;

namespace Дроби
{
    class Fraction
    {
        private double numerator;
        private double denominator;
        private double value;
        public Fraction(double num, double denum)
        {
            Numerator = num;
            Denominator = denum;
            value = num / denum;
        }
        public double Numerator { get => numerator; set => numerator = value; }
        public double Denominator { get => denominator; set => denominator = value; }

        public void Exponentiation(double num)
        {
            Numerator = Math.Pow(Numerator, num);
            Denominator = Math.Pow(Denominator, num);
        }

        public static bool operator ==(Fraction fractionA, Fraction fractionB)
        {
            return fractionA.value.Equals(fractionB.value);
        }

        public static bool operator !=(Fraction fractionA, Fraction fractionB)
        {
            return !fractionA.value.Equals(fractionB.value);
        }

        public static bool operator >(Fraction fractionA, Fraction fractionB)
        {
            return fractionA.value > fractionB.value;
        }

        public static bool operator <(Fraction fractionA, Fraction fractionB)
        {
            return fractionA.value < fractionB.value;
        }

        public static bool operator >=(Fraction fractionA, Fraction fractionB)
        {
            return fractionA.value >= fractionB.value;
        }

        public static bool operator <=(Fraction fractionA, Fraction fractionB)
        {
            return fractionA.value <= fractionB.value;
        }

        public static Fraction operator +(Fraction fractionA, Fraction fractionB)
        {
            return new Fraction(fractionA.numerator * fractionB.denominator + fractionA.denominator * fractionB.numerator, fractionA.denominator * fractionB.denominator);
        }

        public static Fraction operator -(Fraction fractionA, Fraction fractionB)
        {
            return new Fraction(fractionA.numerator * fractionB.denominator - fractionA.denominator * fractionB.numerator, fractionA.denominator * fractionB.denominator);
        }

        public static Fraction operator *(Fraction fractionA, Fraction fractionB)
        {
            return new Fraction(fractionA.numerator * fractionB.numerator, fractionA.denominator * fractionB.denominator);
        }

        public static Fraction operator /(Fraction fractionA, Fraction fractionB)
        {
            return new Fraction(fractionA.numerator * fractionB.denominator, fractionA.denominator * fractionB.numerator);
        }

        public static Fraction operator ^(Fraction fractionA, double x)
        {
            return new Fraction(Math.Pow(fractionA.numerator, x), Math.Pow(fractionA.denominator, x));
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", numerator, denominator);
        }
    }
}
