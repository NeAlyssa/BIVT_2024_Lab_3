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
            if (s == 0) return array;
            else array[i] = Math.Round(array[i] / s, 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                count++;
            }
        }
        double avg = Math.Round(s / count, 2);
        for (int i = 0; i < array.Length; i++)
            if (array[i] > 0)
                array[i] = avg;
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] s = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i < first.Length; i++)
        {
            s[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = Math.Round(first[i] - second[i], 2);
        }
        // end

        return (s, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s = 0;
        for (int i = 0; i < array.Length; i++)
            s += array[i];
        double avg = Math.Round(s / array.Length, 2);
        for (int i = 0; i < array.Length; i++)
            array[i] = Math.Round(array[i] - avg, 2);
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < vector1.Length; i++)
            product += Math.Round(vector1[i] * vector2[i], 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < vector.Length; i++)
            length += Math.Round(vector[i] * vector[i], 2);
        // end

        return Math.Round(Math.Sqrt(length), 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        for (int i = 0; i < array.Length; i++)
            s += array[i];
        double avg = Math.Round(s / array.Length, 2);
        for (int i = 0; i < array.Length; i++)
            if (array[i] > avg)
                array[i] = 0;
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
        if (array[i] < 0)
            count++;
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;
        double s = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
            s += array[i];
        double avg = Math.Round(s / array.Length, 2);
        for (int i = 0; i < array.Length; i++)
            if (array[i] > avg)
                count++;
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
            if (array[i] > P && array[i] < Q)
                count++;
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        //double[] output = null;
        // code here
        int count = 0;
        for (int i = 0; i < array.Length; i++)
            if (array[i] > 0)
                count++;
        double[] output = new double[count];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
            if (array[i] > 0)
                output[index++] = array[i];
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
        int evenIndex = 0, oddIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
                even[evenIndex++] = array[i];
            else
                odd[oddIndex++] = array[i];
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double s = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
                break;
            s += Math.Round(array[i] * array[i], 2);
        }
        // end

        return s;
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
        return y;
        // end
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
        double s = 0;

        // code here
        int index = 0;
        for (int i = 1; i < array.Length; i++)
            if (array[i] > array[index])
                index = i;

        for (int i = 0; i < index; i++)
            s += array[i];

        return Math.Round(s, 2);
        // end
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
        int index = 0;
        for (int i = 1; i < array.Length; i++)
            if (array[i] > array[index])
                index = i;
        double s = 0;
        for (int i = 0; i < array.Length; i++)
            s += array[i];
        double avg = Math.Round(s / array.Length, 2);
        for (int i = index + 1; i < array.Length; i++)
            array[i] = avg;
        return array;
        // end
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
        for (int i = 0; i < array.Length; i++)
            s += array[i];
        double avg = Math.Round(s / array.Length, 2);

        int index = 0;
        double diff = Math.Abs(array[0] - avg);

        for (int i = 1; i < array.Length; i++)
        {
            double difference = Math.Abs(array[i] - avg);
            if (difference < diff)
            {
                diff = difference;
                index = i;
            }
        }

        double[] result = new double[array.Length + 1];
        for (int i = 0, j = 0; i < result.Length; i++, j++)
        {
            if (i == index + 1)
            {
                result[i] = P;
                j--;
            }
            else
            {
                result[i] = array[j];
            }
        }
        // end

        return result;
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
        int index = 0;
        for (int i = 1; i < array.Length; i++)
            if (array[i] > array[index])
                index = i;

        if (index == array.Length - 1)
            return array;

        int minIndex = index + 1;
        for (int i = index + 1; i < array.Length; i++)
            if (array[i] < array[minIndex])
                minIndex = i;

        double t = array[index];
        array[index] = array[minIndex];
        array[minIndex] = t;

        return array;
        // end
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
        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && (index == -1 || array[i] < array[index]))
            {
                index = i;
            }
        }

        if (index != -1)
        {
            double[] result = new double[array.Length - 1];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (i != index)
                    result[j++] = array[i];
            }
            return result;
        }
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
        int index = 0;
        for (int i = 1; i < array.Length; i++)
            if (array[i] > array[index])
                index = i;

        int negIndex = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                negIndex = i;
                break;
            }
        }

        if (negIndex != -1)
        {
            double s = 0;
            for (int i = index + 1; i < array.Length; i++)
                s += array[i];

            array[negIndex] = Math.Round(s, 2);
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
        int maxInd = 0;
        for (int i = 1; i < array.Length; i++)
            if (array[i] > array[maxInd])
                maxInd = i;

        int negInd = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                negInd = i;
                break;
            }
        }

        if (negInd != -1)
        {
            double temp = array[maxInd];
            array[maxInd] = array[negInd];
            array[negInd] = temp;
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
        //int[] output = null;

        // code here
        double s = 0;
        for (int i = 0; i < array.Length; i++)
            s += array[i];

        double avg = Math.Round(s / array.Length, 2);

        int count = 0;
        for (int i = 0; i < array.Length; i++)
            if (array[i] < avg)
                count++;

        int[] indices = new int[count];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
            if (array[i] < avg)
                indices[index++] = i;

        return indices;
        // end
    }
    public double Task_2_17(double[] array)
    {
        double avg = 0;

        // code here

        // end

        return avg;
    }
    public double[] Task_2_18(double[] array)
    {
        // code here
        double even = double.MinValue;
        double odd = double.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0 && array[i] > even)
                even = array[i];
            else if (i % 2 != 0 && array[i] > odd)
                odd = array[i];
        }

        int mid = array.Length / 2;
        if (even > odd)
        {
            for (int i = 0; i < mid; i++)
                array[i] = 0;
        }
        else
        {
            for (int i = mid; i < array.Length; i++)
                array[i] = 0;
        }

        return array;
        // end
    }
    public double[] Task_2_19(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double Task_2_20(double[] array)
    {
        double s = 0;

        // code here
        int negIndex = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                negIndex = i;
                break;
            }
        }

        int minIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[minIndex])
                minIndex = i;
        }

        if (negIndex != -1 && negIndex < minIndex)
        {
            for (int i = 0; i < array.Length; i += 2)
            {
                s += array[i];
            }
        }
        else
        {
            for (int i = 1; i < array.Length; i += 2)
            {
                s += array[i];
            }
        }

        return Math.Round(s, 2);
        // end
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
        int index = 0;
        for (int i = 1; i < array.Length; i++)
            if (array[i] > array[index])
                index = i;

        for (int i = 0; i < index - 1; i += 2)
        {
            double temp = array[i];
            array[i] = array[i + 1];
            array[i + 1] = temp;
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
        // code here
        int length = 0;
        int c = 1;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i - 1])
                c++;
            else
            {
                if (c > length)
                    length = c;
                c = 1;
            }
        }

        if (c > length)
            length = c;

        return length;
        // end
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
        int length = 0;
        int c = 1;
        bool isAscending = false;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[i - 1])
            {
                if (!isAscending)
                {
                    c = 2;
                    isAscending = true;
                }
                else
                    c++;
            }
            else if (array[i] < array[i - 1])
            {
                if (isAscending)
                {
                    c = 2;
                    isAscending = false;
                }
                else
                    c++;
            }
            else
                c = 1;

            if (c > length)
                length = c;
        }

        return length;
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
        int c = 0;
        for (int i = 0; i < array.Length; i++)
            if (array[i] >= 0)
                c++;

        double[] result = new double[c];
        int index = 0;

        for (int i = 0; i < array.Length; i++)
            if (array[i] >= 0)
                result[index++] = array[i];

        return result;
        // end
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
