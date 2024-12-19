using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_1(new int[] {1, 2, 3, 4, 5, 6});
        program.Task_1_15(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, 2, 3.1, -0.7 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double sum = 0;
        foreach (double item in array)
        {
            sum += item;
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] / sum, 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sum = 0;
        int count = 0;
        foreach (double item in array)
        {
            if (item > 0)
            {
                sum += item;
                count++;
            }
        }
        sum /= count;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) array[i] = Math.Round(sum, 2);
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i < first.Length; i++)
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
        double sum = 0;
        foreach (double item in array)
        {
            sum += item;
        }
        sum /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - sum, 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < vector1.Length; i++)
        {
            product += vector1[i] * vector2[i];
        }
        product = Math.Round(product, 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        foreach (double item in vector)
        {
            length += item * item;
        }
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 2);
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double avg = 0;
        foreach (double item in array)
        {
            avg += item;
        }
        avg /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > avg) array[i] = 0;
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        foreach (double item in array)
        {
            if (item < 0) count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double avg = 0;
        foreach (double item in array)
        {
            avg += item;
        }
        avg /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > avg) count++;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        foreach (double item in array)
        {
            if (item > P && item < Q) count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int count = 0;
        foreach (double item in array)
        {
            if (item > 0) count++;
        }
        output = new double[count];
        int currentI = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[currentI] = array[i];
                currentI++;
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
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] < 0)
            {
                value = array[i];
                index = i;
                break;
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
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0) even[i / 2] = array[i];
            else odd[i / 2] = array[i];
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) break;
            sum += array[i] * array[i];
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] <= 0) y[i] = double.NaN;
            else y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
        }
        for (int j = 0; j < y.Length; j++)
        {
            Console.Write(x[j]);
            Console.Write(" ");
            Console.Write(y[j]);
            Console.WriteLine();
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        double min = double.MaxValue;
        foreach (double item in array)
        {
            if (item < min) min = item;
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == min) 
            { 
                array[i] = array[i] < 0 ? array[i] / 2 : array[i] * 2; 
            }
        }
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

        double min = double.MaxValue;
        int minIndex = 0;
        for (int i = 0; i < array.Length; i++) if (array[i] < min) { min = array[i]; minIndex = i; }
        for (int i = 0; i < minIndex; i++)
        {
            if (array[i] >= 0) array[i] *= 2;
            else array[i] /= 2;
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
        double min = double.MaxValue, max = double.MinValue;
        int minIndex = 0, maxIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                minIndex = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
        }
        int count = 0, firstIndex = Math.Min(maxIndex, minIndex), lastIndex = Math.Max(maxIndex, minIndex);

        for (int i = firstIndex + 1; i < lastIndex; i++) if (array[i] < 0) count++;
        double[] resultArray = new double[count];
        int currentIndex = 0;
        for (int i = firstIndex + 1; i < lastIndex; i++)
        {
            if (array[i] < 0)
            {
                resultArray[currentIndex] = array[i];
                currentIndex++;
            }
        }
        // end

        return resultArray;
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
        double max = double.MinValue;
        int maxIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
        }
        if (maxIndex + 1 < array.Length)
        {
            if (array[maxIndex + 1] >= 0) array[maxIndex + 1] *= 2;
            else array[maxIndex + 1] /= 2;
        }
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
        double min = double.MaxValue, max = double.MinValue;
        int minIndex = 0, maxIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                minIndex = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
        }
        int firstIndex = Math.Min(maxIndex, minIndex), lastIndex = Math.Max(maxIndex, minIndex);

        for (int i = firstIndex + 1; i < lastIndex; i++) average += array[i];
        if (lastIndex - firstIndex - 1 > 0) average /= (lastIndex - firstIndex - 1);
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
        int index = -1;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] > 0)
            {
                index = i;
                break;
            }
        }
        double[] resultArray = new double[array.Length + 1];
        if (index < 0) resultArray = array;
        else
        {
            for (int i = 0; i <= index; i++)
            {
                resultArray[i] = array[i];
            }
            resultArray[index + 1] = P;
            for (int i = index + 1; i < array.Length; i++)
            {
                resultArray[i + 1] = array[i];
            }
        }
        array = resultArray;
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
        double max = double.MinValue;
        int maxIndex = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
        }
        array[maxIndex] = maxIndex;
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
        double[] output = new double[A.Length + B.Length];
        if (k >= A.Length) return A;
        // code here
        for (int i = 0; i <= k; i++) output[i] = A[i];
        for (int i = 0; i < B.Length; i++) output[k + i + 1] = B[i];
        for (int i = 0; i < A.Length - k - 1; i++) output[k + B.Length + i + 1] = A[k + i + 1];
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
        double min = double.MaxValue, max = double.MinValue, sumOtr = 0, sumPol = 0;
        int minIndex = -1, maxIndex = -1, countOtr = 0, countPol = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                minIndex = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
            if (array[i] > 0)
            {
                sumPol += array[i];
                countPol++;
            }
            else
            {
                sumOtr += array[i];
                countOtr++;
            }
        }
        if (maxIndex < minIndex)
        {
            average = countPol == 0 ? 0 : sumPol / countPol;
        }
        else
        {
            average = countOtr == 0 ? 0 : sumOtr / countOtr;
        }
        average = Math.Round(average, 3);
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
        double max = double.MinValue, sum = 0;
        int maxIndex = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
            sum += array[i];
        }
        if (max > sum)
        {
            array[maxIndex] = 0;
        }
        else
        {
            array[maxIndex] *= 2;
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
        double maxx = double.MinValue;
        int c = 0;
        int[] zv = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxx)
            {
                maxx = array[i];
                c = 0;
                zv = new int[array.Length];
                zv[c] = i;
            }
            else if (array[i] == maxx)
            {
                c++;
                zv[c] = i;
            }
        }
        output = new int[c + 1];
        for (int i = 0; i <= c; i++)
        {
            output[i] = zv[i];
        }

        return output;
        // end

        return output;
    }
    public double[] Task_3_2(double[] array)
    {
        // code here

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
        if (array.Length == 0)
        {
            return array;
        }
        double maxx = double.MinValue;
        foreach (double i in array)
        {
            if (i > maxx) maxx = i;
        }
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == maxx)
            {
                sum += array[i];
                array[i] = sum - array[i];
            }
            else sum += array[i];
        }
        // end

        return array;
    }
    public double[] Task_3_5(double[] array)
    {
        // code here

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
        int pI = 0, nI = 0;
        double[] a = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                a[pI++] = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                a[pI + nI] = array[i];
                nI++;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = a[i];
        }
        // end

        return array;
    }
    public double[] Task_3_8(double[] array)
    {
        // code here

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
        int c = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 0)
            {
                c = i + 1;
            }
        }
        for (int i = c - 1; i >= 0; i--)
        {
            array[2 * i + 1] = array[i];
            array[2 * i] = array[i];
        }
        // end

        return array;
    }
    public (double[], double[], double, double) Task_3_11(double a, double b, int n)
    {
        double[] X = null, Y = null;
        double globalMax = 0, globalMin = 0;

        // code here

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

        // end

        return normalizedArray;
    }
    #endregion
}