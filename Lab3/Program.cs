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
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i]/sum,2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sum = 0;
        double count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                sum += array[i];
                count++;
            }
        }
        double am = Math.Round(sum / count, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = am;
            }
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
            sum[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = Math.Round(first[i] - second[i], 2);
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
        double am = Math.Round(sum / 5, 2);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - am, 2);
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
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 2);
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        double am = Math.Round(sum / 7, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > am)
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
        for (int i = 0; i < 6; i++)
        {
            if (array[i] < 0)
                count++;
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
        double am = Math.Round(sum / 8, 2);
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > am)
                count++;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for (int i = 0; i < 10; i++)
        {
            if ((array[i] > P) && (array[i] < Q))
                count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int count = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
                count++;
        }
        output = new double[count];
        count = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                output[count] = array[i];
                count++;
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
        int ind = 0;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] < 0)
            {
                value = array[i];
                index = ind;
            }
            ind++;
        }
        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        // code here
        int e = 0;
        int o = 0;
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                even[e] = array[i];
                e++;
            }
            else
            {
                odd[o] = array[i];
                o++;
            }
                
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
            if (array[i] < 0)
                break;
            else
                sum += array[i] * array[i];
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
            if (x[i] > 0)
                y[i] = Math.Round(Math.Log(x[i]) / 2, 2);
            else
                y[i] = double.NaN;

        }
        for (int i = 0; i < y.Length; i++)
        {
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
        double max = -100000000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
                break;
            else
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
        double max = -100000000;
        int index = 0;
        double am = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index = i;
            }
            am += array[i];
        }
        am = Math.Round(am / array.Length, 2);
        for (int i = (index+1); i < array.Length; i++)
        {
            array[i] = am;
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
        double am = 0;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            am += array[i];
        }
        am = Math.Round(am/array.Length, 2);
        for (int i = 1; i < array.Length; i++)
        {
            if (Math.Abs(am - array[i]) < Math.Abs(am - array[index]))
                index = i;
        }
        double[] array2 = new double[array.Length + 1];
        for (int i = 0; i < index + 1; i++)
        {
            array2[i] = array[i];
        }
        array2[index + 1] = P;
        for (int i = index + 2; i < array.Length + 1; i++)
        {
            array2[i] = array[i - 1];
        }
        // end

        return array2;
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
        double max = -1000000000;
        double min = 1000000000;
        int max_index = 0;
        int min_index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
                max_index = i;
            }   
        }
        for (int i = max_index; i < array.Length; i++)
        {
            if (min > array[i])
            {
                min = array[i];
                min_index = i;
            }
        }
        array[max_index] = min;
        array[min_index] = max;
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
        double min = 10000000;
        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && array[i] < min)
            {
                min = array[i];
                index = i;
            }
        }
        if (index == -1) 
            return array;
        double[] array2 = new double[array.Length - 1];
        for (int i = 0; i < index; i++)
        {
            array2[i] = array[i];
        }
        for(int i = index + 1; i < array.Length; i++)
        {
            array2[i-1] = array[i];
        }
        // end

        return array2;
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
        double max = -1000000;
        int max_index = 0;
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (max <  array[i])
            {
                max = array[i];
                max_index = i;
            }
        }
        for (int i = max_index+1; i < array.Length; i++)
        {
            sum += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = Math.Round(sum, 2);
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
        double max = -1000000;
        int max_index = 0;
        double fneg = 0;
        int fn_index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
                max_index = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                fneg = array[i];
                fn_index = i;
                break;
            }
        }
        if (fn_index == -1)
            return array;
        array[max_index] = fneg;
        array[fn_index] = max;
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
        double am = 0;
        int l = 0;
        for (int i = 0; i < array.Length; i++)
        {
            am += array[i];
        }
        am = am / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < am)
                l += 1;
        }
        output = new int[l];
        l = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < am)
            {
                output[l] = i;
                l++;
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
        double max = -1000000; 
        int max_index = 0;
        double min = -1000000;
        int min_index = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > max)
            {
                max = array[i];
                max_index = i;
            }
        }
        for (int i = 1; i < array.Length; i += 2)
        {
            if (array[i] > min)
            {
                min = array[i];
                min_index = i;
            }
        }
        if (max > min)
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
        int index = -1;
        double min = 1000000; 
        int min_index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                index = i;
                break;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                min_index = i;
            }
        }
        if (index == -1)
        {
            for (int i = 1; i < array.Length; i += 2) sum += array[i];
            return sum;
        }
        if (index < min_index)
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
        double max = -1000000;
        int index = 1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                array[i] += index++;
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
        for (int i = 0; i < array.Length; i += 2)
        {
            for (int j = 0; j < array.Length - (i + 2); j += 2)
            {
                if (array[j] > array[j + 2])
                {
                    double n = array[j + 2];
                    array[j + 2] = array[j];
                    array[j] = n;
                }
            }
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
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - (i + 1); j++)
            {
                if ((array[j] < 0 && array[j + 1] < 0) && array[j] < array[j + 1])
                {
                    double n = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = n;
                }
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
        double[] X = null, Y = null;
        double globalMax = 0, globalMin = 0;

        // code here
        X = new double[n];
        Y = new double[n];
        for (int i = 0; i < n; i++)
        {
            double x = a + i * ((b - a) / (n - 1));
            X[i] = Math.Round(x, 2);
            Y[i] = Math.Round(Math.Cos(x) + x * Math.Sin(x), 2);
        }
        globalMax = Y[0];
        globalMin = Y[0];
        for (int i = 0; i < Y.Length; i++)
        {
            if (Y[i] > globalMax)
                globalMax = Y[i];
            if (Y[i] < globalMin)
                globalMin = Y[i];
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
        double[] normalizedArray = null;

        // code here
        normalizedArray = new double[array.Length];
        int max = 0;
        int min = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[max])
                max = i;
            if (array[i] < array[min]) 
                min = i;
        }
        for (int i = 0; i < array.Length; i++)
        {
            normalizedArray[i] = Math.Round((array[i] - array[min]) * (2 / (array[max] - array[min])) - 1, 2);
        }
        // end

        return normalizedArray;
    }
    #endregion
}