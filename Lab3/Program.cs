using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        //program.Task_1_1(new int[] {1, 2, 3, 4, 5, 6});
        program.Task_2_10(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
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
            array[i] = Math.Round(array[i], 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sum = 0; int cnt = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] <= 0) continue;
            sum += array[i];
            cnt++;
        }
        double mean = sum / cnt;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] <= 0) continue;
            array[i] = mean;
            array[i] = Math.Round(array[i], 2);
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        int n = Math.Min(first.Length, second.Length);
        for (int i = 0; i < n; i++)
        {
            sum[i] = first[i] + second[i];
            sum[i] = Math.Round((double)sum[i], 2);
        }
        for (int i = 0; i < n; i++)
        {
            dif[i] = first[i] - second[i];
            dif[i] = Math.Round((double)dif[i], 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        int n = 5;
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += array[i];
        }
        double mean = sum / n;
        for (int i = 0; i < n; i++)
        {
            array[i] -= mean;
            array[i] = Math.Round(array[i], 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        int n = 4;
        for (int i = 0; i < n; i++)
        {
            product += vector1[i] * vector2[i];
        }
        // end
        product = Math.Round(((double)product), 2);
        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        int n = 5;
        double sq = 0;
        for (int i = 0; i < n; i++)
        {
            sq += vector[i] * vector[i];
        }

        length = Math.Sqrt(sq);
        // end

        return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        int n = 7;
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += array[i];
        }
        double mean = sum / n;
        for (int i = 0; i < n; i++)
        {
            if (array[i] > mean) array[i] = 0;
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        int n = 6;
        for (int i = 0; i < n; i++)
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
        int n = 8;
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += array[i];
        }
        double mean = sum / n;
        for (int i = 0; i<n; i++)
        {
            if (array[i] > mean) count++;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        foreach (double i in array)
        {
            if (i > P && i < Q) count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int cnt = 0;
        for (int i =0; i<10; i++)
        {
            if (array[i] > 0) cnt++;
        }
        output = new double[cnt]; cnt = 0;
        for (int i = 0; i<10; i++)
        {
            if (array[i] > 0)
            {
                output[cnt++] = array[i];
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
        for (int i = 7; i>=0; i--)
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
        for (int i =0; i<10; i += 2)
        {
            even[i/2] = array[i];
        }
        for (int i = 1; i < 10; i += 2)
        {
            odd[i / 2] = array[i];
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        int i = 0;
        while (i< array.Length && array[i] >=0 )
        {
            sum += array[i] * array[i];
            i++;
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i =0; i<10; i++)
        {
            if (x[i] <= 0)
            {
                y[i] = Double.NaN; continue;
            }
            y[i] = Math.Log(x[i])/2;
            y[i] = Math.Round(y[i], 2);
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
        double mx = -1e18; int mxpos = 0;
        for (int i =0; i<array.Length; i++)
        {
            if (array[i] > mx)
            {
                mx = array[i];
                mxpos = i;
            }
        }
        for (int i =0; i<mxpos; i++)
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
        int n = array.Length;
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += array[i];
        }
        double mean = sum / n;

        double mx = -1e18; int mxpos = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mx)
            {
                mx = array[i];
                mxpos = i;
            }
        }

        mean = Math.Round(mean, 2);
        for (int i =mxpos + 1; i<n; i++)
        {
            array[i] = mean;
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
        int n = array.Length;
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += array[i];
        }
        double mean = sum / n;

        int pos = 0;
        double mndif = 1e18;
        for (int i =0; i<n; i++)
        {
            if (mndif>Math.Abs(mean - array[i]))
            {
                mndif = Math.Abs(mean - array[i]);
                pos = i;
            }
        }

        double[] new_ar = new double[n + 1];
        //if (pos + 1 >= n) return 0;
        for (int i =0; i<=pos; i++)
        {
            new_ar[i] = array[i];
        }
        new_ar[pos + 1] = P;
        for (int i = pos+2; i<n+1; i++)
        {
            new_ar[i] = array[i - 1];
        }
        // end

        return new_ar;
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
        double mx = -1e18; int mxpos = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mx)
            {
                mx = array[i];
                mxpos = i;
            }
        }
        double mn = 1e18; int mnpos = 0;
        for (int i = mxpos; i < array.Length; i++)
        {
            if (array[i] < mn)
            {
                mn = array[i];
                mnpos = i;
            }
        }
        (array[mxpos], array[mnpos]) = (array[mnpos], array[mxpos]);
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
        double mn = 1e18; int mnpos = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < mn && array[i] > 0)
            {
                mn = array[i];
                mnpos = i;
            }
        }
        if (mnpos == -1) return array;
        double[] new_arr = new double[array.Length - 1];
        for (int i =0; i<mnpos; i++)
        {
            new_arr[i] = array[i];
            //Console.WriteLine(array[i]);
        }
        for(int i =mnpos+1; i<array.Length; i++)
        {
            new_arr[i-1] = array[i];
            //Console.WriteLine(array[i]);
        }

        // end

        return new_arr;
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
        double mx = -1e18; int mxpos = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mx)
            {
                mx = array[i];
                mxpos = i;
            }
        }
        double sum = 0;
        for (int i =mxpos + 1; i<array.Length; i++)
        {
            sum += array[i];
        }

        for (int i =0; i<array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = Math.Round(sum,2);
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
        double mx = -1e18; int mxpos = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mx)
            {
                mx = array[i];
                mxpos = i;
            }
        }
        int pos = -1;
        for (int i = 0; i<array.Length; i++)
        {
            if (array[i] < 0)
            {
                pos = i;
                break;
            }
        }
        if (pos == -1) return array;
        (array[pos], array[mxpos]) = (array[mxpos], array[pos]);
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

        // code here
        int n = array.Length;
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += array[i];
        }
        double mean = sum / n;

        int cnt = 0;
        for (int i =0; i<n; i++)
        {
            if (array[i] < mean) cnt++;
        }

        int[] output = new int[cnt];
        int j = 0;
        for (int i=0; i<n; i++)
        {
            if (array[i]<mean) output[j++] = i;
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
        double mx = -1e18; int mxpos = 0;
        for (int i = 0; i < array.Length; i+=2)
        {
            if (array[i] > mx)
            {
                mx = array[i];
                mxpos = i;
            }
        }

        double mn = -1e18; int mnpos = 0;
        for (int i = 1; i < array.Length; i+=2)
        {
            if (array[i] > mn)
            {
                mn = array[i];
                mnpos = i;
            }
        }

        if (mx > mn)
        {
            for (int i =0; i < array.Length/2; i++)
            {
                array[i] = 0;
            }
        }
        else
        {
            for (int i = array.Length/2; i < array.Length; i++)
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
        double mn = 1e18; int mnpos = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < mn)
            {
                mn = array[i];
                mnpos = i;
            }
        }

        int pos = -1;
        for (int i =0; i<array.Length; i++)
        {
            if (array[i] < 0)
            {
                pos = i; break;
            }
        }
        if (pos == -1) return 0;
        if (pos < mnpos)
        {
            for (int i = 0; i < array.Length; i += 2) sum += array[i]; 
        }
        else
        {
            for (int i = 1; i < array.Length; i += 2) sum += array[i];
        }

        sum = Math.Round(sum, 2);
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