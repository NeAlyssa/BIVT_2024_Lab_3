using Microsoft.VisualBasic;
using System;
using System.Collections;
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
        double summa = 0;
        for (int i =0; i < array.Length; i++)
        {
            summa += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] / summa, 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sr = 0, count = 0;
        foreach (double x in array)
        {
            if (x > 0)
            {
                sr += x;
                count++;
            }
        }
        
        sr =Math.Round( sr / count, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) array[i]=sr;
        }


        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i<first.Length; i++)
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
        double sr =0, count = 0;
        foreach (double x in array)
        {
            sr += x;
            count++;
        }
        sr = sr / count;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - sr, 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < vector1.Length; i++)
        {
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
        foreach(double x in vector)
        {
            length += x * x;
        }
        length=Math.Round(Math.Sqrt(length), 2);

        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sr = 0, count = 0;
        foreach (double x in array)
        {
            sr += x;
            count++;
        }
        sr = sr / count;
        for (int i = 0; i < array.Length; i++)
            if (array[i] > sr) array[i] = 0;
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here

        foreach (double x in array)
        {
            if (x < 0) count++;
        }

        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double sr = 0;
        foreach (double x in array)
        {
            sr += x;

        }
        sr /=  array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sr) count++;
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
            if ( P<x && x < Q) count++;
        }

        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int b = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) b++;
        }
        output = new double[b];
        b = 0;
        foreach(double x in array)
        {
            if (x >0) output[b++] = x;
        }
        // end

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        // code here
        for (int i = array.Length-1; i >= 0; i--)
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

        // code here
        int even_index = 0, odd_index = 0;
        for(int i = 0; i < array.Length; i+= 2)
        {
            even_index++;
        }
        odd_index = array.Length - even_index ;
        even = new double[even_index];
        odd = new double[odd_index];
        odd_index = 0;
        even_index = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            even[even_index++] = array[i];
        }
        for (int i = 1; i < array.Length; i += 2)
        {
            odd[odd_index++] = array[i];
        }
            // end

            return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                break;
            }
            sum += array[i]* array[i];
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for(int i = 0; i < x.Length; i++)
        {
            if (x[i] > 0)
            {
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            }
            else
            {
                y[i] =double.NaN;
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
        int index = 0;
        double min_number = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min_number)
            {
                min_number = array[i];
                index = i;
            }
        }
        if (array[index] > 0) 
            array[index] *= 2;
        else 
            array[index] /= 2;

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
        int index = 0;
        double min_number = 1000000000000000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min_number)
            {
                min_number = array[i];
                index = i;
            }
        }
        for(int i = 0; i < index; i++)
        {
            if (array[i] > 0) array[i] *= 2;
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
        double maxi = -100000000000000;
        double mini = 1000000000000000;
        double[] new_array = null;
        int min_ind = 0, max_ind = 0, hold = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                max_ind = i;
            }
            if (array[i] < mini)
            {
                mini = array[i];
                min_ind = i;
            }
        }
        int count = 0;
        if (min_ind > max_ind)
        {
            hold = min_ind;
            min_ind = max_ind;
            max_ind = hold;
        }
        for (int i = min_ind + 1; i < max_ind; i++)
        {
            if (array[i] < 0) count++;
        }
        new_array = new double[count];
        count = 0;
        for (int i = min_ind + 1; i < max_ind; i++)
        {
            if (array[i] < 0)
            {
                new_array[count++] = array[i];  
            }
        }

        // end

        return new_array;
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
        double maxi = -1000000000;
        int index = 0;
        for (int i=0; i<array.Length; i++)
        {
            if (array[i] > maxi)
            { 
                maxi = array[i];
                index = i;
            }
        }
        if (index+2 < array.Length)
        {
            if (array[index+1] > 0) array[index + 1] *= 2;
            else array[index + 1] /= 2;
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
        double maxi = -100000000000000;
        double mini = 1000000000000000;
        int min_ind = 0, max_ind = 0, hold = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                max_ind = i;
            }
            if (array[i] < mini)
            {
                mini = array[i];
                min_ind = i;
            }
        }
        if (min_ind > max_ind)
        {
            hold = min_ind;
            min_ind = max_ind;
            max_ind = hold;
        }
        int count = 0;
        for (int i = min_ind+1; i < max_ind; i++)
        {
            average += array[i];
            count++;
        }
        if (count > 0) average = Math.Round(average / count, 2);
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
        int index = -1; 
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                index = i;
            }
        }

        double[] new_array;
        //new_array = new double[array.Length + 1];
        if (index + 1 < array.Length)
        {
            new_array = new double[array.Length];
        }
        else new_array = new double[array.Length + 1];

        for (int i = 0; i < array.Length; i++)
        {
            new_array[i] = array[i];
        }


        if (index > 0) new_array[index + 1] = P;
        
        //else if ((index + 1 != array.Length) && (index + 1 > array.Length))
        //{
        //    Array.Resize(ref array, (length+1));
        //    array[index + 1] = P;
        //}
        // end

        return new_array;
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
        int index = 0;
        double maxi = -10000000000000000;
        for(int i =0; i < array.Length; i+=2)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                index = i;
            }
        }
        array[index] = (double)index;

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
        for (int i = 0; i < k+1; i++) 
            output[i] = A[i];
        for (int i = 0; i < B.Length; i++)
            output[k+1+i] = B[i];
        for (int i = 0; i < A.Length - k - 1; i++) 
            output[k + B.Length + i + 1] = A[k + i + 1];


        //for (int i = 0; i < k + 1; i++)
        //    output[i] = A[i];
        //for (int i = 0; i < B.Length; i++)
        //    output[k + 1 + i] = B[i];
        //for (int i = k + 1; i < A.Length; i++)
        //    output[B.Length + i] = A[i];


        //foreach (double x in output)
        //    Console.Write(x + " ");


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
        double maxi=-1000000, mini =100000;
        int imax = 0, imin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi) 
            {
                maxi = array[i];
                imax = i;
            }
            if (array[i] < mini)
            {
                mini = array[i];
                imin = i;
            }
        }
        int count = 0;
        if (imax < imin)
        {
            foreach (double x in array)
            {
                if (x > 0)
                {
                    average += x;
                    count++;
                }
            }
        }
        else
        {
            foreach (double x in array)
            {
                if (x < 0)
                {
                    average += x;
                    count++;
                }
            }
        }
        if ( count != 0) average = Math.Round(average/ count, 2);


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
        double summ = 0, maxi = -1000000;
        int imax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                imax = i;
            }
            summ += array[i];
        }
        if (maxi > summ)
        {
            array[imax] = 0;
        }
        else array[imax] = array[imax] * 2;

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
      
        int[] max_index = new int[array.Length];
        double maxi=-1000000000;
        int index = 0;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                count = 1;
                max_index[0] = i;
            }
            else if (array[i] == maxi)
            {
                index++;
                max_index[index] = i;
                count++;
            }
        }
        output = new int[count];
        for (int j = 0; j < count; j++)
        {
            output[j] = max_index[j];
        }



        //double maxi = array[0];
        //int imax = 0;
        //int index = 0;

        //int count = 0; 

        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] > maxi)
        //    {
        //        maxi= array[i];
        //        imax = i;
        //        index = 0;
        //        count++;
        //        output = new int[count];
        //        output[index] = i;
        //    }
        //    else if (array[i] == maxi)
        //    {
        //        output = new int[count];
        //        index++;
        //        output[index] = i;
        //    }
        //}




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

        double summa = 0;
        double maxi = -10000000;
        int imax = 0;
        //поиск макс элемента
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
            }
        }
        Console.WriteLine(maxi);
        //подсчет суммы
        summa = -maxi;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != maxi)
            {
                summa += array[i];


            }
            else if (array[i] == maxi)
            {

                summa += array[i];
                array[i] = summa;
                Console.WriteLine(summa);

            }
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
        double temp;
        int iLast = array.Length - 1;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] < 0)
            {
                temp = array[iLast];
                array[iLast] = array[i];
                array[i] = temp;
                iLast--;
            }
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
        double temp = 0;
        for (int i = array.Length-1; i>=0 ; i-=2)
        {
            array[i] = array[i/2];
            array[i - 1] = array[i];
               
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

        int count = 0;
        int[] repeat = new int[array.Length];
        double[] arr = null;
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j] && array[j] != 1.123456789)
                {
                    repeat[k++] = j;
                    array[j] = 1.123456789;
                    count++;
                }

            }
        }
        //Console.WriteLine(count+100000);
        arr = new double[array.Length - count];
        int kk = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 1.123456789)
            {
                arr[kk++] = array[i];
            }
        }

        //foreach (double x in arr)
        //    Console.Write(x + " ");



        //double [] arr = new double[array.Length-count];

        //while (k < arr.Length)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        for (int j = i + 1; j < array.Length; j++)
        //        {
        //            //Console.WriteLine($"{array[i]},{array[j]}");

        //            if (array[i] != array[j])
        //            {
        //                arr[k++] = array[i++];
        //                //Console.WriteLine($"{array[k]},{array[i]}");
        //                k++;
        //                i++;

        //            }

        //        }
        //    }
        //}
        //foreach (double x in arr)
        //    Console.Write(x + " ");

        // end

        return arr;
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