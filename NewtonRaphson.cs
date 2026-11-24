using System;
using System.Collections.Generic;

namespace NonlinearEquationSolver
{
    public class IterationResult
    {
        public int Iteration { get; set; }
        public double Xi { get; set; }
        public double NextXi { get; set; }
        public double Error { get; set; }
    }

    public class NewtonRaphson
    {
        public static List<IterationResult> Solve(
            Func<double, double> function,
            Func<double, double> derivative,
            double x0,
            double tolerance)
        {
            List<IterationResult> results = new List<IterationResult>();

            double x = x0;
            int iteration = 0;

            while (iteration < 100)
            {
                double fx = function(x);
                double fdx = derivative(x);

                if (Math.Abs(fdx) < 1e-12)
                    throw new Exception("Derivative is zero.");

                double nextX = x - (fx / fdx);

                double error = Math.Abs(nextX - x);

                results.Add(new IterationResult
                {
                    Iteration = iteration,
                    Xi = x,
                    NextXi = nextX,
                    Error = error
                });

                if (error < tolerance)
                    return results;

                x = nextX;
                iteration++;
            }

            throw new Exception("Maximum iterations reached.");
        }
    }
}