using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Xml.Resolvers;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_3_10(new double[] { 0, 1.5, 1, 3, 0, 0, 0, 0 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        double s = 0;
        foreach(double x in array)
        {
            s += x;
        }
        for (int i=0;i<array.Length;i++)
        {
            array[i] = Math.Round(array[i]/s, 2);
        }
        return (array);
     
    }
    public double[] Task_1_2(double[] array)
    {
        double s = 0;
        int k = 0;
        double sr = 0;
        foreach(double x in array)
        {
            if (x > 0)
            {
                s += x;
                k++;
            }
        }
        sr = Math.Round(s / k,2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = sr;
            }
        }

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        for (int i = 0; i < first.Length; i++)
        {
            sum[i] = Math.Round(first[i] + second[i],2);
            dif[i] = Math.Round(first[i] - second[i],2);
        }

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        
        double s = 0;
        int k = 0;
        double sr = 0;
        foreach(double x in array)
        {
            s += x;
            k++;
        }
        sr = s / k;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - sr,2);
        }
        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        double[] pros = new double[4];
        for (int i = 0; i < vector1.Length; i++)
        {
            pros[i] = vector1[i] * vector2[i];
            product += pros[i];
        }

        return Math.Round(product,2);
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;
        double s = 0;
        for (int i = 0; i < vector.Length; i++)
        {
            vector[i] = vector[i] * vector[i];
            s += vector[i];
        }
        length = Math.Sqrt(s);
        return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        double s = 0;
        int k = 0;
        double sr = 0;
        foreach(double x in array)
        {
            s += x;
            k++;
        }
        sr = s / k;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sr)
            {
                array[i] = 0;
            }
        }

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        foreach (double x in array)
        {
            if (x < 0)
            {
                count++;
            }
        }

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        double s = 0;
        int k = 0;
        double sr = 0;
        foreach (double x in array)
        {
            s += x;
            k++;
        }
        sr = s / k;
        foreach(double x in array)
        {
            if (x > sr)
            {
                count++;
            }
        }

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        foreach (double x in array)
        {
            if ((x>P) && (x < Q))
            {
                count++;
            }
        }

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = new double[array.Length];
        
            int j = 0;
            foreach(double x in array)
            {
                if (x > 0)
                {
                    output[j] = x;
                    j++;
                }
            }
    
        
        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        // code here
        for (int i = (array.Length-1); i >= 0; i--)
        {
            if (array[i] < 0)
            {
                value = array[i];
                index = i;
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
        int j = 0;
        int l = 0;
        for (int i=0;i<=9;i++)
        {
            if (i % 2 == 0)
            {
                even[j] = array[i];
                j++;
            }
            else
            {
                odd[l] = array[i];
                l++;
            }
            
        }

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        foreach (double x in array)
        {
            if (x >= 0)
            {
                sum += x*x;
            }
            else { break; }
            
            
        }

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];
        int j = 0;
        foreach (double k in x)
        {
            if (Math.Log(k) >= 0)
            {
                y[j] = Math.Round(0.5 * Math.Log(k),2);
                
            }else { y[j] = double.NaN; }
            j++;

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
        double amax = array[0];
        foreach(double x in array)
        {
            if (x > amax) { amax = x; }
            
        }
        foreach (double x in array)
        {
            if (x < amax)
            {
                sum += x;
            }
            else { break; }
        }

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
        double s = 0;
        double k = 0;
        double sr = 0;
        double amax = array[0];
        
        int imax = 0;
        foreach (double x in array)
        {
            s += x;
            k++;
            
        }
        sr = s / k;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax) { 
                amax = array[i];
                imax = i;
            }

        }

        for (int j=imax+1; j<array.Length;j++)
        {
                array[j] = Math.Round(sr,1);  
        }
        
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
        double s = 0;
        double sr = 0;
        foreach(double x in array)
        {
            s += x;
        }
        sr =Math.Round( s / array.Length,2);
        double dev = 100000000000000000;
        int isrprib = -1;//why
        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - sr) < dev)
            {
                isrprib = i;
                dev = Math.Abs(array[i] - sr);
            }
        }
        int k = array.Length+1;
        double[] kapec = new double[k];
        k = 0;
        for (int i = 0; i <= isrprib; i++)
        {
            kapec[k]=array[i];
            k++;
        }
        kapec[isrprib + 1] = P;
        int y = isrprib + 2;
        for (int i = isrprib+1; i < array.Length; i++)
        {
            kapec[y]=array[i];
            y++;
        }
        array = kapec;
        

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
        double amax=array[0];
        int imax = 0;
        double amin = 100000;
        int imin = 0;
        double temp;
       for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax=array[i];
                imax = i;
            }

        }
        for (int i = imax+1; i < array.Length; i++)
        {
            if (array[i]<amin)
            {
                amin = array[i];
                imin = i;
            }

        }
        if (imax != array.Length-1)
        {
            temp = array[imax];
            array[imax] = array[imin];
            array[imin] = temp;
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
        
        double amin = 1000000;
        int imin = -1;
        int cnt = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                if (array[i] < amin)
                {
                    amin = array[i];
                    imin = i;
                }
                cnt++;
            }
        }
        if (cnt != 0)
        {
            for (int i = imin; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            double[] kapec = new double[array.Length - 1];
            int j = 0;
            for (int i = 0; i < kapec.Length; i++)
            {
                kapec[j] = array[i];
                j++;
            }
            array = kapec;
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
        double otriz = 0;
        int iotriz = 0;
        double amax = -100000;
        int imax = 0;
        double sum = 0;
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                otriz = array[i];
                iotriz = i;
                break;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
        }
        
        for (int i = imax+1; i < array.Length; i++)
        {
            sum+= array[i];
        }
        for (int i=0;i<array.Length; i++)
        {
            if (array[i] > 0)
            {
                k++;
            }
        }
        if (k != array.Length)
        {
            array[iotriz] = Math.Round(sum,1);
        }

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
        double amax = -10000;
        int imax = 0;
        int iotr = 0;
        double otr = 0;
        double temp;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax= array[i];
                imax = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                otr= array[i];
                iotr = i;
                break;
            }
        }
        if (imax != array.Length - 1)
        {
            temp = array[imax];
            array[imax] = array[iotr];
            array[iotr] = temp;
        }
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
        int k = 0;
        double s = 0;
        int cnt = 0;
        double sr = 0;
        
        for(int i = 0; i < array.Length; i++)
        {
            s += array[i];
            cnt++;
        }
        sr = s / cnt;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr)
            {
                k++;
            }
        }
        int[] output = new int[k];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr)
            {
                output[j] = i;
                j++;
            }
        }

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
        double amax1 = -10000;
        double amax2 = -10000;
        int imax1 = 0;
        int imax2 = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > amax1)
            {
                amax1= array[i];
                imax1 = i;
            }
        }
        for (int i = 1; i < array.Length; i += 2)
        {
            if (array[i] > amax2)
            {
                amax2 = array[i];
                imax2 = i;
            }
        }

        if (amax1 > amax2)
            {
                for (int j = 0; j < array.Length / 2; j++)
                {
                    array[j] = 0;
                }
            }
        else
            {
                for (int j = array.Length / 2; j < array.Length; j++)
                {
                    array[j] = 0;
                }
            }
        
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
        double amin = 10000000000;
        int j = 0;
        int imin = 0;
        int iotr = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < amin)
            {
                amin = array[i];
                imin = i;
            }
       
            if (array[i] > 0) { j++; }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                iotr = i;
                break;
            }
        }
        if (j!=array.Length)
        {
            if (iotr < imin)
            {
                for(int i = 0; i < array.Length; i += 2)
                {
                    sum+=array[i];
                }
            }else
            {
                for (int i = 1; i < array.Length; i+=2)
                {
                    sum+= array[i];
                }
            }
        }
        

        return sum;
    }
    #endregion
    #region Level 3
    public int[] Task_3_1(double[] array)
    {
       
        double amax = -100000;
        int imax = 0;
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array [i] > amax)
            {
                amax= array [i];
                imax= i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == amax)
            {
                k++;
            }
        }
        int[] output = new int[k];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == amax)
            {
                output[j] = i;
                j++;
            }
        }



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
        double amax = -10000;
        int imax = 0;
        double s = 0;
        int o = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax= array [i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
            if (array[i]==amax)
            {
                array[i] = s - amax ;
            }
            
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
        int j = 0;
       
        int p = 0;
        for (int i =0; i <array.Length; i++)
        {
            if (array [i] < 0)
            {
                j++;
            }
            if (array [i] > 0)
            {
                p++;
            }
        }
        double[] otr = new double[j];
        int h = 0;
        for (int i = 0;i< array.Length; i++)
        {
            if (array[i] < 0)
            {
                otr[h] = array[i];
                h++;
            }
            
        }
        int o = 0;
        double[] pol = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                pol[o] = array[i];
                o++;
            }
            
        }
        int l = 0;
        for (int i = (pol.Length-j); i < pol.Length; i++)
        {
            pol[i] = otr[l];
            l++;
        }
        array = pol;
        


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
        
        double[] x = new double[array.Length];
        
        int k = 0;
        for (int i = 0; i < x.Length/2; i++)
        {
            x[k] = array[i];
            x[k + 1] = array[i];
            k += 2 ;
            
        }
      
        array = x;
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
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
        int k = 0;
        int ipov = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    ipov = j;
                   k++; 
                 
                }
            }
        }
        
        for (int i = ipov; i < array.Length - k; i++)
        {
            array[i] = array[i + 1];
        }
        double[] pov = new double[array.Length - k];
        int l = 0;
        for (int i = 0; i < pov.Length; i++)
        {
            pov[l] = array[i];
            l++;
        }
        array = pov;
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