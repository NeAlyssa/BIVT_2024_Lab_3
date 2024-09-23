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
        double s = 0;
        for(int i = 0;i < array.Length;i++){
            s += array[i];
        }
        for(int i = 0;i < array.Length;i++){
            array[i] = Math.Round(array[i]/s,2);

        }

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        double sr = 0;
        int cnt = 0;
        for(int i = 0;i < array.Length;i++){
            if (array[i] > 0){
                sr += array[i];
                cnt++;
            }
        }
        sr = cnt > 0 ? Math.Round(sr/cnt,2) : 0;
        for(int i = 0;i < array.Length;i++){
            array[i] =  array[i] > 0 ? sr : array[i];

        }
        
        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        for(int i = 0;i < first.Length;i++){
            sum[i] = Math.Round(first[i] + second[i],1);
            dif[i] = Math.Round(first[i] - second[i],1);
        }

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        double sr = 0;
        int l = array.Length;
        for(int i = 0; i < l;i++){
            sr += array[i];
        }
        sr /= l;
        for (int i = 0;i < l;i++){
            array[i] = Math.Round(array[i]-sr,2);
        }

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        for(int i = 0;i < vector1.Length;i++){
            product += vector1[i] * vector2[i];
        }

        return Math.Round(product,2);
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        for(int i = 0;i<vector.Length;i++){
            length += vector[i]*vector[i];
        }
        length = Math.Sqrt(length);
        return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        double sr = 0;
        int l = array.Length;
        for(int i = 0;i < l;i++){
            sr += array[i];
        }
        sr /= l;
        for(int i = 0;i < l;i++){
            array[i] = array[i] > sr ? 0 : array[i];
        }
        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        for(int i = 0;i < array.Length;i++){
            count += array[i] < 0 ? 1 : 0;
        }

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;
                double sr = 0;
        int l = array.Length;
        for(int i = 0;i < l;i++){
            sr += array[i];
        }
        sr /= l;
        for(int i = 0;i < array.Length;i++){
            count += array[i] > sr ? 1 : 0;
        }

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;
        for(int i = 0;i < array.Length;i++){
            count += array[i] > P && array[i] < Q ? 1 : 0;
        }

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;
        int cnt = 0;
        
        for(int i = 0;i < array.Length;i++){
            cnt += array[i] > 0 ? 1 : 0;
        }
        output = new double[cnt];
        int j = 0,i1 = 0;
        while(i1 != cnt ){
            if (array[j] > 0){
                output[i1++] = array[j];
            }
            j++;
        }

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        for(int i = 0;i<array.Length;i++){
            if (array[i] < 0){
                value = array[i];
                index = i;
            }
        }

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        int index_odd = 0, index_even = 0;
        for (int i = 0; i < array.Length;i++){
            if (i % 2 == 0) even[index_even++] = array[i];
            else odd[index_odd++] = array[i];
        }
        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        for(int i = 0; i< array.Length;i++){
            if (array[i] < 0) break;
            sum += array[i]*array[i];
        }

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        for(int i = 0;i < x.Length ;i++){
            y[i] =  x[i] > 0 ? Math.Round(0.5 * Math.Log(x[i]),2) : double.NaN;
        }

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

        // end

        return array;
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