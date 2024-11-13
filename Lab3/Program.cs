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
        //program.Task_2_6(new double[] { 5, 2, -8, 1, 9, 3, 7, 4, 6 }, 2.3);
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double s = 0;
        foreach (double item in array)
        {
            s += item;
        }
        for (int i = 0; i < 6; i++)
        {
            array[i] = Math.Round(array[i] / s, 2);
        } 
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0, m = 0;
        foreach (double item in array)
        {
            if (item > 0)
            {
                s += item;
                m++;
            }
        }
        double ans = Math.Round(s/m, 2);
        for (int i = 0; i < 8; i++)
        {   if (array[i] > 0)
            {
                array[i] = ans;
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
        double s = 0, m = 0;
        foreach (double item in array)
        {
            s += item;
            m++;

        }
        for (int i = 0; i < 5; i++)
        {
            array[i] = Math.Round(array[i] - s / m, 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        product = Math.Round(vector1[0] * vector2[0] + vector1[1] * vector2[1] + vector1[2] * vector2[2] + vector1[3] * vector2[3], 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        foreach(double item in vector)
        {
            length += item * item;
        }
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0, m = 0;
        foreach (double item in array)
        {
            s += item;
            m++;
        }
        double ans = s / m;
        for (int i = 0; i < 7; i++)
        {
            if (array[i] > ans)
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
        double s = 0, m = 0;
        foreach (double item in array)
        {
            if (item < 0)
            {
                s += item;
                count++;
            }
        }

        //
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double s = 0, m = 0;
        foreach (double item in array)
        {
            s += item;
            m++;
        }
        double ans = Math.Round(s / m, 2);
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > ans)
            {
                count++;
            }
        }
        //
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        foreach(double item in array)
        {
            if ((item > P) && (item < Q))
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

        // code here
        int m = 0;
        foreach (double item in array)
        {
            if (item > 0) m++;
        }
        output = new double[m];
        m = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0) 
            { 
                output[m] = array[i]; 
                m++;
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

        // end
        int m = 0;
        foreach (double item in array)
        {
            if (item  < 0)
            {
                value = item;
                index= m;
            }
            m++;
        }
        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        // code here
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0) { even[i / 2] = array[i]; }
            else { odd[i / 2] = array[i]; }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        foreach (double item in array)
        {
            if (item < 0) { break; }
            sum += item * item;
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i = 0; i < 10; i++ )
        {
            if (x[i] > 0)
            {
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            }
            else
            {
                y[i] = double.NaN;
            }
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
        double sum = 0, max_s = 0, sum_s = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max_s)
            {   
                max_s = array[i];
                sum += sum_s;
                sum_s = 0;
            }
            sum_s += array[i];
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
        double max_s = 0, s = 0, m = 0;
        foreach (double x in array)
        {
            if (x > max_s) { max_s = x; }
            s += x;
            m++;
        }
        double ans = Math.Round(s / m, 2);
        bool H = false;
        for (int i = 0; i < array.Length; i++)
        {
            if (H) { array[i] = ans; }
            if (array[i] == max_s) { H = true; }
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
        double s = 0, m = 0;
        foreach (double x in array)
        {
            s += x;
            m++;
        }
        double ans = s / m, min_s = double.MaxValue;
        int i_s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if( Math.Abs(ans - array[i]) < min_s ) { min_s = Math.Abs(ans - array[i]); i_s = i; }
        }
        for (int i = 0; i <= i_s; i++)
        {
            b[i] = array[i];
        }
        b[i_s + 1] = P;
        for (int i = i_s + 1; i < array.Length; i++)
        {
            b[i + 1] = array[i];
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
        double max_s = 0, min_s = double.MaxValue;
        int i_max = -1, i_min = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max_s) { max_s = array[i]; i_max = i; min_s = array[i]; i_min = i; }
            if (array[i] < min_s) { min_s = array[i]; i_min = i; };
        }
        array[i_max] = min_s;
        array[i_min] = max_s;
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
        double min_s = double.MaxValue;
        double[] b = new double[array.Length - 1];
        int i_min = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                if (array[i] < min_s)
                {
                    min_s = array[i];
                    i_min = i;
                }
            }
        }
        if (min_s == double.MaxValue) { return array; }
        for (int i = 0; i < i_min; i++)
        {
            b[i] = array[i];
        }
        for (int i = i_min + 1; i < array.Length; i++)
        {
            b[i - 1] = array[i];
        }
        array = b;
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
        double max_s = double.MinValue, sum_s = 0;
        int i_s = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max_s) { max_s = array[i]; i_s = i; }
        }
        for (int i = i_s + 1; i < array.Length; i++ ) { sum_s += array[i]; }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) { array[i] = Math.Round(sum_s, 2); break; }
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
        double max_s = double.MinValue, sum_s = 0;
        int i_s = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max_s) { max_s = array[i]; i_s = i; }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) { array[i_s] = array[i]; array[i] = Math.Round(max_s, 2); break; }
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
        double[] b = new double[array.Length + 1];
        double s = 0, m = 0;
        foreach (double x in array)
        {
            s += x;
            m++;
        }
        double ans = s / m;
        int i_s = 0, n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < ans) { n++; }
        }
        output = new int[n];
        n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < ans) { output[n] = i; n++; }
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
        double max_chet = double.MinValue, max_nechet = double.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0 && max_chet < array[i]) { max_chet = array[i]; }
            else if (i % 2 == 1 && max_nechet < array[i]) { max_nechet = array[i]; }
        }
        if (max_chet > max_nechet)
        {
            for (int i = 0; i < array.Length / 2; i++) { array[i] = 0; }
        }
        else
        {
            for (int i = array.Length / 2; i < array.Length; i++) { array[i] = 0; }
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
        double sum_chet = 0, sum_nechet = 0, min_s = double.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0) { sum_chet += array[i]; }
            else if (i % 2 == 1) { sum_nechet += array[i]; }
            if (min_s > array[i]) {  min_s = array[i]; }
        }
        foreach (double x in array)
        {
            if (x == min_s && min_s < 0) { sum = Math.Round(sum_nechet, 2); break; }
            else if (x < 0) { sum = Math.Round(sum_chet, 2); break; }
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
        double max_s = double.MinValue;
        int i_s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (max_s < array[i]) {  max_s = array[i]; i_s = i; }
        }
        for (int i = 0; i < i_s - 1; i+=2)
        {
            double p = array[i];
            array[i] = array[i+1];
            array[i+1] = p;
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
        int count = 0, m = 1;

        // code here
        for(int i = 0; i < array.Length - 1; i++)
        {
            if (array[i + 1] < array[i]) { m++; }
            else { count = m > count ? m : count; m = 1; }
        }
        count = m > count ? m : count;
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
        int count = 0, m = 1, n = 1;

        // code here
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i + 1] < array[i]) { m++; }
            else { count = m > count ? m : count; m = 1; }
            if (array[i + 1] > array[i]) { n++; }
            else { count = n > count ? n : count; n = 1; }
        }
        count = m > count ? m : count;
        count = n > count ? n : count;
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

        return (X, Y, globalMax,globalMin);
    }
    public double[] Task_3_12(double[] array)
    {
        // code here
        int n = 0;
        foreach (double x in array)
        {
            if (x >= 0) { n++; }
        }
        double[] b = new double[n];
        n = 0;
        foreach (double x in array) { if (x >= 0) {  b[n] = x; n++; } }
        array = b;
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
