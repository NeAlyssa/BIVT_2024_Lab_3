using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
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
        for (int i = 0; i < 6; i++)
        {
            s += array[i];
        }
        if (s != 0)
        {
            for (int i = 0; i < 6; i++)
            {
                array[i] = Math.Round(array[i] / s, 2);
            }
        }
        for (int i = 0; i < 6; i++)
            Console.Write(" ", array[i]);

        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0, r = 0;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                r += 1;
            }
        }
        s = s / r;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                array[i] = Math.Round(s, 2);
            }
        }
        for (int i = 0; i < 8; i++)
            Console.Write(" ", array[i]);

        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        double s = 0, r = 0;
        for (int i = 0; i < 4; i++)
        {
            sum[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = Math.Round(first[i] - second[i], 2);
        }
        for (int i = 0; i < 4; i++)
            Console.Write(" ", sum[i]);
        for (int i = 0; i < 4; i++)
            Console.Write(" ", dif[i]);
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s = 0;
        for (int i = 0; i < 5; i++)
        {
            s += array[i];
        }
        s = s / 5;
        for (int i = 0; i < 5; i++)
        {
            array[i] = Math.Round(array[i] - s, 2);
        }
        for (int i = 0; i < 5; i++)
            Console.Write(" ", array[i]);
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
        Console.WriteLine(product);
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
        Console.WriteLine(length);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        for (int i = 0; i < 7; i++)
        {
            s += array[i];
        }
        s = s / 7;
        for (int i = 0; i < 7; i++)
        {
            if (array[i] > s)
            {
                array[i] = 0;
            }
        }
        // end
        for (int i = 0; i < 7; i++)
            Console.Write(" ", array[i]);

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        for (int i = 0; i < 6; i++)
        {
            if (array[i] < 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double s = 0;
        for (int i = 0; i < 8; i++)
        {
            s += array[i];
        }
        s = s / 8;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > s)
            {
                count++;
            }
        }
        Console.WriteLine(count);
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > P & array[i] < Q)
            {
                count++;
            }
        }
        Console.WriteLine(count);
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int h = 0, c = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                c++;
            }
        }
        double[] result = new double[c];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                result[h] = array[i];
                h++;
            }
        }
        output = result;
        for (int i = 0; i < 5; i++)
            Console.Write(" ", output[i]);
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
        Console.WriteLine(value);
        Console.WriteLine(index);
        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length];
        double[] odd = new double[array.Length];

        // code here
        int ii = 0, iii = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[ii] = array[i];
                ii++;
            }
            else if (i % 2 != 0)
            {
                odd[iii] = array[i];
                iii++;
            }
        }
        for (int i = 0; i < 10; i++)
            Console.Write(" ", even[i]);
        for (int i = 0; i < 10; i++)
            Console.Write(" ", odd[i]);
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i < 11; i++)
        {
            if (array[i] > 0)
            {
                sum += array[i] * array[i];
            }
            else if (array[i] < 0)
            {
                break;
            }
        }
        Console.WriteLine(sum);
            // end

            return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i = 0; i < 10; i++)
        {
            if (x[i] > 0)
            {
                y[i] = 0.5 * Math.Log(x[i]);
            }
            else
            {
                y[i] = double.NaN;
            }
        }
        for (int i = 0; i < 10; i++)
        {
            x[i] = Math.Round(x[i], 2);
            y[i] = Math.Round(y[i], 2);
            Console.WriteLine("x = {0} \t y = {1}", x[i], y[i]);
        }

        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        int s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < array[s])
            {
                s = i;
            }
        }
        array[s] *= 2;
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(" ", array[i]);
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
        int s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < array[s])
            {
                s = i;
            }
        }
        for (int i = 0; i < s; i++)
        {
            if (array[i] < 0)
            {
                array[i] -= array[i] / 2;
            }
            else
            {
                array[i] *= 2;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(" ", array[i]);
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
        int min = 0, max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < array[min])
            {
                min = i;
            }
            if (array[i] > array[max])
            {
                max = i;
            }
        }
        int start = Math.Min(max, min) + 1;
        int end = Math.Max(max, min);
        int d = end - start;
        double[] ot = new double[d];
        int a = 0;
        for (int i = start; i < end; i++)
        {
            if (array[i] < 0)
            {
                ot[a] = array[i];
                a++;
            }
            else
            {
                ot[a] = 0;
            }
        }
        array = ot;
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(" ", array[i]);
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
        int s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[s])
            {
                s = i;
            }
        }
        if (s < array.Length - 1)
        {
            if (array[s + 1] < 0)
            {
                array[s + 1] -= array[s + 1] / 2;
            }
            else
            {
                array[s + 1] *= 2;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(" ", array[i]);
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
        int min = 0, max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < array[min])
            {
                min = i;
            }
            if (array[i] > array[max])
            {
                max = i;
            }
        }
        int start = Math.Min(max, min) + 1;
        int end = Math.Max(max, min);
        int d = end - start;
        double s = 0;
        if (d != 0)
        {
            for (int i = start; i < end; i++)
            {
                s += array[i];
            }
            average = Math.Round(s / d, 2);
        }
        Console.WriteLine(array);
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
        int s = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                s = i;
            }
        }
        if (s != -1)
        {
            double[] newArray = new double[array.Length + 1];
            for (int i = 0; i <= s; i++)
            {
                newArray[i] = array[i];
            }
            newArray[s + 1] = P;
            if (s != array.Length)
            {
                for (int i = s + 1; i < array.Length; i++)
                {
                    newArray[i + 1] = array[i];
                }
            }
            array = newArray;
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(" ", array[i]);
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
        int s = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > array[s])
            {
                s = i;
            }
        }
        array[s] = s;
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(" ", array[i]);
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
        double[] output = null;

        // code here
        double[] Array = new double[A.Length + B.Length];
        if (k < 0 || k >= A.Length)
        {
            output = A;
        }
        else
        {
            for (int i = 0; i <= k; i++)
            {
                Array[i] = A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                Array[k + i + 1] = B[i];
            }
            for (int i = k + 1; i < A.Length; i++)
            {
                Array[B.Length + i] = A[i];
            }
            output = Array;
        }
        for (int i = 0; i < output.Length; i++)
        {
            Console.Write(" ", output[i]);
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
        int min = 0, max = 0;
        double s = 0, c = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < array[min])
            {
                min = i;
            }
            if (array[i] > array[max])
            {
                max = i;
            }
        }
        if (max < min)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    s += array[i];
                    c++;
                }
            }
            if (c > 0) 
            { 
                average = s / c;
            }
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    s += array[i];
                    c++;
                }
            }
            if (c > 0)
            {
                average = s / c;
            }
        }
        average = Math.Round(average, 2);
        Console.WriteLine(average);
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
        int max = 0;
        double s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[max])
            {
                max = i;
            }
            s += array[i];
        }   
        if (array[max] > s)
        {
            array[max] = 0;
        }
        else
        {
            array[max] *= 2;
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(" ", array[i]);
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
        double max = double.MinValue, c = 0;
        int g = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                c = i;
                g = 1;
            }
            else if (array[i] == max)
            {
                g++;
            }
        }
        int[] a = new int[g];
        g = 0;  
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                a[g] = i;
                g++;
            }
        }
        output = a;
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
        double max = double.MinValue, sum = 0, c = 0, g;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                c = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                g = array[i];
                array[i] = sum;
                sum += g;
            }
            else
            {
               sum += array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(" ", array[i]);
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
        int n = array.Length;
        int a = array.Length - 1;
        for (int i = n - 1; i >= 0; i--)
        {
            if (array[i] < 0)
            {
                (array[i], array[a]) = (array[a], array[i]);
                a--;
            }
        }
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
        int n = array.Length - 1;
        int a = n / 2;
        for (int i = n; i >= 0; i -= 2)
        {
            array[i] = array[a];
            array[i - 1] = array[a];
            a--;
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
        double inf = 1e18;
        int c = 0, a = 0;
        for (int i = 0; i < array.Length; i++)
        {
            bool flag = false;
            for (int j = i - 1; j >= 0; j--)
            {
                if (array[i] == array[j])
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                array[i] = 1e18;
            }
            else 
            {
                c++;
            }
        }
        double[] new_arr = new double[c];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == inf)
            {
                continue;
            }
            new_arr[a] = array[i];
            a++;
        }
        array = new_arr;
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
