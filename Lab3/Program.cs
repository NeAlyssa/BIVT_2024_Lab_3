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
        foreach (double v in array){
            s += v;
        }
        for (int i = 0; i<array.Length; i++){
            array[i] = Math.Round(array[i]/s, 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double arif = 0;
        int n = 0;
        foreach (double v in array){
            if (v > 0){
            arif += v;
            n++;
            }
        }
        arif = Math.Round(arif/n, 2);
        for (int i = 0; i<array.Length; i++){
            if (array[i]>0){
            array[i] = arif;
            }
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i < first.Length; i++){
            dif[i] = Math.Round(first[i] - second[i], 2);
            sum[i] = Math.Round(first[i] + second[i], 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sred = 0;
        foreach (double v in array){
            sred += v;
        }
        sred /= array.Length;
        for (int i = 0; i<array.Length; i++){
            array[i] = Math.Round(array[i]-sred, 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < vector1.Length; i++){
            product += vector1[i]*vector2[i];
        }
        product = Math.Round(product, 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        foreach (double v in vector){
            length += v*v;
        }
        length = Math.Round(Math.Sqrt(length), 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sred = 0;
        foreach (double v in array){
            sred += v;
        }
        sred /= array.Length;
        for (int i = 0; i<array.Length; i++){
            if (array[i] > sred){
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
        foreach (double v in array){
            if (v < 0){
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
        foreach (double v in array){
            sred += v;
        }
        sred /= array.Length;
        foreach (double v in array){
            if (v > sred){
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
        foreach (double v in array){
            if (v > P && v < Q){
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
        int n = 0;
        foreach (double v in array){
            if (v > 0){
                n++;
            }
        }
        output = new double[n];
        int j = 0;
        foreach (double v in array){
            if (v > 0){
                output[j] = v; 
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
        for (int i = 0; i < array.Length; i++){
            if (array[i] < 0){
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
        for (int i = 0; i < array.Length; i++){
            if (i%2==0){
                even[i/2] = array[i]; 
            }
            else{
                odd[i/2] = array[i];
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        foreach (double v in array){
            if (v >= 0){
                sum += v*v;
            }
            else{
                break;
            }
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i = 0; i < x.Length; i++){
            if (x[i] > 0){
            y[i] = Math.Round(0.5 * Math.Log(x[i], Math.E), 2);
            }
            else{
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

        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        int ind = 0;
        double max = -Double.MaxValue;
        for (int i = 0; i < array.Length; i++) {
            if (array[i] > max){
                max = array[i];
                ind = i;
            }
        }
        for (int i = 0; i < ind; i++) { 
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
        int ind = 0;
        double max = -Double.MaxValue;
        double arif = 0;
        for (int i = 0; i < array.Length; i++){
            if (array[i] > max){
                max = array[i];
                ind = i;
            }
            arif += array[i];
        }
        arif = Math.Round(arif/array.Length, 2);

        for (int i = ind + 1; i < array.Length; i++){
            array[i] = arif;
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
        // find the average
        double arif = 0;
        for (int i = 0; i < array.Length; i++) {
            arif += array[i];
        }
        arif = Math.Round(arif/array.Length, 2);
        // find the element closest to average and its index
        double min_delta = Double.MaxValue;
        int ind = 0;
        for (int i = 0; i < array.Length; i++) {
            if (Math.Abs(array[i]-arif) < min_delta){
                min_delta = Math.Abs(array[i]-arif);
                ind = i;
            }
        }
        // create new array
        double[] temp_arr = new double[array.Length+1];
        // fill the new array
        for (int i = 0; i < array.Length; i++){
            temp_arr[i] = array[i];
        }
        

        //move everything to the side by one element
        for (int i = temp_arr.Length-1; i > ind; i--){
            temp_arr[i] = temp_arr[i-1];
        }
        //insert P
        temp_arr[ind+1] = P;

        array = temp_arr;
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