using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Net.Http.Headers;
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
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (sum == 0) return array;
            else array[i] = Math.Round(array[i] / sum, 2);
        }
        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        double sum = 0;
        double cred = 0;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                sum += array[i];
                count++;
            }
        }
        cred = Math.Round(sum / count, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = cred;
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
        double sred = 0;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            count++;
        }
        sred = Math.Round(sum / count, 2);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round((array[i] - sred), 2);
        }
        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double sum = 0;
        for (int i = 0; i < vector1.Length; i++)
        {
            sum += Math.Round((vector1[i] * vector2[i]), 2);
        }

        return Math.Round(sum, 2);
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;
        for (int i = 0; i < vector.Length; i++)
        {
            length += vector[i] * vector[i];
        }
        length = Math.Round(Math.Sqrt(length), 2);
        return length;
    }
    public double[] Task_1_7(double[] array)
    {
        double sum = 0;
        double sred = 0;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            count++;
        }
        sred = sum / count;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sred) array[i] = 0;
        }
        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) count++;
        }
            return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;
        double sum = 0;
        double sred = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            count++;
        }
        if (count == 0) return 0;
        sred = sum / count;
        count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sred) count++;
        }
        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > P && array[i] < Q) count++;
        }
        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        //double[] output = null;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                count++;
            }
        }
        double[] output = new double[count];
        int count2 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[count2] = array[i];
                count2++;
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
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0 || i % 2 == 0)
            {
                even[i / 2] = array[i];
            }
            else if (i == 1 || i % 2 == 1)
            {
                odd[count] = array[i];
                count++;
            }
        }
        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0) sum += array[i] * array[i];
            else break;
        }
        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] <= 0) y[i] = double.NaN;
            else y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
        }
        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        double minn = array[0];
        foreach(double x in array)
        {
            if (x < minn) minn = x;
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == minn) array[i] *= 2;
        }
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
        double minn = array[0];
        int count = 0;
        for (int i = 0; i < array.Length; i++) 
        {
            if (array[i] < minn)
            {
                minn = array[i];
                count = i;
            }
        }
        for (int i = 0; i < count; i++)
        {
            if (array[i] >= 0)
            { 
                array[i] *= 2;
            }
            else if (array[i] < 0)
            {
                array[i] /= 2;
            }
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
        double maxx = array[0], minn = array[0];
        int n = 0, m = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minn)
            {
                minn = array[i];
                n = i;
            }
            if (array[i] > maxx)
            {
                maxx = array[i];
                m = i;
            }
        }
        if (n >= m) return new double[0];
        int count = 0;
        for (int i = n + 1; i < m; i++)
        {
            if (array[i] < 0) count++;
        }
        double[] array2 = new double[count];
        int count2 = 0;
        for (int i = n + 1; i < m; i++)
        {
            if (array[i] < 0) array2[count2] = array[i];
            count2++;
        }
        return array2;
    }
    public double[] Task_2_6(double[] array, double P)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_7(double[] array)
    {
        double maxx = array[0];
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxx)
            {
                maxx = array[i];
                count = i;
            }
        }
        if (count == array.Length - 1)
        {
            return array;
        }
        else if (array[count + 1] >= 0)
        {
            array[count + 1] *= 2;
        }
        else if (array[count + 1] < 0)
        {
            array[count + 1] /= 2;
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
        double minn = array[0];
        double maxx = array[0];
        int n = 0, m = 0;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minn)
            {
                minn = array[i];
                n = i;
            }
            if (array[i] > maxx)
            {
                maxx = array[i];
                m = i;
            }
        }
        if (m + 1 < n)
        {
            for (int i = m + 1; i < n; i++)
            {
                average += array[i];
                count++;
            }
        }
        else if (n + 1 < m)
        {
            for (int i = n + 1; i < m; i++)
            {
                average += array[i];
                count++;
            }
        }
        else if (n == m || n + 1 == m || m + 1 == n) return 0;
        average = Math.Round(average / count, 2);
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
        int count = 0;
        double maxx = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                maxx = array[i];
                count = i;
            }
        }
        if (maxx == 0 || count == 0) return array;
        double[] array1 = new double[array.Length + 1];
        for (int i = 0; i < array1.Length; i++)
        {
            if (i <= count) array1[i] = array[i];
            else if (i == count + 1) array1[i] = P;
            else if (i > count + 1) array1[i] = array[i - 1];
        }
        return array1;
    }
    public double[] Task_2_12(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_13(double[] array)
    {
        double maxx = array[0];
        int count = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > maxx)
            {
                maxx = array[i];
                count = i;
            }
        }
        array[count] = count;
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
        double[] output = new double[A.Length + B.Length];
        if (k > A.Length - 1) return A;
        else
        {
            for (int j = 0; j <= k; j++)
            {
                output[j] = A[j];
            }
            for (int j = 1; j <= B.Length; j++)
            {
                output[k + j] = B[j - 1];
            }
            for (int j = 1; j < A.Length - k; j++)
            {
                output[k + B.Length + j] = A[k + j];
            }
            return output;
        }
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
        int count1 = 0;
        int count2 = 0;
        double maxx = array[0];
        double minn = array[0];
        double sum1 = 0;
        double sum2 = 0;
        int count3 = 0;
        int count4 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxx)
            {
                maxx = array[i];
                count1 = i;
            }
            if (array[i] < minn)
            {
                minn = array[i];
                count2 = i;
            }
            if (array[i] > 0)
            {
                sum1 += array[i];
                count3++; 
            }
            if (array[i] < 0)
            {
                sum2 += array[i];
                count4++;
            }
        }
        if (count1 < count2 && count3 != 0)
        {
            average = sum1 / count3;
        }
        else if (count2 < count1 && count4 != 0)
        {
            average = sum2 / count4;
        }
        else if (count1 == count2) return 0;
        return Math.Round(average, 2);
    }
    public double[] Task_2_18(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_19(double[] array)
    {
        double maxx = array[0];
        int count = 0;
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxx)
            {
                maxx = array[i];
                count = i;
            }
            sum += array[i];
        }
        if (maxx > sum) array[count] = 0;
        else array[count] *= 2;
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
        double maxx = array[0];
        int count = 1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxx) maxx = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == maxx)
            {
                array[i] += count;
                count++;
            }
        }
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
        double a = array[0];//временная переменная, куда мы копируем текущий элемент
        for (int i = 0; i < array.Length; i += 2)
        {
            for (int j = 0; j < array.Length - i - 2; j += 2)
            {
                if (array[j] > array[j + 2])
                {
                    a = array[j];
                    array[j] = array[j + 2];
                    array[j + 2] = a;
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
        double a = array[0];//временная переменная, куда мы копируем текущий элемент
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j + 1] >= 0) continue;
                else if (array[j + 1] < 0)
                {
                    if (array[j + 1] > array[j])
                    {
                        a = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = a;
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
        double[] X = new double[n], Y = new double[n];
        double x = 0, y = 0;
        double run = (b - a) / (double) (n - 1);
        for (int i = 0; i < n; i++)
        {
            x = a + i * run;
            y = Math.Round(Math.Cos(x) + x * Math.Sin(x), 2);
            x = Math.Round(x, 2);
            X[i] = x;
            Y[i] = y;
        }
        double globalMax = Y[0], globalMin = Y[0];
        foreach (double h in Y)
        {
            if (h > globalMax) globalMax = h;
            if (h < globalMin) globalMin = h;
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
        double[] array1 = new double[array.Length];
        int maxind = 0, minind = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[maxind]) maxind = i;
            if (array[i] < array[minind]) minind = i;
        }
        for (int i = 0; i < array.Length; i++)
        {
            array1[i] = Math.Round((2 * (array[i] - array[minind]) / (array[maxind] - array[minind])) - 1, 2);
        }
        return array1;
    }
    #endregion
}