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
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] /= sum;
            array[i] = Math.Round(array[i], 2);
        }
        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        double av = 0;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                av += array[i];
                count++;
            }
        }
        av /= count;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) array[i] = av;
            array[i] = Math.Round(array[i], 2);
        }
        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];
        for (int i = 0; i < first.Length; i++ )
        {
            sum[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = Math.Round(first[i] - second[i], 2);
        }
        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        double av = 0;
        for (int i = 0; i < array.Length; i++)
        {
            av += array[i];
        }
        av /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] -= av;
            array[i] = Math.Round(array[i], 2);
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
        for (int i = 0; i < vector.Length; i++)
        {
            length += vector[i] * vector[i];
        }
        length = Math.Sqrt(length);
        return Math.Round(length, 2);
    }
    public double[] Task_1_7(double[] array)
    {
        double av = 0;
        for (int i = 0; i < array.Length; i++)
        {
            av += array[i];
        }
        av /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > av) array[i] = 0;
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
        double av = 0;
        for (int i = 0; i < array.Length; i++)
        {
            av += array[i];
        }
        av /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > av) count++;
        }
        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (P < array[i] && array[i] < Q) count++;
        }
        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;
        int n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) n++;
        }
        output = new double[n];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[j] = array[i];
                j++;
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
        double[] odd = new double[array.Length / 2];
        for (int i = 0; i < even.Length; i++)
        {
            even[i] = array[i * 2];
        }
        for (int i = 0; i < odd.Length; i++)
        {
            odd[i] = array[i * 2 + 1];
        }

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) break;
            sum += array[i] * array[i];
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
            Console.WriteLine($"{x[i]}\t{y[i]}");
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
        int maxInd = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[maxInd] < array[i]) maxInd = i;
        }
        for (int i = 0; i < maxInd; i++)
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
        int maxInd = 0;
        double av = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[maxInd] < array[i]) maxInd = i;
            av += array[i];
        }
        av /= array.Length;
        av = Math.Round(av, 2);
        for (int i = maxInd + 1; i < array.Length; i++)
        {
            array[i] = av;
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
        double av = 0;
        for (int i = 0; i < array.Length; i++)
        {
            av += array[i];
        }
        av /= array.Length;
        int ind = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (Math.Abs(array[ind] - av) > Math.Abs(array[i] - av)) ind = i;
        }
        double[] ans = new double[array.Length + 1];
        for (int i = 0; i <= ind; i++) ans[i] = array[i];
        ans[ind + 1] = P;
        for (int i = ind + 2; i < ans.Length; i++) ans[i] = array[i - 1];
        return ans;
    }
    public double[] Task_2_7(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_8(double[] array)
    {
        int maxInd = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[maxInd] < array[i]) maxInd = i;
        }
        int minInd = maxInd;
        for (int i = maxInd; i < array.Length; i++)
        {
            if (array[minInd] > array[i]) minInd = i;
        }
        (array[maxInd], array[minInd]) = (array[minInd], array[maxInd]);
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
        int minInd = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                minInd = i;
                break;
            }
        }
        if (minInd == -1) return array;

        for (int i = minInd + 1; i < array.Length; i++)
        {
            if (array[i] > 0 && array[minInd] > array[i]) minInd = i;
        }
        double[] ans = new double[array.Length - 1];
        for (int i = 0; i < minInd; i++) ans[i] = array[i];
        for (int i = minInd + 1; i < array.Length; i++) ans[i - 1] = array[i]; 
        return ans;
    }
    public double[] Task_2_11(double[] array, double P)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_12(double[] array)
    {
        int firstM = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                firstM = i;
                break;
            }
        }
        if (firstM == -1) return array;
        int maxInd = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[maxInd] < array[i]) maxInd = i;
        }
        double sum = 0;
        for (int i = maxInd + 1; i < array.Length; i++) sum += array[i];
        array[firstM] = Math.Round(sum, 2);
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
        int firstM = -1, maxInd = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0 && firstM == -1) firstM = i;
            if (array[maxInd] < array[i]) maxInd = i;
        }
        if (firstM == -1) return array;
        (array[firstM], array[maxInd]) = (array[maxInd], array[firstM]);
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
        double av = 0;
        foreach (int x in array) av += x;
        av /= array.Length;
        int n = 0;
        foreach (int x in array) if (x < av) n++;
        output = new int[n];
        for (int i = 0, j = 0; i < array.Length; i++)
        {
            if (array[i] < av)
            {
                output[j] = i;
                j++;
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
        int maxEven = 0, maxOdd = 0;
        for (int i = 0; i < array.Length; i += 2) if (array[maxEven] < array[i]) maxEven = i;
        for (int i = 1; i < array.Length; i += 2) if (array[maxOdd] < array[i]) maxOdd = i;
        if (array[maxEven] >= array[maxOdd]) for (int i = 0; i < array.Length / 2; i++) array[i] = 0;
        else for (int i = array.Length / 2; i < array.Length; i++) array[i] = 0;
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
        int firstM = -1, minInd = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0 && firstM == -1) firstM = i;
            if (array[minInd] > array[i]) minInd = i;
        }
        if (firstM == -1) return 0; 
        int start = 1;
        if (firstM < minInd) start = 0;
        for (int i = start; i < array.Length; i += 2) sum += array[i];
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
        double max = array[0];
        foreach (int x in array) if (x > max) max = x;
        int ind = 1;
        for (int i = 0; i < array.Length; i++) if (array[i] == max) array[i] += ind++;
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

    public void Sort(double[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                }
            }
        }
    }
    public double[] Task_3_5(double[] array)
    {
        int n = (int) Math.Ceiling(array.Length / 2.0);
        double[] sort = new double[n];
        for (int i = 0, j = 0; i < array.Length; i += 2, j++)
        {
            sort[j] = array[i];
        }
        Sort(sort);
        for (int i = 0, j = 0; i < array.Length; i += 2, j++)
        {
            array[i] = sort[j];
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
        int n = 0;
        foreach (double x in array) if (x < 0) n++;
        double[] sort = new double[n];
        int ind = 0;
        foreach (double x in array) if (x < 0) sort[ind++] = x;
        Sort(sort);
        for (int i = 0; i < n / 2; i++) (sort[i], sort[n - 1 - i]) = (sort[n - 1 - i], sort[i]);
        for (int i = 0, j = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = sort[j];
                j++;
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
        double[] X = null, Y = null;
        double globalMax = 0, globalMin = 0;
        X = new double[n];
        Y = new double[n];
        double step = (b - a) / (double) (n - 1);
        for (int i = 0; i < n; i++)
        {
            double x = a + i * step;
            X[i] = Math.Round(x, 2);
            Y[i] = Math.Round(Math.Cos(x) + x * Math.Sin(x), 2);

        }
        globalMax = Y[0];
        globalMin = Y[0];
        foreach (double y in Y)
        {
            if (y > globalMax) globalMax = y;
            if (y < globalMin) globalMin = y;
        }
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
        double[] normalizedArray = new double[array.Length];
        int imax = 0, imin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[imax]) imax = i;
            if (array[i] < array[imin]) imin = i;
        }
        double k = 2 / (array[imax] - array[imin]);
        for (int i = 0; i < array.Length; i++)
        {
            normalizedArray[i] = Math.Round((array[i] - array[imin]) * k - 1, 2);
        }
        return normalizedArray;
    }
    #endregion
}