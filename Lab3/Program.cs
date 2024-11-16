using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
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
        foreach (double a in array)
        {
            s += a;
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
        double s = 0;
        int i = 0;
        foreach (double a in array)
        {
            if (a > 0)
            {
                s += a;
                i++;
            }
        }
        s = s / i;
        for (int t = 0; t < 8; t++)
        {
            if (array[t] > 0)
            {
                array[t] = Math.Round(s, 2);
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
            sum[i] = Math.Round(first[i] + second[i], 5);
            dif[i] = Math.Round(first[i] - second[i], 5);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s = 0;
        int i = 0;
        foreach (double a in array)
        {
            s += a;
            i++;
        }
        s = Math.Round(s / i, 2);
        for (int t = 0; t < 5; t++)
        {
            array[t] = Math.Round(array[t] - s, 5);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        double s = 0;
        for (int i = 0; i < 4; i++)
        {
            s += vector1[i] * vector2[i];
        }
        // end
        product = Math.Round(s, 2);
        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < 5; i++)
        {
            length += vector[i] * vector[i];
        }
        // end
        length = Math.Sqrt(length);
        return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        int i = 0;
        foreach (double a in array)
        {
            s += a;
            i++;
        }
        s = s / i;
        for (int t = 0; t < 7; t++)
        {
            if (array[t] > s) array[t] = 0;
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        int i = 0;
        foreach (double a in array)
        {
            if (a < 0) i++;
        }
        // end
        count = i;
        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double s = 0;
        int i = 0;
        foreach (double a in array)
        {
            s += a;
            i++;
        }
        s = s / i;
        for (int t = 0; t < 8; t++)
        {
            if (array[t] > s) count++;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        foreach (double a in array)
        {
            if (a > P && a < Q) count++;

        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {


        // code here
        int i = 0;
        int t = 0;
        foreach (double a in array)
        {
            if (a > 0)
            {
                t++;
            }

        }
        double[] output = new double[t];
        foreach (double a in array)
        {
            if (a > 0)
            {
                output[i] = a;
                i++;
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
        int t = 0;
        int y = 0;
        // code here
        for (int i = 0; i < 10; i += 2)
        {
            even[t] = array[i];
            t++;
        }
        for (int i = 1; i < 10; i += 2)
        {
            odd[y] = array[i];
            y++;
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
            if (array[i] < 0) break;
            else
            {
                sum += array[i] * array[i];
            }
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
            if (x[i] <= 0) y[i] = double.NaN;
            else
            {
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
                Console.Write(y[i]);
                Console.WriteLine(x[i]);
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
        double m = array[0];
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < m)
            {
                m = array[i];
                k = i;
            }
        }
        // end
        if (array[k]>0) array[k] = 2.0 * array[k];
        if (array[k] < 0) array[k] = 0.5 * array[k];
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
        double m = array[0];
        int k = 0;
        int r = 0;
        foreach (double x in array)
        {

            if (x < m)
            {
                m = x;
                r = k;
            }
            k++;
        }
        for (int i = 0; i < r; i++)
        {
            if (array[i] > 0)
            {
                array[i] = array[i] * 2.0;
            }
            else array[i] = array[i] * 0.5;
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
        double m = array[0];
        double n = array[0];
        int r1 = 0, r2 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < m)
            {
                m = array[i];
                r1 = i;

            }
            if (array[i] > n)
            {
                n = array[i];
                r2 = i;
            }
        }
        int t = 0;
        double[] a;
        if (r2 < r1)
        { 
            for (int i = r2+1; i < r1; i++)

            {
                if (array[i] < 0) t++;
            }
            
            a = new double[t];
            int k = 0;
            for (int i = r2+1; i < r1; i++)
            {
                if (array[i] < 0)
                {
                    a[k] = array[i];
                    k++;
                }
            }
        }
        else
        {
            for (int i = r1+1; i < r2; i++)

            {
                if (array[i] < 0) t++;
            }
            
            a = new double[t];
            int k = 0;
            for (int i = r1+1; i < r2; i++)
            {
                if (array[i] < 0)
                {
                    a[k] = array[i];
                    k++;
                }
            }
        }
        // end
        
        return a;
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
        double m = array[0];
        int y = 0;
        for (int i=0; i<=array.Length-1; i++)
        {
            if (array[i]>m)
            {
                m = array[i];
                y = i;
            }
        }
        if (y + 1 <= array.Length - 1)
        {
            if (array[y + 1] < 0) array[y + 1] *= 0.5;
            if (array[y + 1] > 0) array[y + 1] *= 2.0;
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
        double m = array[0];
        double n = array[0];
        int x = 0, y = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > m)
            {
                m = array[i];
                x = i;
            }
            if (array[i] < n)
            {
                n= array[i];
                y = i;
            }
        }
        double s = 0;
        int k = 0;
        if (x<y)
        {
            for (int i = x+1; i<y; i++)
            {
                s+= array[i];
                k++;
            }
        }
        else if (y<x)
        {
            for (int i = y + 1; i < x; i++)
            {
                s += array[i];
                k++;
            }

        }
        if (k == 0) return 0;
        // end
        average = s / k;
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

        double[] a = new double[array.Length + 1];
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) k = i;
        }
        if (array[k] == 0 || k == 0) return array;
        for (int i = 0; i <= k; i++)
        {
            a[i] = array[i];
        }
        if (k+1==array.Length) a[array.Length] = P;
        else
        {
            a[k + 1] = P;
            for (int i = k+1; i < array.Length; i++)
            {
                a[i+1] = array[i];
            }
        }
        return a;
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
        double m = 0;
        int x = 0;
        for (int i=0; i<array.Length; i+=2)
        {
            if (m<array[i])
            {
                m = array[i];
                x = i;
            }
        }
        array[x] = x;
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
        double[] output = new double[A.Length+B.Length];

        // code here
        if (k >= A.Length) output = A;
        else
        {
            for (int i = 0; i <= k; i++)
            {
                output[i] = A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                output[k + 1 + i] = B[i];
            }
            if (k+1 < A.Length)
            {
                for (int i = k + 1; i < A.Length; i++)
                {
                    output[i + B.Length] = A[i];
                }
            }
        }
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
        double m = array[0];
        double n = array[0];
        int x = 0, y = 0;
        for (int i=0; i<array.Length; i++)
        {
            if (array[i]>m)
            {
                m = array[i];
                x = i;
            }
            if (array[i]<n)
            {
                n = array[i];
                y = i;
            }
        }
        if (x<y)
        {
            double s = 0;
            int k = 0;
            for (int i=0; i<array.Length; i++)
            {
                if (array[i]>0)
                {
                    s += array[i];
                    k++;
                }
            }
            if (k==0)  k=1;
            else average = s / k;
        }
        if (x>y)
        {
            double s = 0;
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    s += array[i];
                    k++;
                }
            }
            if (k == 0) k=1;
            else average = s / k;
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
        double m = array[0];
        double s = 0;
        int k = 0;
        for (int i=0; i<array.Length; i++)
        {
            if (array[i] > m)
            {
                m = array[i];
                k = i;
            }
            s += array[i]; ;
        }
        if (m > s) array[k] = 0;
        if (m < s) array[k] *= 2;

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
        double m = array[0];
        int d = 0;
        for (int i=0; i<array.Length;i++)
        {
            if (array[i]>m)
            {
                m = array[i];
                d = i;
            }
        }
        int r = 1;
        for (int i=0; i<array.Length; i++)
        {
            if (array[i]==m)
            {
                array[i] = array[i]+r;
                r++;
            }
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
        double m = 0;
        int k = 0;
        double p = 0;
        for (int i=0; i<array.Length;i+=2)
        {
            m = array[i];
            k = i;
            for (int j=i+2; j<array.Length;j+=2)
            {
                if (array[j]<m)
                {
                    m=array[j];
                    k = j;
                }
            }
            p=array[i];
            array[i] = array[k];
            array[k] = p;
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
        double p,o = 0;
        int k = 0;
        for (int i=0; i<array.Length; i++)
        {
            if (array[i]<0)
            {
                p = array[i];
                k = i;
                for(int j=i+1; j<array.Length; j++)
                {
                    if (array[j]<0)
                    {
                        if (array[j]>p)
                        {
                            p = array[j];
                            k = j;
                        }
                    }
                }
                o = array[i];
                array[i] = array[k];
                array[k] = o;
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
        double[] X = new double[n], Y = new double[n];
        double globalMax = 0, globalMin = 0;
        int k = 0;
        // code here
        double r=(b-a)/(n-1);
        for (double x=a; x<=b; x+=r)
        {
            X[k] = Math.Round(x,2);
            Y[k] = Math.Round(Math.Cos(x) + x * Math.Sin(x),2);
            k++;
        }
        globalMax = Y[0];
        globalMin = Y[0];
        for (int i=1; i<n; i++)
        {
            if (Y[i] > globalMax) globalMax = Y[i];
            if (Y[i] < globalMin) globalMin = Y[i];
        }
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

        // end

        return array;
    }
    public double[] Task_3_14(double[] array)
    {
        double[] a = new double[array.Length];

        // code here
        double m = array[0];
        double n = array[0];
        int x,y = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > m)
            {
                m = array[i];
                x = i;
            }
            if (array[i] < n)
            {
                n = array[i];
                y = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            a[i] = Math.Round((2 * (array[i] - n) / (m - n)) - 1, 2);
        }
        
        // end

        return a;
    }
    #endregion
}