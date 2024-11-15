using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
        double s = 0.0;
        foreach (double x in array) { 
            s += x;
        }
        for (int i = 0; i < 6; i++)
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
        double avg = 0.0;
        int k_pos = 0;
        foreach (double x in array) {
            if (x > 0) {
                avg += x;
                k_pos++;
            }
        }
        avg /= k_pos;
        for (int i = 0; i < 8; i++) {
            if (array[i] > 0) { 
                array[i] = avg;
                array[i] = Math.Round(array[i], 2);
            }
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i < 4; i++) {
            sum[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = Math.Round(first[i] - second[i], 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double avg = 0.0;
        foreach (double x in array) {
            avg += x;
        }
        avg /= 5;
        for (int i = 0; i < 5; i++)
        {
            array[i] -= avg;
            array[i] = Math.Round(array[i], 2);
        }

        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < 4; i++) { 
            product += vector1[i] * vector2[i];
        }
        product = Math.Round(product, 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        foreach (double x in vector) { 
            length += x * x;
        }
        length = Math.Round(Math.Sqrt(length), 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double avg = 0.0;
        foreach (double x in array) {
            avg += x;
        }
        avg /= 7;
        for (int i = 0; i < 7; i++) {
            if (array[i] > avg) { array[i] = 0.0; }
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        foreach (double x in array) {
            if (x < 0) { count++; }
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double avg = 0.0;
        foreach (double x in array) {
            avg += x;
        }
        avg /= 8;
        foreach (double x in array) {
            if (x > avg) { count++; }
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        foreach (double x in array) { 
            if (x > P && x < Q) { count++; }
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int count_pos = 0;
        foreach (double x in array) {
            if (x > 0) { count_pos++; }
        }
        output = new double[count_pos];
        int i = 0;
        foreach (double x in array) {
            if (x > 0) {
                output[i] = x;
                i++;
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
        for (int i = 0; i < 8; i++) {
            if (array[i] < 0) { 
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
        for (int i = 0; i < 10; i++) {
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
        foreach (double x in array) {
            if (x < 0) { break; }
            sum += x * x;
        }
        sum = Math.Round(sum, 2);
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i = 0; i < 10; i++)
        {
            if (x[i] > 0) { y[i] = Math.Round((0.5 * Math.Log(x[i])), 2); }
            else { y[i] = double.NaN; }
            Console.Write(x[i]); Console.Write(y[i]);
            Console.WriteLine();
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
        double maxi = double.MinValue;
        int index = 0;
        for (int i = 0; i < array.Length; i++) {
            if (array[i] > maxi) { maxi = array[i]; index = i; }
        }
        for (int i = 0; i < index; i++) { 
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
        double maxi = double.MinValue;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi) { maxi = array[i]; index = i; }
        }
        double avg = 0.0;
        foreach (double x in array) { avg += x; }
        avg = Math.Round(avg / array.Length, 2);
        for (int i = index + 1; i < array.Length; i++)
        {
            array[i] = avg;
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
        double avg = 0.0;
        foreach (double x in array) { 
            avg += x;
        }
        avg /= array.Length;
        double min_diff = double.MaxValue;
        int index = 0;
        for (int i = 0; i < array.Length; i++) {
            if (Math.Abs(array[i] - avg) < min_diff) { 
                min_diff = Math.Abs(array[i] - avg);
                index = i;
            }
        }
        double[] array1 = new double[array.Length + 1];
        for (int i = 0; i < array.Length; i++) {
            if (i == index)
            {
                array1[i] = array[i];
                array1[i + 1] = P;
            }
            else if (i > index) { array1[i + 1] = array[i]; }
            else { array1[i] = array[i]; }

        }
        // end

        return array1;
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
        double maxi = double.MinValue;
        int index_max = 0;
        for (int i = 0; i < array.Length; i++) {
            if (array[i] > maxi) { maxi = array[i]; index_max = i; }
        }
        double local_min = double.MaxValue;
        int index_min = index_max + 1;
        for (int i = index_max; i < array.Length; i++) {
            if (array[i] < local_min) { local_min = array[i]; index_min = i; }
        }
        double tmp = array[index_min];
        array[index_min] = array[index_max];
        array[index_max] = tmp;
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
        
        double min_pos = double.MaxValue;
        int index = 0;
        bool flag = false;
        double[] array1 = new double[array.Length - 1];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min_pos && array[i] > 0) { min_pos = array[i]; index = i; flag = true; }
        }
        if (flag)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == index) { }
                else if (i < index) { array1[i] = array[i]; }
                else if (i > index && flag) { array1[i - 1] = array[i]; }
            }
        }
        else { return array; }
        // end

        return array1;
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
        double maxi = double.MinValue;
        double s = 0.0;
        foreach (double x in array) {
            if (x > maxi) { maxi = x; s = 0; }
            else { s += x; }
        }
        s = Math.Round(s, 2);
        for (int i = 0; i < array.Length; i++) {
            if (array[i] < 0) { array[i] = s; break; }
        }
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
        double maxi = double.MinValue;
        int index_max = 0;
        int index_neg = -1;
        for (int i = 0; i < array.Length; i++) {
            if (array[i] > maxi) { maxi = array[i]; index_max = i; }
            if (array[i] < 0 && index_neg == -1) { index_neg = i; }
        }
        if (!(index_neg == -1)) {
            double tmp = array[index_max];
            array[index_max] = array[index_neg];
            array[index_neg] = tmp;
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
        int[] output = null;

        // code here
        double avg = 0;
        foreach (double x in array) { avg += x; }
        avg /= array.Length;
        int count = 0;
        for (int i = 0; i < array.Length; i++) {
            if (array[i] < avg) { count++; }
        }
        output = new int[count];
        int z = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < avg && z != count) { output[z] = i; z++; }
            else if (z == count) { break; }
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
        double even = double.MinValue;
        double odd = double.MinValue;
        for (int i = 0; i < array.Length; i++) {
            if (i % 2 == 0)
            {
                if (array[i] > even) { even = array[i]; }
            }
            else {
                if (array[i] > odd) { odd = array[i]; }
            }
        }
        if (even > odd)
        {
            for (int i = 0; i < array.Length / 2; i++) { array[i] = 0; }
        }
        else {
            for (int i = array.Length / 2; i < array.Length; i++) { array[i] = 0; }
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
        double mini = double.MaxValue;
        int index_mini = 0;
        int first_neg = -1;
        double even = 0, odd = 0;
        for (int i = 0; i < array.Length; i++) { 
            if (array[i] <  mini) { mini = array[i]; index_mini = i; }
            if (array[i] < 0 && first_neg == -1) { first_neg = i; }
            if (i % 2 == 0) { even += array[i]; }
            else { odd += array[i]; }
        }
        if (first_neg != -1)
        {
            if (first_neg < index_mini) { sum = even; }
            else { sum = odd; }
        }
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
        double maxi = double.MinValue;
        double nakop = 1;
        foreach (double x in array)
        {
            if (x > maxi) { maxi = x; }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == maxi) { array[i] += nakop; nakop++; }
        }
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
        double[] even = null;
        if ((array.Length / 2) * 2 == array.Length) { even = new double[array.Length / 2]; }
        else { even = new double[array.Length / 2 + 1]; }
        double tmp;
        for (int i = 0; i < array.Length; i += 2) { 
            even[i / 2] = array[i];
        }
        for (int i = 0; i < even.Length - 1; i++)
        {
            for (int j = 0; j < even.Length - i - 1; j++)
            {
                if (even[j] > even[j + 1])
                {
                    tmp = even[j]; even[j] = even[j + 1]; even[j + 1] = tmp;
                }
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0) { array[i] = even[i / 2]; }
        }
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
        double[] neg = null;
        int count_neg = 0;
        for (int i = 0; i < array.Length; i++) {
            if (array[i] < 0) { count_neg++; }
        }
        neg = new double[count_neg];
        int dob = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) { neg[dob++] = array[i]; }
        }
        double tmp;
        for (int i = 0; i < neg.Length - 1; i++) {
            for (int j = 0; j < neg.Length - i - 1; j++) {
                if (neg[j] < neg[j + 1]) { tmp = neg[j]; neg[j] = neg[j + 1]; neg[j + 1] = tmp; }
            }
        }
        int step = 0;
        for (int i = 0; i < array.Length; i++) {
            if (array[i] < 0) { array[i] = neg[step++]; }
        }
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
        double step = (b - a) / (n - 1);
        X = new double[n];
        Y = new double[n];
        int index = 0;
        for (double i = a; i <= b; i += step)
        {
            X[index] = Math.Round(i, 2);
            Y[index] = Math.Round(Math.Cos(i) + i * Math.Sin(i), 2);
            index++;
        }
        globalMax = Y[0]; globalMin = Y[0];
        for (int i = 0; i < n - 2; i++) {
            if (Y[i] < Y[i + 1] && Y[i + 1] > Y[i + 2]) {
                if (Y[i + 1] > globalMax) { globalMax = Y[i + 1]; }
            }
            if (Y[i] > Y[i + 1] && Y[i + 1] < Y[i + 2]) {
                if (Y[i + 1] < globalMin) { globalMin = Y[i + 1]; }
            }
        }
        if (Y[n - 1] > globalMax) { globalMax = Y[n - 1]; }
        if (Y[n - 1] < globalMin) { globalMin = Y[n - 1]; }
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
        double mini = double.MaxValue;
        double maxi = double.MinValue;
        foreach (double x in array) {
            if (x < mini) { mini = x; }
            else if (x > maxi) { maxi = x; }
        }
        // Для возможности восстановления воспроизведены следующие выводы (зная min, max и отнормализованное значение, можно восстановить массив значений):
        Console.WriteLine($"max value is {maxi}");
        Console.WriteLine($"min value is {mini}");

        normalizedArray = new double[array.Length];
        for (int i = 0; i < array.Length; i++) { 
            normalizedArray[i] = Math.Round((2.0 * (array[i] - mini) / (maxi - mini)) - 1.0, 2);
        }
        // end

        return normalizedArray;
    }
    #endregion
}