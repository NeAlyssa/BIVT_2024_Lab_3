using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
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
        for (int i =0; i<array.Length; i++)
        {
            s += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] / s,2);
        }
        Console.WriteLine(array);
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sz = 0;
        double n= 0;
        for (int i =0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                sz+= array[i];
                n++;
            }
        }
        for (int i=0; i < array.Length; i++)
        {
            if (array[i] > 0)
                array[i] = Math.Round( sz / n,2);
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
            sum[i]= Math.Round(first[i]+second[i],2);
            dif[i]= Math.Round(first[i]-second[i],2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sz = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sz+= array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i]=Math.Round(array[i]-sz/5,2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for(int i = 0;i<vector1.Length;i++)
            product+= vector1[i]*vector2[i];
        product = Math.Round(product, 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < vector.Length; i++)
            length+= Math.Abs(vector[i]* vector[i]);
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sz = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sz += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > Math.Round((sz / 7),2))
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
        for (int i = 0; i < array.Length; i++)
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
        double sz = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sz += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]>=Math.Round((sz / 8), 2))
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
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]>(double)P && (array[i] < (double)Q))
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

        // code here
        int n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                n++;
            }
        }
        output = new double[n];
        n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[n++]= array[i];
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
        for (int i=0; i < array.Length; i++)
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

        // code here
        int n = 0;
        for (int i = 0; i < array.Length; i+=2)
        {
            even[n] = array[i];
            n++;
        }
        int j = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            odd[j] = array[i];
            j++;
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if ((array[i] >= 0))
            {
                sum += array[i]*array[i];
            }
            else break;
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
            if (x[i] <= 0)
            {
                y[i] = double.NaN;
            }
            else
            {
                y[i] = Math.Round(0.5 * Math.Log(x[i]),2);
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
        double maxim = -1000;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxim)
            {
                maxim = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < maxim)
            {
                sum += array[i];
            }
            else break;
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
        double maxim = -1000;
        int index = 0;
        double sz = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxim)
            {
                maxim = array[i];
                index = i+1;
            }
            sz += array[i];
        }
        for (int i = index; i < array.Length; i++)
        {
            array[i] = Math.Round(sz / array.Length, 2);
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
        double cz = 0;
        for (int i = 0; i < array.Length; i++)
        {
            cz+= array[i];
        }
        cz=cz/array.Length;
        int ind = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - cz) < Math.Abs(array[ind]-cz))
            {
                ind = i;
            }
        }
        double[] a= new double[array.Length+1];
        for ( int i = 0; i <= ind; i++)
        {
            a[i]= array[i];
        }
        a[ind+1] = P;
        for (int i=ind+2; i < a.Length; i++)
        {

            a[i]= array[i-1];
        }
        array=a;
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
        int ind = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[ind])
            {
                ind = i;
            }
        }
        int indmin = ind;
        for (int i = ind; i < array.Length; i++)
        {
            if (array[i] < array[indmin]) indmin = i;
        }
        double p = array[indmin];
        array[indmin] = array[ind];
        array[ind] = p;
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
        int ind =-1;
        for (int i=0; i<array.Length;i++)
            if (array[i] > 0)
            {
               
                ind = i;
                break;
            }
        if (ind == -1) return array;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && array[i] < array[ind])
            {
                ind = i;
            } 
        }
        double[] a = new double[array.Length - 1];
        for (int j = 0; j < ind; j++)
        {
            a[j] = array[j];
        }
        for (int j = ind; j < a.Length; j++)
        {
            a[j] = array[j + 1];
        }
        array = a;


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
        int ind = 0;
        int p = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[ind])
            {
                ind = i;
            }
            if (array[i] < 0) p++;

        }
        if (p == 0) return array;
        double summ = 0;
        for (int i = ind+1; i < array.Length; i++) summ +=array[i]; 
        int indmin = 0;
        summ = Math.Round(summ,1);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]<0)
            {
                indmin = i;
                break;
            }
        }
        array[indmin] = summ;
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
        int p = 0;
        double maxim = -1000;
        double minim = 0;
        int ind = 0;
        int maxim_ind = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxim)
            {
                maxim = array[i];
                maxim_ind = i;
            }
            if (array[i] < 0) p++;
        }
        if (p== 0) return array;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                minim=array[i];
                ind = i;
                break;
            }
        }
        array[ind]= maxim;
        array[maxim_ind] = minim;

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
        double cz = 0;
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            cz += array[i];
            
        }
        cz/=array.Length;
        for (int i=0; i<array.Length; i++)
        {
            if (array[i] < cz) k++;
        }
        output = new int[k];
        for (int i = 0, p = 0; i < array.Length; i++)
        {
            if (array[i] < cz)
            {
                output[p] = i;
                p++;
            }
        }
        //end

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
        int ind_maxim1 = 0;
        int ind_maxim2 = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            if (array[i] > array[ind_maxim1])
            {
                ind_maxim1= i;
            }
        }
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > array[ind_maxim2])
            {
                ind_maxim2 = i;
            }
        }
        if (array[ind_maxim2] >= array[ind_maxim1])
        {
            for (int i=0; i < (array.Length / 2); i++)
            {
                array[i] = 0;
            }
        }
        else
        {
            for (int i = array.Length / 2; i < array.Length; i++)
            {
                array[i] = 0;
            }
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
        int ind_minim = 0;
        int otric = 0;
        int prov = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[ind_minim] > array[i])
            {
                ind_minim=i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                otric = i;
                prov++;
                break;
            }
            
            
        }
        if (prov == 0) return 0;
        if (otric < ind_minim)
        {
            for (int i=0;i<array.Length;i+=2)
            {
                sum+= array[i];
            }
        }
        else
        {
            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }
        }
        sum = Math.Round(sum, 1);
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
        int ind_maxim = 0;
        for (int i=0; i < array.Length; i++) 
        {
            if (array[i] > array[ind_maxim]) ind_maxim = i;
        }
        if (ind_maxim==0 || ind_maxim==1) return array;
        for (int i = 1; i < ind_maxim; i += 2)
        {
            double sum = array[i];
            array[i] = array[i - 1];
            array[i - 1] = sum;
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
        int count1 = 1;
        for (int i=1; i < array.Length; i++)
        {
            if (array[i] < array[i - 1]) count1++;
            else
            {
                if (count < count1)
                {
                    count = count1;
                    
                }
                count1 = 1;
                
            }
        }
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
        int count2 = 1, count1 = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] >= array[i - 1])
            {
                count2++;
                if (count < count2) count = count2;
            }

            else
            {
                count2 = 1;
            }

            if (array[i] <= array[i - 1])
            {
                count1++; 
                if (count < count1) count = count1;
            }
            else
            {

                count1 = 1;

            }
        }
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
        int n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0) n++;
        }
        double[] a= new double[n];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
                {
                a[j]= array[i];
                j++;
                }
        }
        array = a;
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