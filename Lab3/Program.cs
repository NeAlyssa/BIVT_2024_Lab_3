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
        double sum = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        if (sum != 0)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Math.Round(array[i] / sum, 2);
            }
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sum = 0;
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                sum += array[i];
                count++;
            }
        }

        if (count > 0)
        {
            double average = sum / count;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = Math.Round(average, 2);
                }
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
            sum[i] = Math.Round(first[i] + second[i], 2); // Сумма
            dif[i] = Math.Round(first[i] - second[i], 2);  // Разность
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
            array[i] = Math.Round(array[i] - average, 2); 
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
        // end

        return Math.Round(product, 2);
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < vector.Length; i++)
        {
            length += vector[i] * vector[i];
        }

        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 2); ;
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
        if(P < Q)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > P && array[i] < Q)
                {
                    count++; 
                }
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
                output[n] = array[i];
                n++;
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
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] < 0)
            {
                index = i;
                value = array[i];
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
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[i / 2] = array[i];
            }
            else 
            {
                odd[i / 2] = array[i];
            }
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
            if (array[i] < 0)
            {
                break;
            }
            sum += array[i] * array[i];
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
            if (x[i] > 0)
            {
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            }
            else y[i] = double.NaN;
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
        int maxIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }

        for (int i = 0; i < maxIndex; i++)
        {
            sum += array[i];
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
        double sum = 0;
        int maxIndex = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }

        double average = sum / array.Length;

        for (int i = maxIndex + 1; i < array.Length; i++)
        {
            array[i] = Math.Round(average, 2);
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
        double sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        double average = Math.Round(sum / array.Length, 2);

        double closestValue = array[0];
        int closestIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - average) < Math.Abs(closestValue - average))
            {
                closestValue = array[i];
                closestIndex = i;
            }
        }

        double[] newArray = new double[array.Length + 1];

        // Копирование элементов в новый массив
        for (int i = 0; i <= closestIndex; i++)
        {
            newArray[i] = array[i];
        }

        newArray[closestIndex + 1] = P;

        for (int i = closestIndex + 1; i < array.Length; i++)
        {
            newArray[i + 1] = array[i];
        }

        array = newArray;
        //end

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
        int maxIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }

        double minValue = double.MaxValue;
        int minIndex = -1;

        for (int i = maxIndex + 1; i < array.Length; i++)
        {
            if (array[i] < minValue)
            {
                minValue = array[i];
                minIndex = i;
            }
        }

        if (minIndex != -1)
        {
            double temp = array[maxIndex];
            array[maxIndex] = array[minIndex];
            array[minIndex] = temp;
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
        double minPositiveValue = double.MaxValue;
        int minPositiveIndex = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && array[i] < minPositiveValue)
            {
                minPositiveValue = array[i];
                minPositiveIndex = i;
            }
        }

        if (minPositiveIndex != -1)
        {
            double[] resultArray = new double[array.Length - 1];
            int resultIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i != minPositiveIndex)
                {
                    resultArray[resultIndex] = array[i];
                    resultIndex++;
                }
            }
            array = resultArray;
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
        double maxValue = double.MinValue;
        int maxIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxValue)
            {
                maxValue = array[i];
                maxIndex = i;
            }
        }

        double sumAfterMax = 0.0;

        if (maxIndex < array.Length - 1)
        {
            for (int i = maxIndex + 1; i < array.Length; i++)
            {
                sumAfterMax += array[i];
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = Math.Round(sumAfterMax, 2);
                break; 
            }
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
        int maxIndex = 0;
        int negativeIndex = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;             
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                negativeIndex = i; 
                break; 
            }
        }

        if (negativeIndex != -1)
        {
            double temp = array[maxIndex];
            array[maxIndex] = array[negativeIndex];
            array[negativeIndex] = temp;
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
        double sum = 0.0;

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

        output = new int[count]; 
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
            int mid = array.Length / 2;
            for (int i = 0; i < mid; i++)
            {
                array[i] = 0;
            }
        }
        else
        {
            int mid = array.Length / 2;
            for (int i = mid; i < array.Length; i++)
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
        double firstNegativeIndex = -1;
        double minIndex = -1;
        double minValue = double.MaxValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0 && firstNegativeIndex == -1)
            {
                firstNegativeIndex = i;
            }

            if (array[i] < minValue)
            {
                minValue = array[i];
                minIndex = i;
            }
        }

        if (firstNegativeIndex == -1) return sum;
        if (firstNegativeIndex != -1 && firstNegativeIndex < minIndex)
        {
            for (int i = 0; i < array.Length; i += 2)
            {
                sum += array[i];
            }
        }
        else
        {
            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }
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

        for (int i = 0; i < maxIndex - 1; i += 2)
        {
            double temp = array[i]; 
            array[i] = array[i + 1];
            array[i + 1] = temp;
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
        count = 1;
        int currentCount = 1;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i - 1])
            {
                currentCount++;
            }
            else
            {
                if (currentCount > count)
                {
                    count = currentCount;
                }
                currentCount = 1; 
            }
        }

        if (currentCount > count)
        {
            count = currentCount;
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
        int count = 1;

        // code here
        int currentCountVoz = 1; // Текущая длина последовательности по возрастанию
        int currentCountUb = 1; // Текущая длина последовательности по убыванию

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[i - 1])
            {
                currentCountVoz++;
                currentCountUb = 1;
            }
            else if (array[i] < array[i - 1])
            {
                currentCountUb++;
                currentCountVoz = 1; 
            }
            else
            {
                currentCountVoz = 1;
                currentCountUb = 1;
            }

            if (currentCountVoz > count)
            {
                count = currentCountVoz;
            }
            if (currentCountUb > count)
            {
                count = currentCountUb;
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
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                count++;
            }
        }

        double[] finalArray = new double[count];
        int index = 0; 

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                finalArray[index] = array[i];
                index++;
            }
        }
        array = finalArray;
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