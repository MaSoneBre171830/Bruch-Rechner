using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruchrechner
{
    public class Fraction
    {
        public int Numerator { get; }
        public int Denominator { get; }

        public Fraction() { Numerator = 0; Denominator = 0; }
        public Fraction(int numerator, int denominator)
        {

            int gcd = GCD(numerator, denominator);
            Numerator = numerator / gcd;
            Denominator = denominator / gcd;
        }

        private int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }

    public class FractionCalculator
    {
        public Fraction Add(Fraction a, Fraction b)
        {
            int newNumerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
            int newDenominator = a.Denominator * b.Denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public Fraction Sub(Fraction a, Fraction b)
        {
            int newNumerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
            int newDenominator = a.Denominator * b.Denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public Fraction Mult(Fraction a, Fraction b)
        {
            int newNumerator = a.Numerator * b.Numerator;
            int newDenominator = a.Denominator * b.Denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public Fraction Div(Fraction a, Fraction b)
        {
            

            int newNumerator = a.Numerator * b.Denominator;
            int newDenominator = a.Denominator * b.Numerator;
            return new Fraction(newNumerator, newDenominator);
        }
        public Fraction Power(Fraction bruch, int exponent)
        {
            int newNumerator = (int)Math.Pow(bruch.Numerator, exponent);
            int newDenominator = (int)Math.Pow(bruch.Denominator, exponent);
            return new Fraction(newNumerator, newDenominator);
        }

        public Fraction SquareRoot(Fraction bruch)
        {
            int newNumerator = (int)Math.Sqrt(bruch.Numerator);
            int newDenominator = (int)Math.Sqrt(bruch.Denominator);
    
            return new Fraction(newNumerator, newDenominator);
        }
    }

}
