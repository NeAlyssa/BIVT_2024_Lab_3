using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        double[] a1 = { -1, -2, -8, -1, -9, -1, -1, -4, -6, -2 };
        program.Task_3_1(a1);
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double s = 0;
        for (int i = 0; i < 6; i++)
        {
            s+= array[i];
        }
        for (int i = 0; i < 6; i++)
        {
            array[i] = Math.Round(array[i]/s,2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0, amount = 0, sr=0; ;

        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                s+= array[i];
                amount++;
            }
        }
        sr = Math.Round(s/amount,2);
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
                array[i] = sr;
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i < 4; i++)
        {
            sum[i] = Math.Round(first[i]+second[i],2);
            dif[i] = Math.Round(first[i]-second[i],2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s = 0, sr;
        for (int i = 0; i < 5; i++)
        {
            s += array[i];
        }
        // end
        sr = s / 5.0;
        for (int i = 0; i < 5; i++)
        {
            array[i] = Math.Round(array[i] - sr,2);
        }
        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < 4; i++)
        {
            product+= vector1[i]*vector2[i];
        }
        // end

        return Math.Round(product,2);
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < 5; i++)
        {
            length += vector[i]*vector[i];
        }
        length= Math.Sqrt(length);
        // end

        return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        double sum = 0, sr = 0;
        // code here
        for (int i = 0; i < 7; i++)
        {
            sum += array[i];
        }
        // end
        sr = Math.Round(sum / 7.0,2);
        for (int i = 0; i < 7; i++)
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

        // code here
        for (int i = 0; i < 6; i++)
        {
            if (array[i] < 0)
                count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;
        double sr = 0;
        // code here
        for (int i = 0; i < 8; i++)
        {
            sr+= array[i];
        }
        sr = sr / 8;
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
        int L=0, R=0;
        // code here
        for (int i = 0; i < 10; i++)
        {
            if (Q > array[i] && P < array[i])
                count++;
            
        }

        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        //double[] output = null;
        int cnt = 0;
        // code here
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                cnt++;    
            }

        }
        double[] output = new double[cnt];
        int index = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                output[index] = array[i];
                index++;
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
                value = array[i];
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
        int index_1 = 0, index_2 = 0;
        // code here
        for (int i = 0; i < 10; i++)
        {
            if (i%2 == 0)
            {
                even[index_1] = array[i];
                index_1++;
            }
            else if (i%2 == 1)
            {
                odd[index_2] = array[i];
                index_2++;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0;i<11;i++)
        {
            if (array[i] >= 0)
            {
                sum += array[i] * array[i];
            }
            else
                break;
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
            y[i] = Math.Round(0.5 * Math.Log(x[i]),2);
            if (x[i] <= 0)
            {
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
        double m = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]>m)
                m = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != m)
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
        double m = 0,sr=0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
           
            sr += array[i];
            if (m < array[i])
                m = array[i];
            
        }
        Console.WriteLine(sr+" "+array.Length);
        sr = Math.Round((sr / array.Length), 2);
        Console.WriteLine(m + " "+ array.Length);
        bool flag = false;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == m)
            {
                flag = true;
            }
            else if (flag)
            {
                array[i] = sr;
            }
            else
                continue;
        }

        // end
        for (int i = 0;i < array.Length; i++)
            Console.Write(array[i]+" ");
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
        double sr = 0, r=double.MaxValue;
        int nearest=0;
        double[] digits = new double[array.Length + 1];
        foreach (double i in array)
        {
            sr += i;
        }
        sr = (sr / array.Length);
        for (int i = 0;i<array.Length;i++)
        {
            if (Math.Abs(array[i]-sr) < r)
            {
                nearest = i;
                r = Math.Abs(array[i]-sr);
            }
        }
        for (int i = 0; i < array.Length+1 ; i++)
        {
            if (i <= nearest)
            {
                digits[i] = array[i];
            }
            else if (i>nearest+1) 
            {
                digits[i] = array[i-1];
            }
        }
        digits[nearest + 1] = P;
        // end

        return digits;
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
        double maxx=double.MinValue,minx=double.MaxValue, temp=0;
        int index_max = 0, index_min=-1;
        for (int i = 0;i<array.Length;i++)
        {
            if (array[i] > maxx)
            {
                maxx = array[i];
                index_max = i;
            }

        }
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j]< minx && j > index_max)
            {
                minx = array[j];
                index_min = j;
            }
        }
        if (index_min >= 0)
        {
            temp = array[index_min];
            array[index_min] = array[index_max];
            array[index_max] = temp;
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
        double minx = double.MaxValue;
        int index_min = -1;
        for (int x = 0; x < array.Length; x++)
        {
            if (array[x] > 0 && array[x] < minx)
            {
                minx = array[x];
                index_min = x;
            }
        }
        // end
        if(index_min >= 0)
        { 
        double[] temp = new double[array.Length - 1];
        for (int i = 0; i < array.Length; i++)
        {
            if (i < index_min)
            {
                temp[i] = array[i];
            }
            else if (i > index_min)
            {
                temp[i - 1] = array[i];
            }
        }
        array = temp;
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
        double maxx=double.MinValue,  sumc = 0;
        int index_max = -1, index_otr=-1;
        for (int x = 0; x < array.Length; x++)
        {
            if (array[x] > maxx)
            {
                maxx = array[x];
                index_max = x;
            }
        }
        for (int x = 0;x< array.Length; x++)
        {
            if (array[x] < 0)
            {
                index_otr = x;
                break;
            }
        }
        if (index_max != array.Length - 1)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i > index_max)
                {
                    sumc += array[i];
                }

            }
        }
        if (index_otr >=0)
            array[index_otr] = Math.Round(sumc,2);
        // end
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
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
        // code here
        int index_otr = -1; int max_index = 0;
        double m = double.MinValue, temp=0;

        bool flag = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > m)
                {
                    m = array[i];
                    max_index = i;
                }
                if (flag == false)
                {
                    if (array[i] < 0)
                    {
                        index_otr = i;
                        flag = true;
                    }
                }
            }
            if (index_otr >= 0)
            {
                temp = array[index_otr];
                array[index_otr] = array[max_index];
                array[max_index] = temp;
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
        double sr = 0;
        // code here
        for (int i = 0;i< array.Length; i++)
        {
            sr+= array[i];
        }
        sr/= array.Length;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr)
            {
                count+=1;
            }
        }
        int[] output = new int[count];
        int n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr)
            {
                output[n] = i;
                n++;
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
        double max_odd = double.MinValue, max_even = double.MinValue;
        int middle = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (array[i] > max_even)
                {
                    max_even = array[i];
                }
            }
            else
            {
                if (array[i] > max_odd)
                {
                    max_odd = array[i];
                }
            }
        }
        middle = (array.Length / 2);
        
        
        Console.WriteLine(max_odd + " " + max_even + " " + middle);
        if (max_even > max_odd)
        {
            Console.WriteLine("Pizza 1");
            for (int i = 0; i < middle; i++)
            {
                array[i] = 0;
                Console.WriteLine(array[i]);
            } 
            
        }
        else
        {
            Console.WriteLine("Pizza 2");
            for (int i = middle; i < array.Length; i++)
            {
                array[i] = 0;
            }
            
        }
        for (int i = 0;i<array.Length; i++)
        {
            Console.Write(array[i] + " ");
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
        double sum = 0, m =double.MaxValue;
        bool flag = false;
        int min_index = 0, otr_index = -1;
        // code here
        for (int i = 0;i<array.Length;i++)
        {
            if (array[i] < m)
            {
                min_index = i;
                m = array[i];
            }
            
            
            if (flag == false)
            {
                if (array[i] < 0) 
                {
                    otr_index = i;
                    flag = true;
                } 
            }
        }
        if (otr_index >= 0)
        {
            if (otr_index < min_index)
            {
                for (int i = 0; i < array.Length; i += 2)
                    sum += array[i];
            }
            else
            {
                for (int i = 1; i < array.Length; i += 2)
                    sum += array[i];
            }
        }
        else
        {
            for (int i = 1; i < array.Length; i += 2)
                sum += array[i];
        }
        // end
        
        return sum;
    }
    #endregion
    #region Level 3
    public int[] Task_3_1(double[] array)
    {
        double m = double.MinValue;

        int index = 0;
        int[] output = new int[array.Length];


        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > m)
            {
                index = 0;
                
                m = array[i];
                output[index] = i;

                Console.WriteLine("Pizza 1");

            }
            else if (array[i] == m)
            {
                index++;
                output[index] = i;
                Console.WriteLine("Pizza 2");
            }
        }
        int[] final = output[0..(index+1)];
        foreach (int i in final)
        {
            Console.Write(i + " ");
        }
        
        return final;

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
        double [] output = new double[array.Length];
        double m = double.MinValue, sum=0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > m)
            {
                m = array[i];
            }
            output[i] = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            sum+= output[i];
            if (output[i] == m)
            {
                output[i] = sum - m;
            }
        }
        foreach (double i in output)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine(m);
        return output;
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
        double[] digits = new double[array.Length];
        int upper_0 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                upper_0++;
            }
        }
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                digits[upper_0] = array[i];
                upper_0++;
            }
            else
            {
                digits[index] = array[i];
                index++;
            }
                

        }
        
        // end

        return digits;
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
        double[] output = new double[array.Length];
        int index = 0;
        for(int d=0;d<array.Length/2;d+=1)
        {
            output[index] = array[d];
            output[index + 1] = array[d];
            index += 2;
            Console.WriteLine(array[d]);
        }
        foreach (double d in output)
        {
            Console.Write(d +" ");
        }
        // end

        return output;
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
        double[] temparr = new double[array.Length];
        for (int i = 0; i < array.Length; i++) temparr[i] = array[i];
        
        double d, a=-1000000000000;
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            d = temparr[i];
            //Console.WriteLine(d+ " это 1 элемент");
            for (int j = i+1;j<array.Length; j++)
            {
                //Console.WriteLine(temparr[j]+" это второй элемент");
                if (temparr[j] == d)
                {
                    temparr[j] = a;
                    a--;
                    sum++;
                }
            }
            
        }
        double[] final = new double[array.Length-sum];
        int index = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (temparr[i] > -1000000000000)
            {
                final[index] = temparr[i];
                index++;
            }
            else
            {
                continue;
            }
        }
        foreach (double r in final)
        {
            Console.Write(r+" ");
        }
        Console.WriteLine();
        //Console.WriteLine("SUM " + sum);
        // end

        return final;
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
