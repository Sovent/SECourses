using System;

namespace SoftwareEngineeringCourses
{
    public class Equation
    {
        public Equation(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double A { get; private set; }

        public double B { get; private set; }

        public double C { get; private set; }

        public double GetDiscriminant()
        {
            return B * B - 4 * A * C;
        }

        public EquationSolution Solve()
        {
            var discriminant = GetDiscriminant();
            var rootsCount = CountRoots();
            switch (rootsCount)
            {
                case 2:
                    var x1 = (-B - Math.Sqrt(discriminant)) / (2 * A);
                    var x2 = (-B + Math.Sqrt(discriminant)) / (2 * A);
                    return new TwoRootsSolution(x1, x2);
                case 1:
                    var x = -B / (2 * A);
                    return new OneRootSolution(x);
                default:
                    return new NoRootsSolution();
            }
        }

        private int CountRoots()
        {
            var discriminant = GetDiscriminant();
            if (discriminant > 0)
            {
                return 2;
            }
            if (discriminant < 0)
            {
                return 0;
            }
            return 1;
        }
    }
}
