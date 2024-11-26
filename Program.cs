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
        double m = 0;
        for (int i=0;i<6; i++){
            m=m+array[i];
        }
        for (int j=0; j<array.Length; j++){
            array[j]=array[j]/m;
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s=0;
        int kolvo=0;
        for (int i=0; i<array.Length; i++){
            if (array[i]>0){
                kolvo++;
                s+=array[i];
            }

        }
        s/=kolvo;
        for (int j=0;j<array.Length;j++){
            if (array[j]>0){
                array[j]=s;
            }
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i=0;i<first.Length;i++){
            sum[i]=first[i]+second[i];
            dif[i]=first[i]-second[i];
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double symma=0;
        int c=0;
        for (int i=0;i<array.Length;i++){
            symma+=array[i];
            c++;
        }
        symma/=c;
        for (int j=0;j<array.Length;j++){
            array[j]-=symma;
        }

        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i=0;i<vector1.Length;i++){
            product+=vector1[i]*vector2[i];
        }
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i=0; i<vector.Length;i++){
            length+=vector[i]*vector[i];
        }
        length=Math.Sqrt(length);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sr=0;
        for (int i=0;i<array.Length; i++){
            sr+=array[i];
        }
        sr/=array.Length;
        for (int j=0; j<array.Length;j++){
            if (array[j]>sr) array[j]=0;
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        for(int i=0;i<array.Length;i++){
            if(array[i]<0) count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;
        double sr=0;
        int c=0;
        // code here
        for (int i=0;i<array.Length;i++){
            sr+=array[i];
            c++;
        }
        sr/=c;
        for (int j=0;j<array.Length;j++){
            if (array[j]>sr) count++;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for (int i=0;i<array.Length;i++){
            if (array[i]>P&&array[i]<Q) count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;
        int c=0;
        int k=0;
        // code here
        for (int j=0;j<array.Length;j++){
            if (array[j]>0)k++;
        }
        output=new double[k];
        for (int i=0;i<array.Length;i++){
            if (array[i]>0){
                output[c]=array[i];
                c++;
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
        for (int i=array.Length-1; i>=0;i--){
            if (array[i]<0){
                value=array[i];
                index=i;
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
        for (int i=0;i<array.Length;i++){
            if (i%2==0) even[i/2]=array[i];
            else odd[i/2]=array[i];
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i=0;i<array.Length;i++){
            if(array[i]<0) break;
            sum+=array[i]*array[i];
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for(int i=0;i<y.Length;i++){
            y[i] = (x[i] > 0) ? 0.5*Math.Log(x[i]) : double.NaN; 
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        double min = double.MaxValue;
        foreach (double i in array) if (i<min) min = i;
        for (int j=0;j<array.Length; j++){
            if (array[j] == min)
            {
                if (array[j] < 0)
                {
                    array[j] = array[j] / 2;
                }
                else
                {
                    array[j] = array[j] * 2;
                }
            }
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
        double min = double.MaxValue;
        int mini = 0;
        for (int i = 0; i < array.Length; i++)
        { 
            if (array[i] < min) 
            { 
                min = array[i]; mini = i; 
            }
        }

        for (int i = 0; i < mini; i++) 
        {
            if (array[i] >= 0) array[i] *= 2;
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
        double min = double.MaxValue, max = double.MinValue;
        int minI = 0, maxI = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                minI = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                maxI = i;
            }
        }
        int rv;
        if (minI > maxI)
        {
            rv = maxI;
            maxI = minI;
            minI = rv;
        }
        minI++;
        int c = 0;
        for (int i = minI; i <= maxI; i++)
        {
            if (array[i] < 0)
            {
                c++;
            }
        }
        var res = new double[c];
        for (int i = 0; minI < maxI; minI++, i++)
        {
            if (array[minI] < 0)
            {
                res[i] = array[minI];
            }
        }
        array = res;
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
        double max = double.MinValue;
        int maxI = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxI = i;
            }
        }
        if (maxI + 1 < array.Length)
        {
            if (array[maxI + 1] >= 0)
            {
                array[maxI + 1] *= 2;
            }
            else array[maxI + 1] /= 2;
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
        double min = double.MaxValue, max = double.MinValue;
        int minI = 0, maxI = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                minI = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                maxI = i;
            }
        }
        if (minI == maxI + 1) return 0;
        int rv;
        if (minI > maxI)
        {
            rv = maxI;
            maxI = minI;
            minI = rv;
        }
        minI++;
        int cc = 0;
        for (; minI < maxI; minI++)
        {
            average += array[minI];
            cc++;
        }

        average /= cc;
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
        int id = -1;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] > 0)
            {
                id = i;
                break;
            }
        }
        double[] res = new double[array.Length + 1];
        if (id < 0) res = array;
        else
        {
            for (int i = 0; i <= id; i++)
            {
                res[i] = array[i];
            }
            res[id + 1] = P;
            for (int i = id + 1; i < array.Length; i++)
            {
                res[i + 1] = array[i];
            }
        }
        array = res;
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
        double max = double.MinValue;
        int maxI = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > max)
            {
                maxI = i;
                max = array[i];
            }
        }
        array[maxI] = maxI;
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
         output = new double[A.Length + B.Length];
        if (k >= A.Length) return A;
        for (int i = 0; i <= k; i++)
        {
            output[i] = A[i];
        }
        for (int i = 0; i < B.Length; i++)
        {
            output[k + i + 1] = B[i];
        }
        for (int i = 0; i < A.Length - k - 1; i++)
        {
            output[k + B.Length + i + 1] = A[k + i + 1];
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
        double minn = double.MaxValue, maxx = double.MinValue, sum1 = 0, sum2 = 0;
        int minI = -1, maxI = -1, co = 0, cp = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minn)
            {
                minn = array[i];
                minI = i;
            }
            if (array[i] > maxx)
            {
                maxx = array[i];
                maxI = i;
            }
            if (array[i] > 0)
            {
                sum2 += array[i];
                cp++;
            }
            else
            {
                sum1 += array[i];
                co++;
            }
        }
        if (maxI < minI)
        {
            if (cp == 0)
            {
                average = 0;
            }
            else average = sum2 / cp;
        }
        else
        {
            if (co == 0)
            {
                average = 0;
            }
            else average =sum1 / co;
        }
        average = Math.Round(average, 3);
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
        double maxx = double.MinValue, sum = 0;
        int maxI = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxx)
            {
                maxx = array[i];
                maxI = i;
            }
            sum += array[i];
        }
        if (maxx > sum)
        {
            array[maxI] = 0;
        }
        else
        {
            array[maxI] *= 2;
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
        int[] output = null;

        // code here
        double maxx = array[0];
        int c = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxx)
            {
                maxx = array[i];
                c = 1;
            }
            else if (array[i] == maxx)
            {
                c++;
            }
        }
        output = new int[c];
        int id = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == maxx)
            {
                output[id++] = i;
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
        if (array.Length == 0)
        {
            return array;
        }
        double maxx = double.MinValue;
        foreach (double i in array)
        {
            if (i > maxx) maxx = i;
        }
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == maxx)
            {
                sum += array[i];
                array[i] = sum - array[i];
            }
            else sum += array[i];
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
        int pI = 0 ,nI = 0;
            double[] a = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    a[pI++] = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    a[pI + nI] = array[i];
                    nI++;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = a[i];
            }
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
        int c = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 0)
            {
                c = i + 1;
            }
        }
        for (int i = c - 1; i >= 0; i--)
        {
            array[2 * i + 1] = array[i];
            array[2 * i] = array[i];
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
        int n = 0; int p = 0;
        double[] newarray = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            bool dubl = true;
            for (int j = 0; j < newarray.Length; j++)
            {
                if (array[i] == newarray[j])
                {
                    dubl = false;
                }
            }
            if (dubl == true)
            {
                newarray[i] = array[i];
            }
        }
        for (int i = 0; i < newarray.Length; i++)
        {
            if (newarray[i] == 0 && newarray[i] != array[i])
            {
                n++;
            }
        }
        double[] res = new double[newarray.Length - n];

        for (int i = 0; i < newarray.Length; i++)
        {
            if (newarray[i] == array[i])
            {
                res[p] = newarray[i];
                p++;
            }
        }
        array = res;
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