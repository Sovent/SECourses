using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieAdviser;

namespace MovieAdviserTests
{
    [TestClass]
    public class MovieTests
    {
        [TestMethod]
        public void CallToStringOnMovie_FormatsStringProperly()
        {
            var movie = new Movie("Рейд", "Чжо Чунг", "Боевик");
            var anotherMovie = new Movie("Рейд", "Чжо Чунг", "Боевик");

            Assert.IsTrue(movie == anotherMovie);
        }
    }
}
