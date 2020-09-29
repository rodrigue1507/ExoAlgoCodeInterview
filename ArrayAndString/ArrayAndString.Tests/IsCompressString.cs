using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayAndString.Tests
{
    [TestClass]
    public class IsCompressString
    {
        private readonly ArrayAndStringExercises _arrayAndStringExercices;
       public IsCompressString()
        {
            _arrayAndStringExercices = new ArrayAndStringExercises();
        }
        [TestMethod]
        [DataRow("wwwwaaadexxxxxx", "w4a3d1e1x6")]
        public void IsCompress_returnTrue(string s1, string s2)
        {
            var result = _arrayAndStringExercices.CompressString(s1);
            Assert.AreEqual(result,s2,$"{s2} should be a compress string of {s1}");
        }
    }
}
