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
        program.Task_3_3(new double[] { 1,2,3,4,5,6,7,999,5,4,3 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        double s = 0;
        for (int i = 0; i < array.Length; i ++)
        {
            s += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] / s, 2);
        }

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        double med = 0;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) { med += array[i]; count++; }
        }
        med /= count;
        med = Math.Round(med, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) { array[i] = med; }
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

        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }

        s /= array.Length;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - s, 2);
        }

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        for(int i = 0; i < vector1.Length; i++)
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
        return Math.Round(length, 2); 
    }
    public double[] Task_1_7(double[] array)
    {
        double s = 0;
        for(int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        s = Math.Round(s/array.Length, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > s) { array[i] = 0; }
        }
        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) { count++; }
        }

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;
        double s = 0;

        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        s = Math.Round(s / array.Length, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > s) { count++; }
        }

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if ((array[i] > P) && (array[i] < Q))
            {
                count++;
            }
        }

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        int k = 0;
        double[] output = null;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if ((array[i] > 0)) { count++; }
        } 
        output = new double[count];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) { output[k] = array[i]; k++; }
        }
        

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] < 0) { value = array[i]; index = i; break; }
        }

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];
        int k0 = 0;
        int k1 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[k0] = array[i];
                k0++;
            }
            else
            {
                odd[k1] = array[i];
                k1++;
            }
        }

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;
        int index = 0;
        while (index < array.Length && array[index] >= 0)
        {
            sum += array[index] * array[index];
            index++;
        }

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] <= 0) {  y[i] = double.NaN; }
            else { y[i] = Math.Round(0.5 * Math.Log(x[i]), 2); }
            Console.Write(x[i] + "      ");
            Console.Write(y[i]);
            Console.WriteLine();
        }
        

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        int index = 0;
        double min = double.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] <  min)
            {
                min = array[i];
                index = i;
            }
        }
        array[index] = min * 2;

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
        int index = 0;
        double min = double.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                index = i;
            }
        }
        for (int i = 0; i < index; i ++)
        {
            if (array[i] <= 0) { 
            array[i] /= 2;
            }
            else { array[i] *= 2; }
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
        int maxIndex = 0;
        int minIndex = 0;
        int count = 0;
        

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
            if (array[i] < array[minIndex])
            {
                minIndex = i;
            }
        }

        if (maxIndex > minIndex)
        {
            int temp = maxIndex;
            maxIndex = minIndex;
            minIndex = temp;
        }

        int negativeCount = 0;
        for (int i = maxIndex + 1; i < minIndex; i++)
        {
            if (array[i] < 0)
            {
                negativeCount++;
            }
        }

        double[] res_array = new double[negativeCount];
        int index = 0;

        for (int i = maxIndex + 1; i < minIndex; i++)
        {
            if (array[i] < 0)
            {
                res_array[index] = array[i];
                index++;
            }
        }

        return res_array;
    }
    public double[] Task_2_6(double[] array, double P)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_7(double[] array)
    {
        int maxIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }
        if( maxIndex + 1 < array.Length) { 
            if (array[maxIndex + 1] < 0) array[maxIndex + 1] /= 2;
            else array[maxIndex + 1] *= 2;

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
        int count = 0;
        int maxIndex = 0;
        int minIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
            if (array[i] < array[minIndex])
            {
                minIndex = i;
            }
        }

        if (maxIndex > minIndex)
        {
            int temp = maxIndex;
            maxIndex = minIndex;
            minIndex = temp;
        }

        for (int i = maxIndex + 1; i < minIndex; i++)
        {
            average += array[i];
            count++;
        }
        if (count == 0) { return 0; }

           return Math.Round(average/count, 2);
    }
    public double[] Task_2_10(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_11(double[] array, double P)
    {
        int lastPositiveIndex = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                lastPositiveIndex = i;
            }
        }

        double[] result = new double[array.Length + 1];
        int j = 0;

        for (int i = 0; i <= lastPositiveIndex; i++)
        {
            result[j++] = array[i];
        }

        if (lastPositiveIndex != -1)
        {
            result[j++] = P;
        }

        for (int i = lastPositiveIndex + 1; i < array.Length; i++)
        {
            result[j++] = array[i];
        }

        return result;
    }
    public double[] Task_2_12(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_13(double[] array)
    {
        int indexMax = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > array[indexMax]) indexMax = i;
        }
        array[indexMax] = indexMax;

        return array;
    }
    public double[] Task_2_14(double[] array)
    {


        return array;
    }
    public double[] Task_2_15(double[] A, double[] B, int k)
    {
        double[] output = new double[A.Length + B.Length];

        if (k >= A.Length || k < 0) return A;


        for (int i = 0; i <= k; i++) {
            output[i] = A[i]; }

        for (int i = 0; i < B.Length; i++) {
            output[k + 1 + i] = B[i]; }

        for (int i = k + 1; i < A.Length; i++) {
            output[B.Length + i] = A[i]; }

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
        int count = 0;
        int maxIndex = 0;
        int minIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < array[minIndex])
            {
                minIndex = i;
            }
        }
        if (maxIndex < minIndex)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > 0) {
                    average += array[i];
                    count++;
                }
            }
        }
        if (maxIndex > minIndex)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) { 
                average += array[i];
                count++;
                }
            }
        }
        if (count == 0) { return 0; }
        return Math.Round(average/count, 2);
    }
    public double[] Task_2_18(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_19(double[] array)
    {
        int maxIndex = 0;
        double s = 0;

        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }
        if (array[maxIndex] > s)
        {
            array[maxIndex] = 0;
        }
        else
        {
            array[maxIndex] *= 2;
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

        int maxIndex = 0;
        

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }

        if (array[maxIndex] < 1) { return output; }

        for (int i = 0; i < maxIndex; i++)
        {
            
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
        int maxIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }
        if (maxIndex % 2 == 0)
        {
            for (int i = 0; i < maxIndex; i += 2)
            {
                double temp = array[i + 1];
                array[i + 1] = array[i];
                array[i] = temp;
            }
        }
        else
        {
            for (int i = 0; i < maxIndex - 1; i += 2)
            {
                double temp = array[i + 1];
                array[i + 1] = array[i];
                array[i] = temp;
            }
        }

        for ( int i = 0; i < array.Length; i++) { Console.WriteLine(array[i]); }

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

        for (int i = 0; i < array.Length - 1; i ++)
        {
            int index = i;
            int c_count = 1;
            while (array[index] > array[index + 1])
            {
                c_count++;
                index++;
            }
            if (c_count > count) count = c_count;
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

        for (int i = 0; i < array.Length - 1; i ++)
        {
            int index = i;
            int c_count = 1;
            while ((index < array.Length - 1) && array[index] > array[index + 1])
            {
                c_count++;
                index++;
            }
            if (c_count > count) count = c_count;
        }

        for (int i = 0; i < array.Length - 1; i++)
        {
            int index = i;
            int c_count = 1;
            while ((index < array.Length - 1) && array[index] < array[index + 1])
            {
                c_count++;
                index++;
            }
            if (c_count > count) count = c_count;
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
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                count++;
            }
        }

        double[] res_array = new double[count];
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                res_array[index] = array[i];
                index++;
            }
        }

        return res_array;

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
