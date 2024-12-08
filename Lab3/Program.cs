using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
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
        double summa = 0;
        foreach (double element in array)
        {
            summa += element;
        }
        for (int i = 0; i < array.Length; i++) {
            array[i] = Math.Round(array[i]/summa,2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double summa = 0;
        double n = 0;
        double avg;
        foreach (double element in array) {
            if (element > 0) {
                summa += element;
                n++;
            }
        }
        avg = Math.Round(summa / n,2);
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = avg;
            }
        }
        
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i < first.Length; i++) {
            sum[i] = Math.Round(first[i] + second[i],1);
            dif[i] = Math.Round(first[i] - second[i],1);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double summa = 0;
        double avg;
        foreach (double element in array) summa += element;
        avg = Math.Round(summa/array.Length,2);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i]-avg,2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for(int i = 0;i < vector1.Length; i++)
        {
            product += (vector1[i] * vector2[i]);
        }
        product = Math.Round(product,2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        foreach (double element in vector) length += (element * element);
        length = Math.Round(Math.Sqrt(length),2);
        // end

        return length;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double avg = 0; ;
        foreach (double element in array) avg += element;
        avg = Math.Round((avg / array.Length), 2);
        for(int i = 0;i < array.Length; i++)
        {
            if (array[i] > avg) array[i] = 0;
        }
        
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double avg = 0;
        foreach(double element in array)avg += element;
        avg = Math.Round(avg / array.Length);
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > avg)
            {
                count++;
            }
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        foreach(double element in array)
        {
            if ((element > P) && (element < Q)) count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                count++;
            }
        }
        output = new double[count];
        count = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[count] = array[i];
                count++;
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
        for (int i = 0; i < array.Length; i++)
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
        int count_even = 0;
        int count_odd = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(i % 2 == 0)
            {
                even[count_even] = array[i];
                count_even++;
            }
            else
            {
                odd[count_odd] = array[i];
                count_odd++;
            }
        }
        
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        bool check;
        for (int i = 0; i < array.Length; i++) {
            check = (array[i] >= 0);
            if(check == true)
            {
                sum += (array[i] * array[i]);
            }
            else
            {
                break;
            }
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        double each = 0; int count = 0; bool check = false;
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] > 0)
            {
                each = 0.5 * Math.Log(Math.E, x[i]);
                y[i] = each;
            }
            else
            {
                y[i] = double.NaN;
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
        double minimum = double.MaxValue;
        int index = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array [i] < minimum)
            {
                minimum = array [i];
                index = i;
            }
        }
        if (minimum >= 0) minimum = minimum * 2;
        else minimum = minimum / 2;
        array[index] = minimum;
        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        //double maximum = double.MinValue;
        //int index = 0;
        //for (int i = 0;i < array.Length; i++)
        //{
        //    if (array[i] > maximum)
        //    {
        //        maximum = array[i];
        //        index = i;
        //    }
        //}
        //for (int j = 0; j < index; j++)
        //{
        //        sum += array[j];
        //}
        // end

        return sum;
    }
    public double[] Task_2_3(double[] array)
    {
        // code here
        double minimum = double.MaxValue;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minimum)
            {
                minimum = array[i];
                index = i;
            }
        }
        for(int i = 0;i < index; i++)
        {
            if (array[i] >= 0) array[i] = array[i]*2;
            else array[i] = array[i] / 2;
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
        double[] mas = null;
        double minimum = double.MaxValue, maximum = double.MinValue;
        int min_index = 0, max_index = 0, count = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > maximum)
            {
                maximum = array[i];
                max_index = i;
            }
            if (array[i] < minimum)
            {
                minimum = array[i];
                min_index = i;
            }
            if (array[i] < 0) count++;
        }
        mas = new double[count];
        count = 0;
        if(Math.Abs(max_index - min_index) > 1)
        {
            if(max_index > min_index)
            {
                for(int i = (min_index + 1); i < max_index; i++)
                {
                    if (array[i] < 0)
                    {
                        mas[count] = array[i];
                        count++;
                    }
                }
            }
        }
        mas = new double[count];
        if (count > 0)
        {
            count = 0;
                for (int i = (min_index + 1); i < max_index; i++)
                {
                    if (array[i] < 0)
                    {
                        mas[count] = array[i];
                        count++;
                    }
                }
        }
        //end
        return mas;
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
        double maximum = double.MinValue;
        int max_index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maximum)
            {
                maximum = array[i];
                max_index = i;
            }
        }
        if (max_index < (array.Length - 1))
        {
            if (array[max_index + 1] < 0)
            {
                array[max_index + 1] = 0.5 * array[max_index + 1];
            }
            else
            {
                array[max_index + 1] = 2 * array[max_index + 1];
            }
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
        double maximum = double.MinValue, minimum = double.MaxValue;
        int max_index = 0, min_index = 0;
        double summa = 0, count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maximum)
            {
                maximum = array[i];
                max_index = i;
            }
            if (array[i] < minimum)
            {
                minimum = array[i];
                min_index = i;
            }
        }
        if (Math.Abs(min_index - max_index) > 1)
        {
            if(min_index < max_index)
            {
                for (int i = min_index + 1; i < max_index; i++)
                {
                    summa += array[i];
                    count++;
                }
            }
            if (max_index < min_index)
            {
                for (int i = max_index + 1; i < min_index; i++)
                {
                    summa += array[i];
                    count++;
                }
            }
            average = summa / count;
        }
        
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
        int last_index = -1;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] > 0)
            {
                last_index = i;
            }
        }
        if (last_index != -1)
        {
            double[] new_array = new double[array.Length + 1];
            for(int i = 0;i < new_array.Length; i++)
            {
                if (i <= last_index) new_array[i] = array[i];
                if (i == last_index + 1)
                {
                    new_array[i] = P;
                }
                if (i > last_index + 1) new_array[i] = array[i - 1];
            }
            array = new_array;
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
        double maximum = double.MinValue;
        int max_index = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > maximum)
            {
                maximum = array[i];
                max_index = i;
            }
        }
        array[max_index] = max_index;
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
        int stop = 0, count = 0;
        int k2 = k + B.Length;
        output = new double[A.Length + B.Length];
        for(int i = 0; i < output.Length; i++)
        {
            if(i <= k)
            {
                output[i] = A[i];
                stop++;
            }
            if(i > k && i < k2)
            {
                output[i] = B[count];
                count++;
                k2++;
            }
            if(i >= k2)
            {
                output[i] = A[stop];
                stop++;
            }
        }
        //end

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
        int maximum_index = 0, minimum_index = 0;
        double maximum = double.MinValue, minimum = double.MaxValue;
        double count = 0, summa = 0;
        for(int i = 0;i < array.Length; i++)
        {
            if (array[i] > maximum) {
                maximum = array[i];
                maximum_index = i;
            }
            if (array[i] < minimum) {
                minimum = array[i];
                minimum_index = i;
            }
        }
        if (maximum_index < minimum_index)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    summa += array[i];
                    count++;
                }
            }
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    summa += array[i];
                    count++;
                }
            }
        }
        if (count == 0) average = 0;
        else average = Math.Round(summa / count, 3);
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
        double maximum = double.MinValue;
        double summa = 0;
        int index = 0;
        for(int i = 0; i < array.Length; i++) {
            if (array[i] > maximum)
            {
                maximum = array[i];
                index = i;

            }
            summa += array[i];
        }
        if(maximum > summa) array[index] = 0;
        else array[index] = 2 * array[index];
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

        // end

        return output;
    }
    public double[] Task_3_2(double[] array)
    {
        // code here
        int max_count = 1;
        double max = double.MinValue;
        for (int i = 0; i < array.Length; i++) 
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                array[i] += max_count;
                max_count++;
            }
        }
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
        int len;
        if(array.Length % 2 == 0) len = array.Length / 2;
        else len = (array.Length / 2) + 1;
        double[] even = new double[len];
        int count = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[count] = array[i];
                count++;
            }
        }
        for (int i = 1, j = 2; i < len;)
        {
            if (i == 0 || even[i] >= even[i - 1])
            {
                i = j;
                j++;
            }
            else
            {
                double change = even[i];
                even[i] = even[i-1];
                even[i-1] = change;
                i--;
            }
        }
        count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(i % 2 == 0)
            {
                array[i] = even[count];
                count++;
            }
        }

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
        // code here
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                count++;
            }
        }
        double[] negative = new double[count];
        count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                negative[count] = array[i];
                count++;
            }
        }
        int len = negative.Length;
        count = 0;
        if (len > 1)
        {
            for (int i = 1, j = 2; i < len;)
            {
                if (i == 0 || negative[i] <= negative[i - 1])
                {
                    i = j;
                    j++;
                }
                else
                {
                    double change = negative[i];
                    negative[i] = negative[i - 1];
                    negative[i - 1] = change;
                    i--;
                }
            }
            for(int i = 0;i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = negative[count];
                    count++;
                }
            }
        }  
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

        // end

        return array;
    }
    public (double[], double[], double, double) Task_3_11(double a, double b, int n)
    {
        double[] X = null, Y = null;
        double globalMax = 0, globalMin = 0;

        // code here
        double each = (b - a) / (n - 1);
        double min = double.MaxValue, max = double.MinValue;
        X = new double[n];
        Y = new double[n];
        for (int i = 0;i < n; i++)
        {
            X[i] = a + each * i;
            Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
        }
        for(int i = 0;i < n; i++)
        {
            if (Y[i] < globalMin)
            {
                globalMin = Y[i];
            }
            if (Y[i] > globalMax)
            {
                globalMax = Y[i];
            }
        }
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
