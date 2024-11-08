using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Console;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        program.Task_1_15(new double[] {0, 1.5, 1, 3, -2.2, -0.5, 2, 2, 3.1, -0.7});
        program.Task_2_6(new double[]  { 0, 1.5, -1, -3, -2.2, -0.5, 6 }, 2.3);
        program.Task_1_3(new double[] { -2.2, -0.5, 2, -1 }, new double[] { 2, 1, 3, 3});
        program.Task_3_12(new double[]  { 0, 1.5, 1, 3, -2.2, -0.5, 3 });
        program.Task_2_20(new double[]  {0, 1.5, 4, 3, -2.2, -0.5, 2, -3.1});
        program.Task_2_12(new double[]  {   0, 1.5, 1, 3, -2.2, -0.5, 2  });

    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        double summa = 0;
        foreach (double element in array)
        {
            summa += element;
        }
        for (int i = 0; i < 6; i++)
        {
            array[i] = Math.Round(array[i]/summa, 2);
        }
        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        double summa = 0;
        int counter = 0;
        foreach (double element in array)
        {
            if (element>0) 
            {
                summa+=element;
                counter++;
            }
        }
        for (int i = 0; i<8; i++) 
        {
            if (array[i] > 0) array[i] = Math.Round(summa/counter,2);
        }
        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];
        for (int i = 0; i<4; i++)
        {
            sum[i] = Math.Round(first[i] + second[i],2);
            dif[i] = Math.Round(first[i] - second[i],2);
        }
        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        double summa = 0;
        foreach (double element in array)
        {
            summa+=element;
        }
        for (int i = 0; i<5; i++)
        {
            array[i] = Math.Round(array[i] - summa/5, 2);
        }
        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;
        for (int i = 0; i<4; i++)
        {
            product = Math.Round(product + vector1[i] * vector2[i], 2);
        }
        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;
        foreach (double element in vector)
        {
            length += element*element;
        }
        length = Math.Sqrt(length);
        return Math.Round(length, 2); 
    }
    public double[] Task_1_7(double[] array)
    {
        double summa = 0;
        foreach (double element in array)
        {
            summa+=element;
        }
        double middle = summa/7;
        for (int i = 0; i<7; i++)
        {
            if (array[i] > middle) array[i] = 0;
        }
        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;
        foreach (double element in array)
        {
            if (element < 0) count++; 
        }
        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;
        double summa = 0;
        foreach (double element in array)
        {
            summa+=element;
        }
        double middle = summa/8;
        for (int i = 0; i<8; i++)
        {
            if (array[i] > middle) count++;
        }
        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;
        foreach(double element in array)
        {
            if (element>P && element<Q) count++;
        }
        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;
        int count = 0;
        foreach(double element in array)
        {
            if (element>0) count++;
        }
        output = new double[count];
        count = 0;
        foreach (double element in array)
        {
            if (element>0)
            {
                output[count] = element;
                count++;
            }
        }
        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;
        for (int i = 0; i<8; i++)
        {
            if (array[i]<0)
            {
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
        int num = 0;
        for (int i = 0; i<9; i+=2)
        {
            even[num] = array[i];
            odd[num] = array[i+1];
            num++;
        }
        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;
        foreach (double element in array)
        {
            if (element >= 0) sum+=element*element;
            else break;
        }
        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];
        for (int i=0; i<10; i++)
        {
            if (x[i] <= 0) y[i] = double.NaN;
            else y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            // WriteLine ($"{x[i]} {y[i]}");
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
        double max_element = array[0];
        int max_element_index = 0;
        for (int i = 0; i<array.Length; i++)
        {
            if (max_element < array[i])
            {
                max_element = array[i];
                max_element_index = i;
            }
        }
        for (int j = 0; j<max_element_index; j++)
        {
            sum += array[j];
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
        double max_element = 0;
        int max_element_index = 0;
        double summa = 0;
        for (int i = 0; i<array.Length; i++)
        {
            summa += array[i];
            if (max_element < array[i])
            {
                max_element = array[i];
                max_element_index = i;
            }
        }
        if (max_element_index == (array.Length-1)) return array;

        for (int i = max_element_index+1; i<array.Length; i++)
        {
            array[i] = Math.Round(summa/array.Length, 2);
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
        double middle = 0;
        foreach (double element in array)
        {
            middle+=element;
        }
        middle/=array.Length;

        int mid_el_index = 0;
        double diff = Math.Abs(array[0]-middle);
        for (int i = 0; i<array.Length; i++)
        {
            if (diff > Math.Abs(array[i]-middle))
            {
                mid_el_index = i;
                diff = Math.Abs(array[i]-middle);
            }
        }

        double[] array_new = new double[array.Length+1];
        for (int j = 0; j<array_new.Length; j++)
        {
            if (j<=mid_el_index)
                array_new[j] = array[j];
            else if (j == mid_el_index + 1)
                array_new[j] = P;
            else
                array_new[j] = array[j-1];
        }

        return array_new;
    }
    public double[] Task_2_7(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_8(double[] array)
    {
        double max_element = array[0];
        int max_element_index = 0;
        for (int i = 0; i<array.Length; i++)
        {
            if (max_element < array[i])
            {
                max_element = array[i];
                max_element_index = i;
            }
        }

        double min_element = array[max_element_index];
        int min_element_index = max_element_index;
        for (int i = max_element_index+1; i<array.Length; i++)
        {
            if (min_element > array[i])
            {
                min_element = array[i];
                min_element_index = i;
            }
        }
        array[max_element_index] = min_element;
        array[min_element_index] = max_element;
        return array;
    }
    public double Task_2_9(double[] array)
    {
        double average = 0;
        
        return average;
    }
    public double[] Task_2_10(double[] array)
    {
        double min_element = double.MaxValue;
        double min_element_index = array.Length;

        for (int i = 0; i<array.Length; i++)
        {
            if (array[i]>0 && array[i]<min_element)
            {
                min_element=array[i];
                min_element_index=i;
            }
        }
        if (min_element_index==array.Length) return array;

        double[] array_new = new double[array.Length-1];
        for (int k = 0; k<array_new.Length; k++)
        {
            if (k<min_element_index)
                array_new[k] = array[k];
            else 
                array_new[k] = array[k+1];
            Write($"{array_new[k]} ");
        }

        return array_new;
    }
    public double[] Task_2_11(double[] array, double P)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_12(double[] array)
    {
        double max_element = array[0];
        int max_element_index = 0;
        for (int i = 0; i<array.Length; i++)
        {
            if (max_element < array[i])
            {
                max_element = array[i];
                max_element_index = i;
            }
        }
        double summa = 0;
        for (int i = max_element_index+1; i<array.Length; i++)
        {
            summa += array[i];
        }
        for (int k = 0; k<array.Length; k++)
        {
            if (array[k]<0)
            {
                array[k] = Math.Round(summa,2);
                break;
            }
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
        double max_element = array[0];
        int max_element_index = 0;
        for (int i = 0; i<array.Length; i++)
        {
            if (max_element < array[i])
            {
                max_element = array[i];
                max_element_index = i;
            }
        }

        for (int k = 0; k<array.Length; k++)
        {
            if (array[k]<0)
            {
                array[max_element_index] = array[k];
                array[k] = max_element;
                break;
            }
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
        int[] output = new int[array.Length/2];
        double middle = 0;
        foreach (double element in array)
        {
            middle+=element;
        }
        middle/=array.Length;

        int index_output = 0;
        for (int j = 0; j<array.Length; j++)
        {
            if (array[j]<middle)
            {
                output[index_output] = j;
                index_output++;
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
        double max_ch = array[0]; int max_ch_index = 0;
        double max_not_ch = array[1]; int max_not_ch_index = 1;
        for (int i = 0; i<array.Length; i++)
        {
            if (i%2==0 && max_ch < array[i])
            {
                max_ch = array[i];
                max_ch_index = i;
            }
            else if (i%2!=0 && max_not_ch < array[i])
            {
                max_not_ch = array[i];
                max_not_ch_index = i;
            }
        }

        if (max_ch>max_not_ch)
        {
            for (int i = 0; i<(array.Length/2); i++)
            {
                array[i] = 0;
            }
        }
        else
        {
            for (int i = array.Length/2; i<array.Length; i++)
            {
                array[i] = 0;
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
        double min_element = double.MaxValue;
        double min_element_index = array.Length;
        for (int i = 0; i<array.Length; i++)
        {
            if (array[i]<min_element)
            {
                min_element=array[i];
                min_element_index=i;
            }
        }

        double first_index = array.Length;
        for (int j = 0; j<array.Length;j++)
        {
            if (array[j] < 0)
            {
                first_index = j;
                break;
            }
        }
        if (first_index == array.Length) return 0;

        int value;
        if (first_index<min_element_index)
            value = 0;
        else
            value = 1;
        for (int k = value; k<array.Length; k+=2)
        {
            sum+=array[k];
        }
        return Math.Round(sum,2);
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
        double max_element = array[0];
        int max_element_index = 0;
        for (int i = 0; i<array.Length; i++)
        {
            if (max_element < array[i])
            {
                max_element = array[i];
                max_element_index = i;
            }
        }
        for (int i = 0; i<max_element_index; i+=2)
        {
            if (i == max_element_index - 1) break;
            double second = array[i+1];
            array[i+1] = array[i];
            array[i] = second;
        }

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
        int max_count = 1;
        for (int i = 0; i<array.Length-1; i++)
        {
            if (array[i] > array[i+1])
                count++;
            else
                count = 1;
            WriteLine(count);
            if (max_count < count) max_count=count;
        }
        return max_count;
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
        // 0, 1.5, 1, -1.3, -2.2, -0.5, 2
        int count = 1;
        int max_count = 1;
        string last_znak = "";
        for (int i = 0; i<array.Length-1; i++)
        {
            if (array[i] == array[i+1])
                {
                count = 1;
                continue;
                }

            string znak = (array[i] > array[i+1])?">":"<";
            if (count==1)
            {
                last_znak = znak;
            }
            if (znak == last_znak)
                count++;
            else
                count = 2;
            if (max_count < count) max_count=count;
            last_znak = znak;
        }
        WriteLine(max_count);
        return max_count;
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
        int counter = 0;
        foreach (double element in array)
        {
            if (element<0) counter++;
        }
        double[] array_new = new double[array.Length-counter];
        int number = 0;
        for (int i = 0; i<array.Length; i++)
        {
            if (array[i]>=0)
            {
                array_new[number] = array[i];
                number++;
            }
        }
        return array_new;
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
