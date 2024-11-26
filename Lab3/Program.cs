using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
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
        foreach (double x in array) {
            s += x;
        }
        for(int i = 0; i <= 5; ++i)
        {
            array[i] = Math.Round(array[i] / s , 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0;
        double count = 0;
        for (int i = 0; i <= 7; ++i)
        {
            if (array[i] > 0)
            {
                s += array[i];
                count++;
            }
        }
        s /= count;
        for (int i = 0; i <= 7; ++i)
        {
            if (array[i] > 0)
                array[i] = Math.Round(s, 2);
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0;i < 4; ++i)
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
        double s = 0;
        for (int i = 0;i < 5; ++i)
        {
            s += array[i];
        }
        s /= 5;
        Math.Round(s, 2);
        for(int i = 0; i < 5; ++i)
        {
            array[i] = Math.Round(array[i] - s, 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i <= 3; ++i)
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
        for (int i = 0; i <= 4; ++i)
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
        double s = 0;
        for (int i = 0; i < 7; ++i)
        {
            s += array[i];
        }
        s /= 7;
        for(int i = 0;i < 7; ++i)
        {
            if(s < array[i])
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
        for (int i = 0; i < 6; ++i)
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
        double s = 0;
        for (int i = 0; i < 8; ++i)
        {
            s += array[i];
        }
        s /= 8;
        for (int i = 0; i < 8; ++i)
        {
            if (array[i] > s)
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
        for (int i = 0; i < 10; ++i)
        {
            if ((array[i] > P) & (array[i] < Q))
            {
                count++;
            }
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = new double[10];

        // code here
        int count = 0;
        for (int i = 0; i < 10; ++i)
        {
            if (array[i] > 0)
            {
                count++;
            }
        }
        output = new double[count];
        count = 0;
        for (int i = 0; i < 10; ++i)
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
        for (int i = 0; i < 8; ++i)
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
        for (int i = 0;i < 10; ++i)
        {
            if (i % 2 == 0)
            {
                even[i / 2] = array[i];
            }
            else
            {
                odd[(i - 1) / 2] = array[i];
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0;i < 11; ++i)
        {
            if(array[i] < 0)
            {
                break;
            }
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
        for (int i = 0; i < 10; ++i)
        {
            y[i] = Math.Round(Math.Log(x[i],Math.E) * 0.5,2);
            if (y[i] == double.NegativeInfinity)
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
        double min = double.MaxValue;
        int nom = 0;
        for (int i = 0; i < array.Length; ++i)
        {
            if (array[i] < min)
            {
                min = array[i];
                nom = i;
            }
        }
        if (array[nom] > 0)
        {
            array[nom] *= 2;
        }
        else
        {
            array[nom] /= 2;
        }
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
        double min = double.MaxValue;
        int nom = 0;
        for (int i = 0; i < array.Length; ++i)
        {
            if (array[i] < min)
            {
                min = array[i];
                nom = i;
            }
        }
        for (int i = 0; i < nom; ++i)
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
        double min = double.MaxValue;
        double max = double.MinValue;
        int index1 = 0;
        int index2 = 0;
        int count = 0;
        double [] s = new double[array.Length];
        s = array;
        for (int i = 0; i < array.Length; ++i)
        {
            if (array[i] < min)
            {
                min = array[i];
                index1 = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                index2 = i;
            }
        }
        if (index1 > index2)
        {
            int p = index2;
            index2 = index1;
            index1 = p;
        }
        for (int i = index1 + 1; i < index2; ++i)
        {
            if (s[i] < 0)
            {
                count++;
            }
        }
        array = new double[count];
        count = 0;
        for (int i = index1 + 1;i < index2; ++i)
        {
            if (s[i] < 0)
            {
                array[count] = s[i];
                count++;
            }
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
        double max = double.MinValue;
        int index1 = 0;
        for (int i = 0;i < array.Length; ++i)
        {
            if (array[i] > max)
            {
                max = array[i];
                index1 = i;
            }
        }
        if (index1 != array.Length - 1)
        {
            if (array[index1 + 1] > 0)
            {
                array[index1 + 1] *= 2;
            }
            else {
                array[index1 + 1] /= 2;
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
        double min = double.MaxValue;
        double max = double.MinValue;
        int index1 = 0;
        int index2 = 0;
        int count = 0;
        double sum = 0;
        for (int i = 0; i < array.Length; ++i)
        {
            if (array[i] < min)
            {
                min = array[i];
                index1 = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                index2 = i;
            }
        }
        if (index1 > index2)
        {
            int p = index2;
            index2 = index1;
            index1 = p;
        }
        for (int i = index1 + 1; i < index2; ++i)
        {
            sum += array[i];
        }
        if (index2 - index1 > 1)
        {
            average = sum / (index2 - index1 - 1);
        }
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
        double[] array1 = new double[array.Length + 1];
        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                index = i;
        }
        if (index != -1)
        {
            for (int i = 0; i <= index; ++i)
            {
                array1[i] = array[i];
            }
            array1[index + 1] = P;
            for (int i = index + 1;i < array.Length; i++)
            {
                array1[i + 1] = array[i];
            }
            array = array1;
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
        int index = 0;
        double max = double.MinValue;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > max)
            {
                index = i;
                max = array[i];
            }
        }
        array[index] = index;
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
        double[] output = new double[A.Length + B.Length];

        // code here
        if (k  < A.Length)
        {
            for (int i = 0; i <= k; i++)
            {
                output[i] = A[i];
            }
            for (int i = 0;i <  B.Length; i++)
            {
                output[i+k+1] = B[i];
            }
            for (int i = k + 1; i < A.Length; i++)
            {
                output[i + B.Length] = A[i];
            }
        }
        else
        {
            output = A;
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

        double s_p = 0;
        double s_o = 0;
        double c = 0;
        double c1 = 0;
        double min1 = double.MaxValue;
        double max1 = double.MinValue;
        double smax = 0;
        double smin = 0;
        for (int i = 0;i < array.Length; ++i)
        {
            if (array[i] > max1) 
            {
                max1 = array[i];
                smax = i;
            }
            if (array[i] < min1)
            {
                min1 = array[i];
                smin = i;
            }
            if (array[i] > 0)
            {
                s_p += array[i];
                c++;
            }
            if (array[i] < 0)
            {
                s_o += array[i];
                c1++;
            }
        }
        if (smax < smin)
        {
            if(c > 0)
            {
                average = s_p / c;
            }
            else
            {
                average = 0;
            }
        }
        else
        {
            if (c1 > 0)
            {
                average = s_o / c1;
            }
            else
            {
                average = 0;
            }
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
        int index = 0;
        double s = 0;
        double max = double.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index = i;
            }
            s += array[i];
        }
        if (array[index] > s)
            array[index] = 0;
        else
            array[index] *= 2;
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
        double count = 1;
        double max = double.MinValue;
        for(int i = 0;i < array.Length; ++i)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        for (int i = 0;i < array.Length; ++i)
        {
            if (array[i] == max)
            {
                array[i] += count;
                count++;
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
        double p = 0;
        for (int i = 0;i < array.Length; i += 2)
        {
            for (int j = i + 2; j < array.Length;j += 2)
            {
                if (array[j] < array[i])
                {
                    p = array[j];
                    array[j] = array[i];
                    array[i] = p;
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
        double p = 0;
        for (int i = 0; i < array.Length; ++i)
        {
            if (array[i] < 0)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[i] && array[j] < 0)
                    {
                        p = array[j];
                        array[j] = array[i];
                        array[i] = p;
                    }
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
        double[] X = new double[n];
        double[] Y = new double[n];
        double globalMax = 0, globalMin = 0;

        // code here
        double per = 0;
        double max = double.MinValue;
        double min = double.MaxValue;
        for (int i = 0; i < n; i++)
        {
            X[i] = a + i * (b - a) / (n - 1);
            per = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
            Y[i] = Math.Round(per, 2);

        }
        for (int i = 0; i < X.Length; i++)
        {
            if (Y[i] > max)
            {
                max = Y[i];
            }
        }
        for (int i = 0; i < X.Length; i++)
        {
            if (Y[i] < min)
            {
                min = Y[i];
            }
        }
        globalMax = max;
        globalMin = min;
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
        double[] normalizedArray = new double[array.Length];

        // code here
        int max = 0, min = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[max])
            {
                max = i;
            }
            if (array[i] < array[min])
            {
                min = i;
            }
        }
        double k = 2 / (array[max] - array[min]);
        for (int i = 0; i < array.Length; i++)
        {
            normalizedArray[i] = Math.Round((array[i] - array[min]) * k - 1, 2);
        }
        // end

        return normalizedArray;
    }
    #endregion
}
