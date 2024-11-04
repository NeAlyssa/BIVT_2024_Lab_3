using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 };
        program.Task_3_14(input1);
        //program.Task_1_1(new int[] {1, 2, 3, 4, 5, 6});
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double sm = 0;
        for (int i = 0; i < 6; i++)
        {
            sm += array[i];
        }
        if (sm == 0)
            return array;
        for (int i = 0; i < 6; i++)
            array[i] = Math.Round(array[i] / sm, 2);
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        int posCnt = 0;
        double posSum = 0;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                posCnt++;
                posSum += array[i];
            }
        }
        if (posCnt == 0)
        {
            return array;
        }
        double posAvg = posSum / posCnt;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                array[i] = Math.Round(posAvg, 2);
            }
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i < 4; i++)
        {
            sum[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = Math.Round(first[i] - second[i], 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sm = 0;
        for (int i = 0; i < 5; i++)
        {
            sm += array[i];
        }
        double avg = sm / 5;
        for (int i = 0; i < 5; i++)
            array[i] = Math.Round(array[i] - avg, 4);
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < 4; i++)
            product += vector1[i] * vector2[i];
        product = Math.Round(product, 4);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < 5; i++)
            length += vector[i] * vector[i];
        length = Math.Round(Math.Sqrt(length), 2);
        // end

        return length;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sm = 0;
        for (int i = 0; i < 7; i++)
        {
            sm += array[i];
        }
        double avg = sm / 7;
        for (int i = 0; i < 7; i++)
            if (array[i] > avg)
                array[i] = 0;
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        for (int i = 0; i < 6; i++)
            if (array[i] < 0)
                count++;
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double sm = 0;
        for (int i = 0; i < 8; i++)
        {
            sm += array[i];
        }
        double avg = sm / 8;
        for (int i = 0; i < 8; i++)
            if (array[i] > avg)
                count++;
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for (int i = 0; i < 10; i++)
            if (array[i] > P && array[i] < Q)
                count++;
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int posCnt = 0;
        for (int i = 0; i < 10; i++)
            if (array[i] > 0)
                posCnt++;
        output = new double[posCnt];
        int iter = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                output[iter++] = array[i];
            }
        }

        // end

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        // code here
        for (int i = 0; i < 8; i++)
        {
            if (array[i] < 0)
            {
                index = i;
                value = array[i];
            }
        }
        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length / 2];

        // code here
        for (int i = 0; i < 10; i += 2)
        {
            even[i / 2] = array[i];
            odd[i / 2] = array[i + 1];
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i < 11; i++)
        {
            if (array[i] < 0)
                break;
            sum += array[i] * array[i];
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i = 0; i < 10; i++)
        {
            if (x[i] > 0)
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            else
                y[i] = double.NaN;
            Console.WriteLine($"y={y[i]} x={x[i]}");
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        double minElem = double.MaxValue;
        foreach (double iter in array)
            minElem = Math.Min(minElem, iter);
        for (int i = 0; i < array.Length; i++)
            if (array[i] == minElem)
                array[i] = minElem * 2;
        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here

        // end

        return sum;
    }
    public double[] Task_2_3(double[] array)
    {
        // code here
        double minElem = double.MaxValue;
        foreach (double iter in array)
            minElem = Math.Min(minElem, iter);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == minElem)
                break;

            if (array[i] < 0)
                array[i] /= 2;
            else
                array[i] *= 2;
        }
        // end

        return array;
    }
    public double[] Task_2_4(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_5(double[] array)
    {
        // code here
        double maxElem = double.MinValue, minElem = double.MaxValue;
        int minIDx = 0, maxIDx = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxElem)
            {
                maxElem = array[i];
                maxIDx = i;
            }
            if (array[i] < minElem)
            {
                minElem = array[i];
                minIDx = i;
            }
        }
        double[] ansArray = new double[Math.Abs(minIDx - maxIDx) - 1];
        int iter = 0;
        for (int i = Math.Min(minIDx, maxIDx) + 1; i < Math.Max(minIDx, maxIDx); i++)
            ansArray[iter++] = array[i];
        array = ansArray;
        // end

        return array;
    }
    public double[] Task_2_6(double[] array, double P)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_7(double[] array)
    {
        // code here
        double maxElem = double.MinValue;
        int maxIdx = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxElem)
            {
                maxElem = array[i];
                maxIdx = i;
            }
        }
        if (maxIdx == array.Length - 1)
            return array;
        if (array[maxIdx + 1] > 0)
            array[maxIdx + 1] *= 2;
        else
            array[maxIdx + 1] /= 2;
        // end

        return array;
    }
    public double[] Task_2_8(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double Task_2_9(double[] array)
    {
        double average = 0;

        // code here
        double maxElem = double.MinValue, minElem = double.MaxValue;
        int minIDx = 0, maxIDx = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxElem)
            {
                maxElem = array[i];
                maxIDx = i;
            }
            if (array[i] < minElem)
            {
                minElem = array[i];
                minIDx = i;
            }
        }
        int ln = Math.Abs(maxIDx - minIDx) - 1;
        if (ln == 0)
            return average;

        for (int i = Math.Min(minIDx, maxIDx) + 1; i < Math.Max(minIDx, maxIDx); i++)
            average += array[i];
        average = Math.Round(average / ln, 2);
        // end

        return average;
    }
    public double[] Task_2_10(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_11(double[] array, double P)
    {
        // code here
        int lastPosIdx = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                lastPosIdx = i;
        }
        if (lastPosIdx == -1)
            return array;
        double[] answer = new double[array.Length + 1];
        int iter = 0;
        for (int i = 0; i < lastPosIdx + 1; i++)
            answer[iter++] = array[i];
        answer[iter++] = P;
        for (int i = lastPosIdx + 1; i < array.Length; i++)
            answer[iter++] = array[i];
        array = answer;
        foreach (double it in answer)
            Console.Write($"{it} ");
        // end

        return array;
    }
    public double[] Task_2_12(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_13(double[] array)
    {
        // code here
        double maxElem = double.MinValue;
        int maxIDx = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0 && array[i] > maxElem)
            {
                maxElem = array[i];
                maxIDx = i;
            }
        }
        array[maxIDx] = maxIDx;
        // end

        return array;
    }
    public double[] Task_2_14(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_15(double[] A, double[] B, int k)
    {
        double[] output = null;

        // code here
        if (k > A.Length - 1)
            return A;
        output = new double[A.Length + B.Length];
        int iter = 0;
        k++;
        for (int i = 0; i < k; i++)
            output[iter++] = A[i];
        for (int i = 0; i < B.Length; i++)
            output[iter++] = B[i];
        for (int i = k; i < A.Length; i++)
            output[iter++] = A[i];
        for (int i = 0; i < A.Length + B.Length; i++)
            Console.WriteLine(output[i]);
        // end

        return output;
    }
    public int[] Task_2_16(double[] array)
    {
        int[] output = null;

        // code here

        // end

        return output;
    }
    public double Task_2_17(double[] array)
    {
        double average = 0;

        // code here
        double maxElem = double.MinValue, minElem = double.MaxValue;
        int minIDx = 0, maxIDx = 0;
        double posSum = 0, negSum = 0;
        int posCnt = 0, negCnt = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                posSum += array[i];
                posCnt++;
            }
            else if (array[i] < 0)
            {
                negSum += array[i];
                negCnt++;
            }
            if (array[i] > maxElem)
            {
                maxElem = array[i];
                maxIDx = i;
            }
            if (array[i] < minElem)
            {
                minElem = array[i];
                minIDx = i;
            }
        }
        if (maxIDx < minIDx)
        {
            if (posCnt == 0)
                return 0;
            average = posSum / posCnt;
        }
        else
        {
            if (negCnt == 0)
                return 0;
            average = negSum / negCnt;
        }
        average = Math.Round(average, 2);
        // end

        return average;
    }
    public double[] Task_2_18(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_19(double[] array)
    {
        // code here
        double maxElem = double.MinValue, sm = 0;
        int maxIdx = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sm += array[i];
            if (array[i] > maxElem)
            {
                maxElem = array[i];
                maxIdx = i;
            }
        }
        if (maxElem > sm)
        {
            array[maxIdx] = 0;
        }
        else
        {
            array[maxIdx] *= 2;
        }
        // end

        return array;
    }
    public double Task_2_20(double[] array)
    {
        double sum = 0;

        // code here

        // end

        return sum;
    }
    #endregion

    #region Level 3
    public int[] Task_3_1(double[] array)
    {
        int[] output = null;

        // code here

        // end

        return output;
    }
    public double[] Task_3_2(double[] array)
    {
        // code here
        double maxElem = array.Max();
        int add = 1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == maxElem)
                array[i] += add++;
        }
        // end

        return array;
    }
    public double[] Task_3_3(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_3_4(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_3_5(double[] array)
    {
        // code here
        for (int i = 0; i < array.Length - 2; i += 2)
        {
            for (int j = 0; j < array.Length - 2 - i; j += 2)
            {
                if (array[j] > array[j + 2])
                {
                    double temp = array[j];
                    array[j] = array[j + 2];
                    array[j + 2] = temp;
                }
            }
        }
        // end

        return array;
    }
    public int Task_3_6(double[] array)
    {
        int count = 0;

        // code here

        // end

        return count;
    }
    public double[] Task_3_7(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_3_8(double[] array)
    {
        // code here

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < 0 && array[j] > array[i])
                    {
                        double temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        // end

        return array;
    }
    public int Task_3_9(double[] array)
    {
        int count = 0;

        // code here

        // end

        return count;
    }
    public double[] Task_3_10(double[] array)
    {
        // code here

        // end

        return array;
    }
    public (double[], double[], double, double) Task_3_11(double a, double b, int n)
    {
        double[] X = null, Y = null;
        double globalMax = 0, globalMin = 0;

        // code here
        double diff = Math.Abs(b - a) / (n - 1);
        X = new double[n];
        Y = new double[n];
        int iter = 0;
        for (double i = a; i <= b; i += diff)
        {
            X[iter] = Math.Round((double)i, 2);
            Y[iter] = Math.Round(X[iter] * Math.Sin(X[iter]) + Math.Cos(X[iter]), 2);
            iter++;
        }
        globalMax = Y[0];
        globalMin = Y[0];
        for (int i = 1; i < n - 1; i++)
        {
            if (Y[i] > Y[i - 1] && Y[i] > Y[i + 1])
            {
                Console.WriteLine($"Max y={Y[i]} x={X[i]}");
                globalMax = Math.Max(globalMax, Y[i]);
            }
            if (Y[i] < Y[i - 1] && Y[i] < Y[i + 1])
            {
                Console.WriteLine($"Min y={Y[i]} x={X[i]}");
                globalMin = Math.Min(globalMin, Y[i]);
            }
        }
        globalMax = Math.Max(globalMax, Y[n - 1]);
        globalMin = Math.Min(globalMin, Y[n - 1]);
        // end

        return (X, Y, globalMax, globalMin);
    }
    public double[] Task_3_12(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_3_13(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_3_14(double[] array)
    {
        double[] normalizedArray = null;

        // code here
        double maxValue = double.MinValue, minValue = double.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            maxValue = Math.Max(maxValue, array[i]);
            minValue = Math.Min(minValue, array[i]);
        }
        Console.WriteLine(maxValue);
        Console.WriteLine(minValue);
        Console.WriteLine(maxValue - minValue);
        Console.WriteLine((-0.15) * (maxValue - minValue));
        normalizedArray = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            normalizedArray[i] = Math.Round(2 * (array[i] - minValue) / (maxValue - minValue) - 1, 2);
            Console.WriteLine(normalizedArray[i]);
        }
            
        // end

        return normalizedArray;
    }
    #endregion
}