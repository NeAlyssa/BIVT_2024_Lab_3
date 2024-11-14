using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        program.Task_3_6(new double[] { 0, 1.5, 1, -1.3, -2.2, -0.5, 2 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double s = 0;
        foreach (double x in array) s += x;
        for (int i = 0; i < array.Length; i++) array[i] = Math.Round(array[i] / s, 2);
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0;
        int n = 0;
        foreach (double x in array)
        {
            if (x > 0)
            {
                s += x;
                n++;
            }
        }
        double sr = Math.Round(s / n, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) array[i] = sr;
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
        foreach (double x in array) s += x;
        double sr = Math.Round(s / array.Length, 2);
        for (int i = 0; i < array.Length; i++) array[i] = Math.Round(array[i] - sr, 2);



        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < vector1.Length; i++) product += vector1[i] * vector2[i];

        // end

        return Math.Round(product, 2);
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        foreach (double x in vector) length += x * x;

        // end
        return Math.Round(Math.Sqrt(length), 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        foreach (double x in array) s += x;
        double sr = s / array.Length;
        for (int i = 0; i < array.Length; i++) if (array[i] > sr) array[i] = 0;
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        foreach (double x in array) if (x < 0) count++;

        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;
        double s = 0;
        // code here
        foreach (double x in array) s += x;
        double sr = (double)Math.Round(s / array.Length, 2);
        foreach (double x in array) if (x > sr) count++;

        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        foreach (double x in array) if ((P < x) && (x < Q)) count++;

        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {

        // code here
        int n = 0;
        foreach (double x in array) if (x > 0) n++;
        double[] output = new double[n]; n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[n] = array[i];
                n++;
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
        double[] odd = new double[array.Length / 2];

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0) even[i / 2] = array[i];
            else odd[(i - 1) / 2] = array[i];
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
            if (array[i] >= 0) sum += array[i] * array[i];
            else break;
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
            if (x[i] == 0) y[i] = double.NaN;
            else y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
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
        double max = double.MinValue;
        // code here

        foreach (double x in array)
        {
            if (x > max) max = x;
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max) break;
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
        bool flag = false;
        double s = 0;
        double max = double.MinValue;
        foreach (double x in array)
        {
            if (x > max) max = x;
            s += x;
        }
        double sr = Math.Round(s / array.Length, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (flag) array[i] = sr;
            if (array[i] == max) flag = true;
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
        double[] answer = new double[array.Length + 1];
        double diff = double.MaxValue;
        double s = 0; int ind = 0;
        for (int i = 0; i < array.Length; i++) s += array[i];
        s = Math.Round(s / array.Length, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (diff > Math.Abs(array[i] - s))
            {
                diff = Math.Abs(array[i] - s);
                ind = i;
            }
        }
        for (int i = 0; i <= ind; i++) answer[i] = array[i];
        answer[ind + 1] = P;
        for (int i = ind + 1; i < array.Length; i++) answer[i + 1] = array[i];

        // end

        return answer;
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
        double maximum = double.MinValue;
        int maxind = 0;
        for (int i = 0; i < array.Length; i++)
            if (array[i] > maximum)
            {
                maximum = array[i];
                maxind = i;
            }
        double minimum = double.MaxValue; int minind = 0;
        if (maxind == array.Length - 1) return array;
        for (int i = maxind + 1; i < array.Length; i++)
        {
            if (array[i] < minimum)
            {
                minimum = array[i];
                minind = i;
            }
        }
        array[minind] = maximum;
        array[maxind] = minimum;
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
        double min = double.MaxValue; int minind = -1;
        double[] answer = new double[array.Length - 1];
        for (int i = 0; i < array.Length; i++)
        {
            if ((array[i] < min) && (array[i] > 0))
            {
                min = array[i];
                minind = i;
            }
        }
        if (minind == -1) return array;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (i < minind) answer[i] = array[i];
            else answer[i] = array[i + 1];
        }
        // end

        return answer;
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
        int negativeindex = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                negativeindex = i;
                break;
            }
        }
        double maximum = double.MinValue; int maxindex = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maximum)
            {
                maximum = array[i];
                maxindex = i;
            }
        }
        double s = 0;
        for (int i = maxindex + 1; i < array.Length; i++) s += array[i];
        if (negativeindex == -1) return array;
        array[negativeindex] = Math.Round(s, 2);
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
        double max = double.MinValue; int maxindex = 0;
        double negative = 1; int negativeindex = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxindex = i;
            }
            if (negative > 0 && array[i] < 0)
            {
                negative = array[i];
                negativeindex = i;
            }
        }
        if (negativeindex != -1)
        {
            array[negativeindex] = max;
            array[maxindex] = negative;
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

        double s = 0; int n = 0;
        // code here
        foreach (double x in array) s += x;
        s = s / array.Length;
        for (int i = 0; i < array.Length; i++) if (array[i] < s) n++;
        int[] output = new int[n];
        int l = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < s)
            {
                output[l] = i;
                l++;
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
        
        double maxeven = double.MinValue, maxodd = double.MinValue;
        int mid = array.Length / 2;
        for (int i = 0; i < array.Length; i++)
        {
            if ((i % 2 == 0) && (maxeven < array[i])) maxeven = array[i];
            else if ((i % 2 != 0) && (maxodd < array[i])) maxodd = array[i];
        }

        if (maxeven > maxodd) for (int i = 0; i < mid; i++) array[i] = 0;
        else for (int i = mid; i < array.Length; i++) array[i] = 0;
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
        double sumodd = 0, sumeven = 0;
        double sum = 0, min = double.MaxValue; int minindex = 0;
        int negativeindex = -1;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0 && negativeindex == -1)
            {
                negativeindex = i;
            }
            if (array[i] < min)
            {
                min = array[i];
                minindex = i;
            }
        }
      
        if (negativeindex == -1) return 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0) sumeven += array[i];
            else sumodd += array[i];
        }
        if (negativeindex < minindex) return Math.Round(sumeven, 2);
        else return Math.Round(sumodd, 2);
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
        double max = double.MinValue, maxindex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxindex = i;
            }
        }
        for (int i = 0; i < array.Length; i++) if (array[i] == max)
            {
                maxindex = i;
                break;
            }
        for (int i = 1; i < maxindex; i+=2)
        {
            double term;
            term = array[i-1];
            array[i-1] = array[i];
            array[i] = term;
        }
        Console.WriteLine(maxindex);
        foreach (double x in array)
        {
            Console.WriteLine(x);
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
        int cnt = 0; int n = 1;
        double a = array[0], b;
        for (int i = 1; i < array.Length; i++)
        {
            b = array[i];
            if (b <= a) n++;
            else n = 1;
            Console.WriteLine($"{a} {b} {n}");
            a = b;

            if (n > cnt) cnt = n;
        }
        Console.WriteLine(cnt);
        // end

        return cnt;
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
        int cnt = 0; int nDesc = 1; int nAsc = 1;
        double aDesc = array[0], bDesc;
        double aAsc = array[0], bAsc;
        for (int i = 1; i < array.Length; i++)
        {
            bDesc = array[i];
            bAsc = array[i];
            if (bDesc <= aDesc) nDesc++;
            else nDesc = 1;
            if (bAsc >= aAsc) nAsc++;
            else nAsc = 1;
            aDesc = bDesc;
            aAsc = bAsc;
            if (Math.Max(nDesc, nAsc) > cnt) cnt = Math.Max(nDesc, nAsc);
        }
        Console.WriteLine(cnt);
        // end

        return cnt;
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
        int cnt = 0, n = 0;
        // code here
        foreach(double x in array) if (x>=0) cnt++;
        double[] answer = new double[cnt];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                answer[n] = array[i];
                n++;
            }
        }
        // end

        return answer;
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