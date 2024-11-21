using Microsoft.VisualStudio.TestPlatform.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class ProgramTests
    {
        Program main = new Program();
        [TestMethod()]
        public void Task_1_1Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5 };
            double[] input2 = new double[] { 2, 1, 3, 3, 5, 6 };
            double[] answer1 = new double[] { 0, 0.54, 0.36, 1.07, -0.79, -0.18 };
            double[] answer2 = new double[] { 0.1, 0.05, 0.15, 0.15, 0.25, 0.3 };
            // Act
            input1 = main.Task_1_1(input1);
            input2 = main.Task_1_1(input2);
            // Assert
            for (int i = 0; i < answer1.Length; i++)
            {
                Assert.AreEqual(answer1[i], input1[i]);
                Assert.AreEqual(answer2[i], input2[i]);
            }
        }
        [TestMethod()]
        public void Task_1_2Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, -1 };
            double[] input2 = new double[] { 2, 1, 3, 3, 5, 6, 3, 4 };
            double[] answer1 = new double[] { 0, 1.88, 1.88, 1.88, -2.2, -0.5, 1.88, -1 };
            double[] answer2 = new double[] { 3.38, 3.38, 3.38, 3.38, 3.38, 3.38, 3.38, 3.38 };
            // Act
            input1 = main.Task_1_2(input1);
            input2 = main.Task_1_2(input2);
            // Assert
            for (int i = 0; i < answer1.Length; i++)
            {
                Assert.AreEqual(answer1[i], input1[i]);
                Assert.AreEqual(answer2[i], input2[i]);
            }
        }
        [TestMethod()]
        public void Task_1_3Test()
        {
            // Arrange
            double[] input1 = new double[] { -2.2, -0.5, 2, -1 };
            double[] input2 = new double[] { 0, 1.5, 4, 3 };
            double[] input3 = new double[] { 2, 1, 3, 3 };
            double[] answer1 = new double[] { -2.2, 1, 6, 2 };
            double[] answer2 = new double[] { -0.2, 0.5, 5, 2 };
            double[] answer3 = new double[] { 2, 2.5, 7, 6 };
            double[] answer4 = new double[] { -2.2, -2, -2, -4 };
            double[] answer5 = new double[] { -4.2, -1.5, -1, -4 };
            double[] answer6 = new double[] { -2, 0.5, 1, 0 };
            double[] sum1, sum2, sum3, dif1, dif2, dif3;
            // Act
            (sum1, dif1) = main.Task_1_3(input1, input2);
            (sum2, dif2) = main.Task_1_3(input1, input3);
            (sum3, dif3) = main.Task_1_3(input2, input3);
            // Assert
            for (int i = 0; i < answer1.Length; i++)
            {
                Assert.AreEqual(answer1[i], sum1[i]);
                Assert.AreEqual(answer2[i], sum2[i]);
                Assert.AreEqual(answer3[i], sum3[i]);
                Assert.AreEqual(answer4[i], dif1[i]);
                Assert.AreEqual(answer5[i], dif2[i]);
                Assert.AreEqual(answer6[i], dif3[i]);
            }
        }

        [TestMethod()]
        public void Task_1_4Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2 };
            double[] input2 = new double[] { 1.5, 2.8, 3.1, 4.7, 5.2 };
            double[] answer1 = new double[] { -0.66, 0.84, 0.34, 2.34, -2.86 };
            double[] answer2 = new double[] { -1.96, -0.66, -0.36, 1.24, 1.74 };
            // Act
            input1 = main.Task_1_4(input1);
            input2 = main.Task_1_4(input2);
            // Assert
            for (int i = 0; i < answer1.Length; i++)
            {
                Assert.AreEqual(answer1[i], input1[i]);
                Assert.AreEqual(answer2[i], input2[i]);
            }
        }
        [TestMethod()]
        public void Task_1_5Test()
        {
            // Arrange
            double[] input1 = new double[] { -2.2, -0.5, 2, -1 };
            double[] input2 = new double[] { 0, 1.5, 4, 3 };
            double[] input3 = new double[] { 2, 1, 3, 3 };
            double answer1 = 4.25;
            double answer2 = -1.9;
            double answer3 = 22.5;
            double outpit1, outpit2, outpit3;
            // Act
            outpit1 = main.Task_1_5(input1, input2);
            outpit2 = main.Task_1_5(input1, input3);
            outpit3 = main.Task_1_5(input2, input3);
            // Assert
            Assert.AreEqual(answer1, outpit1);
            Assert.AreEqual(answer2, outpit2);
            Assert.AreEqual(answer3, outpit3);
        }
        [TestMethod()]
        public void Task_1_6Test()
        {
            // Arrange
            double[] input1 = new double[] { 1.5, 1, 3, -2.2, -0.5 };
            double[] input2 = new double[] { 2, 1, 3, 5, 6 };
            double answer1 = 4.16;
            double answer2 = 8.66;
            double output1, output2;
            // Act
            output1 = main.Task_1_6(input1);
            output2 = main.Task_1_6(input2);
            // Assert
            Assert.AreEqual(answer1, output1);
            Assert.AreEqual(answer2, output2);
        }
        [TestMethod()]
        public void Task_1_7Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 };
            double[] input2 = new double[] { 2, 1, 3, 3, 5, 6, 0 };
            double[] answer1 = new double[] { 0, 0, 0, 0, -2.2, -0.5, 0 };
            double[] answer2 = new double[] { 2, 1, 0, 0, 0, 0, 0 };
            // Act
            input1 = main.Task_1_7(input1);
            input2 = main.Task_1_7(input2);
            // Assert
            for (int i = 0; i < answer1.Length; i++)
            {
                Assert.AreEqual(answer1[i], input1[i]);
                Assert.AreEqual(answer2[i], input2[i]);
            }
        }

        [TestMethod()]
        public void Task_1_8Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5 };
            double[] input2 = new double[] { 2, 1, 3, 3, 5, 6 };
            int output1, output2, answer1 = 2, answer2 = 0;
            // Act
            output1 = main.Task_1_8(input1);
            output2 = main.Task_1_8(input2);
            // Assert
            Assert.AreEqual(answer1, output1);
            Assert.AreEqual(answer2, output2);
        }
        [TestMethod()]
        public void Task_1_9Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, -1 };
            double[] input2 = new double[] { 2, 1, 3, 3, 5, 6, 3, 4 };
            int output1, output2, answer1 = 4, answer2 = 3;
            // Act
            output1 = main.Task_1_9(input1);
            output2 = main.Task_1_9(input2);
            // Assert
            Assert.AreEqual(answer1, output1);
            Assert.AreEqual(answer2, output2);
        }
        [TestMethod()]
        public void Task_1_10Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, -1, 1.8, 2.4 };
            double[] input2 = new double[] { 2, 1, 3, 3, 5, 6, 3, 4, 5, 0 };
            int P1 = 2, Q1 = 8, P2 = 3, Q2 = 4, output1, output2, answer1 = 2, answer2 = 0;
            // Act
            output1 = main.Task_1_10(input1, P1, Q1);
            output2 = main.Task_1_10(input2, P2, Q2);
            // Assert
            Assert.AreEqual(answer1, output1);
            Assert.AreEqual(answer2, output2);
        }
        [TestMethod()]
        public void Task_1_11Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, 2, 3.1, -0.7 };
            double[] input2 = new double[] { 2, 1, 3, 3, 5, 6, 0, 1, 2, 3 };
            double[] answer1 = new double[] { 1.5, 1, 3, 2, 2, 3.1 };
            double[] answer2 = new double[] { 2, 1, 3, 3, 5, 6, 1, 2, 3 };
            // Act
            input1 = main.Task_1_11(input1);
            input2 = main.Task_1_11(input2);
            // Assert
            for (int i = 0; i < answer1.Length; i++)
            {
                Assert.AreEqual(answer1[i], input1[i]);
            }
            for (int i = 0; i < answer2.Length; i++)
            {
                Assert.AreEqual(answer2[i], input2[i]);
            }
        }
        [TestMethod()]
        public void Task_1_12Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, -1 };
            double[] input2 = new double[] { 2, 1, 3, 3, 5, 6, 3, 4 };
            double val1, val2, answer1 = -1, answer2 = 0;
            int idx1, idx2, answerIdx1 = 7, answerIdx2 = -1;
            // Act
            (val1, idx1) = main.Task_1_12(input1);
            (val2, idx2) = main.Task_1_12(input2);
            // Assert
            Assert.AreEqual(answer1, val1);
            Assert.AreEqual(answer2, val2);
            Assert.AreEqual(answerIdx1, idx1);
            Assert.AreEqual(answerIdx2, idx2);
        }
        [TestMethod()]
        public void Task_1_13Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, -1.9, 3.9, -0.1 };
            double[] input2 = new double[] { 2, 1, 3, 3, 5, 6, 0, 2, 7, 1 };
            double[] answerE1 = new double[] { 0, 1, -2.2, 2, 3.9 };
            double[] answerO1 = new double[] { 1.5, 3, -0.5, -1.9, -0.1 };
            double[] answerE2 = new double[] { 2, 3, 5, 0, 7 };
            double[] answerO2 = new double[] { 1, 3, 6, 2, 1 };
            double[] outputE1, outputO1, outputE2, outputO2;
            // Act
            (outputE1, outputO1) = main.Task_1_13(input1);
            (outputE2, outputO2) = main.Task_1_13(input2);
            // Assert
            for (int i = 0; i < answerE1.Length; i++)
            {
                Assert.AreEqual(answerE1[i], outputE1[i]);
                Assert.AreEqual(answerO1[i], outputO1[i]);
                Assert.AreEqual(answerE2[i], outputE2[i]);
                Assert.AreEqual(answerO2[i], outputO2[i]);
            }
        }
        [TestMethod()]
        public void Task_1_14Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, -1, 2, 2.5, -1.4 };
            double[] input2 = new double[] { 2, 5, 3, 0, 7, 9, 1, 4, 6, 10, 8 };
            double[] input3 = new double[] { -2, 5, 3, 0, 7, 9, 1, 4, 6, 10, 8 };
            double output1, output2, output3, answer1 = 12.25, answer2 = 385, answer3 = 0;
            // Act
            output1 = main.Task_1_14(input1);
            output2 = main.Task_1_14(input2);
            output3 = main.Task_1_14(input3);
            // Assert
            Assert.AreEqual(answer1, output1);
            Assert.AreEqual(answer2, output2);
            Assert.AreEqual(answer3, output3);
        }
        [TestMethod()]
        public void Task_1_15Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, 2, 3.1, -0.7 };
            double[] input2 = new double[] { 2, 1, 3, 3, 5, 6, 0, 1, 2, 3 };
            double[] answer1 = new double[] { double.NaN, 0.20, 0, 0.55, double.NaN, double.NaN, 0.35, 0.35, 0.57 };
            double[] answer2 = new double[] { 0.35, 0, 0.55, 0.55, 0.8, 0.9, double.NaN, 0, 0.35 };
            // Act
            input1 = main.Task_1_15(input1);
            input2 = main.Task_1_15(input2);
            // Assert
            for (int i = 0; i < answer1.Length; i++)
            {
                Assert.AreEqual(answer1[i], input1[i]);
                Assert.AreEqual(answer2[i], input2[i]);
            }
        }

        [TestMethod()]
        public void Task_2_1Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 };
            double[] input2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 };
            double[] answer1 = new double[] { 0, 1.5, 1, 3, -4.4, -0.5, 2 };
            double[] answer2 = new double[] { 5, 2, 8, 2, 9, 3, 7, 4, 6, 10 };
            // Act
            input1 = main.Task_2_1(input1);
            input2 = main.Task_2_1(input2);
            // Assert
            for (int i = 0; i < answer1.Length; i++)
            {
                Assert.AreEqual(answer1[i], input1[i]);
                Assert.AreEqual(answer2[i], input2[i]);
            }
        }
        [TestMethod()]
        public void Task_2_2Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, -1 };
            double[] input2 = new double[] { 2, 1, 3, 3, 5, 6, 3, 4 };
            double[] input3 = new double[] { 12, 1, 3, 3, 5, 6, 3, 4 };
            double output1, output2, output3, answer1 = 2.5, answer2 = 14, answer3 = 0;
            // Act
            output1 = main.Task_2_2(input1);
            output2 = main.Task_2_2(input2);
            output3 = main.Task_2_2(input3);
            // Assert
            Assert.AreEqual(answer1, output1);
            Assert.AreEqual(answer2, output2);
            Assert.AreEqual(answer3, output3);
        }
        [TestMethod()]
        public void Task_2_3Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, -1, 3, -2.2, -0.5, 2 };
            double[] input2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 };
            double[] answer1 = new double[] { 0, 3, -0.5, 6, -2.2, -0.5, 2 };
            double[] answer2 = new double[] { 10, 4, 16, 1, 9, 3, 7, 4, 6, 10 };
            // Act
            input1 = main.Task_2_3(input1);
            input2 = main.Task_2_3(input2);
            // Assert
            for (int i = 0; i < answer1.Length; i++)
            {
                Assert.AreEqual(answer1[i], input1[i]);
                Assert.AreEqual(answer2[i], input2[i]);
            }
        }
        [TestMethod()]
        public void Task_2_4Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, -1, 3, -2.2, -0.5, 2 };
            double[] input2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 0 };
            double[] input3 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 };
            double[] answer1 = new double[] { 0, 1.5, -1, 3, 0.4, 0.4, 0.4 };
            double[] answer2 = new double[] { 5, 2, 8, 1, 9, 4.5, 4.5, 4.5, 4.5, 4.5 };
            double[] answer3 = default(double[]);
            // Act
            input1 = main.Task_2_4(input1);
            input2 = main.Task_2_4(input2);
            // Assert
            for (int i = 0; i < answer1.Length; i++)
            {
                Assert.AreEqual(answer1[i], input1[i]);
                Assert.AreEqual(answer2[i], input2[i]);
            }
        }
        [TestMethod()]
        public void Task_2_5Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, -1, -3, -2.2, -0.5, 6 };
            double[] input2 = new double[] { 5, 2, -8, 1, 9, 3, 7, 4, 6 };
            double[] input3 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 };
            double[] answer1 = new double[] { -2.2, -0.5 };
            double[] answer2 = new double[0];
            double[] answer3 = new double[0];
            // Act
            input1 = main.Task_2_5(input1);
            input2 = main.Task_2_5(input2);
            input3 = main.Task_2_5(input3);
            // Assert
            for (int i = 0; i < answer1.Length; i++)
            {
                Assert.AreEqual(answer1[i], input1[i]);
            }
            for (int i = 0; i < answer2.Length; i++)
            {
                Assert.AreEqual(answer2[i], input2[i]);
                Assert.AreEqual(answer3[i], input3[i]);
            }
        }

        [TestMethod()]
        public void Task_2_6Test()
        {// Arrange
            double[] input1 = new double[] { 0, 1.5, -1, -3, -2.2, -0.5, 6 };
            double[] input2 = new double[] { 5, 2, -8, 1, 9, 3, 7, 4, 6 };
            double[] output1, output2, output3, output4;
            double P1 = 2.3, P2 = -0.1;
            double[] answer1 = new double[] { 0, P1, 1.5, -1, -3, -2.2, -0.5, 6 };
            double[] answer2 = new double[] { 0, P2, 1.5, -1, -3, -2.2, -0.5, 6 };
            double[] answer3 = new double[] { 5, 2, -8, 1, 9, 3, P1, 7, 4, 6 };
            double[] answer4 = new double[] { 5, 2, -8, 1, 9, 3, P2, 7, 4, 6 };
            // Act
            output1 = main.Task_2_6(input1, P1);
            output2 = main.Task_2_6(input1, P2);
            output3 = main.Task_2_6(input2, P1);
            output4 = main.Task_2_6(input2, P2);
            // Assert
            for (int i = 0; i < answer1.Length; i++)
            {
                Assert.AreEqual(answer1[i], output1[i]);
                Assert.AreEqual(answer2[i], output2[i]);
                Assert.AreEqual(answer3[i], output3[i]);
                Assert.AreEqual(answer4[i], output4[i]);
            }
        }

        [TestMethod()]
        public void Task_2_7Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 };
            double[] input2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 };
            double[] input3 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 2 };
            double[] answer1 = new double[] { 0, 1.5, 1, 3, -1.1, -0.5, 2 };
            double[] answer2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 };
            double[] answer3 = new double[] { 5, 2, 8, 1, 9, 6, 7, 4, 6, 2 };
            // Act
            input1 = main.Task_2_7(input1);
            input2 = main.Task_2_7(input2);
            input3 = main.Task_2_7(input3);
            // Assert
            for (int i = 0; i < answer1.Length; i++)
            {
                Assert.AreEqual(answer1[i], input1[i]);
                Assert.AreEqual(answer2[i], input2[i]);
                Assert.AreEqual(answer3[i], input3[i]);
            }
        }
        [TestMethod()]
        public void Task_2_8Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 };
            double[] input2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 };
            double[] input3 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 2 };
            double[] answer1 = new double[] { 0, 1.5, 1, -2.2, 3, -0.5, 2 };
            double[] answer2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 };
            double[] answer3 = new double[] { 5, 2, 8, 1, 2, 3, 7, 4, 6, 9 };
            // Act
            input1 = main.Task_2_8(input1);
            input2 = main.Task_2_8(input2);
            input3 = main.Task_2_8(input3);
            // Assert
            for (int i = 0; i < answer1.Length; i++)
            {
                Assert.AreEqual(answer1[i], input1[i]);
                Assert.AreEqual(answer2[i], input2[i]);
                Assert.AreEqual(answer3[i], input3[i]);
            }
        }
        [TestMethod()]
        public void Task_2_9Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 4, 3, -2.2, -0.5, 2, -3.1 };
            double[] input2 = new double[] { 2, 1, 3, 3, 5, 6, 3, 4 };
            double[] input3 = new double[] { 12, 1, 3, 3, 5, 6, 3, 4 };
            double output1, output2, output3, answer1 = 0.57, answer2 = 3.67, answer3 = 0;
            // Act
            output1 = main.Task_2_9(input1);
            output2 = main.Task_2_9(input2);
            output3 = main.Task_2_9(input3);
            // Assert
            Assert.AreEqual(answer1, output1);
            Assert.AreEqual(answer2, output2);
            Assert.AreEqual(answer3, output3);
        }
        [TestMethod()]
        public void Task_2_10Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 };
            double[] input2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 };
            double[] input3 = new double[] { -5, -2, -8, -1, -9, -3, -7, -4, -6, -2 };
            double[] answer1 = new double[] { 0, 1.5, 3, -2.2, -0.5, 2 };
            double[] answer2 = new double[] { 5, 2, 8, 9, 3, 7, 4, 6, 10 };
            double[] answer3 = new double[] { -5, -2, -8, -1, -9, -3, -7, -4, -6, -2 };
            // Act
            input1 = main.Task_2_10(input1);
            input2 = main.Task_2_10(input2);
            input3 = main.Task_2_10(input3);
            // Assert
            for (int i = 0; i < answer1.Length; i++)
            {
                Assert.AreEqual(answer1[i], input1[i]);
                Assert.AreEqual(answer2[i], input2[i]);
            }
            for (int i = 0; i < answer3.Length; i++)
            {
                Assert.AreEqual(answer3[i], input3[i]);
            }
        }
        [TestMethod()]
        public void Task_2_11Test()
        {
            // Arrange
            double P = 7.77;
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 };
            double[] input2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 };
            double[] input3 = new double[] { -5, -2, -8, -1, -9, -3, -7, -4, -6, -2 };
            double[] answer1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, P };
            double[] answer2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10, P };
            double[] answer3 = new double[] { -5, -2, -8, -1, -9, -3, -7, -4, -6, -2 };
            // Act
            input1 = main.Task_2_11(input1, P);
            input2 = main.Task_2_11(input2, P);
            input3 = main.Task_2_11(input3, P);
            // Assert
            for (int i = 0; i < answer1.Length; i++)
            {
                Assert.AreEqual(answer1[i], input1[i]);
                Assert.AreEqual(answer2[i], input2[i]);
            }
            for (int i = 0; i < answer3.Length; i++)
            {
                Assert.AreEqual(answer3[i], input3[i]);
            }
        }
        [TestMethod()]
        public void Task_2_12Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 };
            double[] input2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 };
            double[] input3 = new double[] { -5, -2, -8, -1, -9, -3, -7, -4, -6, -2 };
            double[] answer1 = new double[] { 0, 1.5, 1, 3, -0.7, -0.5, 2 };
            double[] answer2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 };
            double[] answer3 = new double[] { -31, -2, -8, -1, -9, -3, -7, -4, -6, -2 };
            // Act
            input1 = main.Task_2_12(input1);
            input2 = main.Task_2_12(input2);
            input3 = main.Task_2_12(input3);
            // Assert
            for (int i = 0; i < answer1.Length; i++)
            {
                Assert.AreEqual(answer1[i], input1[i]);
                Assert.AreEqual(answer2[i], input2[i]);
                Assert.AreEqual(answer3[i], input3[i]);
            }
        }
        [TestMethod()]
        public void Task_2_13Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 };
            double[] input2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 };
            double[] input3 = new double[] { -5, -2, -8, -1, -9, -3, -7, -4, -6, -2 };
            double[] answer1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 6 };
            double[] answer2 = new double[] { 5, 2, 8, 1, 4, 3, 7, 4, 6, 10 };
            double[] answer3 = new double[] { 0, -2, -8, -1, -9, -3, -7, -4, -6, -2 };
            // Act
            input1 = main.Task_2_13(input1);
            input2 = main.Task_2_13(input2);
            input3 = main.Task_2_13(input3);
            // Assert
            for (int i = 0; i < answer1.Length; i++)
            {
                Assert.AreEqual(answer1[i], input1[i]);
                Assert.AreEqual(answer2[i], input2[i]);
                Assert.AreEqual(answer3[i], input3[i]);
            }
        }
        [TestMethod()]
        public void Task_2_14Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 };
            double[] input2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 };
            double[] input3 = new double[] { -5, -2, -8, -1, -9, -3, -7, -4, -6, -2 };
            double[] answer1 = new double[] { 0, 1.5, 1, -2.2, 3, -0.5, 2 };
            double[] answer2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 10, 6, 4 };
            double[] answer3 = new double[] { -1, -2, -8, -5, -9, -3, -7, -4, -6, -2 };
            // Act
            input1 = main.Task_2_14(input1);
            input2 = main.Task_2_14(input2);
            input3 = main.Task_2_14(input3);
            // Assert
            for (int i = 0; i < answer1.Length; i++)
            {
                Assert.AreEqual(answer1[i], input1[i]);
                Assert.AreEqual(answer2[i], input2[i]);
                Assert.AreEqual(answer3[i], input3[i]);
            }
        }
        [TestMethod()]
        public void Task_2_15Test()
        {
            // Arrange
            int k1 = 1, k2 = 7;
            double[] A1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 };
            double[] B1 = new double[] { 5, 2, 8, 1, 9, 10 };
            double[] A2 = new double[] { -5, -2, -8, -1, -6, -2 };
            double[] B2 = new double[] { 5, 2, 8, 1, 9, 10 };
            double[] answer1 = new double[] { 0, 1.5, 5, 2, 8, 1, 9, 10, 1, 3, -2.2, -0.5, 2 };
            double[] answer2 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 };
            double[] answer3 = new double[] { -5, -2, 5, 2, 8, 1, 9, 10, -8, -1, -6, -2 };
            double[] answer4 = new double[] { -5, -2, -8, -1, -6, -2 };
            double[] output1, output2, output3, output4;
            // Act
            output1 = main.Task_2_15(A1, B1, k1);
            output2 = main.Task_2_15(A1, B1, k2);
            output3 = main.Task_2_15(A2, B2, k1);
            output4 = main.Task_2_15(A2, B2, k2);
            // Assert
            for (int i = 0; i < answer1.Length; i++)
            {
                Assert.AreEqual(answer1[i], output1[i]);
            }
            for (int i = 0; i < answer2.Length; i++)
            {
                Assert.AreEqual(answer2[i], output2[i]);
            }
            for (int i = 0; i < answer3.Length; i++)
            {
                Assert.AreEqual(answer3[i], output3[i]);
            }
            for (int i = 0; i < answer4.Length; i++)
            {
                Assert.AreEqual(answer4[i], output4[i]);
            }
        }
        [TestMethod()]
        public void Task_2_16Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 };
            double[] input2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 };
            double[] input3 = new double[] { -5, -2, -8, -1, -9, -3, -7, -4, -6, -2 };
            int[] answer1 = new int[] { 0, 4, 5 };
            int[] answer2 = new int[] { 0, 1, 3, 5, 7 };
            int[] answer3 = new int[] { 0, 2, 4, 6, 8 };
            int[] output1, output2, output3;
            // Act
            output1 = main.Task_2_16(input1);
            output2 = main.Task_2_16(input2);
            output3 = main.Task_2_16(input3);
            // Assert
            for (int i = 0; i < output1.Length; i++)
            {
                Assert.AreEqual(answer1[i], output1[i]);
            }
            for (int i = 0; i < output2.Length; i++)
            {
                Assert.AreEqual(answer2[i], output2[i]);
            }
            for (int i = 0; i < output3.Length; i++)
            {
                Assert.AreEqual(answer3[i], output3[i]);
            }
        }
        [TestMethod()]
        public void Task_2_17Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 4, 3, -2.2, -0.5, 2, -3.1 };
            double[] input2 = new double[] { 2, 1, 3, 3, 5, 6, 3, 4 };
            double[] input3 = new double[] { 12, 1, 3, 3, 5, 6, 3, 4 };
            double output1, output2, output3, answer1 = 2.62, answer2 = 0, answer3 = 4.62;
            // Act
            output1 = main.Task_2_17(input1);
            output2 = main.Task_2_17(input2);
            output3 = main.Task_2_17(input3);
            // Assert
            Assert.AreEqual(answer1, output1);
            Assert.AreEqual(answer2, output2);
            Assert.AreEqual(answer3, output3);
        }
        [TestMethod()]
        public void Task_2_18Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 };
            double[] input2 = new double[] { 15, 2, 8, 1, 9, 3, 7, 4, 6, 10 };
            double[] input3 = new double[] { -5, -2, -8, -3, -9, -3, -7, -4, -6, -4 };
            double[] answer1 = new double[] { 0, 1.5, 1, 0, 0, 0, 0 };
            double[] answer2 = new double[] { 0, 0, 0, 0, 0, 3, 7, 4, 6, 10 };
            double[] answer3 = new double[] { -5, -2, -8, -3, -9, 0, 0, 0, 0, 0 };
            // Act
            input1 = main.Task_2_18(input1);
            input2 = main.Task_2_18(input2);
            input3 = main.Task_2_18(input3);
            // Assert
            for (int i = 0; i < answer1.Length; i++)
            {
                Assert.AreEqual(answer1[i], input1[i]);
            }
            for (int i = 0; i < answer2.Length; i++)
            {
                Assert.AreEqual(answer2[i], input2[i]);
                Assert.AreEqual(answer3[i], input3[i]);
            }
        }
        [TestMethod()]
        public void Task_2_19Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 };
            double[] input2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 };
            double[] input3 = new double[] { -5, -2, -8, -1, -9, -3, -7, -4, -6, -2 };
            double[] answer1 = new double[] { 0, 1.5, 1, 6, -2.2, -0.5, 2 };
            double[] answer2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 20 };
            double[] answer3 = new double[] { -5, -2, -8, 0, -9, -3, -7, -4, -6, -2 };
            // Act
            input1 = main.Task_2_19(input1);
            input2 = main.Task_2_19(input2);
            input3 = main.Task_2_19(input3);
            // Assert
            for (int i = 0; i < answer1.Length; i++)
            {
                Assert.AreEqual(answer1[i], input1[i]);
            }
            for (int i = 0; i < answer2.Length; i++)
            {
                Assert.AreEqual(answer2[i], input2[i]);
                Assert.AreEqual(answer3[i], input3[i]);
            }
        }
        [TestMethod()]
        public void Task_2_20Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 4, 3, -2.2, -0.5, 2, -3.1 };
            double[] input2 = new double[] { 2, 1, 3, 3, 5, 6, 3, 4 };
            double[] input3 = new double[] { 12, 1, 3, 3, 5, 6, 3, -4 };
            double output1, output2, output3, answer1 = 3.8, answer2 = 0, answer3 = 6;
            // Act
            output1 = main.Task_2_20(input1);
            output2 = main.Task_2_20(input2);
            output3 = main.Task_2_20(input3);
            // Assert
            Assert.AreEqual(answer1, output1);
            Assert.AreEqual(answer2, output2);
            Assert.AreEqual(answer3, output3);
        }
        [TestMethod()]
        public void Task_3_1Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 };
            double[] input2 = new double[] { 5, 2, 8, 10, 9, 3, 7, 4, 10, 10 };
            double[] input3 = new double[] { -1, -2, -8, -1, -9, -1, -1, -4, -6, -2 };
            int[] answer1 = new int[] { 3, 6 };
            int[] answer2 = new int[] { 3, 8, 9 };
            int[] answer3 = new int[] { 0, 3, 5, 6 };
            int[] output1, output2, output3;
            // Act
            output1 = main.Task_3_1(input1);
            output2 = main.Task_3_1(input2);
            output3 = main.Task_3_1(input3);
            // Assert
            for (int i = 0; i < output1.Length; i++)
            {
                Assert.AreEqual(answer1[i], output1[i]);
            }
            for (int i = 0; i < output2.Length; i++)
            {
                Assert.AreEqual(answer2[i], output2[i]);
            }
            for (int i = 0; i < output3.Length; i++)
            {
                Assert.AreEqual(answer3[i], output3[i]);
            }
        }
        [TestMethod()]
        public void Task_3_2Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 };
            double[] input2 = new double[] { 5, 2, 8, 10, 9, 3, 7, 4, 10, 10 };
            double[] input3 = new double[] { -1, -2, -8, -1, -9, -1, -1, -4, -6, -2 };
            double[] answer1 = new double[] { 0, 1.5, 1, 4, -2.2, -0.5, 5 };
            double[] answer2 = new double[] { 5, 2, 8, 11, 9, 3, 7, 4, 12, 13 };
            double[] answer3 = new double[] { 0, -2, -8, 1, -9, 2, 3, -4, -6, -2 };
            double[] output1, output2, output3;
            // Act
            output1 = main.Task_3_2(input1);
            output2 = main.Task_3_2(input2);
            output3 = main.Task_3_2(input3);
            // Assert
            for (int i = 0; i < output1.Length; i++)
            {
                Assert.AreEqual(answer1[i], output1[i]);
            }
            for (int i = 0; i < output2.Length; i++)
            {
                Assert.AreEqual(answer2[i], output2[i]);
            }
            for (int i = 0; i < output3.Length; i++)
            {
                Assert.AreEqual(answer3[i], output3[i]);
            }
        }
        [TestMethod()]
        public void Task_3_3Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 };
            double[] input2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 10, 10 };
            double[] input3 = new double[] { -1, -2, -8, -1, -9, -1, -1, -4, -6, -2 };
            double[] answer1 = new double[] { 1.5, 0, 1, 3, -2.2, -0.5, 3 };
            double[] answer2 = new double[] { 2, 5, 1, 8, 3, 9, 4, 7, 10, 10 };
            double[] answer3 = new double[] { -1, -2, -8, -1, -9, -1, -1, -4, -6, -2 };
            double[] output1, output2, output3;
            // Act
            output1 = main.Task_3_3(input1);
            output2 = main.Task_3_3(input2);
            output3 = main.Task_3_3(input3);
            // Assert
            for (int i = 0; i < output1.Length; i++)
            {
                Assert.AreEqual(answer1[i], output1[i]);
            }
            for (int i = 0; i < output2.Length; i++)
            {
                Assert.AreEqual(answer2[i], output2[i]);
            }
            for (int i = 0; i < output3.Length; i++)
            {
                Assert.AreEqual(answer3[i], output3[i]);
            }
        }
        [TestMethod()]
        public void Task_3_4Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 };
            double[] input2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 10, 10 };
            double[] input3 = new double[] { -1, -2, -8, -1, -9, -1, -1, -4, -6, -2 };
            double[] answer1 = new double[] { 0, 1.5, 1, 2.5, -2.2, -0.5, 2.8 };
            double[] answer2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 39, 49 };
            double[] answer3 = new double[] { 0, -2, -8, -11, -9, -21, -22, -4, -6, -2 };
            double[] output1, output2, output3;
            // Act
            output1 = main.Task_3_4(input1);
            output2 = main.Task_3_4(input2);
            output3 = main.Task_3_4(input3);
            // Assert
            for (int i = 0; i < output1.Length; i++)
            {
                Assert.AreEqual(answer1[i], output1[i]);
            }
            for (int i = 0; i < output2.Length; i++)
            {
                Assert.AreEqual(answer2[i], output2[i]);
            }
            for (int i = 0; i < output3.Length; i++)
            {
                Assert.AreEqual(answer3[i], output3[i]);
            }
        }
        [TestMethod()]
        public void Task_3_5Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 };
            double[] input2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 10, 10 };
            double[] input3 = new double[] { -1, -2, -8, -1, -9, -1, -1, -4, -6, -2 };
            double[] answer1 = new double[] { -2.2, 1.5, 0, 3, 1, -0.5, 3 };
            double[] answer2 = new double[] { 5, 2, 7, 1, 8, 3, 9, 4, 10, 10 };
            double[] answer3 = new double[] { -9, -2, -8, -1, -6, -1, -1, -4, -1, -2 };
            double[] output1, output2, output3;
            // Act
            output1 = main.Task_3_5(input1);
            output2 = main.Task_3_5(input2);
            output3 = main.Task_3_5(input3);
            // Assert
            for (int i = 0; i < output1.Length; i++)
            {
                Assert.AreEqual(answer1[i], output1[i]);
            }
            for (int i = 0; i < output2.Length; i++)
            {
                Assert.AreEqual(answer2[i], output2[i]);
            }
            for (int i = 0; i < output3.Length; i++)
            {
                Assert.AreEqual(answer3[i], output3[i]);
            }
        }
        [TestMethod()]
        public void Task_3_6Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, -1.3, -2.2, -0.5, 2 };
            double[] input2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 };
            double[] input3 = new double[] { -5, -2, -8, -1, -9, -3, -2, -4, -6, -2 };
            int answer1 = 4, answer2 = 2, answer3 = 3;
            int output1, output2, output3;
            // Act
            output1 = main.Task_3_6(input1);
            output2 = main.Task_3_6(input2);
            output3 = main.Task_3_6(input3);
            // Assert
            Assert.AreEqual(answer1, output1);
            Assert.AreEqual(answer2, output2);
            Assert.AreEqual(answer3, output3);
        }
        [TestMethod()]
        public void Task_3_7Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 };
            double[] input2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 10, 10 };
            double[] input3 = new double[] { -1, -2, -8, -1, -9, -1, -1, -4, -6, -2 };
            double[] answer1 = new double[] { 0, 1.5, 1, 3, 3, -2.2, -0.5 };
            double[] answer2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 10, 10 };
            double[] answer3 = new double[] { -1, -2, -8, -1, -9, -1, -1, -4, -6, -2 };
            double[] output1, output2, output3;
            // Act
            output1 = main.Task_3_7(input1);
            output2 = main.Task_3_7(input2);
            output3 = main.Task_3_7(input3);
            // Assert
            for (int i = 0; i < output1.Length; i++)
            {
                Assert.AreEqual(answer1[i], output1[i]);
            }
            for (int i = 0; i < output2.Length; i++)
            {
                Assert.AreEqual(answer2[i], output2[i]);
            }
            for (int i = 0; i < output3.Length; i++)
            {
                Assert.AreEqual(answer3[i], output3[i]);
            }
        }
        [TestMethod()]
        public void Task_3_8Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 };
            double[] input2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 10, 10 };
            double[] input3 = new double[] { -1, -2, -8, -1, -9, -1, -1, -4, -6, -2 };
            double[] answer1 = new double[] { 0, 1.5, 1, 3, -0.5, -2.2, 3 };
            double[] answer2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 10, 10 };
            double[] answer3 = new double[] { -1, -1, -1, -1, -2, -2, -4, -6, -8, -9 };
            double[] output1, output2, output3;
            // Act
            output1 = main.Task_3_8(input1);
            output2 = main.Task_3_8(input2);
            output3 = main.Task_3_8(input3);
            // Assert
            for (int i = 0; i < output1.Length; i++)
            {
                Assert.AreEqual(answer1[i], output1[i]);
            }
            for (int i = 0; i < output2.Length; i++)
            {
                Assert.AreEqual(answer2[i], output2[i]);
            }
            for (int i = 0; i < output3.Length; i++)
            {
                Assert.AreEqual(answer3[i], output3[i]);
            }
        }
        [TestMethod()]
        public void Task_3_9Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, -1.3, -2.2, -0.5, 2 };
            double[] input2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 };
            double[] input3 = new double[] { -5, -2, -8, -1, -9, -3, -2, -4, -6, -2 };
            int answer1 = 4, answer2 = 3, answer3 = 3;
            int output1, output2, output3;
            // Act
            output1 = main.Task_3_9(input1);
            output2 = main.Task_3_9(input2);
            output3 = main.Task_3_9(input3);
            // Assert
            Assert.AreEqual(answer1, output1);
            Assert.AreEqual(answer2, output2);
            Assert.AreEqual(answer3, output3);
        }
        [TestMethod()]
        public void Task_3_10Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, 0, 0, 0, 0 };
            double[] input2 = new double[] { 5, 2, 8, 1, 9, 0, 0, 0, 0, 0 };
            double[] input3 = new double[] { -1, -2, -8, -1, -9, 0, 0, 0, 0, 0 };
            double[] answer1 = new double[] { 0, 0, 1.5, 1.5, 1, 1, 3, 3 };
            double[] answer2 = new double[] { 5, 5, 2, 2, 8, 8, 1, 1, 9, 9};
            double[] answer3 = new double[] { -1, -1, -2, -2, -8, -8, -1, -1, -9, -9 };
            double[] output1, output2, output3;
            // Act
            output1 = main.Task_3_10(input1);
            output2 = main.Task_3_10(input2);
            output3 = main.Task_3_10(input3);
            // Assert
            for (int i = 0; i < output1.Length; i++)
            {
                Assert.AreEqual(answer1[i], output1[i]);
            }
            for (int i = 0; i < output2.Length; i++)
            {
                Assert.AreEqual(answer2[i], output2[i]);
            }
            for (int i = 0; i < output3.Length; i++)
            {
                Assert.AreEqual(answer3[i], output3[i]);
            }
        }
        [TestMethod()]
        public void Task_3_11Test()
        {
            // Arrange
            double a1 = 1.5, a2 = -2.5, b1 = 3, b2 = 2.5, max1, min1, max2, min2;
            int n1 = 4, n2 = 9;
            double[] x1, x2, y1, y2;
            double[] answer1 = new double[] { 1.5, 2, 2.5, 3 };
            double[] answer2 = new double[] { 1.57, 1.40, 0.7, -0.57};
            double[] answer3 = new double[] { -2.5, -1.88, -1.25, -0.62, 0, 0.62, 1.25, 1.88, 2.5 };
            double[] answer4 = new double[] { 0.7, 1.49, 1.50, 1.18, 1, 1.18, 1.50, 1.49, 0.7};
            double answer5 = 1.57, answer6 = -0.57, answer7 = 1.50, answer8 = 0.7;
            // Act
            (x1, y1, max1, min1) = main.Task_3_11(a1, b1, n1);
            (x2, y2, max2, min2) = main.Task_3_11(a2, b2, n2);
            // Assert
            for (int i = 0; i < x1.Length; i++)
            {
                Assert.AreEqual(answer1[i], x1[i]);
                Assert.AreEqual(answer2[i], y1[i]);
            }
            for (int i = 0; i < x2.Length; i++)
            {
                Assert.AreEqual(answer3[i], x2[i]);
                Assert.AreEqual(answer4[i], y2[i]);
            }
            Assert.AreEqual(answer5, max1);
            Assert.AreEqual(answer6, min1);
            Assert.AreEqual(answer7, max2);
            Assert.AreEqual(answer8, min2);

        }
        [TestMethod()]
        public void Task_3_12Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 };
            double[] input2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 10, 10 };
            double[] input3 = new double[] { -1, -2, -8, -1, -9, -1, -1, -4, -6, -2 };
            double[] answer1 = new double[] { 0, 1.5, 1, 3, 3 };
            double[] answer2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 10, 10 };
            double[] answer3 = new double[] { };
            double[] output1, output2, output3;
            // Act
            output1 = main.Task_3_12(input1);
            output2 = main.Task_3_12(input2);
            output3 = main.Task_3_12(input3);
            // Assert
            for (int i = 0; i < output1.Length; i++)
            {
                Assert.AreEqual(answer1[i], output1[i]);
            }
            for (int i = 0; i < output2.Length; i++)
            {
                Assert.AreEqual(answer2[i], output2[i]);
            }
            for (int i = 0; i < output3.Length; i++)
            {
                Assert.AreEqual(answer3[i], output3[i]);
            }
        }
        [TestMethod()]
        public void Task_3_13Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 };
            double[] input2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 10, 10 };
            double[] input3 = new double[] { -1, -4, -8, -1, -9, -1, -1, -4, -2, -8 };
            double[] answer1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5 };
            double[] answer2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 10 };
            double[] answer3 = new double[] { -1, -4, -8, -9, -2 };
            double[] output1, output2, output3;
            // Act
            output1 = main.Task_3_13(input1);
            output2 = main.Task_3_13(input2);
            output3 = main.Task_3_13(input3);
            // Assert
            for (int i = 0; i < output1.Length; i++)
            {
                Assert.AreEqual(answer1[i], output1[i]);
            }
            for (int i = 0; i < output2.Length; i++)
            {
                Assert.AreEqual(answer2[i], output2[i]);
            }
            for (int i = 0; i < output3.Length; i++)
            {
                Assert.AreEqual(answer3[i], output3[i]);
            }
        }
        [TestMethod()]
        public void Task_3_14Test()
        {
            // Arrange
            double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 };
            double[] input2 = new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 10, 10 };
            double[] input3 = new double[] { -1, -2, -8, -1, -9, -1, -1, -4, -6, -2 };
            double[] answer1 = new double[] { -0.15, 0.42, 0.23, 1, -1, -0.35, 1 };
            double[] answer2 = new double[] { -0.11, -0.78, 0.56, -1, 0.78, -0.56, 0.33, -0.33, 1, 1 };
            double[] answer3 = new double[] { 1, 0.75, -0.75, 1, -1, 1, 1, 0.25, -0.25, 0.75};
            double[] output1, output2, output3;
            // Act
            output1 = main.Task_3_14(input1);
            output2 = main.Task_3_14(input2);
            output3 = main.Task_3_14(input3);
            // Assert
            for (int i = 0; i < output1.Length; i++)
            {
                Assert.AreEqual(answer1[i], output1[i]);
            }
            for (int i = 0; i < output2.Length; i++)
            {
                Assert.AreEqual(answer2[i], output2[i]);
            }
            for (int i = 0; i < output3.Length; i++)
            {
                Assert.AreEqual(answer3[i], output3[i]);
            }
        }
    }
}