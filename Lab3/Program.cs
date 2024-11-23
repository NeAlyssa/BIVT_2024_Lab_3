using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
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
        double s = 0;
        for (int i = 0; i < array.Length; i++)
            s += array[i];
        for (int i = 0; i < array.Length; i++)
            array[i] = Math.Round(array[i] / s, 2);


        // end
        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0;
        int count = 0;
        double ave;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                count++;
            }
        }
        ave = Math.Round(s / count, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                array[i] = ave;
        }

        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i < first.Length; i++)
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
        double ave;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        ave = s / array.Length;
        for (int i =0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - ave, 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        double s = 0;
        for (int i = 0; i < vector1.Length; i++)
        {
            product = Math.Round(product + vector1[i] * vector2[i], 2);
        }
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < vector.Length; i++)
        {
            length += vector[i] * vector[i];
        }
        length = Math.Round(Math.Sqrt(length), 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        double ave = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        ave = s / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > ave) array[i] = 0;
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
        double s = 0;
        double ave;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        ave = s / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > ave) count++;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > P && array[i] < Q) count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int a = 0;
        int b = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                a++;
        }
        output = new double[a];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[b] = array[i];
                b++;
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
        int a = 0;
        int b = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
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
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) break;
            sum += array[i] * array[i];
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] > 0)
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            else
                y[i] = double.NaN;
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
        double max = 0;
        double a = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                a = i;
            }

        }
        for (int i = 0; i < a; i++)
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
        double s = 0;
        double ave = 0;
        double max = 0;
        int a = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                a = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        ave = s / array.Length;
        for (int i = a + 1; i < array.Length; i++)
        {
                array[i] = Math.Round(ave, 2);
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
        double ave = 0;
        double dif = 0;
        int index = 0;
        double a = 0;
        if (array.Length > 0)
        {
            for (int i = 0; i < array.Length; i++)
            {
                s += array[i];
            }
            ave = s / array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                dif = Math.Abs(array[i] - ave);
                if (dif < Math.Abs(a - ave))
                {
                    a = array[i];
                    index = i;
                }
            }
            double[] newarray = new double[array.Length + 1];
            for (int i = 0; i < index + 1; i++)
                newarray[i] = array[i];
            newarray[index + 1] = P;
            for (int i = index + 1; i < array.Length; i++)
                newarray[i + 1] = array[i];
            array = newarray;
        }
        else return new double[0];
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
        int max = 0;
        int min = -1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[max])
            {
                max = i;
            }
        }
        for (int i = max + 1; i < array.Length; i++)
        {
            if (min == -1 || array[i] < array[min])
                min = i;
        }
        if (min != -1)
        {
            double a = array[max];
            array[max] = array[min];
            array[min] = a;
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

        double min = double.MaxValue;
        int mini = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && array[i] < min)
            {
                min = array[i];
                mini = i;
            }
        }
        if (mini != -1)
        {
            double[] output = new double[array.Length - 1];
            for (int i = 0; i < array.Length; i++)
            {
                if (i < mini) output[i] = array[i];
                else if (i > mini) output[i - 1] = array[i];
            }
            array = output;
        }

        //double min = 10000;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] > 0)
        //    {
        //        if (array[i] < min) min = array[i];
        //    }
        //}
        //if (min == 10000) return array;
        //double[] output = new double[array.Length - 1];
        //int index = 0;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] != min)
        //    {
        //        output[index] = array[i];
        //        index++;
        //    }
        //}


        //double[] newarray = new double[array.Length - 1];
        //int min =  -1;
        //double min1 = double.MaxValue;
        //int count = 0;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] > 0 && array[i] < min)
        //    {
        //        min = i;
        //        min1 = array[i];
        //    }
        //    if (array[i] > 0) count++;
        //}
        //if (count > 0)
        //{
        //    if (min != -1)
        //    {
        //        for (int i = 0; i < newarray.Length; i++)
        //        {
        //            if (i < min) newarray[i] = array[i];
        //            else newarray[i] = array[i + 1];
        //        }
        //    }
        //    array = newarray;
        //}


        //double min = 0;
        //int mini = -1;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] > 0 && array[i] < min)
        //    {
        //        mini = i;
        //        min = array[i];
        //    }
        //}
        //if (mini != -1)
        //    array[mini] = 0;



        //int min = -1;
        //for (int i = array.Length - 1; i >= 0 && array[i] >= 0; i--)
        //{
        //    if (min == -1 || array[i] < array[min]) 
        //    { 
        //        min = i; break;
        //    }
        //}
        //if (min != -1)
        //{
        //    array[min] = 0;
        //}

        //int min = 0;
        //double min1 = 0;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] > 0)
        //    {
        //        min1 = array[i];
        //        min = i;
        //    }
        //}
        //for (int i = min; i < array.Length; i++)
        //{
        //    if (array[i] > 0 && array[i] < min1)
        //    {
        //        min1 = array[i];
        //        min = i;
        //    }
        //}
        //for (int i = min; i < array.Length - 1; i++)
        //    array[i] = array[i + 1];

        //int min = -1;
        //double min1 = 0;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] > 0 && (min == -1 || array[i] < min1))
        //    {
        //        min1 = array[i];
        //        min = i;
        //    }
        //}
        //if (min != -1)
        //{
        //    for (int i = min; i < array.Length - 1; i++)
        //    {
        //        array[i] = array[i + 1];
        //    }
        //}


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
        int maxi = -1;
        int otri = -1;
        double max = double.MinValue;
        double s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxi = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                otri = i;
                break;
            }
        }
        if (maxi != array.Length - 1)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i > maxi) s += array[i];
            }
        }
        if (otri >= 0) array[otri] = Math.Round(s, 2);
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
        int maxi = 0;
        double max = double.MinValue;
        int otri = -1;
        double otr = 0;
        bool a = false;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxi = i;
            }
            if (a == false)
            {
                if (array[i] < 0) 
                { 
                    otri = i; 
                    a = true; 
                }
            }
        }        
        if (otri >= 0)
        {
            double term = array[maxi];
            array[maxi] = array[otri];
            array[otri] = term;
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
        double ave = 0;
        int count = 0;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        ave = s / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < ave)
                count++;
        }
        output = new int[count];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < ave)
            {
                output[index] = i;
                index++;
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
        double max1 = 0;
        double max2 = 0;
        int pol = array.Length / 2;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > max1)
                max1 = array[i];
        }
        for (int i = 1; i < array.Length; i += 2)
        {
            if (array[i] > max2)
                max2 = array[i];
        }
        if (max1 > max2)
        {
            for (int i = 0; i < pol; i++)
            {
                array[i] = 0;
            }
        }
        else
        {
            for (int i = pol; i < array.Length; i++)
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
        double min = double.MaxValue;
        int mini = 0;
        int otri = int.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                mini = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                otri = i;
                break;
            }
        }
        if (otri < mini)
        {
            for (int i = 0; i < array.Length; i += 2)
                sum += array[i];
        }
        else 
        {
            for (int i = 1; i < array.Length; i += 2)
                sum += array[i];
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
        double max = double.MinValue;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
        }
        for (int i = 0, j = 1; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                array[i] += j;
                j++;
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
        int index = 0;
        double[] output = new double[(array.Length + 1) / 2];
        for (int i = 0, j = 0; i < array.Length; i += 2, j++)
        {
            output[j] = array[i];
        }
        while (index < output.Length)
        {
            if (index == 0 ||  output[index] >= output[index - 1])
                index++;
            else
            {
                double temp = output[index];
                output[index] = output[index - 1];
                output[index - 1] = temp;
                index--;
                if (index < 0) index = 0;
            }
        }
        for (int i = 0, j = 0; i < array.Length; i += 2, j++)
        {
            array[i] = output[j];
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

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] < 0 && array[j] < 0 && array[i] < array[j])
                {
                    double temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }

        //int count = 0;
        //int index = 0;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] < 0) count++;
        //}
        //double[] output = new double[count];
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] < 0)
        //    {
        //        output[index] = array[i];
        //        index++;
        //    }
        //}
        //index = 0;
        //while (index < output.Length)
        //{
        //    if (index == 0 || output[index] <= output[index - 1]) index++;
        //    else
        //    {
        //        double temp = output[index];
        //        output[index] = output[index - 1];
        //        output[index - 1] = temp;
        //        index--;
        //    }
        //}
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] < 0)
        //    {
        //        array[i] = output[output.Length - 1 - index];
        //        index++;
        //    }
        //}

        //for (int i = 0; i < output.Length; i++)
        //{
        //    for (int j = i + 1; j < output.Length; j++)
        //    {
        //        if (output[i] < output[j])
        //        {
        //            double temp = output[i];
        //            output[i] = output[j];
        //            output[j] = temp;
        //        }
        //    }
        //}
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] < 0) count++;
        //}

        //int count = 0;
        //int index = 0;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] < 0) count++;
        //}
        //double[] output = new double[count];
        //for (int i = 0, j = 0; i < array.Length; i++)
        //{
        //    if (array[i] < 0)
        //    {
        //        output[j] = array[i];
        //        j++;
        //    }
        //}
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
        double X0 = 0, Y0 = 0;
        double g = (b - a) / (n - 1.0);
        X = new double[n];
        Y = new double[n];
        for (int i = 0; i < n; i++)
        {
            X0 = a + i * g;
            Y0 = Math.Round(Math.Cos(X0) + X0 * Math.Sin(X0), 2);
            X0 = Math.Round(X0, 2);
            X[i] = X0;
            Y[i] = Y0;
        }
        globalMax = Y[0];
        globalMin = Y[0];
        foreach (double z in Y)
        {
            if (z > globalMax)
                globalMax = z;
            if (z < globalMin)
                globalMin = z;
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
        int mini = 0;
        int maxi = 0;
        normalizedArray = new double[array.Length];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxi])
            {
                maxi = i;
            }
            else if (array[i] < array[mini])
            {
                mini = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            normalizedArray[i] = Math.Round(2 * (array[i] - array[mini]) / (array[maxi] - array[mini]) - 1, 2);
        }
        // end

        return normalizedArray;
    }
    #endregion
}
