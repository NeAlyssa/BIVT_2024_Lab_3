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
            s+=array[i];
        }
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] / s, 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sr = 0;
        double s =0;
        double n = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                n++;
                s += array[i];
            }
            sr = Math.Round(s / n,2);
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = sr;
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
            sum[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = Math.Round(first[i] - second[i], 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s = 0;double sr = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s+= array[i];
        }
        sr = Math.Round(s / 5, 2);
        for(int i = 0; i < 5; i++)
        {
            array[i] = Math.Round(array[i] - sr, 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;
        double pr = 0;
        // code here
        for (int i = 0; i < 4; i++)
        {
            pr = vector1[i] * vector2[i];
            product += pr;
        }
        product = Math.Round(product, 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;
        double sk = 0;
        // code here
        for(int i = 0; i < 5; i++)
        {
            sk += vector[i] * vector[i];
        }
        length = Math.Sqrt(sk);
        length = Math.Round(length, 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sr = 0;
        double s = 0;
        for (int i = 0; i < 7; i++)
        {
            s += array[i];
        }
        sr=Math.Round(s/7, 2);
        for (int i = 0; i < 7; i++)
        {
            if (array[i] > sr)
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
        for(int i = 0; i < 6; i++)
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
        double sr = 0;
        double s = 0;
        for (int i = 0; i < 8; i++)
        {
            s += array[i];
        }
        sr = Math.Round(s / 8, 2);
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > sr)
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
        for (int i = 0; i < 10; i++)
        {
            if (array[i]>P && array[i] < Q)
            {
                count++;
            }
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;
        int n = 0;
        // code here
        for(int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                n++;
            }
        }
        
        output = new double[n];
        n = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                output[n++] = array[i];
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
        for (int i = 0; i < 8; i++)
        {
            if (array[i] < 0)
            {
                value= array[i];
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
        int n = 0;
        // code here
        for (int i = 0; i < 10; i+=2)
        {
            even[n++] = array[i];
        }
        n = 0;
        for (int i = 1; i < 10; i += 2)
        {
            odd[n++] = array[i];
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i < 11; i++)
        {
            if (array[i] >= 0)
            {
                sum += array[i]* array[i];
            }
            else
            {
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
        for (int i = 0; i < 10; i++)
        {
            if (x[i] == 0)
            {
                y[i] = double.NaN;
            }
            else
            {
                y[i] = Math.Round(0.5*Math.Log(x[i]),2);
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
        double amin = double.MaxValue;
        int imin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < amin)
            {
                amin = array[i];
                imin = i;
            }
        }
        if (array[imin] > 0)
        {
            array[imin] *= 2;
        }
        else
        {
            array[imin] /= 2;
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
        
        double amin = double.MaxValue;
        int imin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < amin)
            {
                amin = array[i];
                imin = i;
            }
        }
        for (int i = 0;i<imin;i++)
        {
            if (array[i] < 0)
            {
                array[i] /=2;
            }
            else
            {
                array[i] *= 2;
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
        double amin = double.MaxValue;
        int imin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < amin)
            {
                amin = array[i];
                imin = i;
            }
        }
        double amax = double.MinValue;
        int imax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
        }
        int ko = 0;
        for (int i = imin + 1; i < imax; i++)
        {
            if (array[i] < 0)
            {
                ko++;
            }
        }
        double[] ar = new double[ko];
        ko = 0;
        for (int i = imin+1; i < imax; i++)
        {
            if (array[i] < 0)
            {
                ar[ko] = array[i];
                ko++;
            }
        }
        
        // end

        return ar;
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
        double amax = double.MinValue;
        int imax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
        }
        if (imax + 1 < array.Length)
        {
            if (array[imax+1] < 0)
            {
                array[imax+1] /= 2;
            }
            else
            {
                array[imax+1] *= 2;
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
        double amin = double.MaxValue;
        int imin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < amin)
            {
                amin = array[i];
                imin = i;
            }
        }
        double amax = double.MinValue;
        int imax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
        }
        if (imin > imax)
        {
            int t = imax;
            imax = imin;
            imin = t;
        }
        if (imax-imin - 1 == 0)
        {
            return 0;
        }
        double k = 0;
        double s = 0;
        for (int i = imin + 1; i < imax; i++)
        {
            s += array[i];
            k++;
        }
        average = s / k;
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
        
        int ipol = -1;
        for (int i=0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                ipol = i;
            }
        }
        if (ipol < 0)
        {
            return array;
        }
        double[] b=new double[array.Length+1];

        int j = 0;
        for (; j <= ipol; j++)
        {
            b[j]=array[j];
        }
        b[j]= P;
        j++;
        for(;j <array.Length; j++)
        {
            b[j +1]=array[j];
        }
        
        
        // end

        return b;
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
        double amax = double.MinValue;
        int imax = 0;
        for (int i = 0; i < array.Length; i+=2)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
        }
        array[imax] = imax;
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
        if (k >= A.Length)
        {
            output = new double[A.Length];
            for (int i = 0; i < A.Length; i++)
                output[i] = A[i];
            return output;
        }
        output = new double[A.Length + B.Length];
        for (int i = 0; i <= k; i++)
        {
            output[i] = A[i];
        }
        for (int i = 0; i < B.Length; i++)
        {
            output[k + i + 1] = B[i];
        }
        for (int i = k + 1; i < A.Length; i++)
        {
            output[i + B.Length] = A[i];
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
        double amin = double.MaxValue;
        int imin = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < amin)
            {
                amin = array[i];
                imin = i;
            }
        }
        double amax = double.MinValue;
        int imax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
        }
        double k=0, s=0;
        if (imin > imax)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    s += array[i];
                    k++;
                }
                    
            }
            average = s / k;
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    s += array[i];
                    k++;
                }

            }
            average = Math.Round(s / k, 2);
        }
        if (k == 0)
        {
            average = 0;
        }
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
        double amax = double.MinValue;
        int imax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
        }
        double s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        if (amax > s)
        {
            array[imax] = 0;
        }
        else
        {
            array[imax] *=2;
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

        // end

        return output;
    }
    public double[] Task_3_2(double[] array)
    {
        // code here
        double amax = double.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
            }
        }
        double c = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == amax)
            {
                c++;
                array[i] += c;
            }
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
        double a = array[0];
        for (int i = 0; i < array.Length; i+=2)
        {
            for(int j = 0; j < array.Length-i-2; j+=2)
            {
                if (array[j] > array[j + 2])
                {
                    a = array[j];
                    array[j] = array[j + 2];
                    array[j + 2] = a;
                }
            }
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
        double a = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
               
                if (array[j + 1] < 0)
                {
                    if (array[j + 1] > array[j])
                    {
                        a = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = a;
                    }
                }
            }
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
        double[] X = new double[n], Y = new double[n];
        

        // code here
        double x = 0, y = 0;
        double run = (b - a) / (double)(n - 1);
        for (int i = 0; i < n; i++)
        {
            x = a + i * run;
            y = Math.Round(Math.Cos(x) + x * Math.Sin(x), 2);
            x = Math.Round(x, 2);
            X[i] = x;
            Y[i] = y;
        }
        double globalMax = Y[0], globalMin = Y[0];
        foreach (double h in Y)
        {
            if (h > globalMax) globalMax = h;
            if (h < globalMin) globalMin = h;
        }
       

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
       // double[] normalizedArray = null;

        // code here
        double[] array2 = new double[array.Length];
        int imax = 0, imin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[imax])
            {
                imax = i;
            }
            if (array[i] < array[imin])
            {
                imin = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            array2[i] = Math.Round((2 * (array[i] - array[imin]) / (array[imax] - array[imin])) - 1, 2);
        }
        return array2;
        // end

        //return normalizedArray;
    }
    #endregion
}