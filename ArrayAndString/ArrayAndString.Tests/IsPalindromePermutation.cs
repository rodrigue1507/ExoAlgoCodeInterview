using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayAndString.Tests
{
    [TestClass]
    public class IsPalindromePermutation
    {
        private readonly ArrayAndStringExercises _arrayAndStringExercises;
        public IsPalindromePermutation()
        {
            _arrayAndStringExercises = new ArrayAndStringExercises();
        }
        [TestMethod]
        [DataRow("Tact Coa")]
        [DataRow("Tenet")]
        [DataRow("Kayak")]
        [DataRow("elle")]
        [DataRow("malayalam")]
        [DataRow("rotor")]
        public void Is_Palindrome_returnTrue(string s1)
        {
            var result = _arrayAndStringExercises.PalindromePermutation(s1);
            Assert.IsTrue(result,$"{s1} should be a palindrome permutation");
        }
    }
}
