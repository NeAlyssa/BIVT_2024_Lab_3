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
        //program.Task_1_1(new int[] {1, 2, 3, 4, 5, 6});
        program.Task_3_4(new double[] { -1, -2, -8, -1, -9, -1, -1, -4, -6, -2 });
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
            array[i]=Math.Round(array[i]/s,2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0;
        int cnt = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                cnt++;
            }
        }
        for ( int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = Math.Round(s / cnt,2);
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
            sum[i] = Math.Round(first[i] + second[i],2);
            dif[i] = Math.Round(first[i] - second[i],2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i]-(s/array.Length),2);
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
            product+= vector1[i] * vector2[i];
        }

        // end

        return Math.Round(product,2);
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < vector.Length; i++)
        {
            length += vector[i] * vector[i];
        }
      
        // end

        return Math.Round(Math.Sqrt(length), 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s+= array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > (s / array.Length))
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
        double s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > (s / array.Length))
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
        // code here
        int n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) n++;
        }
        double[] output= new double[n];
        n = 0;
        for (int i = 0; i < array.Length; i++)
            if (array[i] > 0)
            {
                output[n] = array[i];
                n++;
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
            if (i > index && array[i]<0)
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
        int oddindex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[i / 2] = array[i];
            }
            else
            {
                odd[oddindex++] = array[i];
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for(int i = 0; i < array.Length; i++)
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
            if (x[i] > 0) y[i] = Math.Round(0.5 * Math.Log(x[i]),2);
            else y[i] = double.NaN;
        }

        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        int n = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[n]) n = i;
        }
        if (array[n] >= 0)
        {
            array[n] *= 2;
        }
        else array[n] /= 2;
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
        int n = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[n]) n = i;
        }
        for (int i = 0; i < n; i++)
        {
            array[i] *= 2;
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
        int max = 0;
        int min = 0;
        int cnt = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[min]) min = i;
            else max = i;
            if (array[i] < 0) cnt++;
        }
        double[] array2 = new double[cnt];
        int j = 0;
        for (int i = Math.Min(max,min)+1; i < Math.Max(max,min); i++)
        {
            if (array[i] < 0)
            {
                array2[j++] = array[i];
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
        int n = 0;
        for(int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[n]) n = i;
        }
        if (n < array.Length - 1)
        {
            array[n + 1] *= 2;
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
        int max = 0;
        int min = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[min]) min = i;
            if (array[i]>array[max]) max = i;
        }
        if (min > max)
        {
            int temp = min;
            min = max;
            max = temp;
        }
        for (int i = min + 1; i < max; i++)
        {
           average+= array[i];
        }
        if (max - min - 1 > 0)
        {
            average /= (max - min - 1);
        }
        else return 0;
        // end

        return Math.Round(average,2);
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
            if (array[i] > 0) n = i;
        }

        if (n == -1)
        {
            return array;
        }
        else if (n < array.Length - 1) 
        {
            array[n + 1] = P; 
            return array;
        }
        else 
        {
            double[] array1 = new double[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                array1[i] = array[i]; 
            }
            array1[array.Length] = P; 
            return array1;
        }

        // end

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
        for (int i = 1; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (array[i] > array[n]) n = i;

            }
        }
        array[n] = n;
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
        double[] output = new double[A.Length+B.Length];

        // code here
        int i = 0,j=0,n=0;
        while (i < A.Length&&i<=k)
        {
            output[n++] = A[i++];
        }
        while (j < B.Length)
        {
            output[n++] = B[j++];
        }
        while (i < A.Length)
        {
            output[n++] = A[i++];
        }
        Console.WriteLine(output);
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
        int imax=0, imin = 0,cnt=0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[imax]) imax= i;
            if (array[i]<array[imin]) imin= i;
        }
        if (imax < imin)
        {
            for (int i=0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    average += array[i];
                    cnt++;
                }
            }
            if (cnt > 0) return Math.Round(average / cnt, 2);
            else return 0;
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    average += array[i];
                    cnt++;
                }
            }
            if (cnt > 0) return Math.Round(average / cnt, 2);
            else return 0;
        }

        // end
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
        for (int i=0;i < array.Length; i++) sum+= array[i];
        int mx = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[mx]) mx = i;
        }
        if (array[mx] > sum) array[mx] = 0;
        else array[mx] *= 2;

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
        int cnt = 0;
        double max = double.MinValue ;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                cnt = 1;
            }
            else if (array[i] == max)
            {
                cnt++;
            }
        }
        int[] output = new int[cnt];
        int n = 0;
        for (int i = 0; i < array.Length; i++)
        { 
            if (array[i]==max)
            {
                output[n++] = i;
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
        double sum = 0;
        int imax = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[imax])
            {
                imax = i;
            }
        }
        double max = array[imax];
        double[]original = new double[array.Length];
        for (int i=0; i < array.Length; i++)
        {
            original[i] = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (original[i] == max)
            {
                if (i > 0)
                {
                    sum = 0;
                    for (int j = 0; j < i; j++)
                    {
                        sum += original[j];
                    }
                    array[i] = sum;
                }
                else array[i] = 0;
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
        double[]array1=new double[array.Length];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                array1[j++]=array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array1[j++] = array[i];
            }
        }
        array = array1;
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
        double[] array1 = new double[array.Length / 2];
        for (int i = 0; i < array.Length / 2; i++)
        {
            array1[i] = array[i];
        }
        for (int i = 0; i < array.Length; i += 2)
        {
            array[i] = array1[i / 2];
            array[i + 1] = array1[i / 2];
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
        int n = 0;
        int k = 0;

        for (int i = 0; i < array.Length; i++)
        {
            bool orig = true;
            for (int j = 0; j < i; j++)
            {
                if (array[i] == array[j])
                {
                    orig = false;
                    break;
                }
            }
            if (orig==true)
            {
                n++;
            }
        }

        double[] array1 = new double[n];

        for (int i = 0; i < array.Length; i++)
        {
            bool orig = true;
            for (int j = 0; j < i; j++)
            {
                if (array[i] == array[j])
                {
                    orig = false;
                    break;
                }
            }
            if (orig == true)
            {
                array1[k++] = array[i];
            }
        }
        array = array1;
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
