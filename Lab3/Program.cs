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
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double s = 0;
        foreach (double x in array) { s += x; }
        for (int i = 0; i < 6; i++) { array[i] /= s; }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double a = 0, c =0;
        foreach (double x in array)
            if (x > 0)
            {
                a += x;
                c ++;
            }
        a /= c;
        for (int i = 0; i < 8; i++)
            if (array[i]>0) { array[i] = a;}
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i < 4; i++)
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
        double s = 0;
        foreach (double x in array) { s += x; }
        s /= 5;
        for (int i = 0; i < 5; i++) { array[i] -= s; }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < 4; i++)
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
        foreach(double x in vector) {  length += x*x; }
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        foreach (double x in array) { s += x; }
        s /= 7;
        for (int i = 0; i < 7; i++)
            if (array[i] > s) { array[i] = 0; }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        foreach (double x in array)
            if (x < 0)
                count++;
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double s = 0;
        foreach (double x in array) { s += x; }
        s /= 8;
        for (int i = 0; i < 8; i++)
            if (array[i] > s) { count++; }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        foreach (double x in array)
            if (x < Q && x > P)
                count++;
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int c = 0, k = 0;
        foreach (double x in array)
            if (x > 0)
                c++;
        output = new double[c];
        foreach (double x in array)
            if (x > 0)
                output[k++] = x;
        // end

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        // code here
        for (int i = 7; i >= 0; i--)
            if (array[i] < 0)
            {
                value = array[i];
                index = i;
                break;
            }
        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        // code here
        for (int i = 0, j = 0; i < 10; i+=2)
        {
            even[j] = array[i];
            odd[j] = array[i+1];
            j++;
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        foreach (double x in array)
            if (x >= 0) sum += x * x;
            else break;
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
                y[i] = Math.Round(0.5*Math.Log(x[i]),2);
            else y[i] = double.NaN;
            Console.WriteLine($"{x[i]} {y[i]}");
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        //double m = double.MaxValue;
        //int l = array.Length;
        //for (int i = 0; i < l; i++)
        //    if (array[i] < m)
        // end

                return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        int l = array.Length;
        int n = 0;
        double m = -double.MaxValue;
        for (int i = 0; i < l; i++)
            if (array[i] > m)
            {
                m = array[i];
                n = i;
            }
        for (int i = 0; i < n; i++)
            sum += array[i];
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
        int l = array.Length;
        int n = 0;
        double m = -double.MaxValue, s = 0;
        for (int i = 0; i < l; i++)
        {
            if (array[i] > m)
            {
                m = array[i];
                n = i;
            }
            s += array[i];
        }
        s /= l;
        for (int i = n+1; i <l; i++)
            array[i] = s;
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
        int l = array.Length, n = 0;
        double s = 0;
        foreach ( double x in array )
            s += x;
        s = Math.Round(s/l);
        double d = double.MaxValue;
        for (int i = 0; i < l; i++ )
        {
            if (Math.Abs(array[i] - s) < d)
            {
                n = i;
                d = Math.Abs(array[i] - s);
            }
        }
        double[] a = new double[l+1];
        a[n+1] = P;
        for (int i = 0, j = 0; i < l; i++, j++)
        {
            if (j == n + 1)
                j++;
            a[j] = array[i];
        }
        array = a;
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
        int l = array.Length;
        int n = 0, t = 0;
        double m = -double.MaxValue;
        for (int i = 0; i < l; i++)
            if (array[i] > m)
            {
                m = array[i];
                n = i;
            }
        if (n < l - 1)
        {
            m = double.MaxValue;
            for (int i = n + 1; i < l; i++)
                if (array[i] < m)
                {
                    m = array[i];
                    t = i;
                }
            m = array[n];
            array[n] = array[t];
            array[t] = m;
        }
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
        int l = array.Length, n = -1;
        double m = double.MaxValue;
        double[] a = new double[l-1];
        for (int i = 0; i < l; i++)
            if (array[i] > 0 && array[i] < m)
            {
                n = i;
                m = array[i];
            }
        if (n > -1)
        {
            //for (int i = 0, j = 0; i < l; i++, j++)
            //{
            //    if (i == n-1)
            //    {
            //        i--;
            //        continue;
            //    }
            //    a[j] = array[i];
            //}

            for (int i = 0; i < n; i++)
                a[i] = array[i];
            for (int i = n; i < l - 1; i++)
                a[i] = array[i + 1];
            array = a;
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
        int l = array.Length;
        int n = 0, t = -1;
        double m = -double.MaxValue;
        for (int i = 0; i < l; i++)
            if (array[i] > m)
            {
                m = array[i];
                n = i;
            }
        for (int i = 0; i < l; i++)
            if (array[i] < 0)
            {
                t = i;
                break;
            }
        double s = 0;
        if ((t > -1) && (n < l))
        {
            for (int i = n+1; i < l; i++)
                s+= array[i];
            array[t] = s;
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
        int l = array.Length;
        int n = 0, t = -1;
        double m = -double.MaxValue;
        for (int i = 0; i < l; i++)
            if (array[i] > m)
            {
                m = array[i];
                n = i;
            }
        for (int i = 0; i < l; i++)
            if (array[i] < 0)
            {
                t = i;
                break;
            }
        double s = 0;
        if (t > -1)
        {
            s = array[t];
            array[t] = array[n];
            array[n] = s;
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
        double m = 0;
        int l = array.Length, n = 0;
        foreach (double x in array)
            m += x;
        m /= l;
        foreach (double x in array)
            if (x < m) { n++; }
        int[] a = new int[n];
        for (int i = 0, j = 0; i < l; i++)
            if (array[i] < m)
            {
                a[j] = i;
                j++;
            }
        output = a;
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
        int l = array.Length;
        double m = - double.MaxValue, n = -double.MaxValue;
        for (int i = 0; i < l-1; i+=2)
        {
            if (array[i] > m)
                m = array[i];
            if (array[i+1] > n)
                n = array[i+1];
        }
        if (m > n)
            for (int i = 0; i < l/2; i++)
                array[i] = 0;
        else for (int i = l/2; i < l; i++)
                array[i] = 0;
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
        int l = array.Length, f = l, m = l;
        double n = double.MaxValue;
        for (int i = 0; i < l; i++)
        {
            if (f == l && array[i] < 0)
                f = i;
            if (array[i] < n)
            {
                n = array[i];
                m = i;
            }
        }
        if (f < m)
            for (int i = 0; i < l; i += 2)
            {

                sum += array[i];
            }
        else for (int i = 1; i < l; i+=2)
                sum += array[i];
        // end
        return sum;
    }
    #endregion
    #region Level 3
    public int[] Task_3_1(double[] array)
    {
        //int[] output = null;

        // code here
        double m = - double.MaxValue;
        int k = 0, l = array.Length;
        for (int i = 0; i < l; i++)
        {
            if (array[i] > m)
            {
                k = 1;
                m = array[i];
            }
            else if (array[i] == m)
                k++;
        }
        int[] output = new int[k];
        for (int i = 0, j = 0; i < l; i++)
            if (array[i] == m)
            {
                output[j] = i;
                j++;
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
        double s = 0, m = -double.MaxValue;
        int l = array.Length, n = 0;
        for (int i = 0; i < l; i++)
        {
            if (array[i] >= m)
            {
                m = array[i];
                n = i;
            }
        }
        for (int i = 0; i <= n; i++)
        {
            s += array[i];
            if (array[i] == m)
                array[i] = s - m;
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
        double n = 0;
        int l = array.Length;
        for (int i = l - 1, j = l-1; i >= 0; i--)
        {
            if ( array[i] < 0)
            {
                n = array[i];
                array[i] = array[j];
                array[j] = n;
                j--;
            }
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
        for (int i = array.Length / 2 - 1; i >= 0; i--) { array[i * 2] = array[i * 2 + 1] = array[i]; }
        // end
        //one line solution, noice
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
        int l = array.Length, n = 0;
        double[] a = new double[l];
        for (int i = 0, j = 0; i < l; i++)
        {
            for(j = 0; j <= n; j++)
                if (a[j] == array[i])
                {
                    j++;
                    break;
                }
            if (j-1 == n)
            {
                a[n] = array[i];
                n++;
            }
        }
        
        array = new double[n];
        for (int i = 0; i < n; i++)
            array[i] = a[i];
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
