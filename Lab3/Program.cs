using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Linq;
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
        double smm = 0;
        foreach (var item in array)
        {
            smm += item;
        }
        for (int i = 0; i < 6; i++)
        {
            array[i] = Math.Round(array[i]/smm, 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double smm = 0, count = 0;
        foreach (var item in array)
        {
            if (item > 0)
            {
                smm += item;
                count++;
            }
        }
        smm = Math.Round(smm/count, 2);
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
                array[i] = smm;
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
            sum[i] = Math.Round(first[i] + second[i], 1);
            dif[i] = Math.Round(first[i] - second[i], 1);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sr = 0, count = 0;
        foreach (var item in array)
        {
            sr += item; count++;
        }
        sr = Math.Round(sr/count, 2);
        for (int i = 0; i < 5; i++)
        {
            array[i] = Math.Round(array[i] - sr, 2);
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
        product = Math.Round(product, 2);
        // end

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
        length = Math.Round(Math.Sqrt(length), 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sr = 0, count = 0;
        foreach (var item in array)
        {
            sr += item; count++;
        }
        sr = Math.Round(sr/count, 2);
        for (int i = 0; i < 7; i++)
        {
            if (array[i] > sr) array[i] = 0;
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        for (int i = 0; i < 6; i++)
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
        double sr = 0;
        foreach (var item in array)
        {
            sr += item; count++;
        }
        sr = Math.Round(sr / count, 2);
        count = 0;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > sr) count++;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        foreach (var item in array)
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
        foreach (var item in array)
        {
            if (item > 0) count++;
        }
        output = new double[count];
        count = 0;
        foreach (var item in array)
        {
            if (item > 0) output[count++] = item;
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
        double[] odd = new double[array.Length/2];

        // code here
        int count1 = 0, count2 = 0;
        for (int i = 0; i < 10; i++)
        {
            if (i% 2 == 0) even[count1++] = array[i];
            else odd[count2++] = array[i];
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        foreach (var item in array)
        {
            if (item >= 0) sum += item * item;
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
            if (x[i] <= 0) 
                y[i] = double.NaN;
            else 
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        double min = array[0];
        int number = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min) 
            { 
                min = array[i]; 
                number = i; 
            }
        }
        if (array[number] > 0) 
            array[number] *= 2;
        else 
            array[number] /= 2;
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
        double min = array[0];
        int number = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                number = i;
            }
        }
        for (int i = 0; i < number; i++)
        {
            if (array[i] > 0)
                array[i] *= 2;
            else
                array[i] /= 2;
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
        
        double min = array[0], max = array[0];
        int mn = 0, mx = 0;
        for (int i = 1; i < array.Length; i++)
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
        int count = 0;
        for (int i = mn + 1; i < mx; i++)
        {
            if (array[i] < 0) count++;
        }
        double[] output = new double[count];
        int j = 0;
        for (int i = mn + 1; i < mx; i++)
        {
            if (array[i] < 0) output[j++] = array[i];
        }
        return output;
        // end

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
        double max = array[0];
        int mx = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                mx = i;
            }
        }
        if (mx + 1  < array.Length)
        {
            if (array[mx + 1] > 0) array[mx + 1] *= 2;
            else array[mx + 1] /= 2;
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
        double min = array[0], max = array[0];
        int mn = 0, mx = 0;
        for (int i = 1; i < array.Length; i++)
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
        double sum = 0;
        int count = 0;
        if (mn > mx)
        {
            int c = mx;
            mx = mn;
            mn = c;
        }
        for (int i = mn + 1; i < mx; i++)
        {
            sum += array[i];
            count++;
        }
        if (count == 0) average = 0;
        else average = sum / count;
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
        if (index == -1) return array;
        else
        {
            double[] new_array = new double[array.Length + 1];
            for (int i = 0; i <= index; i++)
            {
                new_array[i] = array[i];
            }
            new_array[index + 1] = P;
            if (index + 2 < new_array.Length)
            {
                for (int i = index + 2; i < new_array.Length; i++)
                    new_array[i] = array[i - 1];
            }
            return new_array;
        
        }
        
        // end
        
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
        double max = array[0];
        int index = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > max)
            {
                max = array[i];
                index = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (i == index) array[i] = index;
        }
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

        if (k > A.Length - 1) return A;

        for (int i = 0; i <= k; i++)
        {
            output[i] = A[i];
        }

        for (int i = 0; i < B.Length; i++)
        {
            output[k + 1 + i] = B[i];
        }

        for (int i = k + 1; i < A.Length; i++)
        {
            output[i + B.Length] = A[i];
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
        double min = array[0], max = array[0];
        int mn = 0, mx = 0;
        for (int i = 1; i < array.Length; i++)
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
        double sum = 0;
        int count = 0;

        if (mx < mn)
        {
            foreach (var item in array)
            {
                if (item > 0)
                {
                    sum += item;
                    count++;
                }
            }
        }
        else
        {
            foreach (var item in array)
            {
                if (item < 0)
                {
                    sum += item;
                    count++;
                }
            }
        }
        if (count == 0) average = 0;
        else average = sum / count;
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
        double max = array[0], sum = 0;
        int mx = 0;
        for (int i = 1; i < array.Length; i++)
        {
            sum += array[i];
            if (array[i] > max)
            {
                max = array[i];
                mx = i;
            }
        }

        if (max > sum) array[mx] = 0;
        else if (array[mx] > 0) array[mx] *= 2;
        else array[mx] /= 2;
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
        double max = array[0];
        int index = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max) { max = array[i]; index = i; }
        }
        for (int i = 0; i < index; i += 2 )
        {
            if (i + 1 == index) break;
            else
            {
                double k = array[i];
                array[i] = array[i + 1];
                array[i + 1] = k;
            }
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

        // code here
        int answ = 1, cnt = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] > array[i])
            {
                cnt++;
            }
            else
            {
                if (cnt > answ) answ = cnt;
                cnt = 1;
            }
        }
        count = answ;
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
        int dec = 1, cnt1 = 1;
        int inc = 1, cnt2 = 1;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] > array[i]) //убывающий
            {
                cnt1++;
            }
            else
            {
                if (cnt1 > dec) dec = cnt1;
                cnt1 = 1;
            }

            if (array[i - 1] < array[i]) //возрастающий
            {
                cnt2++;
            }
            else
            {
                if (cnt2 > inc) inc = cnt2;
                cnt2 = 1;
            }
        }
        if (cnt1 > dec) dec = cnt1; 
        if (cnt2 > inc) inc = cnt2;
        count = Math.Max(dec, inc);
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
        int count = 0;
        foreach (var x in array)
        {
            if (x >= 0) count++;
        }
        double[] new_array = new double[count];
        count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0) new_array[count++] = array[i];
        }
        return new_array;
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