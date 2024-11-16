using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Transactions;
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
        for (int i = 0; i < array.Length; i++) s += array[i];
        for (int i = 0; i < array.Length; i++) array[i] = Math.Round(array[i] / s, 2);
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0, a;
        int b = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                b++;
            }
        }
        a = Math.Round(s / b, 2);
        for (int i = 0; i < array.Length; i++) if (array[i] > 0) array[i] = a;
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
        for (int i = 0; i < array.Length; i++) s += array[i];
        for (int i = 0; i < array.Length; i++) array[i] = Math.Round(array[i] - s / array.Length, 2);
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < vector1.Length; i++) product += vector1[i] * vector2[i];
        product = Math.Round(product, 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < vector.Length; i++) length += vector[i] * vector[i];
        length = Math.Round(Math.Sqrt(length), 2);
        // end

        return Math.Round(length, 4);
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        for (int i = 0; i < array.Length; i++) s += array[i];
        for (int i = 0; i < array.Length; i++) if (array[i] > s / array.Length) array[i] = 0;
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        for (int i = 0; i < array.Length; i++) if (array[i] < 0) count++;
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double s = 0;
        for (int i = 0; i < array.Length; i++) s += array[i];
        for (int i = 0; i < array.Length; i++) if (array[i] > s / array.Length) count++;
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for (int i = 0; i < array.Length; i++) if ((array[i] > P) && (array[i] < Q)) count++;
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int n = 0, j = 0;
        for (int i = 0; i < array.Length; i++) if (array[i] > 0) n++;
        output = new double[n];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[j] = array[i];
                j++;
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
        for (int i = 0; i < array.Length; i++) if (array[i] < 0)
        {
            value = array[i];
            index = i;
        }
        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length / 2];

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0) { even[i / 2] = array[i]; } else { odd[i / 2] = array[i]; }
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
            y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            if (x[i] <= 0) y[i] = double.NaN;
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        double mn = double.MaxValue;
        for (int i = 0; i < array.Length; i++) if (array[i] < mn) mn = array[i];
        for (int i = 0; i < array.Length; i++) if (array[i] == mn)
            {
                if (array[i] > 0) array[i] *= 2;
                if (array[i] < 0) array[i] /= 2;
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
        for (int i = 0; i < array.Length; i++) if (array[i] < mn) mn = array[i];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == mn) break;
            if (array[i] > 0) { array[i] *= 2; } else { array[i] /= 2; }
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
        double mn = double.MaxValue, mx = double.MinValue;
        int mndex = 0, mxdex = 0;
        int n = 0, j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < mn) 
            {
                mn = array[i];
                mndex = i;
            }
            if (array[i] > mx)
            {
                mx = array[i];
                mxdex = i;
            }
        }
        for (int i = 0; i < mxdex; i++)
        {
            if (i <= mndex) continue;
            if (array[i] < 0) n++;
        }
        double[] array2 = new double[n];
        for (int i = 0; i < mxdex; i++)
        {
            if (i <= mndex) continue;
            if (array[i] < 0)
            {
                array2[j] = array[i];
                j++;
            }
        }
        // end

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
        // code here
        double mx = double.MinValue;
        for (int i = 0; i < array.Length; i++) if (array[i] > mx) mx = array[i];
        for (int i = 0; i < array.Length; i++) if ((array[i] == mx) && (i + 1 != array.Length))
        {
            if (array[i + 1] > 0) { array[i + 1] *= 2; } else { array[i + 1] /= 2; }
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
        double mn = double.MaxValue, mx = double.MinValue, s = 0, n = 0;
        int mndex = 0, mxdex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < mn)
            {
                mn = array[i];
                mndex = i;
            }
            if (array[i] > mx)
            {
                mx = array[i];
                mxdex = i;
            }
        }
        if (mndex > mxdex)
        {
            int a = mndex;
            mndex = mxdex;
            mxdex = a;
        }
        for (int i = 0; i < mxdex; i++)
        {
            if (i <= mndex) continue;
            s += array[i];
            n++;
        }
        if (n != 0) average = Math.Round(s / n, 2);
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
        double lastplus = 0;
        bool added = false;
        double[] array2 = default(double[]);
        for (int i = 0; i < array.Length; i++) if (array[i] > 0) lastplus = array[i];
        if (lastplus != 0)
        {
            array2 = new double[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                if (added) { array2[i + 1] = array[i]; } else { array2[i] = array[i]; }
                if (array[i] == lastplus)
                {
                    array2[i + 1] = P;
                    added = true;
                }
            }
        }
        else array2 = array;
        // end

        return array2;
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
        double mx = double.MinValue;
        for (int i = 0; i < array.Length; i += 2) if (array[i] > mx) mx = array[i];
        for (int i = 0; i < array.Length; i += 2) if (array[i] == mx) array[i] = i;
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
        int a = 0, b = 0;
        if (A.Length > k)
        {
            output = new double[A.Length + B.Length];
            for (int i = 0; i < A.Length + B.Length; i++)
            {
                if ((a - 1 == k) && (b != B.Length))
                {
                    output[i] = B[b];
                    b++;
                }
                else
                {
                    output[i] = A[a];
                    a++;
                    if (a == A.Length) break;
                }
            }
        }
        else output = A;
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
        double mn = double.MaxValue, mx = double.MinValue, s = 0, n = 0;
        int mndex = 0, mxdex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < mn)
            {
                mn = array[i];
                mndex = i;
            }
            if (array[i] > mx)
            {
                mx = array[i];
                mxdex = i;
            }
        }
        if (mxdex < mndex)
        {
            for (int i = 0; i < array.Length; i++) if (array[i] > 0)
            {
                s += array[i];
                n++;
            }
        } else
        {
            for (int i = 0; i < array.Length; i++) if (array[i] < 0)
            {
                s += array[i];
                n++;
            }
        }
        // end
        if (n != 0) average = Math.Round(s / n, 3);
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
        double mx = double.MinValue, s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mx) mx = array[i];
            s += array[i];
        }
        for (int i = 0; i < array.Length; i++) if (array[i] == mx) if (mx > s) { array[i] = 0; } else { array[i] *= 2; }
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
        double mx = double.MinValue;
        int n = 1;
        for (int i = 0; i < array.Length; i++) if (array[i] > mx) mx = array[i];
        for (int i = 0; i < array.Length; i++) if (array[i] == mx)
        {
            array[i] += n;
            n++;
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
        int n = array.Length / 2;
        for (int j = 1; j <= n; j++) for (int i = 0; i < array.Length - j * 2; i += 2)
        {
            if (array[i] > array[i + 2])
            {
                double a = array[i];
                array[i] = array[i + 2];
                array[i + 2] = a;
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
        for (int j = 0; j < array.Length; j++)
        {
            int oldex = -1;
            for (int i = 0; i < array.Length - j; i++)
            {
                if (array[i] < 0)
                {
                    if (oldex == -1) oldex = i;
                    else
                    {
                        if (array[oldex] < array[i])
                        {
                            double a = array[i];
                            array[i] = array[oldex];
                            array[oldex] = a;
                        }
                        oldex = i;
                    }
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
        globalMax = double.MinValue;
        globalMin = double.MaxValue;
        int d = 0;
        for (double i = a; i <= b; i += (b - a) / (n - 1))
        {
            X[d] = Math.Round(i, 2);
            Y[d] = Math.Round(Math.Cos(i) + i * Math.Sin(i), 2);
            d++;
        }
        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                if (Y[i] > Y[i + 1]) globalMax = Y[i];
                if (Y[i] < Y[i + 1]) globalMin = Y[i];
            } else if (i == n - 1)
            {
                if (Y[i] > Y[i - 1]) globalMax = Y[i];
                if (Y[i] < Y[i - 1]) globalMin = Y[i];
            } else
            {
                if ((Y[i] > Y[i - 1]) && (Y[i] > Y[i + 1])) globalMax = Y[i];
                if ((Y[i] < Y[i - 1]) && (Y[i] < Y[i + 1])) globalMin = Y[i];
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
        normalizedArray = new double[array.Length];
        double mx = double.MinValue, mn = double.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mx) mx = array[i];
            if (array[i] < mn) mn = array[i];
        }
        double md = (mx + mn) / 2, len = (mx - mn) / 2;
        for (int i = 0; i < array.Length; i++) normalizedArray[i] = Math.Round((array[i] - md) / len, 2);
        // end

        return normalizedArray;
    }
    #endregion
}
