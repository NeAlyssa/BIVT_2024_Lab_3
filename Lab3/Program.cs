using Microsoft.VisualBasic;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
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
        //program.Task_1_1(new double[] { 2, 1, 3, 3, 5, 6 });
        //program.Task_1_13(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, -1.9, 3.9, -0.1 });
        //program.Task_1_15(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, 2, 3.1, -0.7 });
        //program.Task_2_2(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, -1 });
        //program.Task_2_4(new double[] { 0, 1.5, -1, 3, -2.2, -0.5, 2 });
        //program.Task_2_6(new double[] { 0, 1.5, -1, -3, -2.2, -0.5, 6 }, 2.3);
        //program.Task_2_8(new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 });
        program.Task_2_10(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_2_12(new double[] { 2, 1, 3, 3, 5, 6 });
        //program.Task_2_14(new double[] { 2, 1, 3, 3, 5, 6 });
        //program.Task_2_14(new double[] { 2, 1, 3, 3, 5, 6 });
        //program.Task_2_18(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_2_20(new double[] { 12, 1, 3, 3, 5, 6, 3, -4 });
        //program.Task_3_1(new double[] { -1, -2, -8, -1, -9, -1, -1, -4, -6, -2 });
        //program.Task_3_4(new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 10, 10 });
        //program.Task_3_7(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 });
        //program.Task_3_10(new double[] { 0, 1.5, 1, 3, 0, 0, 0, 0 });
        //program.Task_3_13(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double s = 0;
        foreach (double i in array)
        {
            s += i;
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] / s,2);
            
        }
        
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0;
        int l = 0;
        double medium;
        foreach (double i in array)
        {
            if (i > 0)
            {
                s += i;
                l++;
            }
        }
        medium = Math.Round(s / l,2);
        for (int i = 0; i < array.Length;i++)
        {
            if (array[i]>0)
            {
                array[i] = medium;
            }    
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i =0; i <4;i++)
        {
            sum[i] = Math.Round(first[i] + second[i],2);
            dif[i] = Math.Round(first[i] - second[i],2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s = 0;
        double medium;
        foreach (double i in array)
        {
            s += i;
        }
        medium = Math.Round(s / 5, 2);
        for (int i = 0; i < 5; i++)
        {
            array[i] = Math.Round(array[i] - medium,2);
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
        foreach (double i in vector)
        {
            length += i * i;
        }
        length = Math.Round(Math.Sqrt(length),2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        double medium;
        foreach (double i in array)
        {
            s += i;
        }
        medium = Math.Round(s / 7, 2);
        for (int i = 0;i < 7; i++)
        {
            if (array[i] > medium)
                array[i] = 0;
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        foreach (double i in array)
        {
            if (i < 0)
                count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double s = 0;
        double medium;
        foreach (double i in array)
        {
            s += i;
        }
        medium = Math.Round(s / 8, 2);
        foreach (double i in array)
        {
            if (i > medium)
                count++;
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
            if ((i < Q) && (i > P))
                count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        double[] output0 = new double[10];
        int i = 0;
        foreach (double j in array)
        {
            if (j > 0)
            {
                output0[i] = j;
                i++;
            }
        }
        output = new double[i];
        for (int j = 0; j < i; j++)
            output[j] = output0[j];
        
        
        // end

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        // code here
        for (int i = 7; i >= 0; i--)
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
        for (int i = 0; i <10; i++)
        {
            if (i % 2 == 0)
            {
                even[i / 2] = array[i];
            }
            else
            {
                odd[i / 2] = array[i];
            }
            
            
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        foreach ( double i in array)
        {
            if (i < 0)
                break;
            else
                sum += i * i;
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i =0; i < x.Length;i++)
        {
            if (x[i] <= 0)
                y[i] = double.NaN;
            else
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
        }
        for (int i = 0; i < x.Length;i++)
            Console.WriteLine("{0:f2}\t{1:f2}", x[i], y[i]);
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
        double m = 0; int mi = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > m)
            {
                m = array[i];
                mi = i;
            }
        }
        for (int i=0; i < mi; i++)
        {
            sum += array[i];
        }
        Console.WriteLine("Сумма элементов, расположенных до максимального элемента массива:" );
        Console.WriteLine(sum);
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
        double s = 0;
        double medium;
        double m = -10000;
        int mi = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
            if (array[i] > m)
            {
                m = array[i];
                mi = i;
            }
        }
        medium = Math.Round(s / array.Length, 2);

        for (int i = mi + 1; i < array.Length; i++)
        {
            array[i] = medium;
        }
        Console.WriteLine("Изменнёный массив:");
        for (int i = 0; i < array.Length;i++)
            Console.Write(array[i]+" ");
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
        double medium = Math.Round((array.Sum()) / (array.Length), 2);
        double r = 100000;
        int ri = 0;
        double[] listt = new double[array.Length + 1];
        for (int i =0; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - medium) < r)
            {
                r = Math.Abs(array[i] - medium);
                ri = i;
            }
            
        }
        int j = 0;
        for (int i = 0; i<= array.Length; i++)
        {
            
            if (i == ri + 1)
            {
                
                listt[i] = P;
            }
            else
            {
                listt[i] = array[j];
                j++;
            }
        }
        array = listt;
        Console.WriteLine("Изменённый массив:");
        for (int i =0; i< array.Length;i++)
            Console.Write(array[i]+" ");
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
        double max = 0;
        int maxi = 0;
        for (int i=0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxi = i;
            }
        }
        if (maxi != array.Length - 1)
        {
            double min = 100000;
            int mini = 0;
            for (int i = maxi + 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    mini = i;
                }
            }
            array[maxi] = min;
            array[mini] = max;
        }
        for (int i = 0; i < array.Length;i++)
            Console.Write(array[i]+" ");
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
        int mini = 0;
        double min = 10000000;
        for (int i = 0; i < array.Length; i++)
        {
            if ((array[i]>0 )&& (array[i]< min))
            {
                min = array[i];
                mini = i;
            }
        }
        int len = array.Length;
        if (min != 10000000)
        {
            for (int i = mini + 1; i < array.Length; i++)
            {
                array[i-1] = array[i];
            }
            len = array.Length - 1;
        }
        double[] arr = new double[len];
        for (int i = 0; i < len; i++)
            arr[i] = array[i];
        array = arr;
        foreach (double i in array)
            Console.Write(i+" ");
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
        int first = -1;
        double max = -10000;
        int maxi = -1;
        double s = 0;
        for (int i =0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxi = i;
            }
            if ((first == -1) && (array[i] < 0))
                first = i;
        }
        
        for (int i = maxi+1; i < array.Length; i++)
        {
            
            s += array[i];
        }
        if (first!=-1)
            array[first] = Math.Round(s,2);
        Console.WriteLine("Изменённый массив:");
        foreach ( double i in array)
            Console.Write(i+" ");
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
        int maxi = -1;
        double max = -10000;
        for (int i = 0; i < array.Length; i++)
        {
            if ((first == -1) && (array[i]<0))
            {
                first = i;
            }
            if (max< array[i])
            {
                max = array[i];
                maxi = i;
            }
        }
        if (first != -1)
        {
            array[maxi] = array[first];
            array[first] = max;
        }
        Console.WriteLine("Изменённый массив:");
        foreach (double i in array)
            Console.Write(i+" ");
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
        double sr = 0;
        foreach (double i in array)
            sr += i;
        sr = Math.Round(sr / array.Length,2);
        int count = 0;
        foreach (double i in array)
        {
            if (sr > i)
                count++;
        }
        output = new int[count];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr)
            {
                output[j] = i;
                j++;
            }
        }
        Console.WriteLine("Индексы:");
        foreach (double i in output)
            Console.Write(i + " ");
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
        double max0 = -10000;
        double max1 = -10000;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (array[i] > max0)
                    max0 = array[i];
            }
            else
            {
                if (array[i] > max1)
                    max1 = array[i];
            }
        }
        int flag = 0;
        if (max0 < max1)
        {
            for (int i = array.Length / 2; i < array.Length; i++)
                array[i] = 0;
        }
        else
        {
            for (int i = 0; i < array.Length / 2; i++)
                array[i] = 0;
        }
        
        Console.WriteLine("Изменённый массив:");
        foreach (double i in array)
            Console.Write(i + " ");
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
        int first = -1;
        int mini = -1;
        double min = 10000;
        for (int i = 0; i < array.Length; i++)
        {
            if ((array[i] < 0)&&(first == -1))
            {
                first = i;
            }
            if (array[i] < min)
            {
                min = array[i];
                mini = i;
            }
        }
        int flag = 1;
        Console.WriteLine(first);
        Console.WriteLine(mini);
        if ((first<mini)&&(first!=-1))
            flag = 0;
        if (first == -1)
            sum = 0;
        else
        {
            for (int i = flag; i < array.Length; i += 2)
                sum += array[i];
        }
        Console.WriteLine(sum);
        // end

        return sum;
    }
    #endregion
    #region Level 3
    public int[] Task_3_1(double[] array)
    {
        int[] output = null;

        // code here
        double max = -1000;
        int countmax = -1;
        int[] output1 = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            
            if (max == array[i])
            {
                
                countmax++;
                output1[i] = 1;
            }
            else if (max < array[i])
            {
                max = array[i];
                countmax = 1;
                output1 = new int[array.Length];
                output1[i] = 1;
            }
        }
        output = new int[countmax];
        int j = 0;
        for (int i =0; i < array.Length; i++)
        {
            if (output1[i] == 1)
            {
                output[j++] = i;
            }
        }
        
        Console.WriteLine("Индексы:");
        for (int i = 0; i < countmax; i++)
        {
            Console.Write(output[i] + " ");
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
        // code here

        double max = -1000;
        foreach (double x in array)
        {
            if (x > max)
                max = x;
        }
        int countmax = 0;
        int[] output1 = new int[array.Length];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (max == array[i])
            {
                countmax++;
                output1[j] = i;
                j++;
            }
        }
        double[] array1 = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
            array1[i] = array[i];
        for (int i = 0; i < countmax; i++)
        {
            array[output1[i]] = 0;
            for (int i1 = 0; i1 < output1[i]; i1++)
            {
                array[output1[i]] += array1[i1];
                
            }
        }
        Console.WriteLine("Изменённый массив:");
        foreach (double i in array)
            Console.Write(i+" ");
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
        double[] array1 = new double[array.Length];
        double[] array2 = new double[array.Length];
        int j1 = 0;
        int j2 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                array1[j1] = array[i];
                j1++;
            }
            else
            {
                array2[j2] = array[i];
                j2++;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (i < j1)
                array[i] = array1[i];
            else
                array[i] = array2[i - j1];
        }
        Console.WriteLine("Ихменённый массив:");
        foreach (double i in array)
            Console.Write(i+" ");
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
        double[] array1 = new double[array.Length];
        for (int i= 0; i < array.Length/2; i++)
        {
            array1[i*2] = array[i];
            array1[i*2 + 1] = array[i];
        }
        array = array1;
        Console.WriteLine("Дублированный массив:");
        foreach (double i in array)
            Console.Write(i+" ");
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
        double[] array1 = new double[array.Length];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            int flag = 0;
            double a = array[i];
            for (int i1 = 0; i1 < j; i1++)
            {
                
                if (a == array1[i1])
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                array1[j] = array[i];
                j++;
            }
        }
        double[] arrayans = new double[j];
        Console.WriteLine("Массив без повторяющихся элементов:");
        for (int i = 0; i <j;i++)
        {
            Console.Write(array1[i]+" ");
            arrayans[i] = array1[i];
        }
        array = arrayans;
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
