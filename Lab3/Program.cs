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
        double[] array = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 };
        Program program = new Program();
        program.Task_3_8(array);
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        double s = 0;
        foreach (double x in array)
        {
            s += x;
        }
        for (int i = 0; i < 6; i++)
        {
            array[i] = Math.Round(array[i] / s, 2);
        }

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        double s = 0;
        double c = 0;
        foreach (double x in array)
        {
            if (x > 0)
            {
                s += x;
                c++;
            }
        }
        s = Math.Round(s / c, 2);
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                array[i] = s;
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
        double s = 0;
        foreach(double x in array)
        {
            s += x;
        }
        s = Math.Round(s / array.Length, 2);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - s, 2);
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
        product = Math.Round(product, 2);
        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        foreach(double x in vector)
        {
            length += x * x;
        }
        length = Math.Round(Math.Sqrt(length), 2);
        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        double srzn = 0;
        for (int i = 0; i < array.Length; i++)
        {
            srzn += array[i];
        }
        srzn /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > srzn)
            {
                array[i] = 0;
            }
        }

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        for(int i = 0; i < array.Length; i++)
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

        double srzn = 0;
        for (int i = 0; i < array.Length; i++)
        {
            srzn += array[i];
        }
        srzn /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > srzn)
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
        double[] output = null;

        int c = 0;
        foreach (double i in array)
        {
            if (i > 0)
            {
                c ++;
            }
        }
        output = new double[c];
        int num = 0;
        for (int n = 0; num < c; n++)
        {
            if (array[n] > 0)
            {
                output[num] = array[n];
                num++;
            }
        }
        //Console.WriteLine(output);
        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        for (int i = 0; i < 8; i++)
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
        double[] odd = new double[array.Length / 2];

        for (int i = 1; i < array.Length; i += 2)
        {
            odd[i / 2] = array[i];
        }
        for (int i = 0; i < array.Length; i += 2)
        {
            even[i / 2] = array[i];
        }
        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;
        int i = 0;

        while(i <= (array.Length - 1) && array[i] >= 0)
        {
            sum += array[i] * array[i];
            i++;
        }

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        for(int i = 0; i < x.Length; i++)
        {
            if (x[i] != 0)
            {
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
                Console.WriteLine("{0} {1}", x[i], y[i]);
            }
            else
            {
                y[i] = double.NaN;
                Console.WriteLine("{0} {1}", x[i], y[i]);
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
        double maxzn = -9999999999;

        foreach(double x in array)
        {
            if(x > maxzn)
            {
                maxzn = x;
            }
        }
        for (int i = 0; array[i] < maxzn; i++ )
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
        double average = 0; double maxzn = -999999999;

        foreach (double x in array)
        {
            if (x > maxzn)
            {
                maxzn = x;
            }
            average += x;
        }
        average /= array.Length;
        if (array[array.Length - 1] != maxzn)
        {
            for (int i = array.Length - 1; array[i] != maxzn; i--)
            {
                array[i] = Math.Round(average, 2);
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
        double difference = 9999999;
        int num = 0;
        double average = 0;
        
        foreach (double x in array)
        {
            average += x;
        }
        average /= array.Length;
        for(int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(average - array[i]) < difference)
            {
                num = i + 1;
                difference = Math.Abs(average - array[i]);
            }
        }
        Array.Resize(ref array, array.Length + 1);
        Array.Copy(array, num, array, num + 1, array.Length - num - 1);
        array[num] = P;
        
        
        return array;
    }
    public double[] Task_2_7(double[] array)
    {
        double maxarray = -10000000;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxarray)
            {
                maxarray = array[i];
            }
        }
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == maxarray)
            {
                array[i + 1] *= 2;
                Console.WriteLine(1);
            }
        }

        return array;
    }
    public double[] Task_2_8(double[] array)
    {
        double max = -999999; double min = 999999;
        int nummax = 0; int nummin = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                nummax = i;
            }
        }
        for (int i = nummax + 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                nummin = i;
            }
        }
        if (nummax < array.Length - 1)
        {
            array[nummax] = min;
            array[nummin] = max;
        }
        

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
        double min = 999999;
        int ind = -1;

        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < min && array[i] > 0)
            {
                min = array[i]; ind = i;
            }
        }
        if (ind == -1)
        {
            return array;
        }
        double[] newarray = new double[array.Length - 1];
        for (int i = 0; i < ind; i++)
        {
            newarray[i] = array[i];
        }
        for (int i = ind + 1; i < array.Length; i++)
        {
            newarray[i - 1] = array[i];
        }
        return newarray;
    }
    public double[] Task_2_11(double[] array, double P)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_12(double[] array)
    {
        double max = -99999; int ind = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i]; ind = i;
            }
        }
        double sum = 0;
        if (ind < array.Length - 1)
        {
            for (int i = ind + 1; i < array.Length; i++)
            {
                sum += array[i];
            }
        }
        sum = Math.Round(sum, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = sum;
                break;
            }
        }
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
        double min = 0; int min_index = -1;
        double max = -999999; int max_index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i]; max_index = i;
            } 
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                min = array[i]; min_index = i;
                break;
            }
        }
        if (min_index >= 0)
        {
            array[max_index] = min;
            array[min_index] = max;
        }
        
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

        int count = 0; double mid = 0;
        for (int i = 0; i < array.Length; i++)
        {
            mid += array[i];
        }
        mid /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < mid)
            {
                count++;
            }
        }
        output = new int[count];
        int x = 0;
        for (int i = 0; x < count; i++)
        {
            if (array[i] < mid)
            {
                output[x] = i;
                x++;
            }
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
        double max = -9999; bool even = false;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                even = i % 2 == 0;
            }
        }
        if (even)
        {
            for (int i = 0; i < array.Length / 2; i++)
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
        double sum = 0; bool check = true; double min = 99999; bool err = true;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min && array[i] < 0)
            {
                if (check == true)
                {
                    check = false;
                    err = false;
                }
                else
                {
                    check = true;
                    break;
                }
            }
        }
        if (err)
        {
            check = false;
        }
        if (check)
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
        int subzero_count = 0;
        foreach (double x  in array)
        {
            if (x < 0)
            {
                subzero_count++;
            }
        }
        double[] subzero = new double[subzero_count]; int[] subzero_index = new int[subzero_count];
        int i1 = 0;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] < 0)
            {
                subzero_index[i1] = j;
                i1++;
            }
        }
        for (int i = 0; i < subzero_count; i++)
        {
            double subzero_max = -999999999; int subzero_max_index = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] < 0 && array[j] > subzero_max)
                {
                    subzero_max = array[j];
                    subzero_max_index = j;
                }
            }
            subzero[i] = subzero_max;
            array[subzero_max_index] = 0;
        }
        for (int i = 0; i < subzero_count; i++)
        {
            array[subzero_index[i]] = subzero[i];
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
