using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
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
        // code here
        double summ = 0;
        for (int i = 0; i < array.Length; i++)
        {
            summ+= array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] /=summ;
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double summ = 0;
        int k=0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                summ += array[i];
                k++;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = summ / k;
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
            sum[i]= first[i] + second[i];
            dif[i] = first[i] - second[i];
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sred = 0, summ=0;
        int k=0;
        for (int i = 0; i < array.Length; i++)
        {
            summ+= array[i];
            k ++;
        }
        sred = summ / k;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] -= sred;
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
            length+= vector[i] * vector[i];
        }
        length=Math.Sqrt(length);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sred = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sred += array[i];
        }
        sred = sred / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sred)
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
        double sred = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sred += array[i];
        }
        sred = sred / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sred) count++;
        }
            // end

            return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        if (P < Q)
        {
            for (int i = 0; i<array.Length; i++)
            {
                if (array[i]>P && array[i]<Q) count++;
            }
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) k++;
        }
        output = new double[k];
        k = 0;
        for (int i = 0; i < array.Length; i++)
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
            if (i % 2 == 0) even[i/2] = array[i];
            else odd[(i-1)/2] = array[i];
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
            if (x[i]<=0) y[i] = double.NaN;
            else y[i]=0.5*Math.Log(x[i]);
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
        int index = 0;
        double min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                index = i;
            } 
        }
        if (array[index]>0) array[index]*=2;
        else array[index]/=2;
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
        int index = 0;
        double min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                index = i;
            }
        }
        for (int i = 0; i < index; i++)
        {
            if (array[i] > 0) array[i] *= 2;
            else array[i] /= 2;
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
        int max_index = 0, min_index = 0;
        int vspomogat = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                max_index = i;
            }
            else if (array[i] < min)
            {
                min = array[i];
                min_index = i;
            }
        }
        if (min_index > max_index)
        {
            vspomogat = min_index;
            min_index = max_index;
            max_index = vspomogat;
        }
        int k = 0;
        for (int i = min_index + 1; i < max_index; i++)
        {
            if (array[i] < 0) k++;
        }
        double[] array2 = new double[k];
        k = 0;
        for (int i = min_index+1; i < max_index; i++)
        {
            if (array[i]<0)
            {
                array2[k]= array[i];
                k++;
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
        double max=array[0];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index = i;
            }
        }
        index++;
        if (index + 2 < array.Length)
        {
            if (array[index] > 0) array[index] *= 2;
            else array[index] /= 2;
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
        double max = array[0], min = array[0], summ=0;
        int max_i = 0, min_i = 0, k=0, dop=0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                max_i = i;
            }
            if (array[i] < min)
            {
                min = array[i];
                min_i = i;
            }
        }
        if (min_i > max_i)
        {
            dop = max_i;
            max_i = min_i;
            min_i = dop;
        }
        for (int i = min_i + 1; i < max_i; i++)
        {
            summ+= array[i];
            k++;
        }
        if (k > 0)
        {
            average= summ/k;
        }
        
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
        int index = 0;
        for (int i = 0; i <array.Length; i++)
        {
            if (array[i]>0)
            {
                index = i;
            }
        }
        double[] array2;
        if (index+1 < array.Length) array2=new double[array.Length];
        else array2=new double[array.Length+1];
        for (int i = 0; i < array.Length; i++)
        {
            array2[i]= array[i];
        }
        if (index > 0) array2[index + 1] = P;

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
        double max=array[0];
        int index = 0;
        for (int i = 0; i < array.Length; i+=2)
        {
            if (array[i]>max)
            {
                max = array[i];
                index = i;
            }
        }
        array[index] = index;
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
        output = new double[A.Length+B.Length];
        if (k >= A.Length) return A;
        for (int i = 0; i < k + 1; i++)
        {
            output[i] = A[i];
        }
        for (int i=0; i<B.Length; i++)
        {
            output[i+k+1]= B[i];
        }
        for (int i = 0; i < A.Length - (k + 1); i++)
        {
            output[k + B.Length + i + 1] = A[i+k+1];
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
        double max = array[0], min = array[0];
        int max_i = 0, min_i = 0, k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                max_i = i;
            }
            if (array[i] < min)
            {
                min = array[i];
                min_i = i;
            }
        }
        if (max_i < min_i)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    average += array[i];
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
                    average += array[i];
                    k++;
                }
            }
        }
        if (k > 0) average = average / k;
        
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
        int index = 0;
        double max=array[0], summ=0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            summ+= array[i];
        }
        if (max > summ)
        {
            array[index] = 0;
        }
        else array[index] *= 2;
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
        double max = array[0];
        int count = 0, k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                k= 1;
            }
            else if (array[i] == max) k++;
        }
        output = new int[k];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max) output[i - count] = i;
            else count++;
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
        double max = array[0];
        double summ = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                array[i] = summ;
                summ += max;
            }
            else summ += array[i];
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
        int count = 0, n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                count++;
            }
        }
        double[] array2 = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0) array2[i - n] = array[i];
            else
            {
                array2[count + n] = array[i];
                n++;
            }
        }
        // end

        return array2;
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
        for (int i = array.Length-1; i >=0; i-=2)
        {
            array[i] = array[i/2];
            array[i-1] = array[i];
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
        int n = 0, m = 0;
        for (int i = array.Length - 2; i >= 0; i--)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] == array[i])
                {
                    array[j] = 999999;
                    n++;
                }
            }
        }
        double[] array2 = new double[array.Length - n];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 999999) array2[i - m] = array[i];
            else m++;
        }
        // end

        return array2;
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
