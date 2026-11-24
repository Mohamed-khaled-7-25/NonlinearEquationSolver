using System;
using Mathos.Parser;

namespace NonlinearEquationSolver
{
    public class FunctionEvaluator
    {
        private MathParser parser = new MathParser();

        public double Evaluate(string expression, double x)
        {
            parser.LocalVariables["x"] = x;

            return parser.Parse(expression);
        }
        public double Derivative(string expression, double x)
        {
            double h = 0.00001;

            double right = Evaluate(expression, x + h);
            double left = Evaluate(expression, x - h);

            return (right - left) / (2 * h);
        }

    }
}