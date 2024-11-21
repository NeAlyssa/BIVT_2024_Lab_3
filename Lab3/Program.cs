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
        //program.Task_3_3(new double[] { -1, -2, -8, -1, -9, -1, -1, -4, -6, -2 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double s = 0;
        foreach (double x in array)
        {
            s += x;
            
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array[i]/s;
        }

        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0;
        double count = 0;
        foreach (double x in array)
        {
            if (x > 0)
            {
                s += x;
                count++;
            }
        }
        double sr = s/count;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = sr;
            }
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i < sum.Length; i++)
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
        foreach (double x in array)
        {
            s += x;
        }
        double sr = s/array.Length;
        for (int i =0; i < array.Length; i++)
        {
            array[i]-=sr;
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
            product += vector1[i]*vector2[i];
        }
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < 5; i++)
        {
            length += (vector[i] * vector[i]);
        }
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        foreach (double x in array)
        {
            s += x;
        }
        double sr = s/array.Length;
        for (int i = 0; i < 7; i++)
        {
            if (array[i] > sr)
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
        foreach(double x in array)
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
        double s = 0;

        foreach (double x in array)
        {
            s += x;
        }
        double sr = s / array.Length;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > sr)
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
            if (x > P & x < Q)
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
        int count = 0;
        foreach (double x in array)
        {
            if (x > 0)
            {
                count++;
            }
        }
        output = new double[count];
        int index = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                output[index] = array[i];
                index++;
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
        for (int i = array.Length-1; i>= 0; i-- )
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
        int index1 = 0;
        int index2 = 0;
        for (int i = 0; i < array.Length; i+=2)
        {
            even[index1] = array[i];
            index1++;
        }
        for (int i = 1; i < array.Length; i += 2)
        {
            odd[index2] = array[i];
            index2++;
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i< array.Length; i++)
        {
            if (array[i] < 0)
            {
                break;
            }
            sum+= array[i] * array[i];
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i = 0; i < y.Length; i++)
        {
            if (!(x[i] > 0))
            {
                y[i] = double.NaN;
            }
            else
            {
                y[i] = 0.5 * Math.Log(x[i]);
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
        double sum = 0;

        // code here
        double max_n = -10000;
        foreach (double x in array)
        {
            if (x > max_n)
            {
                max_n = x;
            }
        }
        foreach (double a in array)
        {
            if (a == max_n)
            {
                break;
            }
            else
            {
                sum += a;
            }
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
        double max_n = -10000;
        double sum = 0;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            if (array[i] > max_n)
            {
                max_n = array[i];
                index = i;
            }
        }
        double sr = sum / array.Length;
        for (int i = index + 1; i < array.Length; i++)
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
        double sum = 0;
        int index = 0;
        foreach (double a in array)
        {
            sum += a;
        }
        double sr = sum/array.Length;
        double mindiff = Math.Abs(array[0] - sr);
        for (int i = 1; i < array.Length; i++)
        {
            if (Math.Abs(array[i]-sr) < mindiff)
            {
                mindiff = Math.Abs(array[i] - sr);
                index = i;
            }
        }
        double[] array1 = new double[array.Length+1];
        
        for (int i = 0; i <= index; i++)
        {
            array1[i] = array[i];
        }
        array1[index + 1] = P;
        for (int i = index+1; i < array.Length; i++)
        {
            array1[i+1] = array[i];
        }


        array = array1;

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
        double p = 0;
        int index1 = 0;
        int index2 = 0;
        double max = -100000;
        double min = 100000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index1 = i;
            }
        }
        if (!(max == array[array.Length-1]))
        {
            for (int i = index1 + 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index2 = i;
                }
            }
            p = array[index2]; array[index2] = max; array[index1] = p;
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
        double min = 100000;
        int k = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 )
            {
                if (array[i] < min)
                {
                    min = array[i];
                    k = i;
                }
            }
        }
        double[] array1 = new double[array.Length-1];
        if (k != -1)
        {
            for (int i = 0; i < k; i++)
            {
                array1[i] = array[i];
            }
            for (int i = k; i < array.Length - 1; i++)
            {
                array1[i] = array[i + 1];
            }
            array = array1;
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
        double maxi = double.MinValue;
        double sum = 0;
        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                index = i;
            }
        }
        if (index != -1)
        {
            for (int i = index+1; i < array.Length; i++)
            {
                sum+= array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = sum;
                    break;
                }
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
        double maxi = double.MinValue;
        double p = 0;
        int index_maxi = -1;
        int index_otr = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                index_maxi = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                index_otr = i;
                break;
            }
        }
        if (index_otr != -1)
        {
            p = array[index_otr]; array[index_otr] = array[index_maxi]; array[index_maxi] = p;
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
        int count = 0;
        int index = 0;
        foreach (double x in array)
        {
            sum += x;
        }
        double sr = sum/array.Length;
        foreach (double x in array)
        {
            if (x < sr)
            {
                count++;
            }
        }
        output = new int[count];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr)
            {
                output[index] = i;
                index++;
            }
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
        double maxi1 = double.MinValue; double maxi2 = double.MinValue;
        for (int i  = 0; i< array.Length; i+=2)
        {
            if (array[i] > maxi1)
            {
                maxi1 = array[i];
            }
        }
        for (int i = 1; i < array.Length; i += 2)
        {
            if (array[i] > maxi2)
            {
                maxi2  = array[i];
            }
        }
        if (maxi1 > maxi2)
        {
            for (int i = 0; i < array.Length/2; i++)
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
        int index1 = -1;
        int index2 = -1;
        double mini = double.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < mini)
            {
                mini = array[i];
                index1 = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                index2 = i;
                break;
            }
        }
        if (index2 != -1)
        {
            if (index2 < index1)
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
        double maxi = double.MinValue;
        int index_maxi = -1;
        double p = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                index_maxi = i;
            }
        }
        if (index_maxi >= 2)
        {
            for (int i = 0; i < index_maxi-1; i+=2)
            {
                p = array[i + 1];
                array[i+1] = array[i];
                array[i] = p;
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
        int k = 0;
        int maxi = int.MinValue;
        for (int i = 0; i<array.Length-1; i++)
        {
            if (array[i+1] < array[i])
            {
                k++;
            }
            else
            {
                if (k > maxi)
                {
                    maxi = k;
                    
                }
                k = 0;
            }
        }
        if (k > maxi)
        {
            maxi = k;
        }
        count = maxi + 1;
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
        int k = 0;
        int k1 = 0;
        int maxi = int.MinValue;
        int maxi1 = int.MinValue;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i + 1] < array[i])
            {
                k++;
            }
            else
            {
                if (k > maxi)
                {
                    maxi = k;

                }
                k = 0;
            }
        }
        if (k > maxi)
        {
            maxi = k;
        }
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i + 1] > array[i])
            {
                k1++;
            }
            else
            {
                if (k1 > maxi1)
                {
                    maxi1 = k1;

                }
                k1 = 0;
            }
        }
        if (k1 > maxi1)
        {
            maxi1 = k1;
        }
        if (maxi > maxi1)
        {
            count = maxi + 1;
        }
        else
        {
            count = maxi1 + 1;
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
        int index = 0;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                count++;
            }
        }
        double[] array_n = new double[count];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                array_n[index] = array[i];
                index++;
            }
        }
        array = array_n;
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