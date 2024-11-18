using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using static System.Net.Mime.MediaTypeNames;
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
        double sum = 0.0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        if (sum != 0)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] /= sum;
                array[i] = Math.Round(array[i],2);
            }
        }
        else
        {
            return array;
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0;
        int elements = 0;
        foreach (double x in array)
        {
            if (x > 0)
            {
                s += x;
                elements += 1; 
            }
        }
        double sr = Math.Round(s / elements,2);
        for (int i = 0; i<array.Length; i++)
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
        if (first.Length == second.Length)
        {
            for (int i = 0;i < first.Length;i++)
            {
                sum[i] = Math.Round(first[i] + second[i], 2);
                dif[i] = Math.Round(first[i] - second[i],2);  
            }
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        double average = sum / array.Length;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - average,2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        if (vector1.Length == vector2.Length)
        {
            for (int i = 0; i < vector2.Length; i++)
            {
                product += vector1[i] * vector2[i];
            }
        }
        
        // end

        return Math.Round(product,2);
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i< vector.Length; i++)
        {
            length += vector[i] * vector[i];
        }
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 2); 
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        double average = sum / array.Length;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > average)
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
            if ((array[i] < 0))
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
        double s = 0.0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        double sr = s / (array.Length - 1);
        for (int i = 0; i < array.Length; i++)
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
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > P && array[i] < Q)
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
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                count++;
            }
        }
        output = new double[count];
        count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[count++] = array[i];
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
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] < 0)
        //    {
        //        value = array[i];
        //        index = i;
        //    }
            
        //}
        for (int i = array.Length -1; i >= 0; i--)
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
        for (int i = 0; i < array.Length / 2; i++)
        {
            even[i] = array[i*2];
        }
        for (int i = 0; i < array.Length / 2; i++)
        {
            odd[i] = array[i * 2 + 1];
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
            if (array[i] >= 0)
            {
                sum += array[i] * array[i];
            }
            else break;

        }
        // end

        return Math.Round(sum,2);
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] > 0)
            {
                y[i] = Math.Round(0.5 * Math.Log(x[i]),2);
            }
            else
            {
                y[i] = double.NaN; 
            }
        }
        Console.WriteLine(" x\t\t y");
        Console.WriteLine("---------------------");
        for (int i = 0; i < x.Length; i++)
        {
            Console.WriteLine($"{x[i]:F2}\t {y[i]:F4}");
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
        double record = double.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < record)
            {
                record = array[i];
                index = i;
            }
        }
        array[index] = record * 2;
        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        int index = 0;
        double record = double.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > record)
            {
                record = array[i];
                index = i;
            }
        }
        for (int i = 0; i < index; i++)
        {
            sum += array[i];
        }
        // end

        return sum;
    }
    public double[] Task_2_3(double[] array)
    {
        // code here
        int index = 0;
        double record = double.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < record)
            {
                record = array[i];
                index = i;
            }
        }
        for (int i = 0; i < index; i++)
        {
            if (array[i] >0)
            {
                array[i] *= 2;
            }
            else
            {
                array[i] /= 2;
            }
        }
        // end

        return array;
    }
    public double[] Task_2_4(double[] array)
    {
        // code here
        double sum = 0;
        int index = 0;
        double record = double.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            if (array[i] > record)
            {
                record = array[i];
                index = i;
            }
        }
        double average = Math.Round(sum / array.Length,2);
        for (int i = index + 1; i < array.Length; i++)
        {
            array[i] = average;
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
        // Step 1: Calculate the average of the array elements
        double average = 0;
        for (int i = 0; i < array.Length; i++)
        {
            average += array[i];
        }
        average /= array.Length;

        // Step 2: Find the element closest to the average
        int closestIndex = 0;
        double closestDifference = Math.Abs(array[0] - average);

        for (int i = 1; i < array.Length; i++)
        {
            double difference = Math.Abs(array[i] - average);
            if (difference < closestDifference)
            {
                closestDifference = difference;
                closestIndex = i;
            }
        }

        // Step 3: Create a new array with the new size
        int newSize = array.Length + 1;
        double[] newArray = new double[newSize];

        // Step 4: Copy elements to the new array and insert P
        for (int i = 0, j = 0; i < array.Length; i++, j++)
        {
            newArray[j] = array[i];
            if (i == closestIndex)
            {
                j++; // Increment j to skip the next position
                newArray[j] = P; // Insert P after the closest element
            }
        }

        // end

        return newArray;
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
        int index1 = 0;
        int index2 = 0;
        double a = double.MinValue;
        double b = double.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > a)
            {
                a = array[i];
                index1 = i;
            }
        }
        for (int i = index1; i < array.Length; i++)
        {
            if (array[i] < b)
            {
                b = array[i];
                index2 = i;
            }
        }
        array[index1] = b;
        array[index2] = a;
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
        double minPositive = double.MaxValue;
        int minIndex = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && array[i] < minPositive)
            {
                minPositive = array[i];
                minIndex = i;
            }
        }
        if (minIndex < 1)
        {
            return array;
        }
        int newSize = array.Length - 1;
        double[] newArray = new double[newSize];
        int newArrayIndex = 0;


        for (int i = 0; i < array.Length; i++)
        {
            if (i != minIndex)
            {
                newArray[newArrayIndex] = array[i];
                newArrayIndex++;
            }
        }
        // end

        return newArray;
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

        double maxElement = double.MinValue;
        int maxIndex = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxElement)
            {
                maxElement = array[i];
                maxIndex = i;
            }
        }

        double sumAfterMax = 0;
        for (int i = maxIndex + 1; i < array.Length; i++)
        {
            sumAfterMax += array[i];
        }

        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = Math.Round(sumAfterMax, 2);
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
        // code here
        double maxElement = double.MinValue;
        int maxIndex = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxElement)
            {
                maxElement = array[i];
                maxIndex = i;
            }
        }
        int firstNegativeIndex = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                firstNegativeIndex = i;
                break;
            }
        }
        if (maxIndex != -1 && firstNegativeIndex != -1)
        {
            double temp = array[maxIndex];
            array[maxIndex] = array[firstNegativeIndex];
            array[firstNegativeIndex] = temp;
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
        //int[] output = null;

        // code here

        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        double average = sum / array.Length;

        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < average)
            {
                count++;
            }
        }

        int[]output = new int[count];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < average)
            {
                output[index] = i;
                index++;
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

        double maxEven = double.MinValue;
        double maxOdd = double.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0) 
            {
                if (array[i] > maxEven)
                {
                    maxEven = array[i];
                }
            }
            else
            {
                if (array[i] > maxOdd)
                {
                    maxOdd = array[i];
                }
            }
        }

        if (maxEven > maxOdd)
        {
            int halfLength = array.Length / 2;
            for (int i = 0; i < halfLength; i++)
            {
                array[i] = 0;
            }
        }
        else
        {

            int halfLength = array.Length / 2;
            for (int i = halfLength; i < array.Length; i++)
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
        double a = double.MaxValue;
        int firstNegativeIndex = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                firstNegativeIndex = i;
                break; 
            }
        }
        if (firstNegativeIndex == -1)
        {
            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }
            return Math.Round(sum, 2);
        }
        int minimumIndex = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < a)
            {
                minimumIndex = i;
            }
        }
        if (minimumIndex == -1)
        {
            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }
            return Math.Round(sum, 2);
        }
        if (firstNegativeIndex < minimumIndex)
        {
            for (int i = 0; i < array.Length; i += 2) 
            {
                sum += array[i];
            }
            return Math.Round(sum, 2);
        }
        else
        {
            for (int i = 1; i < array.Length; i += 2) 
            {
                sum += array[i];
            }
            return Math.Round(sum,2);
        }
        // end
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

        
        int maxIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }

        int newSize = array.Length;
        double[] newArray = new double[newSize];

        int j = 0; 
        for (int i = 0; i < maxIndex; i++)
        {
            if (i % 2 == 0 && i + 1 < maxIndex) 
            {
                newArray[j++] = array[i + 1]; 
                newArray[j++] = array[i];     
                i++; 
            }
            else
            {
                newArray[j++] = array[i]; 
            }
        }

        for (int i = maxIndex; i < array.Length; i++)
        {
            newArray[j++] = array[i];
        }
        for (int i = 0; i < newSize; i++)
        {
            array[i] = newArray[i];
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

        // code here
        if (array.Length == 0) return 0; 

        int maxCount = 0; 
        int currentCount = 1; 

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1]) 
            {
                currentCount++; 
            }
            else
            {
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
                currentCount = 1; 
            }
        }
        if (currentCount > maxCount)
        {
            maxCount = currentCount;
        }

        return maxCount;
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
        int answer = 1, countDec = 1, countInc = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] > array[i]) // убывание
            {
                if (countInc > answer) answer = countInc;
                countInc = 1;
                countDec++;
            }
            else if (array[i - 1] < array[i]) // возрастание
            {
                if (countDec > answer) answer = countDec;
                countDec = 1;
                countInc++;
            }
        }
        if (countDec > answer) answer = countDec;
        if (countInc > answer) answer = countInc;
        return answer;
        // end

        //return count;
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
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                count++;
            }
        }
        double[] resultArray = new double[count];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                resultArray[index] = array[i];
                index++;
            }
        }

        return resultArray; 
        // end

        //return array;
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
