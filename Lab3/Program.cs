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
        int n = 6;
        double sum = 0;
        for(int i = 0;i < n; i++)
        {
            sum+=array[i];
        }
        for(int i = 0; i < n; i++)
        {
            array[i] /= sum;
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double cnt = 0;
        int n = 8;
        double sum = 0;
        for(int i = 0;i < n; i++)
        {
            if (array[i] > 0)
            {
                sum+= array[i];
                cnt++;
            }
        }
        for(int i = 0; i < n; i++)
        {
            if (array[i] > 0)
            {
                array[i] = sum / cnt;
            }
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        int n = 4;
        for(int i = 0; i < n; i++)
        {
            sum[i]= first[i]+ second[i];
            dif[i]= first[i] - second[i];
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double cnt = 0;
        int n = 5;
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
                sum += array[i];
                cnt++;
        }
        for (int i = 0; i < n; i++)
        {
            array[i] -= sum / cnt;
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        int n = 4;
        double ans = 0;
        for(int i = 0; i < n; i++)
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
        for(int i = 0; i < 5; i++)
        {
            length += vector[i]*vector[i];
        }
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double cnt = 0;
        int n = 7;
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += array[i];
            cnt++;
        }
        for(int i = 0; i < n; i++)
        {
            if (array[i] > sum / cnt)
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
        int n = 6;
        for(int i = 0; i < 6; i++)
        {
            if (array[i] < 0)
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
        double cnt = 0;
        int n = 8;
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += array[i];
            cnt++;
        }
        for (int i = 0; i < n; i++)
        {
            if (array[i] > sum / cnt)
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
        int n = 10;
        for(int i = 0; i < n; i++)
        {
            if(P < array[i] && array[i] < Q)
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
        int n = 10;
        int cnt = 0;
        for(int i = 0; i < n; i++)
        {
            if (array[i] > 0)
            {
                cnt++;
            }
        }
        output = new double[cnt];
        int j = 0;
        for(int i = 0; i < n; i++)
        {
            if (array[i] > 0)
            {
                output[j++] = array[i];
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
        int n = 8;
        for(int i  = 0; i < n; i++)
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
        double[] odd = new double[array.Length/2];

        // code here
        int j0 = 0;
        int j1 = 0;
        int n = 10;
        for(int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                even[j0++] = array[i];
            }
            else
            {
                odd[j1++] = array[i];
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        int n = 11;
        for(int i = 0;i < n && array[i] >= 0; i++)
        {
            sum += array[i] * array[i];
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        int n = 10;
        for(int i = 0; i < n; i++)
        {
            if (x[i] > 0) y[i] = 0.5 * Math.Log(x[i]);
            else y[i]=double.NaN;
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        if(array.Length == 0)
        {
            return array;
        }
        int j = 0;
        for(int i = 0;i < array.Length; i++)
        {
            if (array[i] < array[j])
            {
                j = i;
            }
        }
        if (array[j] > 0) array[j] *= 2;
        else array[j] /= 2;
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
        if (array.Length == 0)
        {
            return array;
        }
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < array[j])
            {
                j = i;
            }
        }
        for(int i = 0; i < j; i++)
        {
            if (array[i] > 0) array[i] *= 2;
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
        if (array.Length == 0) 
        {
            return array;
        }
        int mn = 0;
        int mx = 0;
        for(int i = 0;i < array.Length; i++)
        {
            if (array[i] < array[mn])
            {
                mn = i;
            }
            if (array[i] > array[mx])
            {
                mx = i;
            }
        }
        if(mn > mx)
        {
            (mn, mx) = (mx, mn);
        }
        int cnt = 0;
        for(int i = mn + 1;i < mx; i++)
        {
            if (array[i] < 0)
            {
                cnt++;
            }
        }
        double[] b = new double[cnt];
        int j = 0;
        for (int i = mn + 1; i < mx; i++)
        {
            if (array[i] < 0)
            {
                b[j++] = array[i];
            }
        }
        array = b;
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
        if (array.Length == 0)
        {
            return array;
        }
        int mx = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[mx])
            {
                mx = i;
            }
            
        }
        mx++;
        if (mx < array.Length)
        {
            if(array[mx] < 0)
            {
                array[mx] /= 2;
            }
            else
            {
                array[mx] *= 2;
            }
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
        if (array.Length == 0)
        {
            return 0;
        }
        int mn = 0;
        int mx = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < array[mn])
            {
                mn = i;
            }
            if (array[i] > array[mx])
            {
                mx = i;
            }
        }
        if (mn > mx)
        {
            (mn, mx) = (mx, mn);
        }
        double cnt = 0;
        double sum = 0;
        for(int i =  mn + 1;i < mx; i++)
        {
            sum += array[i];
            cnt++;
        }
        if(cnt>0)average = sum / cnt;
        else average = 0;
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
        double[] b = new double[array.Length+1];
        int f = 0;
        for(int i = array.Length-1; i>=0; i--)
        {
            if (array[i] > 0 && f==0)
            {
                f = 1;
                b[i + 1] = P;
            }
            if(f==0)
            {
                b[i + 1] = array[i];
            }
            else
            {
                b[i]=array[i];
            }
        }
        if (f==1)
        {
            b[array.Length] = P;
            array = b;
        }
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
        if (array.Length == 0)
        {
            return array;
        }
        int j = 0;
        for(int i = 0;i < array.Length; i += 2)
        {
            if (array[i] > array[j])
            {
                j = i;
            }
        }
        array[j] = j;
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
        if(k >= A.Length) {
            output = A;
            return output;
        }
        output = new double[A.Length+B.Length];
        int j = 0;
        for(int i = 0;i < A.Length; i++)
        {
            output[j++] = A[i];
            if (j == k+1)
            {
                foreach(double now in B){ 
                    output[j++] = now;
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
        if (array.Length == 0)
        {
            return 0;
        }
        int mn = 0;
        int mx = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < array[mn])
            {
                mn = i;
            }
            if (array[i] > array[mx])
            {
                mx = i;
            }
        }
        double sum = 0;
        double cnt = 0;
        if(mn < mx)
        {
            for (int i = 0; i < array.Length; i++) {
                if (array[i] < 0)
                {
                    sum += array[i];
                    cnt++;
                }
            }
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                    cnt++;
                }
            }
        }
        if(cnt>0)average = sum / cnt;
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
        if(array.Length == 0)
        {
            return array;
        }
        int mx = 0;
        for(int i = 0;i < array.Length; i++)
        {
            if(array[i] > array[mx])
            {
                mx = i;
            }
        }
        double sum = 0;
        for(int i = 0;i < array.Length; i++)
        {
            sum += array[i];
        }
        if (array[mx] > sum)
        {
            array[mx] = 0;
        }
        else
        {
            array[mx] *= 2;
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
        int mx = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[mx])
            {
                mx = i;
            }
        }
        for(int i = 1;i < array.Length && i < mx; i+=2)
        {
            (array[i - 1], array[i]) = (array[i], array[i - 1]);
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
        int count = 0;
        if (array.Length == 0) {
            return count;
        }
        // code here
        int t = 1;
        count = 1;
        for(int i = 1;i < array.Length; i++)
        {
            if (array[i-1] > array[i])
            {
                t++;
            }
            else
            {
                t = 1;
            }
            if(count < t)
            {
                count = t;
            }
        }
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
        if (array.Length == 0) {
            return count;
        }
        int t = 1;
        count = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] > array[i])
            {
                t++;
            }
            else
            {
                t = 1;
            }
            if (count < t)
            {
                count = t;
            }
        }
        t = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] < array[i])
            {
                t++;
            }
            else
            {
                t = 1;
            }
            if (count < t)
            {
                count = t;
            }
        }
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
        int cnt = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                cnt++;
            }
        }
        double[] b = new double[cnt];
        int j = 0;
        for(int i = 0;i < array.Length; i++)
        {
            if(array[i] >= 0)
            {
                b[j++] = array[i];
            }
        }
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
