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
        double summ = 0;
        for (int i = 0; i < array.Length; i++)
        {
            summ += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] / summ, 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double summ = 0; double k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                summ += array[i];
                k++;
            }
        }
        double sredn = Math.Round(summ / k, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) 
                array[i] = sredn;
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
        double summ = 0;
        for (int i = 0; i < array.Length; i++)
        {
            summ = summ + array[i];
        }
        double sredn = Math.Round(summ / 5, 2);
        for (int i = 0; i < 5; i++)
        {
            array[i] = Math.Round(array[i] - sredn, 2);
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
        double summ = 0;
        for (int i = 0; i < 5; i++)
        {
            length += vector[i] * vector[i];
        }
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sredn = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sredn += array[i];
        }
        sredn = sredn / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sredn)
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
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                count += 1;
            }
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double sredn = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sredn += array[i];
        }
        sredn = sredn / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sredn)
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
        foreach (double i in array)
        {
            if (i > P && i < Q)
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
        int k = 0, j = 0;
        foreach (double x in array)
        {
            if (x > 0) 
                k++;
        }
        output = new double[k];
        foreach (double x in array)
        {
            if (x > 0)
            {
                output[j] = x;
                j++;
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
        for (int i = 0; i < array.Length; i++)
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
        int nomer = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[nomer] = array[i];
            }
            else
            {
                odd[nomer] = array[i];
                nomer++;
            }
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
            if (array[i] >= 0)
            {
                sum += array[i] * array[i];
            }
            else 
                break;
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
            if (x[i] <= 0)
            {
                y[i] = double.NaN;
            }
            else
            {
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
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
        int m = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[m])
            {
                m = i;
            }
        }
        for (int i = 0; i < m; i++)
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
        double max = array[0];
        int x = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                x = i;
            }
            sum += array[i];
        }
        double sredn = Math.Round(sum / array.Length, 2);
        for (int i = x + 1; i < array.Length; i++)
        {
            array[i] = sredn;
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
        double sredn = Math.Round((array.Sum()) / (array.Length), 2);
        double r = 100000000;
        int k = 0;
        double[] l = new double[array.Length + 1];
        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - sredn) < r)
            {
                r = Math.Abs(array[i] - sredn);
                k = i;
            }

        }
        int x = 0;
        for (int i = 0; i <= array.Length; i++)
        {

            if (i == k + 1)
            {

                l[i] = P;
            }
            else
            {
                l[i] = array[x];
                x++;
            }
        }
        array = l;
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
        double maximum = double.MinValue;
        int maxi = 0;
        for (int i = 0; i < array.Length; i++)
            if (array[i] > maximum)
            {
                maximum = array[i];
                maxi = i;
            }
        double minimum = double.MaxValue; 
        int mini = 0;
        if (maxi == array.Length - 1)
        {
            return array;
        }
            for (int i = maxi + 1; i < array.Length; i++)
        {
            if (array[i] < minimum)
            {
                minimum = array[i];
                mini = i;
            }
        }
        array[mini] = maximum;
        array[maxi] = minimum;
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
        double min = double.MaxValue;
        double[] answer = new double[array.Length - 1];
        int mini = -1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min && array[i] > 0)
            {
                mini = i;
                min = array[i];
            }
        }
        if (mini == -1)
        {
            return array;
        }
            for (int i = 0; i < array.Length; i++)
        {
            if (i < mini)
            {
                answer[i] = array[i];
            }
            else if (i == mini)
            {
                continue;
            }
            else
            {
                answer[i - 1] = array[i];
            }
        }
        array = answer;
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
        int minus = -1;
        double max = double.MinValue, s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (minus == -1 && array[i] < 0) minus = i;
            if (array[i] > max)
            {
                max = array[i];
                s = 0;
                continue;
            }
            else s += array[i];
        }
        if (minus == -1)
        {
            return array;
        }
            array[minus] = Math.Round(s, 2);
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
        int maxi = 0;
        int minus = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (minus == -1 && array[i] < 0) 
                minus = i;
            if (array[i] > array[maxi]) 
                maxi = i;
        }
        if (minus == -1) 
            return array;
        double p = array[maxi];
        array[maxi] = array[minus];
        array[minus] = p;
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
        int n = 0;
        double sredn = 0;
        foreach (double x in array) 
            sredn += x;
        sredn = sredn / array.Length;
        for (int i = 0; i < array.Length; i++) 
            if (array[i] < sredn) n++;
        int[] output = new int[n];
        int p = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sredn)
            {
                output[p] = i;
                p++;
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
        int x = 0, y = 1;
        for (int i = 2; i < array.Length; i += 2)
        {
            if (array[i] > array[x]) x = i;
        }
        for (int i = 3; i < array.Length; i += 2)
        {
            if (array[i] > array[y]) y = i;
        }
        if (array[x] > array[y])
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
        int mini = 0;
        int minus = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (minus == -1 && array[i] < 0)
            {
                minus = i;
            }
            if (array[i] < array[mini])
            {
                mini = i;
            }
            if (!(minus == -1) && minus < mini)
            {
                for (int j = 0; j < array.Length; j += 2)
                {
                    sum += array[j];
                }
                return sum;
            }
        }
        for (int j = 1; j < array.Length; j += 2)
        {
            sum += array[j];
        }
        // end

        return sum;
    }
    #endregion
    #region Level 3
    public int[] Task_3_1(double[] array)
    {
        

        // code here
        int k = 0;
        double m = double.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > m)
            {
                m = array[i];
                k = 1;
            }
            else if (array[i] == m)
            {
                k++;
            }
        }
        int shc = 0;
        int[] output = new int[k];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == m)
            {
                output[shc++] = i;
            }
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
        double x = array[0]; //max el poisk
        // code here
        double s = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > x) 
                x = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == x)
            {
                array[i] = s;
                s += x;
            }
            else
            {
                s += array[i];
            }
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
        double[] list = new double[array.Length];
        // code here
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                list[k++] = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                list[k++] = array[i];
            }
        }
        array = list;
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
        double[] list = new double[array.Length / 2];
        for (int i = 0; i < array.Length / 2; i++)
        {
            list[i] = array[i];
        }
        for (int i = 0; i < array.Length; i += 2)
        {
            array[i] = list[i / 2];
            array[i + 1] = list[i / 2];
        }
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
        int n = 0, s = 0;
        for (int i = array.Length - 2; i >= 0; i--)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] == array[i])
                {
                    array[j] = 1000000;
                    n++;
                }
            }
        }
        double[] list = new double[array.Length - n];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 1000000)
            {
                list[i - s] = array[i];
            }
            else
                s++;
        }
        array = list;
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
