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
        program.Task_2_6(new double[] { 0, 1.5, -1, -3, -2.2, -0.5, 6 }, 2.3);
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double s = 0;
        foreach(double x in array)
        { 
            s += x;
        }
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] / s, 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double k = 0, s = 0;
        foreach(double x in array)
        {
            if(x > 0)
            {
                s += x;
                k++;
            }
        }
        double sr = Math.Round(s / k, 2);
        for(int i = 0; i < array.Length; i++)
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
        for(int i = 0; i < sum.Length; i++)
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
        for(int i = 0; i < 5; i++)
        {
            s += array[i];
        }
        double sr = Math.Round(s / 5, 2);
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
        for(int i = 0; i < 4; i++)
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
        double s = 0;
        for(int i = 0; i < 5; i++)
        {
            s += vector[i] * vector[i];
        }
        length = Math.Round(Math.Sqrt(s), 2);
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
        double sr = Math.Round(s/7, 2);
        for(int i = 0; i < 7; i++)
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
            if (x < 0) count++;
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
        double sr = Math.Round(s / 8, 2);
        foreach(double x in array)
        {
            if (x > sr) count++;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        foreach(double x in array)
        {
            if(x > P && x < Q) count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = new double[10];
        int k = 0;
        // code here
        foreach(double x in array)
        {
            if(x > 0)
            {
                output[k] = x;
                k++;
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
        for(int i = 0; i < 8; i++)
        {
            if (array[i] < 0)
            {
                index = i;
                value = array[i];
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
        int k = 0, m = 0;
        for(int i = 0; i < 10; i++)
        {
            if(i % 2 == 0)
            {
                even[k] = array[i];
                k++;
            }
            else
            {
                odd[m] = array[i];
                m++;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for(int i = 0; i < 11; i++)
        {
            if (array[i] >= 0)
            {
                sum += array[i] * array[i];
            }
            else break;
        }
        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        double lg = 0;
        int i = 0;
        foreach(double ch in x)
        {
            if (ch > 0)
            {
                lg = Math.Log(ch);
                y[i] = Math.Round(0.5 * lg,2);
            }
            else y[i] = double.NaN;
            i++;
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
        double amax = array[0];
        int imax = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
        }
        double s = 0;
        for(int i = 0; i < imax; i++)
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
        double amax = array[0];
        int imax = 0;
        double s = array[0];
        for(int i = 1; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                imax = i;
                amax = array[i];
            }
            s += array[i];
        }
        double sr = Math.Round(s/array.Length, 2);
        Console.WriteLine();
        for(int j = imax + 1; j < array.Length; j++)
        {
            array[j] = sr;
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
        double s = 0;
        foreach(double x in array)
        {
            s += x;
        }
        double sr = Math.Round(s/array.Length, 2);
        double dif = 1000000000000;
        int imax = -1;
        for(int i = 0; i < array.Length; i++)
        {
            if(Math.Abs(array[i] - sr) < dif)
            {
                dif = Math.Abs(array[i] - sr);
                imax = i;
            }

        }
        int k = array.Length + 1;
        double[] n = new double[k];
        k = 0;
        for(int i = 0; i <= imax; i++)
        {
            n[k] = array[i];
            k++;
        }
        n[imax + 1] = P;
        for (int i = imax+1; i < array.Length; i++)
        {
            n[k+1] = array[i];
            k++;
        }
        array = n;
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
        double amax = array[0];
        int imax = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] >= amax)
            {
                amax = array[i];
                imax = i;
            }
        }
        if (imax +1 != array.Length)
        {
            double amin = array[imax + 1];
            int imin = imax + 1;
            for (int j = imax + 2; j < array.Length; j++)
            {
                if (array[j] <= amin)
                {
                    amin = array[j];
                    imin = j;
                }
            }
            array[imax] = amin;
            array[imin] = amax;
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
        double amin = 100000000000000000;
        int imin = 0, k = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && array[i] < amin)
            {
                amin = array[i];
                imin = i;
            }
            if (array[i] < 0) k++;
        }
        if (k != array.Length)
        {
            for (int j = imin; j < array.Length - 1; j++)
            {
                array[j] = array[j + 1];
            }
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
        double amax = array[0];
        int imax = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
        }

        int iotr = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                iotr = i;
                break;
            }
        }

        double s = 0;
        if (imax + 1 != array.Length)
        {
            for (int j = imax + 1; j < array.Length; j++)
            {
                s += array[j];
            }
            array[iotr] = Math.Round(s, 2);

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
        double amax = -100000000000000;
        int imax = -1;
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
            if (array[i] > 0) k++;
        }

        int iotr = -1;
        double aotr = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                iotr = i;
                aotr = array[i];
                break;
            }
        }
        if (k != array.Length)
        {
            array[imax] = aotr;
            array[iotr] = amax;
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
        double s = 0;
        foreach(double x in array)
        {
            s += x;
        }
        double sr = s/array.Length;
        int k = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr)
            {
                k++;
            }
        }
        output = new int[k];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr)
            {
                output[j] = i;
                Console.WriteLine(i);
                j++;
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
        double amax2 = array[0];
        for (int i = 0; i < array.Length; i+=2)
        {
            if (array[i] > amax2)
            {
                amax2 = array[i];
            }
        }

        double amax1 = array[1];
        for (int i = 1; i < array.Length; i += 2)
        {
            if (array[i] > amax1)
            {
                amax1 = array[i];
            }
        }
        if (amax2 > amax1)
        {
            for(int i = 0; i < array.Length/2; i++)
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

        for(int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
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
        int iotr = 0, k = 0;
        for(int i = 0; i < array.Length; i ++)
        {
            if (array[i] < 0)
            {
                iotr = i;
                k++;
                break;
            }
        }

        int imin = 0;
        double amin = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < amin)
            {
                amin = array[i];
                imin = i;
            }
        }
        if (k != 0)
        {
            if(iotr < imin)
            {
                for(int i = 0; i < array.Length;i += 2)
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
        }        // end

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
        double amax = array[0];
        int imax = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
        }

        double a, b;
        if(imax >= 2)
        {
            if (imax % 2 == 0)
            {
                for (int i = 0; i < imax; i += 2)
                {
                    a = array[i];
                    b = array[i + 1];
                    array[i] = b;
                    array[i + 1] = a;
                }
            }
            else
            {
                for (int i = 0; i < imax-1; i += 2)
                {
                    a = array[i];
                    b = array[i + 1];
                    array[i] = b;
                    array[i + 1] = a;
                }
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
        int k = 1;
        for(int i = 0; i < array.Length-1; i++)
        {
            if(array[i] > array[i+1])
            {
                k += 1;
                if (k > count)
                {
                    count = k;
                }
            }
            else
            {
                k = 1;
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
        int count1 = 0;
        int k = 1;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                k ++;
                if (k > count1)
                {
                    count1 = k;
                }
            }
            else
            {
                k = 1;
            }
        }

        int m = 1;
        int count2 = 0;
        for (int i = 0; i < array.Length-1; i++)
        {
            if (array[i] < array[i + 1])
            {
                m ++;
                if (m > count2)
                {
                    count2 = m;
                }
            }
            else
            {
                m = 1;
            }
        }

        if(count1 > count2)
        {
            count = count1;
        }
        else
        {
            count = count2;
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
        int k = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) k++;
        }

        if(k != 0)
        {
            double[] newarray = new double[array.Length - k];
            int m = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] >= 0)
                {
                    newarray[m] = array[i];
                    m++;
                }
            }
            array = newarray;
        }
        else
        {
            double[] newarray = new double[0];
            array = newarray;
        }
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
