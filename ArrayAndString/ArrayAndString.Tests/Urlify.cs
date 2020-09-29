using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayAndString.Tests
{
    [TestClass]
    public class Urlify
    {
        private readonly ArrayAndStringExercises _arrayAndStringExercises;
        public Urlify()
        {
            _arrayAndStringExercises = new ArrayAndStringExercises();
        }
        [TestMethod]
        [DataRow("Mr John Smith  ",13,"Mr%20John%20Smith")]
        public void urlify_returnTrue(string string1,int string1Lenght ,string string2)
        {
            var result = _arrayAndStringExercises.Urlify(string1, string1Lenght);
            Assert.AreEqual(string2,result,$"{result} and {string2} are not equal");
        }
    }
}
