using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwareEngineeringCourses;

namespace SoftwareEngineeringTests
{
    [TestClass]
    public class EquationTests
    {
        [TestMethod]
        public void GetDiscriminant_SatisfiesAlgorithm()
        {
            var equation = new Equation(4, 5, 2);
            var expectedDiscriminant = -7;

            var actualDiscriminant = equation.GetDiscriminant();

            Assert.AreEqual(expectedDiscriminant, actualDiscriminant);
        }
    }
}
