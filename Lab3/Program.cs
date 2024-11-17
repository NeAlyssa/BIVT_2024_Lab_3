using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_1(new int[] {1, 2, 3, 4, 5, 6});
        //program.Task_2_3(new double[] {4, 2, -1, 4, 5, 6});
        //program.Task_3_9(new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10});
        //program.Task_1_11(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, 2, 3.1, -0.7 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double s = 0;
        for(int i = 0; i < 6; i++)
        {
            s += array[i];
        }
        for(int i = 0; i < 6; i++)
        {
            array[i] /= s;
            array[i] = Math.Round(array[i], 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0;
        int k = 0;
        for(int i = 0; i < 8; i++)
        {
            if (array[i] > 0) { s += array[i]; k++; }
        }
        double sr;
        sr = s / k;
        for(int i = 0; i < 8; i++)
        {
            if (array[i] > 0) array[i] = sr;
            array[i]=Math.Round(array[i], 2);
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i < 4; i++)
        {
            sum[i] = first[i] + second[i];
            dif[i] = first[i] - second[i];
            sum[i] = Math.Round(sum[i], 2);
            dif[i] = Math.Round(dif[i], 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sr = 0;
        double s = 0;
        int k = 0;
        for (int i = 0; i < 5; i++)
        {
            s += array[i];
            k++;
        }
        sr = s / k;
        for (int i = 0; i < 5; i++)
        {
            array[i] -= sr;
            array[i]=Math.Round(array[i], 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for(int i = 0; i < 4; i++)
        {
            product += vector1[i] * vector2[i];
        }
        product=Math.Round(product, 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for(int i = 0; i < 5; i++)
        {
            length+=vector[i] * vector[i];
        }
        length=Math.Sqrt(length);
        length = Math.Round(length,2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sr = 0;
        double s = 0;
        int k = 0;
        for (int i = 0; i < 7; i++)
        {
            s += array[i];
            k++;
        }
        sr = s / k;
        for(int i = 0; i < 7; i++)
        {
            if (array[i] > sr) array[i] = 0;
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        for(int i = 0; i < 6; i++)
        {
            if (array[i] < 00) count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double sr = 0;
        double s = 0;
        int k = 0;
        for (int i = 0; i < 8; i++)
        {
            s += array[i];
            k++;
        }
        sr = s / k;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > sr) count++;
        }
            // end

            return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for (int i = 0; i < 10; i++)
        {
            if ((array[i] > P) && (array[i] < Q)) count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        //double[] output= null;
        // code here
        int k = 0;

        for(int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                k++;
            }
        }
        double [] output = new double[k];
        int j = 0;
        for(int i = 0;i < 10; i++) 
            { 
                if (array[i] > 0)
                {
                    output[j] = array[i];
                    j++;
                }
            }
        
        for (int i = 0; i < k; i++)
        {
            Console.WriteLine(output[i]);

        }
        // end

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        // code here
        for(int i = 7; i>=0; i--)
        {
            if (array[i] < 0) { value = array[i]; index = i; break; }
        }
        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        // code here
        for(int i = 0; i < 10;i++)
        {
            if (i % 2 == 0) { even[i / 2] = array[i]; }
            else { odd[i / 2] = array[i]; }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for(int i = 0; i < 11; i++)
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
            if (x[i] > 0) 
            { 
                y[i] = 0.5 * Math.Log(x[i]);
                y[i] = Math.Round(y[i], 2);
            }
            else
            {
                y[i] = double.NaN;
            }
            
        }    
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        double min = array[0];
        int k = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] <= min)
            {
                min = array[i];
                k = i;
            }
        }
        if (array[k] < 0) array[k] /= 2;
        else array[k] *= 2;
        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        double max = array[0];
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] > max)
            {
                max=array[i]; ;
                k = i;
            }
        }
        for (int i = 0; i < k; i++)
        {
            sum+= array[i];
        }
        // end

        return sum;
    }
    public double[] Task_2_3(double[] array)
    {
        // code here
        double min = array[0];
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] <= min)
            {
                min = array[i];
                k = i;
            }
        }
        for (int i = 0; i < k; i++)
        {

            if(array[i]>=0) array[i] *= 2;
            if (array[i] < 0) array[i] *= 0.5;
        }
        /*for (int i = 0; i < array.Length; i++) { 
        Console.Write(array[i] ); }*/
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
        double min= array[0];
        double max = array[0];

        int index_max = -1, index_min = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] <= min)
            {
                min = array[i];
                index_min = i;
            } }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= max)
            {
                max = array[i];
                index_max = i;
            }
        }
        
        int a1=-1;
        int a2=-1;
        if (index_min < index_max) {a1 = index_min; a2 = index_max; }
        if (index_min > index_max) {a1 = index_max; a2 = index_min; }

        int k = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if ((i < a2) && (i > a1) && (array[i]<0)) 
            { 
                k++; 
            }
        }
        double[] a = new double[k];
        k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if ((i < a2) && (i > a1) && (array[i] < 0))
            {
                a[k] = array[i];k++;
            }
        }
       

        // end

        return a;
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
        
        double max;
       
        max = array[0];

        int index_max = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= max)
            {
                max = array[i];
                index_max = i;
            }
        }
        //увеличить отрицательное число это значит уменьшить его на два
        if (index_max + 1 < array.Length) 
        { 
            if (array[index_max + 1] >= 0) array[index_max + 1] *= 2;
            if (array[index_max + 1] < 0) array[index_max + 1] *= 0.5;
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
        double min;
        double max;
        min = array[0];
        max = array[0];
        double[] a = new double[array.Length];
        int index_max = -1, index_min = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] <= min)
            {
                min = array[i];
                index_min = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= max)
            {
                max = array[i];
                index_max = i;
            }
        }
        //Console.WriteLine(index_min);
        //Console.WriteLine(index_max);

        int a1 = -1;
        int a2 = -1;
        if (index_min < index_max) { a1 = index_min; a2 = index_max; }
        if (index_min > index_max) { a1 = index_max; a2 = index_min; }
        int k = 0;
        double s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if ((i < a2) && (i > a1)) { s += array[i]; k++; }
        }
        if (k == 0) return 0;
        average = s / k;
        //average = Math.Round(average,2);
        for (int i = 0; i < k; i++)
        {
            Console.Write(a[i]);
            Console.Write(" ");
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
        int k = -1;
        for(int i = array.Length-1; i >=0; i--)
        {
            if(array[i] > 0)
            {
                k = i;
                break;
            }
        }
        if (k == -1) return array;

        double[] new_array= new double[array.Length+1];
        for(int i = 0; i <= k; i++)
        {
            new_array[i] = array[i];
        }
        new_array[k+1]= P;
        for (int i = k+2; i < (array.Length + 1); i++)
        {
            new_array[i] = array[i-1];
        }
        
        for (int i = 0; i < array.Length + 1; i++)
        {
            Console.Write(new_array[i]);
            Console.Write(" ");
        }
        // end
        return new_array;
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
        double max = array[0];
        int k =0;
        for (int i = 0; i < array.Length; i++)
        {
            if ((i % 2 == 0)&&(array[i]>=max)) { max = array[i]; k = i; }
        }
        array[k] = k;
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
        double[] output = new double [A.Length+B.Length];

        // code here
        if (k >= A.Length) return A;

        for (int i = 0; i <= k; i++)
        {
            output[i]= A[i];
        }
        for(int i = k+1, j=0; j<B.Length; i++,j++)
        {
            output[i]= B[j];
        }
        for(int i = k+B.Length+1, j=k+1;j<A.Length;i++,j++)
        {
            output[i] = A[j];
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
        double min;
        double max;
        min = array[0];
        max = array[0];
        double[] a = new double[array.Length];
        int index_max = -1, index_min = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] <= min)
            {
                min = array[i];
                index_min = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= max)
            {
                max = array[i];
                index_max = i;
            }
        }
        int type = -1;
        if (index_max < index_min) type = 0;
        else type = 1;
        int k = 0;
        double sum = 0;
        switch (type)
        {
            case 0:
                for(int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        sum += array[i];
                        k++;
                    }
                }
                if (k == 0) return average;
                average = sum / k; break;
            case 1:
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < 0)
                    {
                        sum += array[i];
                        k++;
                    }
                } if (k == 0) return average;
                average = sum / k; break;
        }
        //average = Math.Round(average, 2);
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
        double s = 0;
        double max = array[0];
        int k = 0;
        for(int i = 0; i < array.Length; i++)
        {
            s += array[i];
            if (array[i] >= max)
            {
                max = array[i];
                k = i;
            }
        }
        if (max > s)
        {
            array[k] = 0;
        }
        else if (array[k] >= 0) array[k] *= 2;
        else if (array[k] < 0) array[k] /= 2;
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
        double max = array[array.Length-1];
        int i_max = array.Length-1;
        for(int i = array.Length-1; i>=0; i--)
        {
            if (array[i] >= max)
            {
                max=array[i];
                i_max = i;
            }
        }

        double t;
        double count = 0;
        for (int i = 0; i < i_max; i=i+2)
        {
            t = array[i];
            array[i] = array[i + 1];
            array[i + 1] = t;
            count++;
            if (i_max / 2 == count) break;
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
        int[] a= new int[array.Length];
        for (int i = 0; i < array.Length-1; i++)
        {
            if (array[i] >= array[i + 1])
            {
                count++;
            }
            else { a[i] = count + 1; count = 0; }
        }

        int max_c = 0;
        for(int i = 0; i < a.Length; i++)
        {
            if (a[i] >= max_c) max_c = a[i];
        }
        count = max_c;
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
        int[] a = new int[array.Length];
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] >= array[i + 1])
            {
                count++;
            }
            else { a[i] = count + 1; count = 0; }
        }

        int max_c = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] >= max_c) max_c = a[i];
        }
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
            Console.WriteLine(' ');
        }
        Console.WriteLine(' ');

        int[]b = new int[array.Length];
        int c = 0;
        for (int i = array.Length-1; i >=1; i--)
        {
            if (array[i-1] <= array[i])
            {
                c++;
            }
            else { b[i] = c + 1; c = 0; }
        }

        int max_c_1 = 0;
        for (int i = 0; i < b.Length; i++)
        {
            if (b[i] >= max_c_1) max_c_1 = b[i];
        }
        for (int i = 0; i < b.Length; i++)
        {
            Console.WriteLine(b[i]);
            Console.WriteLine(' ');
        }
        count = max_c_1>=max_c ? max_c_1 : max_c;

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

        return (X, Y, globalMax,globalMin);
    }
    public double[] Task_3_12(double[] array)
    {
        // code here
        int count_negative = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] < 0) count_negative++;
        }
        double[] array_no_negative = new double[array.Length-count_negative];

        for(int i = 0,j=0; i < array.Length; i++)
        {
            if (array[i] >= 0) { array_no_negative[j] = array[i]; j++; }
        }
        array = array_no_negative;
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

        // end

        return normalizedArray;
    }
    #endregion
}