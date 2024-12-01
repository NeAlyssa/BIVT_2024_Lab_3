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
        double[] x = program.Task_3_4(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 });
    }

    public double increase(double x)
    {
        if (x >= 0) return x * 2.0;
        else return x / 2.0;
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        double sumi = 0;

        for (int i = 0; i != 6; i++) sumi += array[i];
        for (int i = 0; i != 6; i++) array[i] /= sumi;

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        double sumi = 0, amount = 0;

        for (int i = 0; i != 8; i++) if (array[i] > 0) { sumi += array[i]; amount++; }
        for (int i = 0; i != 8; i++) if (array[i] > 0) { array[i] = sumi / amount; }

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        for (int i = 0; i != 4; i++) { sum[i] = first[i] + second[i]; dif[i] = first[i] - second[i]; }

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        double sumi = 0, amount = 0;

        for (int i = 0; i != 5; i++) { sumi += array[i]; amount++; }
        for (int i = 0; i != 5; i++) { array[i] -= sumi / amount; }

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        for (int i = 0; i != 4; i++) product += vector1[i] * vector2[i];

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        for (int i = 0; i != 5; i++) length += vector[i] * vector[i];

        length = Math.Sqrt(length);

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        double sumi = 0, amount = 0;

        for (int i = 0; i != 7; i++) { sumi += array[i]; amount++; }
        for (int i = 0; i != 7; i++) if (array[i] > sumi / amount) array[i] = 0;

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        for (int i = 0; i != 6; i++) if (array[i] < 0) count++;

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        double sumi = 0, amount = 0;

        for (int i = 0; i != 8; i++) { sumi += array[i]; amount++; }
        for (int i = 0; i != 8; i++) if (array[i] > sumi / amount) count++;

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        for (int i = 0; i != 10; i++) if (array[i] < Q && array[i] > P) count++;

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        int count = 0;

        for (int i = 0; i != 10; i++) if (array[i] > 0) count++;

        double[] output = new double[count];

        int cur = 0;

        for(int i = 0; i != 10; i++) if (array[i] > 0) output[cur++] = array[i];

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        for (int i = 0; i != 8; i++) if (array[i] < 0) { value = array[i]; index = i; }

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        for (int i = 0; i < 10; i += 2) even[i / 2] = array[i];
        for (int i = 1; i < 10; i += 2) odd[(i - 1) / 2] = array[i];

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        for (int i = 0; i != 11; i++) if (array[i] >= 0) { sum += array[i] * array[i]; } else { break; }

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        for (int i = 0; i < y.Length; i++) if (x[i] > 0) y[i] = Math.Log(x[i]) / 2; else y[i] = double.NaN;

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        int index_mini = 0;

        for (int i = 1; i < array.Length; i++) if (array[i] < array[index_mini]) index_mini = i;

        array[index_mini] = increase(array[index_mini]);

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
        int index_mini = 0;

        for (int i = 1; i < array.Length; i++) if (array[i] < array[index_mini]) index_mini = i;

        for (int i = 0; i < index_mini; i++) array[i] = increase(array[i]);

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
        int index_mini = 0, index_maxi = 0;

        for (int i = 1; i < array.Length; i++) {
            if (array[i] < array[index_mini]) index_mini = i; 
            if (array[i] > array[index_maxi]) index_maxi = i;
        }

        int ltz = 0;
        if (index_mini < index_maxi) for (int i = index_mini + 1; i < index_maxi; i++) if (array[i] < 0) ltz++;
        if (index_mini > index_maxi) for (int i = index_maxi + 1; i < index_mini; i++) if (array[i] < 0) ltz++;

        double[] new_array =  new double[ltz];

        int cur = 0;
        if (index_mini < index_maxi) for (int i = index_mini + 1; i < index_maxi; i++) if (array[i] < 0) { new_array[cur] = array[i]; cur++; }
        if (index_mini > index_maxi) for (int i = index_maxi + 1; i < index_mini; i++) if (array[i] < 0) { new_array[cur] = array[i]; cur++; }

        return new_array;
    }
    public double[] Task_2_6(double[] array, double P)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_7(double[] array)
    {
        int index_maxi = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[index_maxi]) index_maxi = i;
        }

        if (index_maxi != array.Length - 1) array[index_maxi + 1] = increase(array[index_maxi + 1]);

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
        int index_mini = 0, index_maxi = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[index_mini]) index_mini = i;
            if (array[i] > array[index_maxi]) index_maxi = i;
        }

        double sumi = 0;
        if (index_mini < index_maxi) for (int i = index_mini + 1; i < index_maxi; i++) sumi += array[i];
        if (index_mini > index_maxi) for (int i = index_maxi + 1; i < index_mini; i++) sumi += array[i];
        if (index_mini - index_maxi != 1) sumi /= Math.Abs(index_mini - index_maxi) - 1; else sumi = 0;

        return sumi;
    }
    public double[] Task_2_10(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_11(double[] array, double P)
    {
        double[] new_array = new double[array.Length + 1];

        int last_positive = -1;
        for (int i = 0; i != array.Length; i++) if (array[i] > 0) last_positive = i;

        new_array[last_positive +  1] = P;
        for(int i = 0; i != array.Length; i++) if (i > last_positive) new_array[i + 1] = array[i]; else new_array[i] = array[i];

        if (last_positive >= 0) return new_array;
        else return array;
    }
    public double[] Task_2_12(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_13(double[] array)
    {
        int max_even = 0;

        for (int i = 0; i < array.Length; i += 2) if (array[i] > array[max_even]) max_even = i;
        array[max_even] = max_even;

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
        if (k >= A.Length)
        {
            return A;
        }
        double[] output = new double[A.Length + B.Length];

        int cur = 0;

        for (int i = 0; i <= k; i++) { output[cur++] = A[i]; }
        for (int i = 0; i != B.Length; i++) { output[cur++] = B[i]; }
        for (int i = 0; i < A.Length - k - 1; i++) { output[cur++] = A[i + k + 1]; }

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

        int index_mini = 0, index_maxi = 0, count = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[index_mini]) index_mini = i;
            if (array[i] > array[index_maxi]) index_maxi = i;
        }

        if (index_mini > index_maxi)
        {
            for (int i = 0; i != array.Length; i++) if (array[i] > 0) { average += array[i]; count++; }
        } else
        {
            for (int i = 0; i != array.Length; i++) if (array[i] < 0) { average += array[i]; count++; }
        }

        if (count == 0)
        {
            return 0;
        }
        else
        {
            return average / count;
        }
    }
    public double[] Task_2_18(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_19(double[] array)
    {
        int index_maxi = 0;
        double sumi = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[index_maxi]) index_maxi = i;
            sumi += array[i];
        }

        if (array[index_maxi] > sumi) array[index_maxi] = 0;
        else array[index_maxi] *= 2;

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
        int[] output = new int[array.Length];

        output[0] = 0;

        int cur = 1;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[output[0]])
            {
                output[0] = i;
                cur = 1;
            } else if (array[i] == array[output[0]])
            {
                output[cur++] = i;
            }
        }

        int[] final = new int[cur];
        for (int i = 0; i != cur; i++) final[i] = output[i];

        return final;
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

        // end

        return array;
    }
    public double[] Task_3_4(double[] array)
    {
        int index_maxi = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] >= array[index_maxi]) index_maxi = i;
        }

        double sumi = 0;

        for (int j = 0; j < array.Length; j++)
        {
            sumi += array[j];
            if (array[j] == array[index_maxi]) { array[j] = sumi - array[j]; }
        }

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

        // end

        return count;
    }
    public double[] Task_3_7(double[] array)
    {
        double[] negative = new double[array.Length];
        double[] positive = new double[array.Length];

        int cn = 0, cp = 0;

        for (int i = 0; i != array.Length; i++)
        {
            if (array[i] >= 0)
            {
                positive[cp++] = array[i];
            } else
            {
                negative[cn++] = array[i];
            }
        }

        for (int i = 0; i < cp; i++) array[i] = positive[i];
        for (int i = 0; i < cn; i++) array[i + cp] = negative[i];

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

        // end

        return count;
    }
    public double[] Task_3_10(double[] array)
    {
        double[] newa = new double[array.Length];

        int cur = 0;

        for (int i = 0; i != array.Length / 2; i++)
        {
            newa[cur++] = array[i];
            newa[cur++] = array[i];
        }

        return newa;
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

        // end

        return array;
    }
    public double[] Task_3_13(double[] array)
    {
        double[] newa = new double[array.Length];
        int cur = 0;

        for (int i = 0; i != array.Length; i++)
        {
            bool addit = true;
            for (int j = 0; j != cur; j++) if (newa[j] == array[i]) addit = false;
            if (addit) newa[cur++] = array[i];
        }

        array = new double[cur];
        for (int i = 0; i != cur; i++) array[i] = newa[i];

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