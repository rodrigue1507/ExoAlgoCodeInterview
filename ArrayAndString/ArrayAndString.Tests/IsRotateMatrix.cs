using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayAndString.Tests
{
    [TestClass]
    public class IsRotateMatrix
    {
        private readonly ArrayAndStringExercises _arrayAndStringExercises;
        public IsRotateMatrix()
        {
            _arrayAndStringExercises = new ArrayAndStringExercises();
        }
        [TestMethod]
        [DataRow( new byte { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 16, 17 } }, "{ 13, 9, 5, 1 }, { 14, 10, 6, 2 }, { 15, 11, 7, 3 }, { 16, 12, 8, 4 }")]
        public void Is_RotateMatrix_ReturnTrue(byte[,] origniMatrix, byte[,] rotateMatrix)
        {


        } 
    }
}
