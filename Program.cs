using Microsoft.VisualBasic;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
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
        program.Task_2_10(new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (sum == 0)
            {
                return array;
            }
            else
            {
                array[i] = Math.Round(array[i] / sum, 2);
            }
            
        }


        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        double sum = 0;
        int n = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                sum += array[i];
                n += 1;
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = Math.Round(sum/n, 2);
            }
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
        double sum = 0;
        int n = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            n += 1;
        }

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - Math.Round(sum / n, 2), 2);
        }

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        for (int i = 0; i < vector1.Length; i++)
        {
            product += Math.Round(vector1[i] * vector2[i], 2);
        }

        return Math.Round(product, 2);
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        for (int i = 0; i < vector.Length; i++)
        {
            length += vector[i] * vector[i];
        }

        length = Math.Sqrt(length);

        return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        double sum = 0;
        int n = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            n += 1;
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sum/n)
            {
                array[i] = 0;
            }
        }

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                count++;
            }
        }

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        double sum = 0;
        int n = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            n += 1;
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sum/n)
            {
                count++;
            }
        }

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > P && array[i] < Q)
            {
                count++;
            }
        }

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                count++;
            }
        }

        int n = 0;
        double[] output = new double[count];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[n] = array[i];
                n++;
            }
        }

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        for (int i = 0; i < array.Length; i++)
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

        int a = 0;
        int b = 0;

        for (int i = 0; i < array.Length; i ++)
        {
            if (i%2==0)
            {
                even[a] = array[i];
                a++;
            }
            else
            {
                odd[b] = array[i];
                b++;
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
            {
                sum += array[i] * array[i];
            }
            else
            {
                break;
            }
        }

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
            else
            {
                y[i] = double.NaN;
            }
        }

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
        double a = 0;
        int b = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > a)
            {
                a = array[i];
                b = i;
            }
        }

        for (int i = 0; i < b; i++)
        {
            sum += array[i];
        }

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
        double sum = 0;
        double a = 0;
        int b = 0;
        int n = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            n++;
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > a)
            {
                a = array[i];
                b = i;
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (i > b)
            {
                array[i] = Math.Round(sum / n, 2);
            }
        }

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
        int n = 0;
        double a = 999;
        int b = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            n++;
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - sum/n) < a)
            {
                b = i;
                a = Math.Abs(array[i] - sum / n);
            }

        }
        
        double[] arr = new double[n + 1];

        for (int i = 0; i < arr.Length; i++)
        {
            if (i <= b)
            {
                arr[i] = array[i];
            }
            if (i == b+1)
            {
                arr[i] = P;
            }
            if (i > b+1)
            {
                arr[i] = array[i - 1];
            }
        }
        
        
        return arr;
    }
    public double[] Task_2_7(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_8(double[] array)
    {
        
        double max = -9999999;
        int ind = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                ind = i;
            }
        }

        double min = 9999;
        int a = 0;

        for (int i = ind; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                a = i;
            }
        }

        double br = max;
        array[ind] = min;
        array[a] = br;
        //for (int i = ind; i < array.Length; i++)
        //{
        //    if (i == a)
        //    {
                //        array[a] = max;
                //    }
                //    if (i == ind)
                //    {
                //        array[ind] = min;
                //    }

                //}




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
        
        double min = 9999;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
        }
        if (min == 9999) return array;
        double[] arr = new double[array.Length - 1];
        int n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != min)
            {
                arr[n] = array[i];
                n++;
            }
            
        }

        

        return arr;
    }
    public double[] Task_2_11(double[] array, double P)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_12(double[] array)
    {
        int k = 0;
        double min = 0;
        int minind = 0;


        for (int i = 0; i < array.Length; i++)
        {
            if (k == 0)
            {
                if (array[i] < 0)
                {
                    k = 1;
                    min = array[i];
                    minind = i;
                }
            }
        }


        if (k == 0)
        {
            return array;
        }
        else
        {

            double max = -9999;
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
            }

            double sum = 0;
            for (int i = index + 1; i < array.Length; i++)
            {
                sum += array[i];
            }

            array[minind] = Math.Round(sum, 2);

            return array;
        }
    }
    public double[] Task_2_13(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_14(double[] array)
    {
        int k = 0;
        double min = 0;
        int minind = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (k == 0)
            {
                if (array[i] < 0)
                {
                    k = 1;
                    min = array[i];
                    minind = i;
                }
            }
        }
        
        double max = -9999;
        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index = i;
            }
        }
        
        if (k != 0)
        {
            double x = min;
            array[minind] = max;
            array[index] = x;
            return array;
        }
        else
        {
            return array;
        }

        
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
        ///int[] output = null;

        double a = 0;
        int n = array.Length;

        for (int i = 0; i < array.Length; i++) { a += array[i];  }

        double sum = a / n;

        int k = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sum) { k++; }
        }

        int [] arr = new int[k];
        int m = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sum)
            {
                arr[m] = i;
                m++;
            }
        }

        return arr;
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
        double max0 = -999;
        double max1 = -999;
        int a0 = -1;
        int a1 = -1;

        for (int i = 0; i < array.Length; i+= 2)
        {
            if (array[i] > max0)
            {
                max0 = array[i];
                a0 = i;
            }
        }

        for (int i = 1; i < array.Length; i += 2)
        {
            if (array[i] > max1)
            {
                max1 = array[i];
                a1 = i;
            }
        }

        if (max0 > max1)
        {
            for (int i = 0; i < array.Length/2; i++)
            {
                array[i] = 0;
            }
        }
        else
        {
            for (int i = array.Length/2; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }

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

        int k = 0;
        int minind = 999;

        for (int i = 0; i < array.Length; i++)
        {
            if (k == 0)
            {
                if (array[i] < 0)
                {
                    k = 1;
                    minind = i;
                }
            }
        }

        double min = 9999;
        int a = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                a = i;
            }    
        }

        if (minind < a)
        {
            for (int i = 0; i < array.Length; i+= 2) 
            { 
                sum += array[i];
            }
            return sum;
        }
        if (minind == 999)
        {
            return 0;
        }
        else
        {
            for (int i = 1; i < array.Length; i+= 2) 
            {
                sum += array[i];
            }
            return sum;
        }
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
        double max = -999;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        double n = 1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                array[i] += n;
                n++;
            }
        }

        return array;

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
        for (int j = 0; j < array.Length; j+=2)
        {
            for (int i = 0; i < array.Length - 2; i += 2)
            {
                if (array[i] > array[i+2])
                {
                    double k = array[i];
                    array[i] = array[i + 2];
                    array[i + 2] = k;
                }
            }
        }

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
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] < 0)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if ((array[i] < 0) && (array[i+1] < 0) && (array[i] < array[i + 1]))
                    {
                        double k = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = k;
                    }
                }
            }
        }


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

        double x = 0;
        double y = 0;

        double globalMax = -999, globalMin = 999;

        double k = (b - a) / (n - 1);

        for (int i = 0; i < n; i++)
        {
            x = a + i * k;
            y = Math.Round(Math.Cos(x) + x * Math.Sin(x), 2);
            x = Math.Round(x, 2);
            X[i] = x;
            Y[i] = y;
        }

        
        foreach (double p in Y)
        {
            if (p > globalMax)
            {
                globalMax = p;
            }
            if (p < globalMin)
            {
                globalMin = p;
            }
        }


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
        double[] arr = new double[array.Length];
        int maxind = 0;
        int minind = 0;
        int length = array.Length;
        double a = 0;

        for (int i = 0; i < length; i++)
        {
            if (array[i] > array[maxind])
            {
                maxind = i;
            }
            if (array[i] < array[minind])
            {
                minind = i;
            }
        }

        a = 2 / (array[maxind] - array[minind]);

        for (int i = 0; i < length; i++)
        {
            arr[i] = Math.Round((array[i] - array[minind]) * a - 1, 2);
        }
        

        return arr;
    }
    #endregion
}