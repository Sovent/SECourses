namespace SoftwareEngineeringCourses
{
    public class EquationSolver
    {
        public EquationSolver(IEquationParser equationParser)
        {
            _equationParser = equationParser;
        }

        public EquationSolution SolveEquation(string equation)
        {
            var parsedEquation = _equationParser.ParseEquation(equation);
            return parsedEquation.Solve();
        }

        private readonly IEquationParser _equationParser;
    }
}
