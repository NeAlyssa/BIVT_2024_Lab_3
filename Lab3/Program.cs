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
        program.Task_2_11(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 }, 7.77);
    }
    public void PrintArray(double[] array)
    {
        for (int k = 0; k < array.Length; k++)
        {
            Console.Write($"{array[k]}  ");
        }
        Console.WriteLine();
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double sum = 0;
        for(int k = 0; k < array.Length; k++)
        {
            sum += array[k];
        }
        for(int k = 0; k < array.Length; k++)
        {
            array[k] /= sum;
            array[k] = Math.Round(array[k], 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sumPositive = 0;
        int numPositive = 0;
        for(int k = 0; k < array.Length; k++)
        {
            if (array[k] > 0)
            {
                sumPositive += array[k];
                numPositive++;
            }
        }
        double averagePositive = sumPositive / numPositive;
        averagePositive = Math.Round(averagePositive, 2);
        for(int k = 0; k < array.Length; k++)
        {
            if(array[k] > 0)
                array[k] = averagePositive;
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        if(first.Length != second.Length)
        {
            Console.WriteLine("different legth"); 
            return (sum, dif);
        }
        for(int k = 0; k < sum.Length; k++)
        {
            sum[k] = first[k] + second[k];
            sum[k] = Math.Round(sum[k], 2);
        }
        for(int k = 0; k < dif.Length; k++)
        {
            dif[k] = first[k] - second[k];
            dif[k] = Math.Round(dif[k], 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sumElem = 0;
        int num = 0;
        double average = 0;
        for(int k = 0; k < array.Length; k++)
        {
            sumElem += array[k];
            num++;
        }
        average = sumElem / num;
        for(int k = 0; k < array.Length; k++)
        {
            array[k] -= average;
            array[k] = Math.Round(array[k], 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        if(vector1.Length != vector2.Length)
        {
            Console.WriteLine("dif length");
            return 0;
        }
        for(int k = 0; k < vector1.Length; k++)
        {
            product += vector1[k] * vector2[k];
        }
        product = Math.Round(product, 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for(int k = 0; k < vector.Length; k++)
        {
            length += vector[k] * vector[k];
        }
        length = Math.Sqrt(length);
        length = Math.Round(length, 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sum = 0;
        double average = 0;
        for(int k = 0; k < array.Length; k++)
        {
            sum += array[k];
        }
        average = sum / array.Length;
        for(int k = 0; k < array.Length; k++)
        {
            if (array[k] > average)
                array[k] = 0;
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        for(int k = 0; k < array.Length; k++)
        {
            if (array[k] < 0)
                count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double sum = 0;
        double average = 0;
        for (int k = 0; k < array.Length; k++)
        {
            sum += array[k];
        }
        average = sum / array.Length;
        for (int k = 0; k < array.Length; k++)
        {
            if (array[k] > average)
                count++;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for(int k = 0; k < array.Length; k++)
        {
            if(P < array[k] && array[k] < Q)
                count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int outputLength = 0;
        for(int k = 0; k < array.Length; k++)
        {
            if (array[k] > 0)
                outputLength++;
        }
        output = new double[outputLength];
        int i = 0;
        for (int k = 0; k < array.Length; k++)
        {
            if (array[k] > 0)
            {
                output[i++] = array[k];
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
        for(int k = 0; k < array.Length; k++)
        {
            if(array[k] < 0)
            {
                value = array[k];
                index = k;
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
        for(int k = 0; k < even.Length; k ++)
        {
            even[k] = array[2 * k];
        }
        for(int k = 0; k < odd.Length; k++)
        {
            odd[k] = array[2 * k + 1];
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for(int k = 0; k < array.Length; k++)
        {
            if (array[k] < 0)
                break;
            sum += array[k] * array[k];
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for(int k = 0; k < x.Length; k++)
        {
            if (x[k] <= 0)
                y[k] = double.NaN;
            else
            {
                y[k] = 0.5 * Math.Log(x[k]);
                y[k] = Math.Round(y[k], 2);
            }
            Console.WriteLine($"{x[k]} {y[k]}");
        }
        // end

        return y;
    }
    #endregion
    
    //нечётные
    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        double min = array[0];
        int minIndex = 0;
        for(int k = 1; k < array.Length; k++)
        {
            if (array[k] < min)
            {
                min = array[k];
                minIndex = k;
            }
        }
        array[minIndex] *= 2;
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
        double min = array[0];
        int minIndex = 0;
        for (int k = 1; k < array.Length; k++)
        {
            if (array[k] < min)
            {
                min = array[k];
                minIndex = k;
            }
        }
        for(int k = 0; k < minIndex; k++)
        {
            if (array[k]>=0)
                array[k] *= 2;
            else
                array[k] /= 2;
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
        double min = array[0];
        int minIndex = 0;
        double max = array[0];
        int maxIndex = 0;
        for (int k = 1; k < array.Length; k++)
        {
            if (array[k] < min)
            {
                min = array[k];
                minIndex = k;
            }
            else if (array[k] > max)
            {
                max = array[k];
                maxIndex = k;
            }
        }
        int count = 0;
        for(int k = minIndex+1; k < maxIndex; k++)
        {
            if (array[k] < 0)
                count++;
        }
        double[] answer = new double[count];

        count = 0;
        for (int k = minIndex + 1; k < maxIndex; k++)
        {
            if (array[k] < 0)
            {
                answer[count] = array[k];
                count++;
            }
        }
        // end

        return answer;
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
        double max = array[0];
        int maxIndex = 0;
        for (int k = 1; k < array.Length; k++)
        {
            if (array[k] > max)
            {
                max = array[k];
                maxIndex = k;
            }
        }
        if (maxIndex + 1 < array.Length)
        {
            if (array[maxIndex + 1] >= 0)
                array[maxIndex + 1] *= 2;
            else
                array[maxIndex + 1] /= 2;
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
        double min = array[0];
        int minIndex = 0;
        double max = array[0];
        int maxIndex = 0;
        for (int k = 1; k < array.Length; k++)
        {
            if (array[k] < min)
            {
                min = array[k];
                minIndex = k;
            }
            else if (array[k] > max)
            {
                max = array[k];
                maxIndex = k;
            }
        }
        double sumElem = 0;
        if(minIndex>maxIndex)
        {
            int tmp = maxIndex;
            maxIndex = minIndex;
            minIndex = tmp;
        }
        for(int k = minIndex+1; k < maxIndex; k++)
        {
            sumElem += array[k];
        }
        if (maxIndex - minIndex - 1== 0)
            return 0;
        average = sumElem / (maxIndex - minIndex - 1);
        average = Math.Round(average, 2);
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
        PrintArray(array);
        int lastPlusIndex = -1;
        for(int k = 0; k<array.Length; k++)
        {
            if (array[k] > 0)
                lastPlusIndex = k;
        }
        if(lastPlusIndex<0)
            return array;
        double[] answer = new double[array.Length + 1];
        int count = 0;
        for(;count <=lastPlusIndex; count++)
        {
            answer[count] = array[count];
        }
        answer[count] = P;
        count++;
        for (;count < array.Length; count++)
        {
            answer[count+1] = array[count];
        }
        PrintArray(answer);
        // end

        return answer;
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
        int maxIndex = 0;
        double max = array[0];
        for(int k = 2; k < array.Length; k+=2)
        {
            if(array[k] > max)
            {
                max = array[k];
                maxIndex = k;
            }
        }
        array[maxIndex] = maxIndex;
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
            for(int i = 0; i < A.Length; i++)
                output[i] = A[i];
            return output;
        }
        output = new double[A.Length + B.Length];
        for(int i = 0; i <= k; i++)
        {
            output[i] = A[i];
        }
        for(int i = 0; i < B.Length; i++)
        {
            output[k+i+1] = B[i];
        }
        for(int i = k+1; i < A.Length; i++)
        {
            output[i+B.Length] = A[i];
        }
        /*
        PrintArray(A);
        PrintArray(B);
        PrintArray(output);
        */
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
        double min = array[0];
        int minIndex = 0;
        double max = array[0];
        int maxIndex = 0;
        for (int k = 1; k < array.Length; k++)
        {
            if (array[k] < min)
            {
                min = array[k];
                minIndex = k;
            }
            else if (array[k] > max)
            {
                max = array[k];
                maxIndex = k;
            }
        }

        double sum = 0;
        int count = 0;
        if(maxIndex < minIndex)//ср ар положит
        {
            for(int k = 0; k < array.Length; k++)
            {
                if(array[k] > 0)
                {
                    sum += array[k];
                    count++;
                }
            }
        }
        else//ср ар отриц
        {
            for (int k = 0; k < array.Length; k++)
            {
                if (array[k] < 0)
                {
                    sum += array[k];
                    count++;
                }
            }
        }

        if (count == 0)
        {
            average = 0;
            return average;
        }
        average = sum / count;
        average = Math.Round(average, 2);
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
        double max = array[0];
        int maxIndex = 0;
        double sum = 0;
        for(int k = 0; k < array.Length; k++)
        {
            sum += array[k];
            if (array[k] > max)
            {
                max = array[k];
                maxIndex = k;
            }
        }

        if (max > sum)
            array[maxIndex] = 0;
        else
            array[maxIndex] *= 2;
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
    
    // 1 4 7 10 13
    #region Level 3
    public int[] Task_3_1(double[] array)
    {
        int[] output = null;

        // code here
        PrintArray(array);
        double max = array[0];
        int maxCount = 1;
        //найти кол-во макс. эл-тов
        for (int k = 1; k < array.Length; k++)
        {
            if (array[k] > max)
            {
                max = array[k];
                maxCount = 1;
            }
            else if (array[k] == max)
                maxCount++;
        }
        Console.WriteLine($"max = {max}");
        //массив из индексов макс. эл-тов
        output = new int[maxCount];
        int it = 0;
        for(int k = 0; k<array.Length; k++)
        {
            if (array[k] == max)
            {
                output[it] = k;
                Console.WriteLine($"output[{it}] = {k}");
                it++;
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
        PrintArray(array);
        //найти значение максю эл-та
        double max = array[0];
        for (int k = 1; k < array.Length; k++)
        {
            if (array[k] > max)
            {
                max = array[k];
            }    
        }
        Console.WriteLine($"max = {max}");
        //замена максю эл-тов
        double sum = 0;
        for(int k = 0; k<array.Length; k++)
        {
            if (array[k] == max)
            {
                array[k] = sum;
                sum += max;
            }
            else
                sum += array[k];
        }
        PrintArray(array);
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
        PrintArray(array);
        int countNegative = 0;
        for(int k = array.Length - 1; k >= 0; k--)
        {
            if (array[k] < 0)
            {
                countNegative++;
                for(int m = k; m<array.Length-countNegative; m++)
                {
                    double tmp = array[m];
                    array[m] = array[m + 1];
                    array[m + 1] = tmp;
                }
                PrintArray(array);
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
        PrintArray(array);
        int index = array.Length - 1;
        for (int k = array.Length / 2 - 1; k >= 0; k--)
        {
            array[index] = array[k];
            index--;
            array[index] = array[k];
            index--;
            PrintArray(array);
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
        PrintArray(array);
        int sameCount = 0;
        for(int k = 0; k < array.Length; k++)
        {
            for(int m = k+1; m < array.Length; m++)
            {
                if (array[m] == array[k])
                {
                    sameCount++;
                    break;
                }
            }
        }
        double[] answer = new double[array.Length - sameCount];
        int count = 0;
        for(int k = 0;k < array.Length; k++)
        {
            bool isRepeat = false;
            for(int n = k-1;n>=0;n--)
            {
                if (array[k] == array[n])
                {
                    isRepeat = true;
                    break;
                }
            }
            if(!isRepeat)
            {
                answer[count] = array[k];
                count++;
            }
        }
        PrintArray(answer);
        // end

        return answer;
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