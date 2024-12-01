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
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] / sum, 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double k = 0;
        double s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                k += 1;
                s += array[i];
            }

        }
        double sr = Math.Round(s / k, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = sr;
            }
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here

        for (int i = 0; i < 4; i++)
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
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        sum /= 5;
        sum = Math.Round(sum, 2);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - sum, 2);
        }

        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here

        for (int i = 0; i < 4; i++)
        {
            product += vector1[i] * vector2[i];
        }
        // end

        product = Math.Round(product, 2);
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

        return Math.Round(length, 4); 
    }
    public double[] Task_1_7(double[] array)
    {
        // code here

        double sum = 0;
        for (int i = 0; i < 7; i++)
        {
            sum += array[i];
        }
        sum /= 7;
        for (int i = 0; i < 7; i++)
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

        for (int i = 0; i < 6; i++)
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

        double sum = 0;
        for (int i = 0; i < 8; i++)
        {
            sum += array[i];
        }
        sum /= 8;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > sum)
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

        for (int i = 0; i < 10; i++)
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
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                count++;
            }
        }
        output = new double[count];
        int k = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                output[k] = array[i];
                k++;
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

        for (int i = 0; i < 8; i++)
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
        double[] odd = new double[array.Length / 2];

        // code here

        int count1 = 0;
        for (int i = 0; i < 10; i += 2)
        {
            even[count1] = array[i];
            count1++;
        }
        int count2 = 0;
        for (int i = 1; i < 10; i += 2)
        {
            odd[count2] = array[i];
            count2++;
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here

        int k = 0;
        for (int i = 0; i < 11; i++)
        {
            if (array[i] >= 0)
            {
                k += 1;
            }
            else break;
        }
        for (int i = 0; i < k; i++)
        {
            sum += Math.Pow(array[i], 2);
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
            {
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            }
            else
            {
                y[i] = double.NaN;
            }
        }

        Console.WriteLine("Массив x: Массив y:");
        for (int i = 0; i < x.Length; i++)
        {
            Console.WriteLine($"{x[i],5:F2}     {y[i],5:F2}");
        }
        // end

        return y;
    }
    #endregion
    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        int minIndex = 0;
        double minValue = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minValue)
            {
                minValue = array[i];
                minIndex = i;
            }
        }

        if (minValue < 0)
        {
            array[minIndex] /= -2; 
        }
        else
        {
            array[minIndex] *= 2;  
        }
        //end

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

        double m = 12345678900987654321;
        int index = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < m)
            {
                m = array[i];
                index = i;
            }

        }
        for (int i = 0; i < index; i++)
        {
            if (array[i] > 0) array[i] *= 2;
            else array[i] *= 0.5;
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
        int minindex = 0, maxindex = 0;
        int l = 0;


        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[minindex])
            {
                minindex = i;
            }

        }
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxindex])
            {
                maxindex = i;
            }

        }

        if (maxindex > minindex)
        {
            for (int i = minindex + 1; i < maxindex; i++)
            {
                if (array[i] < 0) l++;
            }
        }
        if (maxindex < minindex)
        {
            for (int i = maxindex + 1; i < minindex; i++)
            {
                if (array[i] < 0) l++;
            }
        }


        double[] negativeArray = new double[l];

        int count = 0;
        if (maxindex > minindex)
        {
            for (int i = minindex + 1; i < maxindex; i++)
            {
                if (array[i] < 0)
                {
                    negativeArray[count] = array[i];
                    count++;
                }
            }
        }
        if (maxindex < minindex)
        {
            for (int i = maxindex + 1; i < minindex; i++)
            {
                if (array[i] < 0)
                {
                    negativeArray[count] = array[i];
                    count++;
                }
            }
        }
        // end

        return negativeArray;
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

        int index = -1;
        double maxi = -123451234567890;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= maxi)
            {
                index = i;
                maxi = array[i];
            }
        }
        if (index + 1 < array.Length)
        {
            if (array[index + 1] >= 0) array[index + 1] *= 2;
            else array[index + 1] *= 0.5;
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

        double mini = 12345678900987654321;
        double maxi = -123456789054321;
        int minindex = 0;
        int maxindex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] <= mini)
            {
                minindex = i;
                mini = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= maxi)
            {
                maxindex = i;
                maxi = array[i];
            }
        }
        double count = 0;
        double sum = 0;
        int n = Math.Max(minindex, maxindex);
        int k = Math.Min(minindex, maxindex);
        for (int i = k + 1; i < n; i++)
        {
            count++;
            sum += array[i];
        }
        if (count == 0) return 0;
        average = sum / count;



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
        int lastPositiveIndex = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                lastPositiveIndex = i;
            }
        }
        if (lastPositiveIndex != -1)
        {
            double[] newArray = new double[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            newArray[lastPositiveIndex + 1] = P;

            for (int i = lastPositiveIndex + 1; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }


            array = newArray;
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

        double m = -123456;
        double index = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > m)
            {
                index = (double)i;
                m = array[i];
            }
        }
        array[(int)index] = index;
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

        double[] output = null;
        // code here

        if (k >= A.Length) return A;
        output = new double[A.Length + B.Length];

        for (int i = 0; i <= k; i++)
        {
            output[i] = A[i];
        }

        for (int i = k + 1, n = 0; n < B.Length; i++, n++)
        {
            output[i] = B[n];
        }
        for (int i = B.Length + 1 + k, n = k + 1; n < A.Length; i++, n++)
        {
            output[i] = A[n];
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
        int minindex = 0;
        int maxindex = 0;
        double maxi = -1234567890987654321;
        double mini = 1234567890987654321;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= maxi)
            {
                maxi = array[i];
                maxindex = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] <= mini)
            {
                mini = array[i];
                minindex = i;
            }
        }
        int count = 0;
        double sum = 0;
        if (maxindex < minindex)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    count++;
                    sum += array[i];
                }
            }
        }
        if (maxindex > minindex)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    count++;
                    sum += array[i];
                }
            }
        }
        if (count == 0) return average;
        average = sum / count;


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

        double sum = 0;
        double maxi = -109876543212345678;
        int maxindex = 0;
        for (int i = 0; i < array.Length; i++)
        { sum += array[i]; }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= maxi)
            {
                maxi = array[i];
                maxindex = i;
            }
        }
        if (maxi > sum) array[maxindex] = 0;
        else if (array[maxindex] < 0) array[maxindex] *= 0.5;
        else array[maxindex] *= 2;
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
        int k = 1;
        double maxi = -123456782123457;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= maxi)
            {
                maxi = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == maxi)
            {
                array[i] += k;
                k++;
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

        double[] output = new double[(array.Length / 2) + (array.Length % 2)];
        int k = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            output[k] = array[i];
            k++;
        }
        for (int i = 0; i < output.Length; i++)
        {
            for (int j = 0; j < output.Length - 1; j++)
            {
                if (output[j] > output[j + 1])
                {
                    double temp = output[j];
                    output[j] = output[j + 1];
                    output[j + 1] = temp;
                }
            }
        }

        int c = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            array[i] = output[c];
            c++;

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
            if (array[i] < 0) count++;
        }
        double[] output = new double[count];
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                output[k] = array[i];
                k++;
            }
        }
        for (int i = 0; i < output.Length - 1; i++)
        {
            double x = output[i];
            int y = i;
            for (int j = i + 1; j < output.Length; j++)
            {
                if (output[j] > x)
                {
                    x = output[j];
                    y = j;
                }
            }
            output[y] = output[i];
            output[i] = x;
        }
        int p = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = output[p];
                p++;
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
        double[] X = new double[n], Y = new double[n];
        double globalMax = 0, globalMin = 0;

        // code here
        double k = 0;
        // code here
        double h = (b - a) / (n - 1);
        for (int i = 0; i < n; i++)
        {
            k = a + i * h;
            Y[i] = Math.Round(Math.Cos(k) + k * Math.Sin(k), 2);
            X[i] = Math.Round(k, 2);
        }
        globalMin = Y[0];
        globalMax = Y[0];

        foreach (double i in Y)
        {
            if (i > globalMax) globalMax = i;
            if (i < globalMin) globalMin = i;
        }

        // end

        return (X, Y, globalMax, globalMin);
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
        double[] normalizedArray = new double[array.Length];

        // code here
        double min = array[0];
        double max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min) min = array[i];
            if (array[i] > max) max = array[i];
        }

        double range = max - min;

        for (int i = 0; i < array.Length; i++)
        {
            if (range == 0)
            {
                normalizedArray[i] = 0; 
            }
            else
            {
                normalizedArray[i] = Math.Round(2 * ((array[i] - min) / range) - 1, 2);
            }
        }
        double[] restoredArray = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            restoredArray[i] = Math.Round(min + ((normalizedArray[i] + 1) / 2) * range, 2);
        }
        // end

        return normalizedArray;
    }
    #endregion
}