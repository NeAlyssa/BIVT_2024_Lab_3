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
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] /= s;
            array[i] = Math.Round(array[i], 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0;
        double k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                k++;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = s / k;
                array[i] = Math.Round(array[i], 2);
            }
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
        double k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
            k++;
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] -= s / k;
            array[i] = Math.Round(array[i], 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < vector1.Length; i++)
        {
            product += vector1[i] * vector2[i];
            product = Math.Round(product, 2);
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
        double k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
            k++;
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > s/k) 
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
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                count++;
            }
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double s = 0;
        double k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
            k++;
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > s / k)
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
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > P && array[i] < Q)
            {
                count++;
            }
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
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[count++] = array[i];
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
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] < 0)
            {
                value = array[i];
                index = i;
                break;
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
        int evencount = 0;
        int oddcount = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i%2 == 0)
            {
                even[evencount++] = array[i];

            }
            else
            {
                odd[oddcount++] = array[i];
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
            if (array[i] < 0)
            {
                break;
            }
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
            if (x[i] <= 0)
            {
                y[i] = double.NaN;
            }
            else
            {
                y[i] = Math.Round(0.5 * Math.Log(x[i], Math.E), 2);
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
        double minimum = 10000000000;
        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minimum)
            {
                minimum = array[i];
                index = i;
            }
        }
        if (array[index] < 0)
        {
            array[index] /= 2;
        }
        else
        {
            array[index] *= 2;
        }
        // end

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
        // code here
        double minimum = 100000000;
        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minimum)
            {
                minimum=array[i];
                index = i;
            }
        }
        for (int i = 0; i < index; i++)
        {
            if (array[i] >= 0)
            {
                array[i] *= 2;
            }
            else
            {
                array[i] *= 0.5;
            }
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
        double minimum = 1000000000;
        double maximum = -100000000;
        int indexmax = -1;
        int indexmin = -1;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maximum)
            {
                maximum=array[i];
                indexmax=i;
            }
            if (array[i] < minimum)
            {
                minimum = array[i];
                indexmin=i;
            }
        }
        if (indexmax > indexmin)
        {
            for (int i = indexmin + 1; i < indexmax; i++)
            {
                if (array[i] < 0)
                {
                    count++;
                }
            }
        }
        else
        {
            for (int i = indexmax + 1; i < indexmin; i++)
            {
                if (array[i] < 0)
                {
                    count++;
                }
            }
        }
        double [] newarray = new double[count];
        int k = 0;
        if (indexmin > indexmax)
        {
            for (int i = indexmax + 1; i < indexmin; i++)
            {
                if (array[i] < 0)
                {
                    newarray[k++] = array[i];
                }
            }
        }
        else
        {
            for (int i = indexmin + 1; i < indexmax; i++)
            {
                if (array[i] < 0)
                {
                    newarray[k++] = array[i];
                }
            }
        }
        array = newarray;
        // end

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
        // code here
        double maximum = -100000000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maximum)
            {
                maximum = array[i];
            }
        }
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == maximum)
            {
                if (array[i + 1] >= 0) array[i + 1] *= 2;
                else array[i + 1] *= 0.5;
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
        double minimum = 1000000000;
        double maximum = -100000000;
        int indexmax = -1;
        int indexmin = -1;
        double s = 0;
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maximum)
            {
                maximum = array[i];
                indexmax = i;
            }
            if (array[i] < minimum)
            {
                minimum = array[i];
                indexmin = i;
            }
        }
        if (indexmin > indexmax && (indexmin - indexmax) > 1)
        {
            for (int i = indexmax + 1; i < indexmin; i++)
            {
                s += array[i];
                k++;
            }
        }
        else if (indexmin < indexmax && (indexmax - indexmin) > 1)
        {
            for (int i = indexmin + 1; i < indexmax; i++)
            {
                s += array[i];
                k++;
            }
        }
        else k = 1;
        average = s / k;
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
        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                index = i;
            }
        }
        double[] newarray = new double[array.Length + 1];
        if (index != -1)
        {
            for (int i=0; i < index + 1; i++)
            {
                newarray[i] = array[i];
            }
            newarray[index + 1] = P;
            for (int i=index + 2; i < newarray.Length; i++)
            {
                newarray[i] = array[i-1];
            }
            array = newarray;
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
        double maximum = -1000000;
        int index = -1;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > maximum)
            {
                maximum = array[i];
                index = i;
            }
        }
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] == maximum) array[i] = index;
        }
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
        if (k > A.Length)
        {
            output = new double[A.Length];
        }
        else
        {
            output = new double[A.Length + B.Length];
        }
        if (k < A.Length)
        {
            for (int i = 0; i <= k; i++)
            {
                output[i] = A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                output[i+k+1] = B[i];
            }
            for (int i = k + 1; i < A.Length; i++)
            {
                output[i+B.Length] = A[i];
            }
        }
        else
        {
            output = A;
        }
        // end

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
        double maximum = -1000000;
        double minimum = 1000000;
        int indexmax = -1;
        int indexmin = -1;
        double pols = 0;
        double otrs = 0;
        double polk = 0;
        double otrk = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                pols += array[i];
                polk++;
            }
            if (array[i] < 0)
            {
                otrs += array[i];
                otrk++;
            }
            if (array[i] > maximum)
            {
                maximum = array[i];
                indexmax = i;
            }
            if (array[i] < minimum)
            {
                minimum = array[i];
                indexmin = i;
            }
        }
        if (indexmax < indexmin && polk != 0)
        {
            average = pols / polk;
        }
        else if (indexmax > indexmin && otrk != 0)
        {
            average = otrs / otrk;
        }
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
        double maximum = -1000000;
        int indexmax = -1;
        double s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
            if (maximum < array[i])
            {
                maximum = array[i];
                indexmax = i;
            }
        }
        if (maximum > s)
        {
            array[indexmax] = 0;
        }
        else
        {
            array[indexmax] *= 2;
        }
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
        double maximum = -100000;
        int count = 1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maximum)
            {
                maximum = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == maximum)
            {
                array[i] += count;
                count++;
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
        for (int i = 0; i < array.Length; i += 2)
        {
            for (int j = 0; j < array.Length - i - 2; j += 2)
            {
                if (array[j] > array[j + 2])
                {
                    double temp = array[j + 2];
                    array[j+2] = array[j];
                    array[j] = temp;
                }
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
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] < 0 && array[j+1] < 0 && array[j] < array[j + 1])
                {
                    double temp = array[j + 1];
                    array[j+1] = array[j];
                    array[j] = temp;
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
        X = new double[n];
        Y = new double[n];
        double x = 0;
        double y = 0;
        double k = (b - a) / (double) (n - 1);
        for (int i = 0; i < n; i++)
        {
            x = a + i * k;
            y = Math.Cos(x) + x * Math.Sin(x);
            X[i] = x;
            Y[i] = y;
        }
        globalMax = Y[0];
        globalMin = Y[0];
        for (int i = 0; i < Y.Length; i++)
        {
            if (Y[i] > globalMax) globalMax = Y[i];
            if (Y[i] < globalMin) globalMin = Y[i];
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
        

        // code here
        double[] normalizedArray = new double[array.Length];
        int indexmin = 0;
        int indexmax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[indexmax])
            {
                indexmax = i;
            }
            if (array[i] < array[indexmin])
            {
                indexmin = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            normalizedArray[i] = 2*(array[i] - array[indexmin]) / (array[indexmax] - array[indexmin]) - 1;
        }
        // end

        return normalizedArray;
    }
    #endregion
}