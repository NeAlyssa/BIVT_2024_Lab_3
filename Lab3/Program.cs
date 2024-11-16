using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        program.Task_1_15(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, 2, 3.1, -0.7 });
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
        Console.WriteLine(s);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i]/s, 2);

            Console.WriteLine(array[i]);
        }
        
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sum = 0;
        double cnt = 0;
        for (int i = 0;i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                cnt++;
                sum += array[i];
            }
        }
        double avg = sum / cnt;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) 
            {
                array[i] = Math.Round(avg, 2);
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
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        sum /= array.Length;
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
        for (int i = 0; i < vector1.Length; i++)
        {
            product += vector1[i] * vector2[i] ;
        }
        product = Math.Round(product, 2);
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
        double avg = 0;
        for (int i = 0; i < array.Length; i++)
        {
            avg += array[i];
        }
        avg /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > avg)
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
        double avg = 0;
        for (int i = 0; i < array.Length; i++)
        {
            avg += array[i];
        }
        avg /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > avg)
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
                output[count] = array[i];
                count++;
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
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
                even[i/2] = array[i];
            else 
                odd[i/2] = array[i];
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
                break;
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
                continue;
            }
            y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
        }
        for (int i = 0; i < x.Length; i++)
        {
            Console.WriteLine($"{x[i]} {y[i]}");
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
        double max = double.MinValue;
        int pos = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
                pos = i;
            }
        }
        for (int i = 0; i < pos; i++) {
            sum += array[i];
        }
        sum = Math.Round(sum, 2);
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
        double max = double.MinValue;
        int pos = 0;
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            if (max < array[i])
            {
                max = array[i];
                pos = i;
            }
        }
        sum = Math.Round(sum /= array.Length, 2);
        for (int i = pos+1; i < array.Length; i++)
        {
            array[i] = sum;
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
        int pos = 0;
        double dif = double.MaxValue;
        double[] array2 = new double[array.Length + 1];
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        sum /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - sum) < dif)
            {
                dif = Math.Abs(array[i] - sum);
                pos = i;
            }
        }
        for (int i = 0; i <= pos; i++)
        {
            array2[i] = array[i];
        }
        array2[pos + 1] = P;
        for (int i = pos + 2; i < array.Length + 1; i++)
            array2[i] = array[i - 1];
        // end

        return array2;
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
        double max = double.MinValue;
        double min = double.MaxValue;
        int maxp = 0;
        int minp = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxp = i;
            }
        }
        for (int i = maxp; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i]; 
                minp = i;
            }
        }
        array[maxp] = min;
        array[minp] = max;
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
        int pos = array.Length;
        double[] ar2 = new double[array.Length - 1];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && array[i] < min)
            {
                min = array[i];
                pos = i;
            }
        }
        if (pos == array.Length)
            return array;
        for (int i = 0; i < pos; i++)
        {
            ar2[i] = array[i];
        }
        for (int i = pos + 1; i < array.Length; i++)
        {
            ar2[i-1] = array[i];
        }
        // end

        return ar2;
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
        double max = double.MinValue;
        int maxp = array.Length;
        int pos = array.Length * 2;
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxp = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                pos = i;
                break;
            }
        }
        for (int i = maxp + 1; i < array.Length; i++)
        {
            sum += array[i];
        }
        sum = Math.Round(sum, 2);
        if (pos == array.Length * 2)
            return array;
        array[pos] = sum;
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
        double max = double.MinValue;
        int maxp = 0;
        double min = 0;
        int pos = array.Length * 2;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxp = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                pos = i;
                min  = array[i];
                break;
            }
        }
        if (pos == array.Length * 2)
            return array;
        array[pos] = max;
        array[maxp] = min;
        
        // end

        return array;
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

        // code here
        double sum = 0;
        int cnt = 0;
        int cntt = 0;
        double avg = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        avg = sum / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < avg)
                cnt++;
        }
        int[] output = new int[cnt];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < avg)
            {
                output[cntt] = i;
                cntt++;
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
        double maxch = double.MinValue;
        double maxnech = double.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxch && i % 2 ==0)
            {
                maxch = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxnech && i % 2 != 0)
            {
                maxnech = array[i];
            }
        }
        if (maxch > maxnech)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                array[i] = 0;
            }
        } else
        {
            for (int i = array.Length / 2; i < array.Length; i++)
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
        int pos = array.Length;
        double min = double.MaxValue;
        int posm = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                posm = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                pos = i;
                break;
            }
        }
        if (array.Length == pos)
            return sum;
        if (pos < posm)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                    sum += array[i];
            }
        } else
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                    sum += array[i];
            }
        }
        // end

        return sum;
    }
    #endregion
    #region Level 3
    public int[] Task_3_1(double[] array)
    {

        // code here
        int cnt = 0;
        double max = double.MinValue;
        for (int i = 0; i < array.Length; i++) { 
            if (array[i] > max)
            {
                cnt = 1;
                max = array[i];
            } else if (array[i] == max)
            {
                cnt++;
            }
        }
        int[] output = new int[cnt];
        int cntt = 0;
        for (int i = 0; i < array.Length; i++) {
            if (array[i] == max)
            {
                output[cntt++] = i;
            }
        }

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

        // end

        return array;
    }
    public double[] Task_3_4(double[] array)
    {
        // code here
        double max = double.MinValue;
        double[] pref = new double[array.Length];
        pref[0] = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            pref[i] = array[i] + pref[i-1];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max && i != 0)
            {
                array[i] = pref[i - 1];
            }
            else if (array[i] == max && i == 0)
                array[i] = 0;
        }
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

        // end

        return count;
    }
    public double[] Task_3_7(double[] array)
    {
        // code here
        double[] arr2 = new double[array.Length];
        int cnt = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                arr2[cnt] = array[i];
                cnt++;
            }
        }
        for (int i =0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                arr2[cnt] = array[i];
                cnt++;
            }
        }
        // end

        return arr2;
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
        // code here
        int j = (array.Length - 1)/2;
        for (int i = array.Length - 1;i >= 0; i-= 2)
        {
            array[i] = array[j];
            array[i-1] = array[j];
            j--;
        }
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

        // end

        return array;
    }
    public double[] Task_3_13(double[] array)
    {
        // code here
        int cnt = 0;
        for (int i = 0; i < array.Length; i++)
        {
            bool isDuplicate = false;
            for (int j = i - 1; j >= 0; j--)
            {
                if (array[j] == array[i])
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (isDuplicate == true)
            {
                array[i] = double.MaxValue;
            }
            else
                cnt++;
        }
        double[] arr2 = new double[cnt];
        int cntt = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != double.MaxValue)
            {
                arr2[cntt] = array[i];
                cntt++;
            }
        }
        // end

        return arr2;
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