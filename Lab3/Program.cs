using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
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
        double mn = double.MaxValue;
        int index = 0;

        for(int i = 0; i < array.Length;i++){
        if (array[i] < mn){
            index = i; 
            mn = array[i];
        }
        }
        array[index] *= 2;

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        double mx = double.MinValue;
        int index = 0;

        for(int i = 0; i < array.Length;i++){
        if (array[i] > mx){
            index = i; 
            mx = array[i];
        }
        }
        for(int i = 0;i < index;i++){
            sum += array[i];
        }
        return sum;
    }
    public double[] Task_2_3(double[] array)
    {
        double mn = double.MaxValue;
        int index = 0;

        for(int i = 0; i < array.Length;i++){
        if (array[i] < mn){
            index = i; 
            mn = array[i];
        }
        }
        for(int i = 0;i < index;i++){
            if (array[i] >= 0){
             array[i] *= 2;   
            }
            else{
                array[i] /= 2;  
            }
            
        }

        return array;
    }
    public double[] Task_2_4(double[] array)
    {
        double mx = double.MinValue,s = 0,sr;
        int index = 0;

        for(int i = 0; i < array.Length;i++){
        if (array[i] > mx){
            index = i; 
            mx = array[i];
        }
        s += array[i];
        }
        sr = Math.Round(s/array.Length,1);
        for(int i = index + 1;i < array.Length;i++){
            array[i] = sr;
        }

        return array;
    }
    public double[] Task_2_5(double[] array)
    {
        double mx = double.MinValue,mn = double.MaxValue;
        int indmn = 0,indmx = 0;

        for(int i = 0; i < array.Length;i++){
        if (array[i] < mn){
            indmn= i; 
            mn = array[i];
        }
        if (array[i] > mx){
            indmx = i;
            mx = array[i];
        }
        }
        int mxind = indmx, mnind = indmn;
        if (mxind < mnind){
            mxind = indmn;
            mnind = indmx;
        }
        double[] array1 = new double[Math.Abs(indmx-indmn-1)];
        int k = 0;
        for(int i = mnind + 1; i < mxind;i++){
            if (array[i] < 0){
                array1[k] = array[i];
                k++;
            }
        }
        array = array1;
        return array;
    }
    public double[] Task_2_6(double[] array, double P)
    {
        double s = 0,sr,mn = double.MaxValue;

        for(int i = 0; i < array.Length;i++){
            s += array[i];
        }
        sr = Math.Round(s/array.Length,2);
        int ind = 0;
        for(int i = 0; i < array.Length;i++){
            if (Math.Abs(array[i]-sr) < mn){
                ind = i + 1;
                mn = Math.Abs(array[i]-sr);
            }
        }
        double[] array1 = new double[array.Length+1];
        for(int i = 0; i < ind + 1;i++){
            if (i != ind){
                array1[i] = array[i];
            }
            else{
                array1[i] = P; 
            }
            }
            for(int i = ind + 1; i < array1.Length;i++){
                array1[i] = array[i - 1];
            }
  
        array = array1;

        return array;
    }
    public double[] Task_2_7(double[] array)
    {
        double mx = double.MinValue;
        int index = 0;

        for(int i = 0; i < array.Length;i++){
        if (array[i] > mx){
            index = i + 1; 
            mx = array[i];
        }
        }
        if ( index != array.Length) {
           array[index] *= array[index] > 0 ? 2 : 0.5; 
        }


        return array;
    }
    public double[] Task_2_8(double[] array)
    {
        double mx = double.MinValue, mn = double.MaxValue;
        int indmx = 0, indmn = 0;
        for(int i = 0; i < array.Length;i++){
        if (array[i] > mx){
            indmx = i; 
            mx = array[i];
        }
        }
        for(int i = indmx + 1; i < array.Length;i++){
        if (array[i] < mn){
            indmn = i; 
            mn = array[i];
        }
        }
        if (indmx < indmn){
            array[indmx] = mn;
            array[indmn] = mx;
        }

        return array;
    }
    public double Task_2_9(double[] array)
    {
        double average = 0;

        double mx = double.MinValue,mn = double.MaxValue;
        int indmn = 0,indmx = 0,start = 0,end = 0;

        for(int i = 0; i < array.Length;i++){
            start = indmn + 1;
            end = indmx;
            if (array[i] < mn){
                indmn= i; 
                mn = array[i];
            }
            if (array[i] > mx){
                indmx = i;
                mx = array[i];
            }
            if (indmx < indmn){
                start = indmx + 1;
                end = indmn;
        }
        
        }
        for(int i = start; i < end;i++){
            average += array[i];
        }
        average /= average != 0 ? end-start : 1;
        return Math.Round(average,2);
    }
    public double[] Task_2_10(double[] array)
    {
        double mn = double.MaxValue;
        bool flag = false;

        for(int i = 0; i < array.Length;i++){
            if (array[i] < mn && array[i] > 0){
                mn = array[i];
                flag = true;
            } 
        } 
        if (flag){
            double[] array1 = new double[array.Length-1];
            int j = 0;
            for(int i = 0; i < array.Length;i++){
                if (array[i] != mn){
                    array1[j] = array[i];
                    j++;
                }
            }
            array = array1;
        }
        return array;
    }
    public double[] Task_2_11(double[] array, double P)
    {
        int ind = 0;
        bool flag = false;

        for(int i = 0; i < array.Length;i++){
            if (array[i] > 0){
                ind = i + 1;
                flag = true;
            } 
        }
        if (flag){
            double[] array1 = new double[array.Length+1];
            int j = 0;
            for(int i = 0; i < ind; i++){
                array1[i] = array[i];
            }
            array1[ind] = P;
            for(int i = ind; i < array.Length;i++){
                array1[i+1] = array[i];
            }
            array = array1;
        }
        return array;
    }
    public double[] Task_2_12(double[] array)
    {
        int ind = 0,indmx = 0;
        bool flag = false;
        double mx = double.MinValue;
        double[] pref_s = new double[array.Length+1];
        pref_s[0] = 0;
        for(int i = 0; i < array.Length;i++){
            if (array[i] < 0 && !flag){
                ind = i;
                flag = true;
            }
            if (array[i] > mx){
                indmx = i;
                mx = array[i];
            } 
            pref_s[i+1] = pref_s[i] + array[i];
            }
        if (flag){
        array[ind] = Math.Round(pref_s[pref_s.Length - 1] - pref_s[indmx + 1],1);
        }
        return array;
    }
    public double[] Task_2_13(double[] array)
    {
        int indmx = 0;
        double mx = double.MinValue;
        for(int i = 0; i < array.Length;i += 2){
            if (array[i] > mx){
                indmx = i;
                mx = array[i];
            } 
        }
        array[indmx] = indmx;
        return array;
    }
    public double[] Task_2_14(double[] array)
    {
        int indmx = 0,indotr = 0;
        double mx = double.MinValue, otr = 0;
        bool flag = false;
        for(int i = 0; i < array.Length;i++){
            if (array[i] > mx){
                indmx = i;
                mx = array[i];
            } 
            if (array[i] < 0 && !flag){
                indotr = i;
                otr = array[i];
                flag = true;
            }
        }
        if (flag){
            double buf = mx;
            array[indmx] = array[indotr];
            array[indotr] = buf;
        }
        return array;
    }
    public double[] Task_2_15(double[] A, double[] B, int k)
    {
        double[] output = new double[A.Length+B.Length];
        bool flag = true;
        int lB = B.Length;
        for(int i = 0;i<A.Length;i++){
            if (i != k + 1 && flag){
                output[i] = A[i];  
            }
            else if (flag){
                for (int j = 0;j < lB;j++){
                    output[i+j] = B[j];
                }
                flag = false;
            }
            else{
                output[i+lB-1] = A[i-1];
            }
        }
        output[output.Length-1] = A[A.Length-1];
        for(int i = 0;i<output.Length;i++){
            Console.WriteLine(output[i]);
        }
        return output;
    }
    public int[] Task_2_16(double[] array)
    {
        int[] output = null;
        double sr = 0;
        for(int i = 0;i < array.Length;i++){
            sr += array[i];
        }
        sr /= array.Length;
        int cnt = 0;
        for(int i = 0;i < array.Length;i++ ){
            if (array[i] < sr){
            cnt += 1;
            }
        }
        output = new int[cnt];
        int j = 0;
        for(int i = 0;i < array.Length;i++ ){
            if (array[i] < sr){
            output[j] = i;
            j++;
            }
        }
        return output;
    }
    public double Task_2_17(double[] array)
    {
        double average = 0;

        double mx = double.MinValue,mn = double.MaxValue, srot = 0,srpol =0;
        int indmn = 0,indmx = 0, cntpol = 0,cntotr = 0;

        for(int i = 0; i < array.Length;i++){
        if (array[i] < mn){
            indmn= i; 
            mn = array[i];
        }
        if (array[i] > mx){
            indmx = i;
            mx = array[i];
        }
        if (array[i] < 0){
            cntotr++;
            srot += array[i];
        }
        else if (array[i] != 0){
            cntpol++;
            srpol += array[i];
        }
        }
        if (indmx > indmn && cntotr != 0){
           average = srot / cntotr;
        }
        else if (indmx < indmn && cntpol != 0){
            average = srpol / cntpol;
        }

        return Math.Round(average,2);
    }
    public double[] Task_2_18(double[] array)
    {
        double mxnch = double.MinValue,mxch = double.MinValue;
        for(int i = 0; i < array.Length;i++){
        if (array[i] > mxnch && i % 2 > 0){
            mxnch = array[i];
        }
        if (array[i] > mxch && i % 2 == 0){
            mxch= array[i];
        }
        }
        int start, end;
        if (mxch > mxnch){
            start = 0;
            end = array.Length/2;
        }
        else{
            start = array.Length/2;
            end = array.Length;
        }
        for(int i = start;i < end;i++){
            array[i] = 0;
        }
        return array;
    }
    public double[] Task_2_19(double[] array)
    {
        double mx = double.MinValue,s = 0;
        int indmx = 0;

        for(int i = 0; i < array.Length;i++){
        s += array[i];
        if (array[i] > mx){
            indmx = i;
            mx = array[i];
        }
        }
        array[indmx] = mx > s ? 0 : array[indmx]*2;

        return array;
    }
    public double Task_2_20(double[] array)
    {
        double sum = 0;

        double mn = double.MaxValue;
        int indmn = 0,indotr = 0;
        bool flag = false;
        for(int i = 0; i < array.Length;i++){
        if (array[i] < 0 && !flag){
                indotr = i;
                flag = true;
            }
        if (array[i] < mn){
            indmn = i; 
            mn = array[i];
        }
        }
        for (int k = indmn > indotr ? 0 : 1; k < array.Length && flag;k += 2){
            sum += array[k];
        }
        return sum;
    }
    #endregion
    #region Level 3
    public int[] Task_3_1(double[] array)
    {
        int[] output = [1], output1 = [1],output2 = [1];
        int cnt = 0;
        double mx = double.MinValue;
        bool flag = true;
        for(int i = 0; i < array.Length;i++){
            if (array[i] > mx){
                output[0] = i; 
                mx = array[i];
                cnt = 1;
                flag = true;
            }
            else if (mx == array[i]){
                if (flag){
                    output2[0] = output[0];
                    flag = false;
                }
               output1 = new int[++cnt];
               for (int j = 0; j < output2.Length;j++){
                output1[j] = output2[j];
               }
               output1[cnt - 1] = i;
               output2 = new int[cnt];
               output2 = output1;
            }
        }
        output = output1;
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
        double mx = double.MinValue;
        double[] pref_s = new double[array.Length+1];
        int cnt = 0;
        pref_s[0] = 0;
        for(int i = 0; i < array.Length;i++){
            if (array[i] > mx){
                cnt = 0;
                mx = array[i];
            }
            if (array[i] == mx){
                cnt++;
            }
            pref_s[i+1] = pref_s[i] + array[i];
            }
        int[] ind = new int[cnt];
        int j = 0;
        for(int i = 0;i < array.Length;i++){
            if (mx == array[i]){
                ind[j++] = i;
            }
        }
        for (int i = 0;i < ind.Length;i++){
            array[ind[i]] = pref_s[ind[i]];
        }

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
        int cnt = 0;
        for (int i = 0; i < array.Length;i++){
            if (array[i] < 0){
                cnt++;
            }
        }
        double[] otr = new double [cnt];
        double[] pol = new double [array.Length-cnt];
        int j = 0,k = 0;
        for (int i = 0; i < array.Length;i++){
            if (array[i] < 0){
                otr[j++] = array[i];
            }
            else{
                pol[k++] = array[i];
            }
        }
        int lpol = pol.Length;
        array = new double[lpol+otr.Length];
        for(int i = 0;i < array.Length;i++){
            if (i < lpol){
                array[i] = pol[i];
            }
            else{
                array[i] = otr[i-lpol];
            }

        }

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
        int j = 0;
        double[] buf = new double[array.Length];
        for(int i = 0;i < array.Length - 1;i += 2){
            buf[i] = array[j];
            buf[i+1] = array[j];
            j++;
        }
        array = buf;
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
        int cnt = 0;
        bool flag = true;
        for (int i = 0; i < array.Length; i++)
        {
            flag = true;
            for (int j = 0; j < i; j++)
            {
                if (array[i] == array[j])
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                cnt++;
            }
        }
        double[] buf = new double[cnt];
        int k = 0;

        for (int i = 0; i < array.Length; i++)
        {
            flag = true;
            for (int j = 0; j < k; j++)
            {
                if (array[i] == buf[j])
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                buf[k++] = array[i];
            }
        }
        array = buf;

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