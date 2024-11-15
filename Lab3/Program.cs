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
        foreach (double x in array)
        {
            sum += x;
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

        double sum=0,k=0; 
        foreach (double x in array) 
        {
            if (x > 0)
            {
                sum += x;
                k++;
            }
        }
        sum = Math.Round(sum / k, 2);
        for (int i = 0; i < array.Length; i++)
        {
           if (array[i]>0)  array[i] = sum;
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here

        for (int i = 0;i < 4; i++)
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

        double sum=0;
        for (int i = 0; i < 5;i++)
        {
            sum=sum+ array[i];
        }
        sum=Math.Round(sum/5, 2);
        for (int i = 0; i < 5; i++)
        {
            array[i] = Math.Round(array[i]-sum, 2);
        }
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

        return Math.Round(product, 2);
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here

        for (int i=0;i<5;i++)
        {
            length+= vector[i]*vector[i];
        }
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sum = 0;
        for (int i = 0; i < 7; i++)
        {
            sum+= array[i];
        }
        sum = sum / 7;
        for (int i = 0; i < 7; i++)
        {
            if (array[i] > sum) array[i] = 0;
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        foreach ( double x in array)
        {
            if (x < 0) count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here

        double sum = 0;
        foreach (double x in array)
        {
            sum= sum + x;
        }
        sum = Math.Round(sum/8, 2);
        foreach (double x in array)
        {
            if (x > sum) count++;
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
            if (x>P && x<Q) count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;
        // code here

        int k = 0, f = 0;
        foreach (double x in array)
        {
            if (x > 0) k++;
        }
        output = new double[k];
        foreach (double x in array)
        {
            if (x > 0)
            {
                output[f] = x;
                f++;
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

        for ( int i = 0; i < 8; i++)
        {
            if (array[i]<0) 
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
        double[] odd = new double[array.Length/2];

        // code here

        for (int i = 0; i < even.Length; i++)
        {
            even[i] = array[i * 2];
        }
        for (int i = 0; i < odd.Length; i++)
        {
            odd[i] = array[i * 2 + 1];
        }
        //kereer
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here

        for (int i = 0;i<11;i++)
        {
            if (array[i] >= 0)
            {
                sum = sum + array[i] * array[i];
            }
            else break;
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

            else y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here

        int min = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < array[min])
            {
                min = i;
            }
        }
        array[min] *= 2;
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
        double min = 1000000, k = 1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                k = i;
            }
        }

        for (int i = 0; i < k; i++)
        {
             if (array[i]>=0) array[i] *= 2;
             else array[i] -= array[i] / 2;
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
        double max = double.MinValue, min = double.MaxValue;
        double[] array1 = array;
        int mx = -1, mn = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                mn = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                mx = i;
            }
        }
        int t;
        if (mn > mx)
        {
            t = mx;
            mx = mn;
            mn = t;

        }
        for (int i = mn + 1, j = 0; i < mx; i++, j++)
        {
            if (array1[i] < 0) array[j] = array[i];
        }

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

        double max = -100000;
        int n=1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                n = i;
            }
        }
        if (array.Length > n+1)
        {
            if (array[n + 1] >= 0) array[n + 1] = array[n + 1] * 2;
            else array[n + 1] = array[n + 1] / 2;
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
        double min = array[0], max = array[0], sum=0;
        int n = 0, k = 0, sr = 0, index;


        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                k = i;
            }

            if (array[i] < min)
            {
                min = array[i];
                n = i;
            }
        }


        if (n > k)
        {
            index = n;
            n = k;
            k = index;
        }

        for (int i = n + 1; i < k; i++)
        {
            sum += array[i];
            sr++;
        }

        if (sr > 0) average = sum /sr;
        // end

        return Math.Round(average, 2);
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
        double[] nov;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)  index = i;
        }

       
        if (index + 1 < array.Length) nov = new double[array.Length];
        
        else nov = new double[array.Length + 1];

        for (int i = 0; i < array.Length; i++)
        {
            nov[i] = array[i];
        }

        if (index > 0) nov[index + 1] = P;

        // end

        return nov;
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
        double max = -1000000; int k=1;
        for ( int i=0;i<array.Length;i++)
        {
            if (i % 2 == 0 && max < array[i])
            {
                max = array[i];
                k = i;
            }

        }
        array[k] = k;
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
        //double[] output = null;

        // code here
        double[] output = new double[A.Length + B.Length];
        int c1 = 0, c2 = 0;
        if (k > A.Length - 1)
            return A;
        else
        {
            for (int i = 0; i < A.Length + B.Length; i++)
            {
                if (i <= k)
                {
                    output[i] = A[c1];
                    c1++;
                }
                else if (i > k && i <= B.Length + k)
                {
                    output[i] = B[c2];
                    c2++;
                }
                else
                {

                    output[i] = A[c1];
                    c1++;
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
        double min = array[0], max = array[0], sum = 0;
        int n = 0, k = 0, sr = 0, index;


        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                k = i;
            }

            if (array[i] < min)
            {
                min = array[i];
                n = i;
            }
        }
      
        int count = 0;
        if (k < n)
        {
            foreach (double x in array)
            {
                if (x > 0)
                {
                    average += x;
                    count++;
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
                    count++;
                }
            }
        }
        if (count != 0) average = Math.Round(average / count, 2);

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

        double sum = 0, max = double.MinValue; int ind=0;
        foreach (double x in array) sum += x;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) { max = array[i]; ind = i; }
        } 
        if (max > sum) array[ind] = 0;
        else array[ind] *= 2;
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

        double max = double.MinValue;
        int[] maximumy = new int[array.Length];
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maximumy[0] = i;
                k = 1;
            }
            else if (array[i] == max)
            {
                maximumy[k] = i;
                k++;
            }
        }
        output = new int[k];
        for (int i = 0; i < k; i++) output[i] = maximumy[i];
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

        double max = double.MinValue, sum=0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                array[i] = sum;
                sum += max;
                continue;
            }
            sum += array[i];
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

        double[] plus = new double[array.Length];
        int[] minus = new int[array.Length];
        int ot = 0, k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                plus[k] = array[i];
                k++;
            }
            else
            {
                minus[ot] = i;
                ot++;
            }
        }
        for (int i = 0; i < ot; i++)
        {
            plus[k+i] = array[minus[i]];
        }
        // end

        return plus;
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

        double[] dvoynoy = new double[array.Length];
        for (int i = 0; i < array.Length / 2; i++)
        {
            dvoynoy[2 * i] = array[i];
            dvoynoy[2 * i + 1] = array[i];
        }
       
        // end

        return dvoynoy;
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

        double[] pov = new double[array.Length];
        int k = 0, f;
        for (int i = 0; i < array.Length; i++)
        {
            f = 1;
            for (int j = 0; j < k; j++)
            {
                if (array[i] == pov[j])
                {
                    f = 0;
                    break;
                }
            }
            if (f==1)
            {
                pov[k] = array[i];
                k++;
            }
        }
        array = new double[k];
        for (int i = 0; i < k; i++)
        {
            array[i] = pov[i];
        }
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
