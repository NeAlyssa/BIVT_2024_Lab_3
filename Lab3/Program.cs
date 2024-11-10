using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
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
        double s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s = s + array[i];  
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i]/s, 2);
        }
        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        double s = 0;
        int n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                s = s + array[i];
                n++;
            }
        }
        s = Math.Round(s/ n * 1.0, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                array[i] = s;
        }
        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];
        for (int i = 0; i < first.Length; i++)
        {
            sum[i] = Math.Round(first[i] + second[i],2);
            dif[i] = Math.Round(first[i] - second[i], 2); 

        }
        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        double s = 0;
        int n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s = s + array[i];
            n++;
        }
        s = s/ n * 1.0;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - s, 2);
        }
        return array;

        
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;
        for (int i = 0; i < 4; i++)
        {
            product = product + vector1[i] * vector2[i];
            
        }
        return Math.Round(product, 2);
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;
        for (int i = 0; i < 5; i++)
        {
            length = length + vector[i] * vector[i];
        }
        length = Math.Sqrt(length);
        return Math.Round(length, 2); 
    }
    public double[] Task_1_7(double[] array)
    {
        double s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s = s + array[i];
        }
        s = s/array.Length * 1.0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > s)
                array[i] = 0;
        }
        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] <0)
                count++;

        }
        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;
        double s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s = s + array[i];
        }
        s = s/array.Length * 1.0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > s)
                count ++;
        }
        return count;
    }

    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (P < array[i] && array[i] < Q)
                count++;
        }

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        int count = 0;
        double[] output = null;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                count++;
        }
        output = new double[count];
        int n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                output[n++] = array[i];
        }
        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] <  0)
            {
                value = array[i];
                index = i;
            }
        }

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        int n1 = 0, n2 = 0;
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 ==0)
            {
                even[n1++] = array[i];
            }
            else
                odd[n2++] = array[i];
        }

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
                sum += array[i] * array[i];
            else
                break;
        }
            return sum;

    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i]<= 0)
                y[i] = double.NaN;
            else
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
        }
        //Вывести масссивы в виде двух столбцов
        for (int i = 0; i < x.Length; i++)
        {
            Console.WriteLine(x[i] + " " + y[i] + "/n");
        }
        //конец вывода
        return (y);
    }
    #endregion

   #region Level 2
    public double[] Task_2_1(double[] array)
    {
        double mn = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < mn)
                mn = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == mn)
                array[i] = mn * 2;
        }

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
        double mn = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < mn)
                mn = array[i];
        }
        int f = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != mn && f == 0 && array[i] >= 0)
                array[i] = array[i] * 2.0;
            else if (array[i] != mn && f == 0 && array[i] < 0)
                array[i] = array[i] * 0.5;
            else
                f = 1;
        }

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
        int indexmin = 0;
        int indexmax = 0;
        double mn = array[0];
        double mx = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < mn)
            {
                mn = array[i];
                indexmin = i;
            }
            if (array[i] > mx)
            {
                mx = array[i];
                indexmax = i;
            }
        }
        int count = 0;
        if (indexmax > indexmin)
        {
            for (int i = indexmin + 1; i < indexmax; i++)
            {
                if (array[i] < 0)
                    count++;
            }   
        }
        else
        {
            for (int i = indexmax + 1; i < indexmin; i++)
            {
                if (array[i] < 0)
                    count++;
            }
        }
        double[] a = new double[count];
        int n = 0;
        if (indexmax > indexmin)
        {
            for (int i = indexmin + 1; i < indexmax; i++)
            {
                if (array[i] < 0)
                    a[n++] = array[i];
            }
        }
        else
        {
            for (int i = indexmax + 1; i < indexmin; i++)
            {
                if (array[i] < 0)
                a[n++] = array[i];
            }
        }
        array = a;
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
        double mx = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mx)
            {
                mx = array[i];
            }
        }
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == mx)
            {
                if (array[i + 1] > 0)
                    array[i + 1] = array[i + 1] * 2;
                else
                    array[i + 1] = array[i + 1] * 0.5;
            }
        }
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
        int indexmin = 0;
        int indexmax = 0;
        double mn = array[0];
        double mx = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < mn)
            {
                mn = array[i];
                indexmin = i;
            }
            if (array[i] > mx)
            {
                mx = array[i];
                indexmax = i;
            }
        }
        int count = 0;
        if (indexmax > indexmin)
        {
            for (int i = indexmin + 1; i < indexmax; i++)
            {
                average += array[i]; 
                count++;
            }
        }
        else
        {
            for (int i = indexmax + 1; i < indexmin; i++)
            {
                average += array[i];
                count++;
            }
        }
        if (count == 0)
            average = 0;
        else
            average = Math.Round(average/count * 1.0, 2); 

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
        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                index = i;
        }
        double[] a = new double[array.Length + 1];
        if (index != -1)
        {
            for (int i = 0; i <= index; i++)
                a[i] = array[i];
            a[index + 1] = P;
            if (index + 2 < a.Length)
            {
                for (int i = index + 2; i <= a.Length; i++)
                    a[i] = array[i - 1];
            }
            array = a;
        }
        

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
        int index = 0;
        double mx = array[0];
        for (int i = 0; i < array.Length; i = i + 2)
        {
            if (array[i] > mx)
            {
                mx = array[i];
                index = i;
            }
        }
        for (int i = 0; i < array.Length; i = i + 2)
        {
            if (array[i] == mx)
            {
                array[index] = index;
            }
        }
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

        int n = 0;
        if (k >= A.Length)
        {
            n = A.Length;
        }
        else
            n = A.Length + B.Length;
        double[] output = new double[n];
        if (k < A.Length)
        {
            for (int i = 0; i <= k; i++)
                output[i] = A[i];
            for (int i = 0; i < B.Length; i++)
            {
                output[i+ k + 1] = B[i];
            }
            for (int i = k + 1; i < A.Length; i++)
                output[i + B.Length] = A[i];
        }
        else
        {
            output = A;
        }
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
        int indexmin = 0;
        int indexmax = 0;
        double mn = array[0];
        double mx = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < mn)
            {
                mn = array[i];
                indexmin = i;
            }
            if (array[i] > mx)
            {
                mx = array[i];
                indexmax = i;
            }
        }
        int count = 0;
        if (indexmax > indexmin)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    average += array[i];
                    count++;
                }

            }
        }
        else
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    average += array[i];
                    count++;
                }
            }
        if (count == 0)
            average = 0;
        else
            average = Math.Round(average / count * 1.0, 2);
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
        int indexmax = 0;
        double sum = 0;
        double mx = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mx)
            {
                mx = array[i];
                indexmax = i;
            }
            sum += array[i];
        }
        if (mx > sum)
            array[indexmax] = 0;
        else
            array[indexmax] = array[indexmax] * 2;
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
        int indexmax = 0;
        double sum = 0;
        double mx = array[0];
        int n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mx)
            {
                mx = array[i];
                indexmax = i;
                n = 1;
            }
            else if (array[i] == mx)
                n ++ ;
        }
        int[] output = new int[n];
        n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == mx)
                output[n++] = i;
        }
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
        int indexmax = 0;
        double mx = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mx)
            {
                mx = array[i];
                indexmax = i;
            }
        }
        double a = 0;
        for (int i = 1; i < indexmax; i = i + 2)
        {
            a = array[i];
            array[i] = array[i - 1];
            array[i - 1] = a;
        }
        return array;
    }

    
    public double[] Task_3_4(double[] array)
    {
        int indexmax = 0;
        double mx = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mx)
            {
                mx = array[i];
                indexmax = i;
            }
            
        }
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            if (array[i] ==  mx)
            {
                array[i] = sum - array[i];
            }   
        }
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
        int cp = 0;
        int co = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                cp++;
            }
            else 
                co++;

        }
        double[] A = new double[cp];
        double[] B = new double[co];
        int n1 = 0;
        int n2 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                A[n1++] = array[i];
            }
            else
                B[n2++]= array[i];
        }
        for (int i = 0; i < cp; i++)
            array[i] = A[i];
        for (int i = 0; i < co; i++)
            array[i + cp] = B[i];
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
        double[] B = new double[array.Length];
        for (int i = 0; i < (array.Length/2); i++)
        {
            B[i* 2] = array[i];
            B[i * 2 + 1] = array[i];
        }
        array = B;
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
        int l = 0;
        double[] A = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            int f = 1;
            for (int j = 0; j < l; j++)
                if (array[i] == A[j])
                {
                    f = 0;
                    break;
                }
            if (f == 1)
            {
                A[l] = array[i];
                l++;
            }
        }
        double[] B = new double[l];
        for (int i = 0; i < l; i++)
        {
            B[i] = A[i];
        }
        array = B;
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
