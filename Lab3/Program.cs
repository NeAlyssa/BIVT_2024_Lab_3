using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
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
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] /= sum;
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sum = 0; int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                sum += array[i];
                k++;
            }
        }
        double sr = sum / k;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) array[i] = sr;
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
            sum[i] = first[i] + second[i];
            dif[i] = first[i] - second[i];
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        double sr = sum / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] -= sr;
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
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < vector.Length; i++)
        {
            length += vector[i] * vector[i];
        }
        length = Math.Sqrt(length); ;
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        double sr = sum / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (sr < array[i]) array[i] = 0;
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        double sr = sum / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (sr < array[i]) count++;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < Q && array[i] > P) count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) k++;
        }
        double[] arr = new double[k];
        k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                arr[k] = array[i];
                k++;
            }
        }
        output = arr;
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
            else odd[(i - 1) / 2] = array[i];
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
            if (array[i] >= 0) sum += array[i] * array[i];
            else break;
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
            else y[i] = Math.Log(x[i]) / 2;
            Console.WriteLine($"{x[i]}, {y[i]}");
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        double amax = array[0];
        int imax = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
        }
        for (int i = 0; i < imax; i++)
        {
            sum += array[i];
        }
        // end

        return sum;
    }
    public double[] Task_2_3(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_4(double[] array)
    {
        // code here
        double sum = 0;
        double amax = array[0];
        int imax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
            sum += array[i];
        }
        double sr = sum / array.Length;
        for (int i = imax + 1; i < array.Length; i++)
        {
            array[i] = sr;
        }
        // end

        return array;
    }
    public double[] Task_2_5(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_6(double[] array, double P)
    {
        // code here
        double[] b = new double[array.Length + 1];
        double sum = 0;
        foreach (double x in array)
        {
            sum += x;
        }
        double sr = sum / array.Length;
        double dif = 999999;
        int iii = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - sr) < dif)
            {
                dif = Math.Abs(array[i] - sr);
                iii = i;
            }
        }
        for (int i = 0; i < array.Length + 1; i++)
        {
            if (i <= iii) b[i] = array[i];
            else if (i - 1 == iii) b[i] = P;
            else b[i] = array[i - 1];
        }
        array = b;
        // end

        return array;
    }
    public double[] Task_2_7(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_8(double[] array)
    {
        // code here
        double amax = array[0];
        int imax = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
        }
        double amin = amax;
        int imin = imax;
        for (int i = imax; i < array.Length; i++)
        {
            if (array[i] < amin)
            {
                amin = array[i];
                imin = i;
            }
        }
        var p = array[imin];
        array[imin] = array[imax];
        array[imax] = p;
        // end

        return array;
    }
    public double Task_2_9(double[] array)
    {
        double average = 0;

        // code here

        // end

        return average;
    }
    public double[] Task_2_10(double[] array)
    {
        // code here
        double[] b = new double[array.Length - 1];
        double amin = 9999999;
        int imin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && array[i] < amin)
            {
                amin = array[i];
                imin = i;
            }
        }
        if (amin != 9999999)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i < imin) b[i] = array[i];
                else if (i > imin) b[i - 1] = array[i];
            }
            array = b;
        }

        // end

        return array;
    }
    public double[] Task_2_11(double[] array, double P)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_12(double[] array)
    {
        // code here
        double sum = 0;
        double amax = array[0];
        int imax = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
        }
        if (imax != array.Length - 1)
        {
            for (int i = imax + 1; i < array.Length; i++)
            {
                sum += array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = sum;
                break;
            }
        }
        // end

        return array;
    }
    public double[] Task_2_13(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_14(double[] array)
    {
        // code here
        double amax = array[0];
        int imax = 0, iotr = 100;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                iotr = i;
                break;
            }
        }
        if (iotr != 100)
        {
            var p = array[imax];
            array[imax] = array[iotr];
            array[iotr] = p;
        }
        // end

        return array;
    }
    public double[] Task_2_15(double[] A, double[] B, int k)
    {
        double[] output = null;

        // code here

        // end

        return output;
    }
    public int[] Task_2_16(double[] array)
    {
        int[] output = null;

        // code here
        double sum = 0;
        int count = 0, k = 0;
        foreach (double x in array)
        {
            sum += x;
        }
        double sr = sum / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr) count++;
        }
        output = new int[count];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr) output[i - k] = i;
            else k++;
        }
        // end

        return output;
    }
    public double Task_2_17(double[] array)
    {
        double average = 0;

        // code here

        // end

        return average;
    }
    public double[] Task_2_18(double[] array)
    {
        // code here
        double amaxch = array[0], amaxnech = array[1];
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > amaxch) amaxch = array[i];
        }
        for (int i = 1; i < array.Length; i += 2)
        {
            if (array[i] > amaxnech) amaxnech = array[i];
        }
        if (amaxch > amaxnech)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                array[i] = 0;
            }
        }
        else
        {
            for (int i = array.Length / 2; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }
        // end

        return array;
    }
    public double[] Task_2_19(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double Task_2_20(double[] array)
    {
        double sum = 0;

        // code here
        double amin = array[0];
        int imin = 0, iotr = 100;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < amin)
            {
                amin = array[i];
                imin = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                iotr = i;
                break;
            }
        }
        if (iotr < imin)
        {
            for (int i = 0; i < array.Length; i += 2)
            {
                sum += array[i];
            }
        }
        else
        {
            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }
        }
        // end

        return sum;
    }
    #endregion
    #region Level 3
    public int[] Task_3_1(double[] array)
    {
        int[] output = null;

        // code here
        double amax = array[0];
        int count = 0, k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                count = 1;
            }
            else if (array[i] == amax) count++;
        }
        output = new int[count];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == amax) output[i - k] = i;
            else k++;
        }
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
        double amax = array[0];
        double sum = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > amax) amax = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == amax)
            {
                array[i] = sum;
                sum += amax;
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
        int count = 0, k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0) count++;
        }
        double[] b = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0) b[i - k] = array[i];
            else
            {
                b[count + k] = array[i];
                k++;
            }
        }
        array = b;
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
        double[] b = new double[array.Length];
        for (int i = 0; i < array.Length / 2; i++)
        {
            b[2*i] = array[i];
            b[2*i+1] = array[i];
        }
        array = b;
        // end

        return array;
    }
    public (double[], double[], double, double) Task_3_11(double a, double b, int n)
    {
        double[] X = null, Y = null;
        double globalMax = 0, globalMin = 0;

        // code here
        
        // end

        return (X, Y, globalMax,globalMin);
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
        int k = 0, m = 0;
        for (int i = array.Length - 2; i >=0; i--)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] == array[i])
                {
                    array[j] = 999999;
                    k++;
                }
            }
        }
        double[] b = new double[array.Length - k];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 999999) b[i-m] = array[i];
            else m++;
        }
        array = b;
        // end

        return array;
    }
    public double[] Task_3_14(double[] array)
    {
        double[] normalizedArray = null;

        // code here
        
        normalizedArray = array;
        // end

        return normalizedArray;
    }
    #endregion
}
