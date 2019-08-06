using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

/*
 * Confusion matrix for testing:
 * TP = 87      FP = 5
 * FN = 2       TN = 26
 * */

namespace ConfMatrix
{
    [TestFixture]
    class test
    {

        Calc obj = new Calc("87", "5", "26", "2");
        float expectedAccuracy = 0.941666663f;
        float expectedPrecision = 0.945652187f;
        float expectedSensitivity = 0.977528095f;
        float expectedSpecificity = 0.838709652f;
        float expectedF1Score = 0.961325943f;

        [Test]
        public void TestAccuracy()
        {
            float accuracy = obj.accuracy();
            Assert.AreEqual(expectedAccuracy, accuracy);
        }

        [Test]
        public void TestPrecision()
        {
            float precision = obj.precision();
            Assert.AreEqual(expectedPrecision, precision);
        }

        [Test]
        public void TestSpecificity()
        {
            float specificity = obj.specificity();
            Assert.AreEqual(expectedSpecificity, specificity);
        }

        [Test]
        public void TestSensitivity()
        {
            float sensitivity = obj.sensitivity();
            Assert.AreEqual(expectedSensitivity, sensitivity);
        }

        [Test]
        public void TestF1Score()
        {
            float f1Score = obj.f1Score();
            Assert.AreEqual(expectedF1Score, f1Score);
        }

        
        [Test]
        public void testAllBlank()
        {
            Calc obj1 = new Calc("", "", "", "");
            Assert.AreEqual(0.0f, obj1.accuracy()); //Also applicable for precision, sensitivity, specificity, f1-score  
        }

        [Test]
        public void testFirstBlank()
        {
            Calc obj1 = new Calc("", "5", "26", "2");
            Assert.AreEqual(0.0f, obj1.accuracy()); //Also applicable for precision, sensitivity, specificity, f1-score
        }

        [Test]
        public void testSecondBlank()
        {
            Calc obj1 = new Calc("87", "", "26", "2");
            Assert.AreEqual(0.0f, obj1.accuracy()); //Also applicable for precision, sensitivity, specificity, f1-score
        }

        [Test]
        public void testThirdBlank()
        {
            Calc obj1 = new Calc("87", "5", "", "2");
            Assert.AreEqual(0.0f, obj1.accuracy()); //Also applicable for precision, sensitivity, specificity, f1-score
        }

        [Test]
        public void testLastBlank()
        {
            Calc obj1 = new Calc("87", "5", "26", "");
            Assert.AreEqual(0.0f, obj1.accuracy()); //Also applicable for precision, sensitivity, specificity, f1-score
        }

        [Test]
        public void testCharacter()
        {
            Calc obj1 = new Calc("Abcpo", "5", "ew", "2");
            Assert.AreEqual(-1.0f, obj1.accuracy());
            //Also applicable for precision, sensitivity, specificity, f1-score
        }



    }
}
