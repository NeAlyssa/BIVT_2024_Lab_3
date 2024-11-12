using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
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
        //program.Task_2_15(new double[] {1, 2, 3, 4, 5, 6, 7}, new double[] { -1, -2, -3}, 2);

    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        double sm = 0;
        for (int i = 0; i < array.Length; i++)
            sm += array[i];
        for (int i = 0; i < array.Length; i++)
            array[i] = Math.Round(array[i]/sm, 2);

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        double sm = 0;
        double n = 0;
        for (int i = 0; i < array.Length; i++)
            if (array[i] > 0)
            {
                sm += array[i];
                n += 1;
            }
        for (int i = 0; i < array.Length; i++)
            if (array[i] > 0)
            {
                array[i] = Math.Round(sm /n, 2);
            }
        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        for (int i = 0; i < first.Length; i++)
        {
            sum[i] = Math.Round(first[i] + second[i],1);
            dif[i] = Math.Round(first[i] - second[i],1);
        }

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        double sm = 0;
        double n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sm += array[i];
            n += 1;
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i]-(sm/n), 2);
        }

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        for (int i = 0; i < vector1.Length; i++)
        {
            product += vector1[i] * vector2[i];
        }
        product= Math.Round(product, 2);
        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        for (int i = 0; i < vector.Length; i++)
        {
            length += vector[i] * vector[i];
        }
        length = Math.Sqrt(length);

        return Math.Round(length, 2);
    }
    public double[] Task_1_7(double[] array)
    {
        double sm = 0;
        double n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sm += array[i];
            n += 1;
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]>Math.Round(sm/n,2))
                array[i] = 0;
        }

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
                count += 1;
        }

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        double sm = 0;
        double n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sm += array[i];
            n += 1;
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > Math.Round(sm / n, 2))
                count+=1;
        }

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > P&& array[i] < Q)
                count += 1;
        }

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        int n = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                n += 1;
        }
        double[] output = new double[n];
        n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[n] = array[i];
                n += 1;
            }
        }

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        for (int i = 0; i < array.Length;i++)
        {
            if (array[i] < 0)
            {
                value = array[i];
                index = i;
            }
        }

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];
        int j = 0;
        int g = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[j] = array[i];
                j++;
            }
            else
            {
                odd[g] = array[i];
                g++;
            }
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
        Console.WriteLine(x.Length);
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] > 0)
                y[i] = Math.Round(Math.Log(x[i]) / 2, 2);
            else
                y[i] = double.NaN;
        }
        Console.WriteLine(x.Length);
        for (int i = 0; i < x.Length; i++)
            Console.WriteLine("{0}\t{1}", x[i], y[i]);
        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        double min = double.MaxValue;
        for(int i =0;i<array.Length;i++)
            if (array[i] < min)
                min = array[i];
        for (int i = 0; i < array.Length; i++)
            if (array[i] == min)
            {array[i] = array[i] * 2; break;}


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
        double min = double.MaxValue;
        for (int i = 0; i < array.Length; i++)
            if (array[i] < min)
                min = array[i];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == min) break;
            else if (array[i] < 0) array[i] = Math.Round(array[i] / 2, 2);
            else array[i] = array[i] * 2;
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
        double min = double.MaxValue;
        double max = double.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min) min = array[i];
            if (array[i] > max) max = array[i];
        }
        int s = 0;
        int e = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == min) s=i;
            if (array[i] == max) e=i;
        }
        int n = 0;
        for (int i = 0; i < array.Length; i++)
            if ((i > s && i < e || i > e && i < s) && array[i]<0) n+=1;
        double[] array1 = new double[n];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
            if ((i > s && i < e || i > e && i < s) && array[i] < 0)
            {
                array1[j] = array[i];
                j += 1;
            }
        array = array1;
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
        double max = double.MinValue;
        int maxindex = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) { max = array[i]; maxindex = i; }
        }
        if (array.Length - 1 != maxindex) 
            if (array[maxindex + 1]>0) 
                array[maxindex + 1] = array[maxindex + 1] * 2;
            else
                array[maxindex + 1] = Math.Round(array[maxindex + 1] / 2, 2);

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

        double min = double.MaxValue;
        double max = double.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min) min = array[i];
            if (array[i] > max) max = array[i];
        }
        int s = 0;
        int e = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == min) s = i;
            if (array[i] == max) e = i;
        }
        int n = 0;
        for (int i = 0; i < array.Length; i++)
            if (i > s && i < e || i > e && i < s) n += 1;
        double[] array1 = new double[n];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
            if (i > s && i < e || i > e && i < s)
            {
                array1[j] = array[i];
                j += 1;
            }
        n= 0;
        double sum = 0;
        for (int i = 0; i < array1.Length; i++)
        { sum += array1[i]; n += 1; }
        if (n > 0)
            average = Math.Round(sum / n,2);
        else
            average = 0;


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
            if (array[i] > 0) index = i;
        double[] array1 = new Double[array.Length+1];
        if (index == -1)
            return array;
        for (int i = 0; i < array1.Length; i++)
        {
            if (i < index + 1)
                array1[i] = array[i];
            if (i == index + 1)
                array1[i] = P;
            if (i > index + 1)
                array1[i] = array[i+1];
        }
        array = array1;
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
        double max = double.MinValue;
        for (int i = 0; i < array.Length; i=i+2)
        {
            if (array[i] > max) max = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max) array[i]=i;
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
        double[] output = new double[A.Length+B.Length];

        int iA = 0;
        int iB = 0;
        k = k;
        if (k >= A.Length)
            return A;
        for (int i = 0; i < output.Length; i++)
        {
            if (i <= k)
            {
                output[i] = A[iA];
                iA++;
            }
            else if (i >= k && iB < B.Length)
            {
                output[i] = B[iB];
                iB++;
            }
            else
            {
                output[i] = A[iA];
                iA++;
            }

        }
        for(int i = 0;i<output.Length;i++)
            Console.Write("{0} ", output[i]);
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

        double min = double.MaxValue;
        double max = double.MinValue;
        double minindex = 0;
        double maxindex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min) { min = array[i]; minindex = i; }
            if (array[i] > max) { max = array[i]; maxindex = i; }
        }
        double n = 0;
        double sum = 0;
        if (maxindex < minindex)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                    n += 1;
                }
            }
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    sum += array[i];
                    n += 1;
                }
            }
        }
        if (n == 0)
            return 0;
        average = sum / n;
        average = Math.Round(average, 2);
        Console.WriteLine(average);
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
        double max = double.MinValue;
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
            sum += array[i];
        }
        if (max > sum)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == max)
                    array[i] = 0;
            Console.WriteLine(10000);
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == max)
                    array[i] = array[i] * 2;
        }
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

        // end

        return array;
    }
    public double[] Task_3_3(double[] array)
    {
        double max = double.MinValue;
        double maxindex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxindex = i;
            }
        }
        for (int i = 0; i < array.Length; i=i+2) 
        {
            if (i + 1 < maxindex)
            {
                double n = array[i];
                array[i] = array[i + 1];
                array[i + 1] = n;
            }
            else
                break;
        }
        for (int i = 0; i < array.Length; i++)
            Console.WriteLine(array[i]);
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

        int k = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i - 1])
            {
                k += 1;
                if (k > count)
                    count = k;
            }
            else
            {
                k = 1;
            }
        }

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

        int k = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i - 1])
            {
                k += 1;
                if (k > count)
                    count = k;
            }
            else
            {
                k = 1;
            }
        }
        k = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[i - 1])
            {
                k += 1;
                if (k > count)
                    count = k;
            }
            else
            {
                k = 1;
            }
        }
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
        int n = 0;
        for (int i = 0; i < array.Length; i++)
            if (array[i] >= 0) 
                n += 1;
        int j = 0;
        double[] array1 = new double[n];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                array1[j] = array[i];
                j += 1;
            }
        }
        array = array1;
        for(int i = 0; i < array.Length; i++)
            Console.WriteLine(array[i]);
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