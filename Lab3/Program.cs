using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
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
        // code here
        for (int i = 0; i <= 5; i++)
        {
            sum += array[i];
        }

        if (sum == 0)
            return array;

        for (int i = 0; i <= 5; i++)
            array[i] = Math.Round(array[i] / sum, 2);
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        double sum = 0;
        double cnt = 0;
        // code here
        for (int i = 0; i <= 7; i++)
        {
            if (array[i] > 0)
            {
                cnt++;
                sum += array[i];
            }
        }
        double sr = Math.Round(sum / cnt, 2);
        for (int i = 0; i <= 7; i++)
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
        for (int i = 0; i <= 3; i++)
        {
            sum[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = Math.Round((first[i] - second[i]), 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i <= 4; i++)
        {
            sum += array[i];
        }
        double sr = Math.Round(sum / 5, 2);
        for (int i = 0; i <= 4; i++)
        {
            array[i] = Math.Round(array[i] - sr, 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i <= 3; i++)
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
        for (int i = 0; i <= 4; i++)
        {
            length += Math.Round((vector[i] * vector[i]), 2);
        }
        length = Math.Round(Math.Sqrt(length), 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        double sum = 0;
        double sr = 0;
        // code here
        for (int i = 0; i <= 6; i++)
        {
            sum += array[i];
        }
        sr = Math.Round(sum / 7, 2);
        for (int i = 0; i <= 6; i++)
        {
            if (array[i] > sr)
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
        for (int i = 0; i <= 5; i++)
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
        double sum = 0;
        double sr = 0;
        // code here
        for (int i = 0; i <= 7; i++)
        {
            sum += array[i];
        }
        sr = Math.Round(sum / 8, 2);
        for (int i = 0; i <= 7; i++)
        {
            if (array[i] > sr)
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
        for (int i = 0; i <= 9; i++)
        {
            if (array[i] < Q && array[i] > P)
                count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;
        int sz = 0;
        // code here
        for (int i = 0; i <= 9; i++)
        {
            if (array[i] > 0)
                sz++;
        }
        output = new double[sz];
        int ind = 0;
        for (int i = 0; i <= 9; i++)
        {
            if (array[i] > 0)
            {
                output[ind] = array[i];
                ind++;
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
        for (int i = 0; i <= 7; i++)
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
        int m1 = 0;
        for (int i = 0; i <= 9; i++)
        {
            if (i % 2 == 0)
            {
                even[m1++] = array[i];
            }
        }
        int m2 = 0;
        for (int i = 0; i <= 9; i++)
        {
            if (i % 2 != 0)
            {
                odd[m2++] = array[i];
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i <= 10; i++)
            if (array[i] >= 0)
            {
                sum += array[i] * array[i];
            }
            else
            {
                break;
            }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i = 0; i <= 9; i++)
        {
            if (x[i] <= 0)
            {
                y[i] = double.NaN;
            }
            else
            {
                y[i] = Math.Round(Math.Log(x[i]) * 0.5, 2);
            }
            Console.WriteLine($"y={y[i]} x={x[i]}");
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        double mn = double.MaxValue;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            mn = Math.Min(mn, array[i]);
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == mn && array[i] > 0)
            {
                array[i] = mn * 2;
            }
            if (array[i] == mn && array[i] < 0)
            {
                array[i] = mn / 2;
            }
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
        double mn = double.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            mn = Math.Min(mn, array[i]);
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == mn)
            {
                break;
            }
            if (array[i] < 0)
            {
                array[i] /= 2;
            }
            else
            {
                array[i] *= 2;
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
        double mx = double.MinValue;
        double mn = double.MaxValue;
        int mnpos = 0;
        int mxpos = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mx)
            {
                mx = array[i];
                mxpos = i;
            }
            if (array[i] < mn)
            {
                mn = array[i];
                mnpos = i;
            }
        }
        int k = 0;
        for (int i = Math.Min(mnpos, mxpos) + 1; i < Math.Max(mnpos, mxpos); i++)
        {
            if (array[i] < 0)
            {
                k++;
            }
        }
        if (k == 0)
            return new double[0];
        double[] ansArray = new double[k];
        int iter = 0;
        for (int i = Math.Min(mnpos, mxpos) + 1; i < Math.Max(mnpos, mxpos); i++)
        {
            if (array[i] < 0)
            {
                ansArray[iter++] = array[i];

            }
        }
        // end

        return ansArray;
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
        double mx = double.MinValue;
        int mxpos = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mx)
            {
                mx = array[i];
                mxpos = i;
            }
        }
        if (mxpos == array.Length - 1)
        {
            return array;
        }
        if (array[mxpos + 1] > 0)
        {
            array[mxpos + 1] *= 2;
        }
        else
        {
            array[mxpos + 1] /= 2;
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
        double mx = double.MinValue;
        double mn = double.MaxValue;
        int mnpos = 0;
        int mxpos = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mx)
            {
                mx = array[i];
                mxpos = i;
            }
            if (array[i] < mn)
            {
                mn = array[i];
                mnpos = i;
            }
        }
        int k = Math.Abs(mxpos - mnpos) - 1;
        if (k == 0)
            return average;

        for (int i = Math.Min(mnpos, mxpos) + 1; i < Math.Max(mnpos, mxpos); i++)
            average += array[i];

        average /= k;
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
        int pos = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                pos = i;
            }
        }
        if (pos == -1)
        {
            return array;
        }
        double[] arr = new double[array.Length + 1];
        int ind = 0;
        for (int i = 0; i < pos + 1; i++)
        {
            arr[ind++] = array[i];
        }
        arr[ind++] = P;
        for (int i = pos + 1; i < array.Length; i++)
            arr[ind++] = array[i];
        // end

        return arr;
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
        int mxpos = 0;
        double mx = double.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0 && array[i] > mx)
            {
                mx = array[i];
                mxpos = i;
            }
        }
        array[mxpos] = mxpos;
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
        if (k > A.Length - 1)
            return A;
        output = new double[A.Length + B.Length];
        int j = 0;
        k++;
        for (int i = 0; i < k; i++)
            output[j++] = A[i];
        for (int i = 0; i < B.Length; i++)
            output[j++] = B[i];
        for (int i = k; i < A.Length; i++)
            output[j++] = A[i];
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
        double mx = double.MinValue;
        double mn = double.MaxValue;
        int mnpos = 0;
        int mxpos = 0;
        double s1 = 0;
        double s2 = 0;
        int cnt1 = 0;
        int cnt2 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                s1 += array[i];
                cnt1++;
            }
            else if (array[i] < 0)
            {
                s2 += array[i];
                cnt2++;
            }
            if (array[i] > mx)
            {
                mx = array[i];
                mxpos = i;
            }
            if (array[i] < mn)
            {
                mn = array[i];
                mnpos = i;
            }
        }
        if (mxpos < mnpos)
        {
            if (cnt1 == 0)
                return 0;
            average = s1 / cnt1;
        } else {
            if (cnt2 == 0)
                return 0;
            average = s2 / cnt2;
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
        double maxElem = double.MinValue, sm = 0;
        int maxIdx = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sm += array[i];
            if (array[i] > maxElem)
            {
                maxElem = array[i];
                maxIdx = i;
            }
        }
        if (maxElem > sm)
        {
            array[maxIdx] = 0;
        }
        else
        {
            array[maxIdx] *= 2;
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

        // end

        return array;
    }
    public double[] Task_3_3(double[] array)
    {
        // code here
        double mx = double.MinValue; 
        int mxpos = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mx)
            {
                mx = array[i];
                mxpos = i;
            }
        }
        for (int i = 1; i < mxpos; i += 2)
        {
            (array[i], array[i - 1]) = (array[i - 1], array[i]);
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
        int count = 0;

        // code here
        int now = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] <= array[i - 1])
            {
                now++;
            }
            else
            {
                count = Math.Max(count, now);
                now = 1;
            }
        }
        count = Math.Max(count, now);
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
        int tmp = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] <= array[i - 1])
            {
                tmp++;
            }
            else
            {
                count = Math.Max(count, tmp);
                tmp = 1;
            }
        }
        count = Math.Max(count, tmp);
        tmp = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] >= array[i - 1])
            {
                tmp++;
            }
            else
            {
                count = Math.Max(count, tmp);
                tmp = 1;
            }
        }
        count = Math.Max(count, tmp);
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

        return (X, Y, globalMax, globalMin);
    }
    public double[] Task_3_12(double[] array)
    {
        int cnt = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                cnt++;
            }
        }
        double[] ans = new double[array.Length - cnt];
        cnt = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) continue;
            ans[cnt] = array[i];
            cnt++;
        }
        // end

        return ans;
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