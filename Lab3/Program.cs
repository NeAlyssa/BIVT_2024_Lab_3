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
        program.Task_2_5(new double[] {3, 122, -1, -4, 12,-34,-90,-22, 6});
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
            sum[i] = first[i]+ second[i];
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
        double[] output= null;

        // code here
        /*int j = 0;7???????????
        for(int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                output[j]=array[i];
                j++;
            }
        }*/
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

        for (int i = 0; i < 10; i++)
        {
            if (x[i] > 0) 
            { 
                y[i] = 0.5 * Math.Log(x[i]);
                y[i] = Math.Round(y[i], 2); 
            }
            //если х меньше или равен нулю программа не должна ничего считать и возвращает значение равное Эне числоЭ
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
                min=array[i];
                k = i;
            }
        }
        array[k] *= 2;


        //
        //везде оформить ввод и вывод начального и конечного массива и закомментировать
        //

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
            } }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= max)
            {
                max = array[i];
                index_max = i;
            }
        }
        Console.WriteLine(index_min);
        Console.WriteLine(index_max);
        
        int a1=-1;
        int a2=-1;
        if (index_min < index_max) {a1 = index_min; a2 = index_max; }
        if (index_min > index_max) {a1 = index_max; a2 = index_min; }
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if ((i < a2) && (i > a1)&&(array[i]<0)) { a[k] = array[i];k++; }
        }

        for (int i = 0; i < k; i++)
        {
            Console.Write(a[i]);
            Console.Write(" ");
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
        average = Math.Round(average,2);
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