using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ArrayAndString;

namespace ArrayAndString.Tests
{
    [TestClass]
    public class IsUnique
    {
        private readonly ArrayAndStringExercises _arrayAndStringExercises;
        public IsUnique()
        {
            _arrayAndStringExercises = new ArrayAndStringExercises();
        }

        [DataTestMethod]
        [DataRow("asdfgetrz")]
        [DataRow("fghdjsk")]
        [DataRow("qewrstzxf")]
        [DataRow("gnsbdu")]
        public void IsUnique_returnTrue(string value)
        {
            var result = _arrayAndStringExercises.IsUnique(value);
            Assert.IsTrue(result,$"{value} should return true");
        }

        [DataTestMethod]
        [DataRow("addsdfgetrz")]
        [DataRow("bsggtedd")]
        [DataRow("bcseuhdzvedk")]
        [DataRow("cdhjsgzegg")]
        public void IsUnique_returnFalse(string value)
        {
            var result = _arrayAndStringExercises.IsUnique(value);
            Assert.IsFalse(result, $"{value} should return false");
        }
    }
}
