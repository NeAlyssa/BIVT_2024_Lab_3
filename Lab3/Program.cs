using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;
using System.Xml.Schema;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_1(new double[] {1, 2, 3, 4, 5, 6});
        //program.Task_1_2(new double[] { 1, 2, -3, 4, -5, 6, 7, 8 });
        //program.Task_1_3(new double[] { 1, 2, -3, 4, -5, 6, 7, 8 }, new double[] { 1, 2, -3, 4, -5, 6, 7, 8 });
        //program.Task_1_4(new double[] { 1, 2, -3, 4, -5, 6, 7, 8 });
        //program.Task_1_5(new double[] { 1, 2, -3, 4}, new double[] { 1, 2, -3, 4});
        //program.Task_1_6(new double[] {1, 2, 3, 4, 5});
        //program.Task_1_7(new double[] { 1, 2, -3, 4, -5, 6, 7});
        //program.Task_1_8(new double[] { 1, 2, -3, 4, -5, 6 });
        //rogram.Task_1_9(new double[] { 1, 2, -3, 4, -5, 6, 7, 9 });
        //program.Task_1_10(new double[] { 1, 2, 3, 4, 5, 6, 7, 9, 10 }, 2, 7);
        //program.Task_1_11(new double[] { 1, 2, 3, 4, 5, 6, 7, 9, 10 });
        //program.Task_1_12(new double[] { 1, 2, 3, 4, 5, 6, 7, 9, 10 });
        //program.Task_1_12(new double[] { 1, 2, 3, 4, 5, 6, 7, 9, 10 });
        //program.Task_1_13(new double[] { 1, 2, 3, 4, 5, 6, 7, 9, 10 });
        //program.Task_1_13(new double[] { 1, 2, 3, 4, 5, 6, 7, 9, 10 });
        //program.Task_1_14(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, -1, 2, 2.5, -1.4 });
        //program.Task_1_15(new double[] { 1, 2, 3, 4, 5, 6, 7, 9, 10 });
        //program.Task_2_1(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_2_2(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_2_4(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_2_6(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 }, 100);
        //program.Task_2_10(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_2_12(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_2_18(new double[] { 15, 2, 8, 1, 9, 3, 7, 4, 6, 10 });
        //program.Task_2_20(new double[] { 2, 1, 3, 3, 5, 6, 3, 4 });
        //program.Task_3_3(new double[] { 2, 1, 3, 3, 5, 6, 3, 4 });
        //program.Task_3_6(new double[] { -5, -2, -8, -1, -9, -3, -2, -4, -6, -2 });
        program.Task_3_9(new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 });

    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        double sm = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sm += array[i];
        }
        Console.WriteLine(sm);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] / sm, 2);
            Console.Write($"{array[i]} ");
        }

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        double smsr = 0;
        int q = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) { smsr += array[i]; q++; }
        }
        double avzn = Math.Round(smsr / q, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) { array[i] = avzn; }
            Console.Write($"{array[i]} ");
        }


        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];
        for (int i = 0; i < first.Length; i++)
        {
            sum[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = Math.Round(first[i] - second[i], 2);

        }

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        double sm = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sm += array[i];
        }
        double avzn = Math.Round(sm / array.Length, 2);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round((array[i] - avzn), 2);
            Console.Write($"{array[i]} ");
        }

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        for (int i = 0; i < vector1.Length; i++)
        { product += (vector1[i] * vector2[i]); }
        product = Math.Round(product, 2);

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        for (int i = 0; i < vector.Length; i++) { length += vector[i] * vector[i]; }
        length = Math.Sqrt(length);
        return Math.Round(length, 2);
    }
    public double[] Task_1_7(double[] array)
    {
        double sm = 0;
        for (int i = 0; i < array.Length; i++) { sm += array[i]; }
        double sr = Math.Round(sm / array.Length, 2);
        for (int i = 0; i < array.Length; i++) if (array[i] > sr) { array[i] = 0; }
        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++) if (array[i] < 0) { count++; }
        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;
        double sm = 0;
        for (int i = 0; i < array.Length; i++) sm += array[i];
        double sr = (sm / array.Length);
        for (int i = 0; i < array.Length; i++) if (array[i] > sr) { count++; }
        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        for (int i = 0; i < array.Length; i++) if ((array[i] > P) && (array[i] < Q)) { count++; }
        Console.WriteLine(count);
        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;
        int c = 0;
        for (int i = 0; i < array.Length; i++) if (array[i] > 0) { c++; }
        output = new double[c];
        int j = 0;
        for (int i = 0; i < array.Length; i++) if (array[i] > 0) { output[j] = array[i]; j++; }

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) { value = array[i]; index = i; }
        }

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length / 2];
        int j1 = 0, j2 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0) { even[j1] = array[i]; j1++; }
            else { odd[j2] = array[i]; j2++; }
        }



        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;
        int i = 0;
        double tz = array[i];
        while (tz >= 0 && i < array.Length)
        {
            
            sum += tz*tz;
            i++;
            if (i >= array.Length) break;
            tz = array[i];
           

        }
        Console.WriteLine(sum);

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] > 0) 
            { 
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2); 
            }
            else y[i] = double.NaN;
            Console.WriteLine($"{x[i]} {y[i]}");
        }
        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        double maxz = double.MinValue;
        int mi = -1;
        for (int i = 0; i < array.Length; i++) if (array[i] > maxz) { maxz = array[i]; mi = i;}
        for(int i = 0; i < mi; i++) { sum += array[i]; }

        return sum;
    }
    public double[] Task_2_3(double[] array)
    {
        return array;
    }
    public double[] Task_2_4(double[] array)
    {
        double sum = 0;
        double maxz = double.MinValue;
        int mi = -1;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            if (array[i] > maxz) { maxz = array[i]; mi = i; }
        }
        double srzn = Math.Round(sum/ array.Length, 2);
        for (int i = mi + 1; i < array.Length; i++) { array[i] = srzn; }

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
        double sum = 0;
        for (int i = 0; i < array.Length; i++) sum += array[i];
        double srzn = sum / array.Length;
        double mindif = double.MaxValue;
        int ni = -1;
        for (int i = 0; i < array.Length; i++)
        {
            double dif = Math.Abs(array[i] - srzn);
            if (dif < mindif) { mindif = dif; ni = i;}

        }
        double[] narray = new double[array.Length + 1];
        narray[ni+1] = P;
        for (int i = 0; i <= ni ; i++) {narray[i] = array[i]; }
        for (int i = ni+1; i < array.Length; i++) {narray[i+1] = array[i]; }
        array = narray;
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
        
        double minzn = double.MaxValue, maxzn = double.MinValue;
        int mini = -1, maxi = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxzn) { maxzn = array[i]; maxi = i; }
        }
        for (int i = maxi; i < array.Length; i++) if (array[i] < minzn) { minzn = array[i]; mini = i; }
        array[mini] = maxzn;
        array[maxi] = minzn;
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
        double nz = double.MaxValue;
        int nzi = -1;
        for (int i = 0; i < array.Length; i+=1)
        {
            if ((array[i] > 0) && (array[i] < nz))
            {
                nz = array[i];
                nzi = i;
            }

        }
        if (nzi < 0)
        {
            for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
            return array;
        }
        if (nzi < 0) return array;
        double[] narray = new double[array.Length-1];
        for (int i = 0; i < array.Length; i++)
        {
            if ((i != nzi)&&(i < nzi))
            {
                narray[i] = array[i];
            }
            if ((i != nzi) && (i > nzi))
            {
                narray[i-1] = array[i];
            }
        }
        
        array = narray;
        for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
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
        double pol = double.MaxValue;
        int poli = -1;
        double maxv = double.MinValue;
        int maxvi = -1;
        for (int i = 0; i < array.Length; i++) if (array[i] < 0) { pol = array[i];  poli = i; break; }
        if (poli < 0) { for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} "); return array; }
        for (int i = 0; i < array.Length; i++) if (array[i] > maxv) { maxv = array[i]; maxvi = i; }
        double s = 0;
        for (int i = maxvi + 1; i < array.Length; i++) { s += array[i]; }
        
        array[poli] = Math.Round(s, 2);
        for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
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
        double pol = double.MaxValue;
        int poli = -1;
        double maxv = double.MinValue;
        int maxvi = -1;
        for (int i = 0; i < array.Length; i++) if (array[i] < 0) { pol = array[i]; poli = i; break; }

        if (poli < 0) { for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} "); return array; }

        for (int i = 0; i < array.Length; i++) if (array[i] > maxv) { maxv = array[i]; maxvi = i; }
        array[poli] = maxv;
        array[maxvi] = pol;

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
        double s = 0;
        for (int i = 0; i < array.Length; i++) s+= array[i];
        double sr = (s /array.Length);
        int j = 0;
        int q = 0;
        for (int i = 0; i < array.Length; i++) if (array[i] < sr) { q++; }
        output = new int[q];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr) { output[j] = i; j++; }
        }

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
        double max1 = double.MinValue; double max2 = double.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (array[i] > max1) { max1 = array[i]; }
            }
            else
            {
                if (array[i] > max2) { max2 = array[i]; }
            }
        }

        Console.WriteLine($"{ array.Length} {max1} { max2}");
        if (max1 > max2)
        {
            
            for (int i = 0; i < array.Length / 2; i++) array[i] = 0;
        }
        else
        {
            for (int i = array.Length / 2 ; i < array.Length; i++) array[i] = 0;
        }
        for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");

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
        double pol = double.MaxValue;
        int poli = int.MaxValue;
        double minv = double.MaxValue;
        int minvi = -1;
        for (int i = 0; i < array.Length; i++) if (array[i] < 0) { pol = array[i]; poli = i; break; }

        

        for (int i = 0; i < array.Length; i++) if (array[i] < minv) { minv = array[i]; minvi = i; }

        if (poli < minvi) { for (int i = 0; i < array.Length; i++) if (i % 2 == 0) { sum += array[i]; } }
        else { for (int i = 0; i < array.Length; i++) if (i % 2 != 0) { sum += array[i]; } }

        Console.WriteLine($"={sum} ");
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
        for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
        double maxz = double.MinValue;
        int mi = -1;
        for (int i = 0; i < array.Length; i++) if (array[i] > maxz) {  maxz = array[i]; mi = i; }
        for (int i = 1; i < mi; i+=2)
        {
            double a1 = array[i - 1];
            double a2 = array[i];
            array[i] = a1;
            array[i - 1] = a2;

        }
        Console.WriteLine();
        for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
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

        for (int i = 0;i < array.Length;i++)
        {
            int c = 1;
            for (int j = i; j < array.Length-1; j++)
            {
                if (array[j] > array[j + 1]) c++;
                else
                {
                    if (c > count) { count = c; }
                    break;
                }
                if (c > count) { count = c; Console.WriteLine($"i={i} j={j} {array[i]} {array[i + 1]}"); }
            }
        }
        Console.WriteLine(count);
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

        for (int i = 0; i < array.Length; i++)
        {
            int c = 1;
            for (int j = i; j < array.Length - 1; j++)
            {
                if (array[j] > array[j + 1]) c++;
                else
                {
                    if (c > count) { count = c; }
                    break;
                }
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            int c = 1;
            for (int j = i; j < array.Length - 1; j++)
            {
                if (array[j] < array[j + 1]) c++;
                else
                {
                    if (c > count) { count = c; Console.WriteLine($"i={i} j={j} {array[i]} {array[i+1]}"); }
                    break;
                }
                if (c > count) { count = c; Console.WriteLine($"i={i} j={j} {array[i]} {array[i + 1]}");}
            }
        }
        Console.WriteLine(count);
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
        int cpol = 0;
        for(int i = 0;i < array.Length; i++) if (array[i] >= 0) cpol++;
        double [] na = new double [cpol];
        int j = 0;
        for (int i = 0; i < array.Length; i++) if (array[i] >= 0) {  na[j] = array[i]; j++; }
        array = na;
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
