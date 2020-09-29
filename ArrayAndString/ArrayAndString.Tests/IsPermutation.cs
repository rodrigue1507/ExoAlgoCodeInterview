using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayAndString.Tests
{
    [TestClass]
    public class IsPermutation
    {
        private readonly ArrayAndStringExercises _arrayAndStringExercises;
        public IsPermutation()
        {
            _arrayAndStringExercises = new ArrayAndStringExercises();
        }
        [TestMethod]
        [DataRow("qwer", "rweq")]
        [DataRow("dfghj","fghdj")]
        [DataRow("okm","kom")]
        [DataRow("yxcv","xcvy")]
        [DataRow("decs","edsc")]
        public void IsPermutation_returnTrue(string value1, string value2)
        {
            var result = _arrayAndStringExercises.IsPermutation(value1,value2);
            Assert.IsTrue(result,$"{value1} and {value2} should be permutation");
        }

        [TestMethod]
        [DataRow("asdfg","asdf")]
        [DataRow("gtds","gtdd")]
        [DataRow("yxcvb","nhzres")]
        public void IsPermutation_returnFalse(string value1, string value2)
        {
            var result = _arrayAndStringExercises.IsPermutation(value1, value2);
            Assert.IsFalse(result, $"{value1} and {value2} should not be permute");
        }
    }
}
