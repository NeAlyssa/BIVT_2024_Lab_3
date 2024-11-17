using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_1(new int[] { 1, 2, 3, 4, 5, 6 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double sum = 0;
        for(int i = 0; i < array.Length; i ++)
        {
            sum += array[i];
        }
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = array[i] / sum;
        }
        // end
       

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sum = 0;
        int h = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                h += 1;
                sum += array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = sum/h;
            }
        }
 

        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length];
        double[] dif = new double[first.Length];

        // code here
        for(int i = 0; i < first.Length; i++)
        {
            sum[i] = first[i] + second[i];
            dif[i] = first[i] - second[i];
        }
        // end
        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s = 0;
        
        for(int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        double sum = s / 5;
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = array[i] - sum;
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for(int i = 0; i < vector1.Length; i++)
        {
            product += vector1[i] * vector2[i];
        }
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for(int i = 0; i < vector.Length; i++)
        {
            length += vector[i] * vector[i];
        }
        // end
        length = Math.Sqrt(length);

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        int k = 7;
        for(int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        double sum = s / k;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > sum)
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
        for(int i = 0; i < array.Length; i++)
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
        double s = 0;
        // code here
        for(int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        double sum = s / 8;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > sum)
            {
                count += 1;
            }
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for(int i = 0; i < array.Length; i++)
        {
            if ((array[i] > P) & (array[i] < Q))
            {
                count += 1;
            }
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output;

        // code here
        int l = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                l += 1;
            }
        }
        output = new double[l];
        int h = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[h] = array[i];
                h += 1;
            }
            ;
        }
        // end

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        // code here
        for(int i = 0; i < array.Length; i++)
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
        int h = 0;
        int g = 0;
        for(int i = 0; i < array.Length; i+= 2)
        {
            even[h] = array[i];
            h++;
        }
        for(int i = 1; i < array.Length; i += 2)
        {
            odd[g] = array[i];
            g++;
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;
        int k = 0;
        // code here
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                break;
            }
            sum += (array[i] * array[i]);
        }
        
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for(int i = 0; i < x.Length; i++)
        {
            if (x[i] <= 0)
            {
                y[i] = double.NaN;
            }
            else
            {
                y[i] = 0.5 * Math.Log(x[i]);
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
        double k = double.MaxValue;
        int h1 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            double l = array[i];
            int h = i;
            if (l <= k)
            {
                k = l;
                h1 = i;
            }
        }
        if (k > 0)
        {
            k = k * 2;
        }
        else
        {
            k = k / 2;
        }
        array[h1] = k;
        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;
        double k = double.MinValue;
        int h1 = 0;
       
        // code here
        for(int i = 0; i < array.Length; i++)
        {
            double l = array[i];
            int h = i;
            if (l >= k)
            {
                k = l;
                h1 = h;
            }
        }
        for(int j = 0; j < h1; j++)
        {
            sum += array[j];
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
        double k = double.MinValue;
        int s = array.Length;
        double sum = 0;
        int h1 = 0;
        for(int i = 0; i< s; i++)
        {
            double l = array[i];
            int h = i;
            if(l >= k)
            {
                k = l;
                h1 = h;
            }
        }
        for (int g = 0; g < s; g++)
        {
            sum += array[g];
        }

        for (int j = (h1 + 1); j < s; j++)
        {
            array[j] = sum / s;
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
        for(int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        s = s / array.Length;
        double h = double.MaxValue;
        int k = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(Math.Abs(s - array[i]) <= h)
            {
                h = Math.Abs(s - array[i]);
                k = i;
            }
        }
        double[] b = new double[array.Length + 1];
        for(int i = 0; i <= k; i++)
        {
           b[i] = array[i];
    
            
        }
        b[k + 1] = P;
        for(int i = k + 2; i < (array.Length + 1); i++)
        {
            b[i] = array[i - 1];
        }
        
        // end

        return b;
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
        double s = double.MinValue;
        double s1 = double.MaxValue;
        int k = 0;
        int h = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] >= s)
            {
                s = array[i];
                k = i;
            }
        }
        for(int i = k; i < array.Length; i++)
        {
            if (array[i] <= s1)
            {
                s1 = array[i];
                h = i;
            }
        }
        double b = array[k];
        array[k] = array[h];
        array[h] = b;
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
        double s = double.MaxValue;
        int k = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && array[i] < s)
            {
                s = array[i];
                k = i;
            }
        }
        if (k != -1)
        {
            double[] b = new double[array.Length - 1];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (i < k)
                {
                    b[i] = array[i];
                }
                else
                {
                    b[i] = array[i + 1];
                }
            }
            array = b;
        }
        //Console.WriteLine(b[8]);
       
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
        double s = double.MinValue;
        int k = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > s)
            {
                s = array[i];
                k = i;
            }
        }
        double sum = 0;
        for(int i = k + 1; i < array.Length; i++)
        {
            sum += array[i];
        }
        for(int i = 0; i < array.Length; i++) 
        {
            if (array[i] < 0)
            {
                array[i] = sum;
                break;
            }
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
        double s = double.MinValue;
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > s)
            {
                s = array[i];
                k = i;
            }
        }
        double g = 0;
        int h = -1;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                h = i;
                g = array[i];
                break;
            }
        }

        if (h != -1)
        {
            array[k] = g;
            array[h] = s;
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
        double sum = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        double sr_sum = sum / array.Length;
        int k = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr_sum)
            {
                k += 1;
            }
        }
        int [] b = new int[k];
        int l = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr_sum)
            {
                b[l] = i;
                l ++;
            }
        }
        // end

        return b;
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
        double sh = double.MinValue;
        
        for (int i = 0; i < array.Length; i+=2)
        {
            if (array[i] > sh)
            {
                sh = array[i];
            }
        }

        double snh = double.MinValue;

        for (int i = 1; i < array.Length; i += 2)
        {
            if (array[i] > snh)
            {
                snh = array[i];
            }
        }
        if (sh > snh)
        {
            for(int i = 0; i < array.Length / 2; i++)
            {
                array[i] = 0;
            }
        }
        else
        {
            for(int i = array.Length / 2; i < array.Length; i++)
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
        double s = double.MaxValue;
        int h = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] <= s)
            {
                s = array[i];
                h = i;
            }
        }
        int k = -1;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                k = i;
                break;
            }
        }
        if (k == -1)
        {
            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }
        }
        if (k != -1)
        {
            if (k < h)
            {
                for (int i = 0; i < array.Length; i += 2)
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
        double s = double.MinValue;
        int k = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > s)
            {
                s = array[i];
                k = i;
            }
        }
        for(int i = 0, j = 1; j < k; i+=2, j +=2)
        {
            double b = array[i];
            array[i] = array[j];
            array[j] = b;
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
        int count = 1;
        int b = 0;
        // code here
        if (array.Length == 0) { return 0; };
        for (int j = 0; j < array.Length - 1; j += 1)
        {
            if (array[j] > array[j + 1])
            {
                count += 1;
            }
            else
            {
                b = Math.Max(b, count);
                count = 1;
            }
            
        }

        count = Math.Max(b, count);
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
        
        int b = 0;
        // code here
        if (array.Length == 0) { return 0; };
        for (int j = 0; j < array.Length - 1; j += 1)
        {
            if (array[j] > array[j + 1])
            {
                count += 1;
            }
            else
            {
                b = Math.Max(b, count);
                count = 1;
            }

        }

        int d = 0;
        int count1 = 0;
        for (int j = 0; j < array.Length - 1; j += 1)
        {
            if (array[j] < array[j + 1])
            {
                count1 += 1;
            }
            else
            {
                d = Math.Max(d, count1);
                count1 = 1;
            }

        }
        int z1 = Math.Max(b, count);
        int z2 = Math.Max(d, count1);
        count = Math.Max(z2, z1);
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
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                k++;
            }
        }
        if (k > 0)
        {
            double[] b = new double[array.Length - k];
            int h = 0;

            foreach (var element in array)
            {
                if (element >= 0)
                {
                    b[h++] = element;
                }
            }
            array = b;
        }

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
