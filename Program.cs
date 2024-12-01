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
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (s == 0)
                return array;
            else
                array[i] = Math.Round(array[i] / s, 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0;
        double cr = 0;
        int c = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                c++;
            }
        }
        cr = Math.Round(s / c, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                array[i] = cr;
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
            double d = Math.Round(first[i] - second[i], 2);
            double s = Math.Round(first[i] + second[i], 2);
            sum[i] = s; dif[i] = d;
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double a = 0;
        for (int i = 0; i < array.Length; i++)
            a += array[i];
        a /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] -= a;
            array[i] = Math.Round(array[i], 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < vector1.Length; i++)
            product += Math.Round(vector1[i] * vector2[i], 2);
        product = Math.Round(product, 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < vector.Length; i++)
            length += vector[i] * vector[i];
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        double sr = 0;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
            count++;
        }
        sr = s / count;
        for (int i = 0; i < array.Length; i++)
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
        foreach (double x in array)
        {
            if (x < 0)
                count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double a = 0;
        for (int i = 0; i < array.Length; i++)
            a += array[i];
        a /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > a)
                count++;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        if (P > Q || P == Q)
            return 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (P < array[i] && array[i] < Q)
                count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int a = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                a++;
        }
        output = new double[a];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[j] = array[i];
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
        double[] odd = new double[array.Length / 2];

        // code here
        for (int i = 0; i < even.Length; i++)
            even[i] = array[i * 2];
        for (int i = 0; i < odd.Length; i++)
            odd[i] = array[(i * 2) + 1];
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
                break;
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

        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        int max = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[max] < array[i])
                max = i;
        }
        for (int e = 0; e < max; e++)
            sum += array[e];
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
        double max = -1000000000000;
        int place = 0;
        double sr = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                place = i;
            }
        }
        for (int j = 0; j < array.Length; j++)
            sr += array[j];
        sr = sr / array.Length;
        for (int y = place + 1; y < array.Length; y++)
            array[y] = Math.Round(sr, 2);
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
        double c = 0;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
            c += array[i];
        c = c / array.Length;
        for (int j = 1; j < array.Length; j++)
        {
            if (Math.Abs(array[j] - c) < Math.Abs(array[index] - c))
                index = j;
        }
        double[] a = new double[array.Length + 1];
        for (int y = 0; y <= index; y++)
            a[y] = array[y];
        a[index + 1] = P;
        for (int u = index + 2; u < a.Length; u++)
            a[u] = array[u - 1];
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
        double max = -10000000;
        int numx = 0;
        double min = 100000000;
        int numn = 0;
        double tr;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                numx = i;

            }
        }
        for (int j = numx + 1; j < array.Length; j++)
        {
            if (array[j] < min)
            {
                min = array[j];
                numn = j;
            }
        }
        if (numx != array.Length - 1)
        {
            tr = array[numx];
            array[numx] = array[numn];
            array[numn] = tr;
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
        int index = -1;
        for (int i = 0; i < array.Length; i++)
            if (array[i] > 0)
            {
                index = i;
                break;
            }
        if (index == -1)
            return array;
        for (int k = 0; k < array.Length; k++)
        {
            if (array[k] > 0 && array[k] < array[index])
                index = k;
        }
        double[] a = new double[array.Length - 1];
        for (int j = 0; j < index; j++)
            a[j] = array[j];
        for (int r = index; r < a.Length; r++)
            a[r] = array[r + 1];
        array = a;
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
        int index = 0;
        int h = 0;
        double sum = 0;
        int min = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[index])
                index = i;
            if (array[i] < 0)
                h++;
        }
        if (h == 0)
            return array;
        for (int j = index + 1; j < array.Length; j++)
            sum += array[j];
        sum = Math.Round(sum, 1);
        for (int r = 0; r < array.Length; r++)
        {
            if (array[r] < 0)
            {
                min = r;
                break;
            }
        }
        array[min] = sum;
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
        int first = -1;
        int max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0 && first == -1)
                first = i;
            if (array[max] < array[i])
                max = i;
        }
        if (first == -1)
            return array;
        (array[first], array[max]) = (array[max], array[first]);
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
        double c = 0;
        int k = 0;
        for (int i = 0; i < array.Length; i++)
            c += array[i];
        c /= array.Length;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] < c)
                k++;
        }
        output = new int[k];
        for (int r = 0, t = 0; r < array.Length; r++)
        {
            if (array[r] < c)
            {
                output[t] = r;
                t++;
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
        int maxe = 0;
        int maxo = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[maxe] < array[i])
                maxe = i;
        }
        for (int i = 1; i < array.Length; i += 2)
        {
            if (array[maxo] < array[i])
                maxo = i;
        }
        if (array[maxe] >= array[maxo])
        {
            for (int i = 0; i < array.Length / 2; i++)
                array[i] = 0;
        }
        else
        {
            for (int i = array.Length / 2; i < array.Length; i++)
                array[i] = 0;
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

        double min = double.MaxValue;
        int index1 = 0;
        int index2 = 0;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                index1 = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
                count++;
        }
        if (count == 0)
        {
            for (int j = 1; j < array.Length; j += 2)
                sum += array[j];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                index2 = i;
                if (index2 < index1 && count != 0)
                {
                    for (int j = 0; j < array.Length; j += 2)
                        sum += array[j];
                }
                else
                {
                    for (int j = 1; j < array.Length; j += 2)
                        sum += array[j];
                }
                break;
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
        if (array.Length == 0)
            return output;
        double max = array[0] - 1;
        int count = 0;
        int[] temp = new int[array.Length];
        for (int i = 0; i < array.Length; ++i)
        {
            if (array[i] > max)
            {
                max = array[i];
                temp[0] = i;
                count = 1;
            }
            else if (array[i] == max)
            {
                temp[count] = i;
                ++count;
            }
        }
        output = new int[count];
        for (int j = 0; j < count; ++j)
            output[j] = temp[j];
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
        int index = 0;
        double max = double.MinValue;
        double[] new_array = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            new_array[i] = array[i];
            if (array[i] > max)
            {
                index = i;
                max = array[i];
            }
        }
        double sum = 0;
        for (int j = 0; j < array.Length; j++)
        {
            if (new_array[j] == max)
            {
                if (j != 0)
                {
                    sum = 0;
                    for (int k = 0; k < j; k++)
                        sum += new_array[k];
                    array[j] = sum;
                }
                else
                    array[j] = 0;
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
        // code here
        int p = 0;
        int o = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
                p++;
            else
                o++;
        }
        double[] P = new double[p];
        double[] O = new double[o];
        int q = 0;
        int w = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                P[q++] = array[i];
            }
            else
                O[w++] = array[i];
        }
        for (int i = 0; i < p; i++)
            array[i] = P[i];
        for (int i = 0; i < o; i++)
            array[i + p] = O[i];
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
        double[] t = new double[array.Length];
        for (int i = 0; i < array.Length / 2; ++i)
        {
            t[2 * i] = array[i];
            t[(2 * i) + 1] = array[i];
        }
        array = t;
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
        int count = 0;
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            bool flag = true;
            for (int j = 0; j < i; j++)
            {
                if (array[i] == array[j])
                {
                    flag = false;
                    break;
                }
            }
            if (flag == true)
                count++;
        }
        double[] a = new double[count];
        for (int i = 0; i < array.Length; i++)
        {
            bool flag = true;
            for (int j = 0; j < i; j++)
            {
                if (array[i] == array[j])
                {
                    flag = false;
                    break;
                }
            }
            if (flag == true)
                a[k++] = array[i];
        }
        array = a;
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
