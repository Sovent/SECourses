using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwareEngineeringCourses;

namespace SoftwareEngineeringTests
{
    [TestClass]
    public class EquationSolverTests
    {
        [TestMethod]
        public void SolveEquation_CallsParser()
        {
            var equationParserStub = new EquationParserStub();
            var equationSolver = new EquationSolver(equationParserStub);

            var solution = equationSolver.SolveEquation("blahblahblahblah");

            Assert.IsTrue(equationParserStub.called);
        }
    }

    public class EquationParserStub : IEquationParser
    {
        public bool called = false;
        public Equation ParseEquation(string equation)
        {
            called = true;
            return new Equation(1, 1, 1);
        }
    }
}
