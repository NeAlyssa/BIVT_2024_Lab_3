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
            array[i] = array[i] / s;
        }

        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sum = 0;
        double k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                sum += array[i];
                k += 1;
            }
        }
        double a = sum / k;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = a;
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
            sum[i] = first[i] + second[i];
            dif[i] = first[i] - second[i];
        }

        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double summa = 0;
        for (int i = 0; i < array.Length; i++)
        {
            summa += array[i];
        }
        double a = summa / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array[i] - a;
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
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 4);
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double summa = 0;
        for (int i = 0; i < array.Length; i++)
        {
            summa += array[i];
        }
        double a = summa / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > a)
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

        // endf

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double summa = 0;
        double k = 0;

        for (int i = 0; i < array.Length; i++)
        {

            summa += array[i];
            k++;
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > summa / k)
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
            if ((array[i] > P) && (array[i] < Q))
            {
                count += 1;
            }
        }

        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int j = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) j++;
        }

        double[] a = new double[j];

        j = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                a[j] = array[i];
                j++;
            }
        }
        output = a;
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
        for(int i = 0; i < even.Length; i++)
        {
            even[i] = array[2 * i];
        }
        for(int i = 0; i < odd.Length; i++)
        {
            odd[i] = array[2 * i + 1];
        }

        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] < 0)
            {
                break;
            }
            sum += (array[i] * array[i]);
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
                y[i] = Math.Log(x[i]) / 2;
            }
            else
            {
                y[i] = double.NaN;
            }
            Console.WriteLine($"{x[i]}, {y[i]}");

        }

        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        
    
        // code here
        int n = -1;
        double min = 100000000;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (min > array[i])
            {
                min = array[i];
                n = i;
            }
        }
        if (array[n] < 0)
        {
            array[n] = array[n] / 2;
        }
        else
        {
            array[n] = array[n] * 2;
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
        int min_index = 0;
        double m = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < m)
            {
                m = array[i];
                min_index = i;
            }
        }
        for(int i = 0; i < min_index; i++)
        {
            if (array[i] >= 0)
            {
                array[i] = array[i] * 2;
            }
            else
            {
                array[i] = array[i] / 2;
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
        double max = array[0];
        double min = array[0];
        int min_index = 0;
        int max_index = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                min_index = i;
            }
            else if (array[i] > max)
            {
                max = array[i];
                max_index = i;
            }
        }
        int k = 0;
        for(int i = min_index + 1; i < max_index; i++)
        {
            if (array[i] < 0)
                k++;
        }
        double[] answer = new double[k];

        k = 0;
        for (int i = min_index + 1; i < max_index; i++)
        {
            if (array[i] < 0)
            {
                answer[k] = array[i];
                k++;
            }
        }
        // end

        return answer;
    }
    
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
        double max = array[0];
        int max_index = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                max_index = i;
            }
        }
        if (max_index + 1 < array.Length)
        {
            if (array[max_index + 1] >= 0)
            { 
                array[max_index + 1] = array[max_index + 1] * 2;
            }
                
            else
            {
                array[max_index + 1] = array[max_index + 1] / 2;
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
        double max = array[0];
        int max_index = 0;
        double min = array[0];
        int min_index = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
                max_index = i;
            }
            else if (min > array[i])
            {
                min = array[i];
                min_index = i;
            }
        }
        double sum = 0;
        if(max_index < min_index)
        {
            int t = max_index;
            max_index = min_index;
            min_index = t;
        }
        for(int i = min_index + 1; i < max_index; i++)
        {
            sum += array[i];
        }
        if (max_index - min_index - 1 == 0)
        {
            return 0;
        }
        average = sum / (max_index - min_index - 1);
        
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
        int n = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                n = i;
        }
        double[] a = new double[array.Length + 1];
        if (n != -1)
        {
            for (int i = 0; i <= n; i++)
            {
                a[i] = array[i];
            }

            a[n + 1] = P;
            if ((n + 2) < a.Length)
            {
                for (int i = (n + 2); i <= a.Length; i++)
                    a[i] = array[i - 1];
            }
            array = a;
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
        int n = 0;
        double max = array[0];

        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > max)
            {
                max = array[i];
                n = i;
            }
        }
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] == max)
            {
                array[n] = n;
            }
        }
        return array;

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
        int c = 0;

        if (A.Length <= k)
        {
            c = A.Length;
        }

        else
        {
            c = A.Length + B.Length;
        }

        double[] output = new double[c];

        if (A.Length > k)
        {
            for (int i = 0; i <= k; i++)
            {
                output[i] = A[i];
            }

            for (int i = 0; i < B.Length; i++)
            {
                output[i + k + 1] = B[i];
            }

            for (int i = k + 1; i < A.Length; i++)
                output[i + B.Length] = A[i];
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
        double min = array[0];
        int min_index = 0;
        double max = array[0];
        int max_index = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (min > array[i])
            {
                min = array[i];
                min_index = i;
            }
            else if (max < array[i])
            {
                max = array[i];
                max_index = i;
            }
        }

        double sum = 0;
        int k = 0;
        if(max_index < min_index)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] > 0)
                {
                    sum += array[i];
                    k++;
                }
            }
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    sum += array[i];
                    k += 1;
                }
            }
        }

        if (k == 0)
        {
            average = 0;
            return average;
        }
        average = sum / k;
        

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
        double max = array[0];
        double sum = 0;
        int max_index = 0;

        for(int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];

            if (max < array[i])
            {
                max = array[i];
                max_index = i;
            }
        }

        if (max > sum)
        {
            array[max_index] = 0;
        }
        else
        {
            array[max_index] = array[max_index] * 2;
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

        // code here
        double n = double.MinValue;
        int c = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > n)
            {
                n = array[i];
                c = 1;
            }
            else if (array[i] == n)
            {
                c++;
            }
        }
        int[] output = new int[c];
        int s = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == n)
            {
                output[s] = i;
                s++;
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
        double summa = 0;
        double max = array[0];
        int max_index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
                max_index = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            summa = summa + array[i];

            if (max == array[i])
            {
                array[i] = summa - array[i];
            }   
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
        int n = 0;
        int k = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                k++;
            } 
        }

        double[] a = new double[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                a[i - n] = array[i];
            }

            else
            {
                a[k + n] = array[i];
                n++;
            }
        }
        array = a;
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

        // end

        return count;
    }
    public double[] Task_3_10(double[] array)
    {
        // code here
        double[] B = new double[array.Length];
        for (int i = 0; i < (array.Length / 2); i++)
        {
            B[2 * i] = array[i];
            B[2 * i + 1] = array[i];
        }
        array = B;

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
        int kol = 0;
        int n = 0;
        for (int i = (array.Length - 2); i >= 0; i -= 1)
        {
            for (int j = (i + 1); j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    array[j] = 999999;
                    kol++;
                }
            }
        }
        double[] B = new double[array.Length - kol];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 999999)
            {
                B[i-n] = array[i];
            }
            else
            {
                n++;
            }
        }

        array = B;

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
