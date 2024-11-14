using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        program.Task_3_11( -2.5,2.5,9);
        
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        double sum = 0;
        // code here
        for (int i = 0; i < 6; i++) sum += array[i];
        for (int i = 0; i < 6; i++) array[i] = Math.Round(array[i] / sum,2);

        
        // end
        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        double sum = 0;
        int a = 0;
        // code here
        for(int i=0;i<8;i++)
        {
            if (array[i] > 0)
            { sum += array[i];
                a++;
            }
        }
        sum = Math.Round(sum / a, 2);
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0) array[i] = sum;
        }
                // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];
        for(int i=0;i<4;i++)
        {
            sum[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = Math.Round(first[i] - second[i], 2);
        }
        // code here

        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        double sum = 0;
        // code here
        for (int i = 0; i < 5; i++) sum += array[i];
        sum = sum / 5;
        for (int i = 0; i < 5; i++)
            array[i] = Math.Round(array[i] - sum, 2);
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i <4; i++) product += vector1[i] * vector2[i];

        // end
        
        return Math.Round(product,2);
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < 5; i++)
            length += vector[i] * vector[i];
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 2); 
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sum = 0;
        for (int i = 0; i < 7; i++) sum += array[i];
        sum = sum / 7;
        for (int i = 0; i < 7; i++) if (array[i] > sum) array[i] = 0;


            // end

            return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        for (int i = 0; i < 6; i++) if (array[i] < 0) count++;
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double sum = 0;
        for (int i = 0; i < 8; i++) sum += array[i];
        sum = sum / 8;
        for (int i = 0; i < 8; i++) if (array[i] > sum) count++;

        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for (int i = 0; i < 10; i++) if (array[i] > P && array[i] < Q) count++;
            // end

            return count;
    }
    public double[] Task_1_11(double[] array)
    {


        // code here
        int sum = 0;
        foreach (double x in array)if (x > 0) sum++;
        double [] output = new double [sum];
        int k = 0;
        foreach( double x in array)
        {
            if(x> 0)
            {
                output[k] = x;
                k++;

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
        for (int i = 0; i < 8; i++) if (array[i] < 0)
            {
                index = i;
                value= array[i];
            }
                // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];
        int k = 0;
        int n = 0;
        // code here
        for(int i=0;i<array.Length;i++)
        {
            if(i%2==0)
            {
                even[k]=array[i];
                k++;
            }
            else
            {
                odd[n]=array[i];
                n++;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for(int i=0;i<11;i++)
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
            if (x[i] > 0) y[i] = Math.Round((Math.Log(x[i]) * 0.5), 2);
            else y[i] = double.NaN;
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
        double max = array[0];
        // code here
        for(int i=1;i<array.Length;i++)if(array[i] > max)max=array[i];
        for(int i=0;i<array.Length;i++)
        {
            if (array[i] == max) break;
            sum += array[i];
        }
        // end

        return sum;
    }
    public double[] Task_2_3(double[] array)
    {
        
        // code here
        

        return array;
    }
    public double[] Task_2_4(double[] array)
    {
        // code here
        double max = array[0];
        double sum = array[0];
        int count = 0;
        for (int i = 1; i < array.Length; i++)
        {
            sum += array[i];
            if (array[i] > max) max = array[i];
        }
        sum = Math.Round(sum / array.Length, 2);
        for (int i = 0; i < array.Length; i++) if (array[i] == max)
            {
                count = i;
                break;
            }

        for (int i = count + 1; i < array.Length; i++) array[i] = sum;
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
        double sum = 0;
        int k1=0;
        for (int i = 0; i < array.Length; i++) sum += array[i];  
        sum = sum / array.Length;
        double d = Math.Abs(sum - array[0]);
        for (int i = 1; i < array.Length ; i++)
        {
            if (d > Math.Abs(sum - array[i]))
            {
                d = Math.Abs(sum - array[i]);
                k1 = i;
            }
        }
        double [] array1 = new double[array.Length + 1];
        for(int i=0;i<array1.Length;i++)
        {
            if (i < k1+1) array1[i] = array[i];
            else if (i > k1+1) array1[i] = array[i - 1];
             
        }
        array1[k1+1] = P;
        array = array1;

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
        double d = double.MinValue;
        int k = 0;
        for(int i=0;i<array.Length;i++)
        {
            if (array[i] > d)
            {
                d = array[i];
                k = i; 
            }
            
        }
        double b = double.MaxValue;
        int g = -1;
        for(int i=k;i<array.Length;i++)
        {
            if(array[i] < b)
            {
                b=array[i];
                g = i;
            }
        }
        if(g>0)
        {
            double p = array[k];
            array[k] = array[g];
            array[g] = p;
        }
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
        double d = double.MaxValue;
        int k = -1;
        for (int i = 0; i < array.Length; i++)

        {
            if (array[i] > 0 && array[i] < d)
            {
                d = array[i];
                k = i;
            }
        }
        double[] array1 = new double[array.Length - 1];
        if (k >= 0)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i < k)
                {
                    array1[i] = array[i];
                }
                else if (i > k)
                {
                    array1[i - 1] = array[i];
                }
            }

            array = array1;
        }
        
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
        int k = -1;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            { 
                k = i;
                break;
            }
        }
        double d=double.MinValue;
        int ind = 0;
        double sum = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (d < array[i])
            {
                d=array[i];
                ind = i;
            }
        }
        for (int i = ind + 1; i < array.Length; i++) sum += array[i];
        if (k >= 0)
        {
            
            array[k] = Math.Round(sum,2);
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
        double max = array[0];
        int ind = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                ind = i;
                max = array[i];
            }
        }
        int ind1 = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                ind1 = i;
                break;
            }
        }
        if (ind1 >= 0)
        {


            array[ind] = array[ind1];
            array[ind1] = max;
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


        // code here
        
        double sum = 0;
        int n = 0;
        int k = 0;
        for (int i = 0; i < array.Length; i++) sum += array[i];
        sum=sum/array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sum)
            {
                
                n++;
            }
        }
        int[] output = new int[n];
        for (int i=0;i<array.Length;i++)
        {
            if (array[i]<sum)
            {
                output[k] = i; 
                k++;
            }
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
        int s = array.Length;
        double k = Math.Ceiling(s / 2.0);
        double max0 = double.MinValue;
        double max1 = double.MinValue;
        for (int i = 0; i < array.Length; i += 2) if (array[i] > max0) max0 = array[i];
        for (int i = 1; i < array.Length; i += 2) if (array[i] > max1) max1 = array[i];
        if (max0 > max1) for (int i = 0; i < k; i++) array[i] = 0;
        else for (int i = s - 1; i >= s - k; i--) array[i] = 0;

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
        int k = -1;
        for (int i = 0; i < array.Length; i++) if (array[i] < 0)
            { k = i;
                break;
            }
        double min = double.MaxValue;
        int k1 = -1;
        for (int i = 0; i < array.Length; i++) if (array[i] < min)
            {
                min = array[i];
                k1 = i;
            }
        if (k >= 0)
        {
            if (k1 > k)
            {
                for (int i = 0; i < array.Length; i += 2) sum += array[i];
            }
            else for (int i = 1; i < array.Length; i += 2) sum += array[i];
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
        double max = double.MinValue;
        for(int i=0;i<array.Length;i++) if(array[i] > max) max=array[i];
        double k = 1;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                array[i] = k + array[i];
                k++;
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
        // code her
        
        // end
       
        return array;
    }
    public double[] Task_3_5(double[] array)
    {
        // code here
        int ind = -1;
        
        for (int i = 0; i < array.Length; i += 2)
        {
            double min = double.MaxValue;
            
            for (int k=i; k < array.Length; k += 2)
            {
                if (array[k] < min)
                {
                    min = array[k];
                    ind = k;
                }
               
            }
            array[ind] = array[i];
            array[i] = min;
           
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
        for(int i = 0; i < array.Length; i++)
        {

            if (array[i] < 0)
            {
                
                double max = double.MinValue;
                int ind = 0;
                for(int k=i; k < array.Length; k++)
                {
                    if (array[k] < 0 && array[k] > max)
                    {
                        max = array[k];
                        ind = k;
                    }

                }
                array[ind] = array[i];
                array[i] = max;
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
        double globalMax = 0, globalMin = 0;

        // code here
        double max = double.MinValue;
        double min = double.MaxValue;
        double k = (b - a) / (n - 1);
        for (int i = 0; i < n; i++)
        {
            if (Math.Round(Math.Cos(a) + a * Math.Sin(a),2) > max)
            {
                max = Math.Round(Math.Cos(a) + a * Math.Sin(a), 2);
                globalMax = max;
            }
            if (Math.Round(Math.Cos(a) + a * Math.Sin(a),2) < min)
            {
                min = Math.Round(Math.Cos(a) + a * Math.Sin(a),2);
                globalMin = min;
            }
            X[i] = Math.Round(a,2);
            Y[i] = Math.Round(Math.Cos(a)+ a * Math.Sin(a),2);
            a += k;
        }
        
        
       
        
        // end
        for (int i = 0; i < X.Length; i++) Console.WriteLine(X[i]);
        for (int i = 0; i < X.Length; i++) Console.WriteLine(Y[i]);
        Console.WriteLine(globalMax);
        Console.WriteLine(globalMin);
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
        double[] normalizedArray = new double[array.Length] ;

        // code here
        double min = double.MaxValue;
        double max = double.MinValue;
        for(int i=0;i<array.Length;i++) if(array[i] < min) min = array[i];
        for (int i = 0; i < array.Length; i++) if (array[i] > max) max = array[i];
        for (int i = 0; i < array.Length; i++) normalizedArray[i] = Math.Round((array[i] - min)*2 / (max - min) - 1,2);
       
        // end

        return normalizedArray;
    }
    #endregion
}
