namespace SoftwareEngineeringCourses
{
    public class TwoRootsSolution : EquationSolution
    {
        public TwoRootsSolution(double x1, double x2)
        {
            X1 = x1;
            X2 = x2;
        }

        public double X1 { get; private set; }

        public double X2 { get; private set; }

        public override double[] AllRoots
        {
            get
            {
                return new[] { X1, X2 };
            }
        }
    }
}
