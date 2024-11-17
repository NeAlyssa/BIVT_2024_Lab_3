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
        program.Task_1_11(new double[] { 1.5, 1, 3, -2.2, -0.5   });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double s = 0;
        foreach (double x in array)
        {
            s+=x;
        }
        for (int i =0; i<6;i++)
        {
            array[i] = Math.Round(array[i]/s,2);
        }
        // end
        foreach (double x in array)
        {
            Console.WriteLine(x);
        }
        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double k =0, s=0;
        foreach (double x in array)
        {
            if (x>0)
            {
                s+=x;
                k++;
            }
        }
        double sr = Math.Round(s/k,2);
        for (int i =0; i<8;i++)
        {
            if (array[i] >0) array[i]=sr;
        }
        foreach (double x in array)
        {
            Console.WriteLine(x);
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i=0; i < first.Length;i++)
        {
            sum[i]=Math.Round(first[i] + second[i],2);
            dif[i]=Math.Round(first[i] - second[i],2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s =0,k=0;
        foreach (double x in array)
        {
            s+=x;
            k++;
        }
        double sr = Math.Round(s/k,2);
        for (int i =0; i<5;i++)
        {
            array[i]=Math.Round(array[i]-sr,2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i=0; i<4;i++)
        {
            product+=vector1[i]* vector2[i];
        }
        // end
        product = Math.Round(product,2);
        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i=0; i<5;i++)
        {
            length+=vector[i]* vector[i];
        }
        // end
        length = Math.Round(Math.Sqrt(length),2);
        Console.WriteLine(length);
        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s =0,k=0;
        foreach (double x in array)
        {
            s+=x;
            k++;
        }
        double sr = Math.Round(s/k,2);
        for (int i=0;i<7;i++)
        {
            if (array[i] >sr) array[i]=0;
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        foreach(double x in array)
        {
            if (x<0) count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double s =0,k=0;
        foreach (double x in array)
        {
            s+=x;
            k++;
        }
        double sr = Math.Round(s/k,2);
        foreach(double x in array)
        {
            if (x>sr) count++;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        foreach(double x in array)
        {
            if (x>P && x<Q) count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        int j =0;
        int n=0;
        // code here
        foreach (double x in array)
        {
            if (x>0) n++;
        }
        double[] output = new double[n];
        foreach(double x in array)
        {
            if (x>0)
            {
                output[j]=x;
                j++;
            }
        }
        foreach (double x in output)
        {
            Console.WriteLine(x);
        }
        // end

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        // code here
        for (int i=0;i<8;i++)
        {
            if (array[i]<0)
            {
                value=array[i];
                index=i;
            }
        }
        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];
        int k1=0,k2=0;

        // code here
        for(int i=0;i<10;i++)
        {
            if (i%2==0) 
            {
                even[k1]=array[i];
                k1++;
            }
            else
            {
                odd[k2]=array[i];
                k2++;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        foreach(double x in array)
        {
            if (x<0) break;
            else
            {
                sum+=x*x;
            }
            
        }
        Console.WriteLine(sum);
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i =0; i<10;i++)
        {
            if (x[i] <= 0) y[i] = double.NaN;
            else 
            {
                y[i]= Math.Round(0.5 * Math.Log(x[i]),2);
            }
            
        }
        // end
        foreach (double s in y)
        {
            Console.WriteLine(s);
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
        int imax =0;
        for (int i=1; i < array.Length;i++)
        {
            if (array[i] > array[imax]) imax=i;
        }
        for (int i =0;i<imax;i++)
        {
            sum+=array[i];
        }
        // end
        Console.WriteLine(sum);
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
        int imax =0;
        double sum=0;
        for (int i=0; i < array.Length;i++)
        {
            sum+=array[i];
            if (array[i] > array[imax]) imax=i;
        }
        double sr = Math.Round(sum/array.Length,2);
        for (int i =imax+1;i<array.Length;i++)
        {
            array[i]=sr;
        }
        foreach (double x in array)
        {
            Console.WriteLine(x);
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
        double sum =0;
        foreach ( double x in array) sum+=x;
        double sr = Math.Round(sum/array.Length,2);
        double r = 1000000000000000000;
        int j =0;
        for (int i =0; i <array.Length;i++)
        {
            if (Math.Abs(array[i] - sr) < r)
            {
                r = Math.Abs(array[i] - sr);
                j =i;
            }
        }
        int n = array.Length +1;
        double[] asw = new double[n];
        n=0;
        for (int i =0; i <=j;i++)
        {
            asw[n] = array[i];
            n++;
        }
        asw[n] = P;
        n++;
        for (int i =j+1; i <array.Length;i++)
        {
            asw[n] = array[i];
            n++;
        }
        // end
        array = asw;
        foreach (double x in array)
        {
            Console.WriteLine(x);
        }
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
        int imax=0;
        double amax = 0;
        for (int i =0; i <array.Length;i++)
        {
            if (array[i] > array[imax]) 
            {
                imax=i;
                amax = array[i];
            }
        }
        if (imax +1 < array.Length)
        {
            double amin=array[imax+1];
            int imin=imax+1;
            for (int i =imax+1; i<array.Length;i++)
            {
                if (array[i] < array[imin])
                {
                    imin=i;
                    amin=array[i];
                }
            }
            array[imax] = amin;
            array[imin] = amax;
        }
        
        

        // end
        foreach (double x in array)
        {
            Console.WriteLine(x);
        }
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
        double[] asw = new double[array.Length -1];
        int j =0;
        double mini=100000000000000;
        for (int i =0 ;i<array.Length;i++)
        {
            if (array[i]>0 && array[i]<mini)
            {
                mini=array[i];
                j=i;
            }
        }
        if (array[j]<=0) 
        {
            asw=new double[array.Length];
            j=-1;
        }
        
        int k=0;
        for (int i=0;i<j;i++)
        {
            asw[k]=array[i];
            k++;
        }
        if (j!=array.Length)
        {
            for (int i = j+1;i<array.Length;i++)
            {
                asw[k]=array[i];
                k++;
            }
            array=asw;  
        }
        foreach (double x in array)
            {
                Console.WriteLine(x);
            }
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
        int imin=-1;
        double sum=0;
        int imax=0;
        double amax=-1000000000;
        for (int i=0;i<array.Length;i++)
        {
            if (array[i]<0 && imin==-1) imin=i;
            if (array[i] > amax)
            {
                amax=array[i];
                imax=i;
            }
        }
        if (imax+1!=array.Length)
        {
            for (int i=imax+1;i<array.Length;i++)
            {
                sum+=array[i];
            }
             array[imin]=Math.Round(sum,2);
        }
       
        foreach (double x in array)
        {
            Console.WriteLine(x);
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
        int imin=-1;
        double omin=0;
        int imax=0;
        double amax=-1000000000;
        for (int i=0;i<array.Length;i++)
        {
            if (array[i]<0 && imin==-1) 
            {
                imin=i;
                omin=array[i];
            }
            if (array[i] > amax)
            {
                amax=array[i];
                imax=i;
            }
        }
        if (imin!=-1)
        {
            array[imin]=amax;
            array[imax]=omin;
        }
        foreach (double x in array)
        {
            Console.WriteLine(x);
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
        double sum=0;
        for (int i=0; i<array.Length;i++)
        {
            sum+=array[i];
        }
        double sr=Math.Round(sum/array.Length,2);
        int n=0;
        for (int i=0;i<array.Length;i++)
        {
            if (array[i]<sr) n++;
        }
        output = new int[n];
        int j=0;
        for (int i=0;i<array.Length;i++)
        {
            if (array[i]<sr)
            {
                output[j]=i;
                j++;
            }
        }
        foreach (double x in output)
        {
            Console.WriteLine(x);
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
        double ch=-100000000000000;
        double nch=-10000000000000;
        for (int i=0;i<array.Length;i++)
        {
            if (i%2==0 && array[i]>ch) ch=array[i];
            if (i%2!=0 && array[i]>nch) nch=array[i];
        }
        if (ch>nch)
        {
            for (int i=0;i<array.Length/2;i++)
            {
                array[i]=0;
            }
        }
        else
        {
            for (int i=array.Length/2;i<array.Length;i++)
            {
                array[i]=0;
            }
        }
        foreach (double x in array)
        {
            Console.WriteLine(x);
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
        int omin=-1;
        double amin=10000000000;
        int imin=0;
        for (int i=0; i<array.Length;i++)
        {
            if (array[i]<0 && omin==-1) omin=i;
            if (array[i]<amin)
            {
                amin=array[i];
                imin=i;
            }
        }
        if (omin!=-1)
        {
            if (omin<imin)
            {
                for (int i=0;i<array.Length;i+=2) sum+=array[i];
            }
            else
            {
                for (int i=1;i<array.Length;i+=2) sum+=array[i];
            }
        }
        // end
        Console.WriteLine(sum);
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
        int s=1;
        double amax=-100000000;
        for (int i=0; i<array.Length;i++)
        {
            if (array[i]>amax) amax=array[i];
        }
        for (int i=0;i<array.Length;i++)
        {
            if (array[i]==amax)
            {
                array[i]=array[i]+s;
                s++;
            }
        }
        foreach (double x in array)
        {
            Console.WriteLine(x);
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
        int l = array.Length/2 + array.Length%2;
        double[] ch = new double[l];
        int k=0;
        for (int i=0; i<array.Length;i+=2)
        {
            ch[k]=array[i];
            k++;
        }
        for (int i=ch.Length-1;i>0;i--)
        {
            double amax =ch[i];
            int imax=i;
            for (int j=i-1;j>=0;j--)
            {
                if (ch[j] > amax)
                {
                    amax=ch[j];
                    imax=j;
                }
            }
            ch[imax]=ch[i];
            ch[i]=amax;
        }
        int k1=0;
        for (int i=0; i<array.Length;i+=2)
        {
            array[i]=ch[k1];
            k1++;
        }
        foreach (double x in array)
        {
            Console.WriteLine(x);
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
        int k=0;
        for (int i=0; i<array.Length;i++)
        {
            if (array[i] < 0) k++;
        }
        double[] otr =new double[k];
        int z=0;
        for (int i=0;i<array.Length;i++)
        {
            if (array[i] <0)
            {
                otr[z] = array[i];
                z++;
            } 
        }
        for (int i=0;i<otr.Length-1;i++)
        {
            double amax =otr[i];
            int imax=i;
            for (int j=i+1;j<otr.Length;j++)
            {
                if (otr[j] > amax)
                {
                    amax=otr[j];
                    imax=j;
                }
            }
            otr[imax]=otr[i];
            otr[i]=amax;
        }
        int z1=0;
        for (int i=0;i<array.Length;i++)
        {
            if (array[i]<0)
            {
                array[i] = otr[z1];
                z1++;
            }
        }
        foreach (double x in array)
        {
            Console.WriteLine(x);
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
        double x1=0,y1=0;
        double rast = (b-a) / (n-1.0);
        double globalMax = 0, globalMin = 0;
        for (int i=0; i<n;i++)
        {
            x1 = a +i*rast;
            y1=Math.Round(Math.Cos(x1) + x1*Math.Sin(x1),2);
            x1=Math.Round(x1,2);
            X[i]=x1;
            Y[i]=y1;
        }
        globalMax = Y[0];
        globalMin=Y[0];
        foreach (double z in Y)
        {
            if (z > globalMax) globalMax =z;
            if (z < globalMin) globalMin =z;
        }
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
        double[] answer = new double[array.Length];
        int imax=0,imin=0;
        for (int i=0; i<array.Length;i++)
        {
            if (array[i] > array[imax]) imax=i;
            if (array[i] < array[imin]) imin=i;
        }
        for (int i=0;i<array.Length;i++)
        {
            answer[i] = Math.Round((2*(array[i] - array[imin])/(array[imax] -array[imin]))-1,2);
        }
        // code here

        // end
        foreach (double x in answer)
        {
            Console.WriteLine(x);
        }
        return answer;
    }
    #endregion
}
