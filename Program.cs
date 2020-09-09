using System;
using MathNet.Symbolics;
using Expr = MathNet.Symbolics.SymbolicExpression;
using MathNet.Numerics;
using System.Collections.Generic;

namespace caculus
{

    class Program
    {


        static void Main(string[] args)
        {
            var x = Expr.Variable("x");
            var a = Expr.Variable("a");
            string poly = "5x^2+3x+5";
            int start;
            int count;
            int end;
            int posOfx;
            //int counting;
            List<int> coeff = new List<int>();

            end = poly.Length;
            start = 0;
            count = 0;
            posOfx = 0;
            //counting = 0;

            while ((start <= end) && (posOfx > -1))
            {
                count = end - start;
                posOfx = poly.IndexOf('x', start, count);
                if (posOfx == -1) break;
                start = posOfx + 1;
                coeff.Add(posOfx);


            }
            Console.WriteLine(coeff[0]);
            foreach (int y in coeff)
            {
                Console.WriteLine(coeff[y]);
            }
            Console.ReadLine();










            //  menu();


        }

        static void menu()
        {
            Console.WriteLine("Welcome to the Differentiation app\n\n1: Calculator\n2: Quiz");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Calc();
            }
            if (input == 2)
            {
                Quiz();
            }
        }

        static void Quiz()
        {
            Console.WriteLine("Welcome to the quiz");
        }
        static void Calc()
        {
            Console.WriteLine("Welcome to the Calculator");

        }


    }
}
