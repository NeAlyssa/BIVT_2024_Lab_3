using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        int k1 = 1, k2 = 7;
        double[] A1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 };
        double[] B1 = new double[] { 5, 2, 8, 1, 9, 10 };
        double[] A2 = new double[] { -5, -2, -8, -1, -6, -2 };
        double[] B2 = new double[] { 5, 2, 8, 1, 9, 10 };
        program.Task_2_15(A1, B1, k2);
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double max = 0;
        foreach (double x in array)
        {
            max += x;
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] / max, 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double arf = 0, n = 0;
        foreach (double x in array)
        {
            if (x > 0)
            {
                arf += x;
                n++;
            }
        }
        arf /= n;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = Math.Round(arf, 2);
            }

        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];
        double a, b;
        // code here
        for (int i = 0; i < first.Length; i++)
        {
            a = first[i];
            b = second[i];
            sum[i] = Math.Round(a + b, 4);
            dif[i] = Math.Round(a - b, 4);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double arf = 0, n = 0;
        foreach (double x in array)
        {
            arf += x;
            n++;
        }
        arf /= n;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - arf, 4);


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
            product += Math.Round(vector1[i] * vector2[i], 4);
        }
        // end
        product = Math.Round(product, 4);
        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        foreach (double x in vector)
        {
            length += x * x;
        }
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 2);
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double arf = 0, n = 0;
        foreach (double x in array)
        {
            arf += x;
            n++;
        }
        arf /= n;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > arf)
            {
                array[i] = 0;
            }

        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here

        foreach (double x in array)
        {
            if (x < 0)
            {
                count++;
            }
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double arf = 0, n = 0;
        foreach (double x in array)
        {
            arf += x;
            n++;
        }
        arf /= n;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > arf)
            {
                count++;
            }

        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        foreach (double x in array)
        {
            if (x > P && x < Q)
            {
                count++;
            }
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;
        int n = 0;
        // code here
        foreach (double x in array)
        {
            if (x > 0) n++;

        }

        output = new double[n];
        n = 0;
        foreach (double x in array)
        {
            if (x > 0)
            {
                output[n] = x;
                n++;
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
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                value = array[i];
                index = i;
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
            if (i % 2 == 0)
            {
                even[i / 2] = array[i];

            }
            else
            {
                odd[(i / 2)] = array[i];

            }

        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        foreach (double x in array)
        {
            if (x < 0)
            {
                break;
            }
            sum += x * x;
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
            if (x[i] > 0) y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            else y[i] = double.NaN;
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        double min = Math.Pow(10, 9);
        int ind = 0, i = 0;
        foreach (double x in array)
        {

            if (x < min)
            {
                min = x;
                ind = i;
            }
            i++;
        }
        if (array[ind] < 0)
        {
            array[ind] /= 2;
        }
        else
        {
            array[ind] *= 2;
        }
        // end
        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0, max = -Math.Pow(10, 9);
        int ind = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                ind = i;
            }
        }
        for (int i = 0; i < ind; i++)
        {
            sum += array[i];
        }
        // end

        return sum;
    }
    public double[] Task_2_3(double[] array)
    {
        double min = Math.Pow(10, 9);
        int ind = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                ind = i;
            }
        }
        for (int i = 0; i < ind; i++)
        {
            if (array[i] > 0)
            {
                array[i] *= 2;
            }
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
        double min = Math.Pow(10, 9), max = -Math.Pow(10, 9), t = 0;
        int indmin = 0, indmax = 0, x;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                indmin = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                indmax = i;
            }
        }
        if (indmin > indmax)
        {
            t = indmin;
            indmin = indmax;
            indmax = (int)t;
        }
        int ind = 0;
        for (int i = indmin + 1; i < indmax; i++)
        {
            if (array[i]<0) ind++;
        }
        double[] arr = new double[ind];
        ind = 0;
        for (int i = indmin + 1; i < indmax; i++)
        {
            if (array[i] < 0)
            {
                arr[ind] = array[i];
            }
            ind++;
        }
        // end
        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
        return arr;
    }
    public double[] Task_2_6(double[] array, double P)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_7(double[] array)
    {
        double max = -Math.Pow(10, 9);
        int ind = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                ind = i;
            }
        }
        if (ind + 2 < array.Length)
        {
            if (array[ind + 1] < 0)
            {
                array[ind + 1] /= 2;
            }
            else array[ind + 1] *= 2;
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

        double min = Math.Pow(10, 9), max = -Math.Pow(10, 9), t = 0;
        int indmin = 0, indmax = 0, x;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                indmin = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                indmax = i;
            }
        }
        if (indmin > indmax)
        {
            t = indmin;
            indmin = indmax;
            indmax = (int)t;
        }
        x = indmax - indmin - 1;
        double[] arr = new double[x];
        int ind = 0;
        for (int i = indmin + 1; i < indmax; i++)
        {
            average += array[i];
        }
        average /= x;
        if (x == 0) average = 0;
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
        int ind = -1;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                ind = i;
            }
        }
        Console.WriteLine(ind);
        double[] arr;
        if (ind == -1)
        {
            arr = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = array[i];
                Console.WriteLine(arr[i]);
            }
        }
        else
        {
            arr = new double[array.Length + 1];
            for (int i = 0; i <= ind; i++)
            {
                arr[i] = array[i];
                Console.WriteLine(arr[i]);
            }
            arr[ind + 1] = P;
            Console.WriteLine(arr[ind + 1]);
            for (int i = ind + 2; i < array.Length + 1; i++)
            {
                arr[i] = array[i];
                Console.WriteLine(arr[i]);
            }
        }
        // end
        Console.WriteLine(123);
        return arr;
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
        double max = -Math.Pow(10, 9);
        int ind = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > max)
            {
                max = array[i];
                ind = i;
            }
        }
        array[ind] = ind;
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
        int ind = 0;
        if (A.Length > k)
        {
            output = new double[A.Length + B.Length];
            for (int i = 0; i <= k; i++)
            {
                output[ind] = A[i];
                ind++;
            }
            for (int i = 0; i < B.Length; i++)
            {
                output[ind] = B[i];
                ind++;
            }
            for (int i = k + 1; i < A.Length; i++)
            {
                output[ind] = A[i];
                ind++;
            }
        }
        else
        {
            output = new double[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                output[i] = A[i];
            }
        }
        // end
        for(int i=0;i< output.Length;i++)
            Console.WriteLine(output[i]);
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
        double max = -Math.Pow(10, 9), min = Math.Pow(10, 9);
        int imin = 0, imax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                imax = i;
            }
            if (array[i] < min)
            {
                min = array[i];
                imin = i;
            }
        }
        int n = 0;
        if (imax < imin)
        {
            foreach (double x in array)
            {
                if (x > 0)
                {
                    average += x;
                    n++;
                }
            }
        }
        else
        {
            foreach (double x in array)
            {
                if (x < 0)
                {
                    average += x;
                    n++;
                }
            }

        }
        if (n != 0)
        {
            average /= n;
        }
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
        double sum = 0, max = -Math.Pow(10, 9);
        int imax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            if (array[i] > max)
            {
                max = array[i];
                imax = i;
            }

        }

        if (max > sum) array[imax] = 0;
        else
        {
            if (array[imax] > 0) array[imax] *= 2;
            else array[imax] /= 2;
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

        // end

        return array;
    }
    public double[] Task_3_3(double[] array)
    {
        // code here
        double max = -Math.Pow(10, 9), t;
        int imax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                imax = i;
            }
        }
        for (int i = 0; i < imax - 1; i += 2)
        {
            t = array[i];
            array[i] = array[i + 1];
            array[i + 1] = t;
        }
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

        // end

        return array;
    }
    public int Task_3_6(double[] array)
    {
        int count = 0, start = 0, end = 0;

        // code here
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                end++;
            }
            else
            {

                if (end - start + 1 > count) count = end - start + 1;
                start = i + 1;
                end = start;
            }
        }
        if (end - start + 1 > count) count = end - start + 1;
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

        // end

        return array;
    }
    public int Task_3_9(double[] array)
    {
        int count = 0, start = 0, end = 0;

        // code here
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                end++;
            }
            else
            {

                if (end - start + 1 > count) count = end - start + 1;
                start = i + 1;
                end = start;
            }
        }
        if (end - start + 1 > count) count = end - start + 1;
        start = 0;
        end = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                end++;
            }
            else
            {

                if (end - start + 1 > count) count = end - start + 1;
                start = i + 1;
                end = start;

            }
        }
        if (end - start + 1 > count) count = end - start + 1;
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

        // end

        return (X, Y, globalMax, globalMin);
    }
    public double[] Task_3_12(double[] array)
    {
        // code here
        int n = 0, ind = 0;
        
        foreach (double x in array)
        {
            if (x >= 0) n++;
        }
        double[] ost = new double[n];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                ost[ind] = array[i];
                ind++;

            }
        }
        // end

        return ost;
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