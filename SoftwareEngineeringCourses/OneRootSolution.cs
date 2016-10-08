namespace SoftwareEngineeringCourses
{
    public class OneRootSolution : EquationSolution
    {
        public OneRootSolution(double x)
        {
            X = x;
        }

        public double X { get; private set; }

        public override double[] AllRoots
        {
            get
            {
                return new[] { X };    
            }
        }
    }
}
