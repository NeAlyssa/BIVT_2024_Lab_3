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
        //program.Task_1_11(new double[] {0, 1.5, 1, 3, -2.2, -0.5, 2, 2, 3.1, -0.7});
        //program.Task_1_15(new double[] {0, 1.5, 1, 3, -2.2, -0.5, 2, 2, 3.1, -0.7 });\
        program.Task_3_11(1.5, 3, 4);
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double sum = 0;

        foreach(double item in array)
        {
            sum += item;
        }

        for(int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] / sum, 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double positiveSr = 0;
        int n = 0;

        foreach(double item in array)
        {
            if(item > 0)
            {
                positiveSr += item;
                n++;
            }
        }

        positiveSr = Math.Round(positiveSr / n, 2);

        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                array[i] = positiveSr;
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for(int i = 0; i < first.Length; i++)
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
        double sr = 0;

        foreach (double item in array)
        {
            sr += item;
        }

        sr /= array.Length;

        for(int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i]-sr, 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for(int i = 0; i < vector1.Length; i++)
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
        foreach(double x in vector)
        {
            length += x * x;
        }
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sr = 0;

        foreach (double item in array)
        { sr += item; }

        sr /= array.Length;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sr)
                array[i] = 0;
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        foreach(double item  in array)
        {
            if(item < 0)
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
        foreach(double item in array)
        {
            sr += item;
        }
        
        sr /= array.Length;

        foreach (double item in array)
        {
            if (item > sr)
                count++;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        foreach(double item in array)
        {
            if(P < item && item < Q)
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
        int lenght = 0;
        // code here
        
        foreach(double item in array)
        {
            if (item > 0)
                lenght++;
        }

        output = new double[lenght];

        for(int i = 0, k = 0; i < array.Length; i++)
        {
            if (array[i] > 0) { 
                output[k++] = array[i];
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
        for(int i = array.Length - 1; i >= 0; i--)
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
        double[] odd = new double[array.Length / 2];

        // code here
        for(int i = 0, e = 0, o = 0; i < array.Length; i++)
        {
            if(i % 2 == 0)
                even[e++] = array[i];

            else odd[o++] = array[i];
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;
        int firstNegative = 0;

        // code here
        foreach(double item in array)
        {
            if (item < 0) break;
            else firstNegative++;
        }

        for(int i = 0; i < firstNegative; i++)
        {
            sum += array[i] * array[i];
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
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            else y[i] = double.NaN;
        }

        for (int i = 0; i < x.Length; i++)
        {
            Console.WriteLine("{0,-10:f2}{1,-10:f2}", x[i], y[i]);
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
        double sum = 0, max = array[0];
        int indexMax = 0;
        // code here
        for(int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                indexMax = i;
            }
        }

        for(int i = 0; i < indexMax; i++)
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
        double max = array[0], average = 0;
        int indexMax = 0;
        // code here
        foreach(double item in array)
        {
            average += item;
        }

        average = Math.Round(average / array.Length, 2);

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                indexMax = i;
            }
        }

        for (int i = array.Length - 1; i > indexMax; i--)
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
        double average = 0, deviation;
        double[] tmpArray = new double[array.Length + 1];
        int index = 0;
        // code here
        foreach(double item in array)
        {
            average += item;
        }

        average /= array.Length;

        deviation = Math.Abs(average - array[0]);

        for (int i = 1; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - average) < deviation)
            {
                deviation = Math.Abs(array[i] - average);
                index = i;
            }
        }

        for (int i = 0; i < array.Length + 1; i++)
        {
            if (i <= index) tmpArray[i] = array[i];
            else if (i == index + 1) tmpArray[i] = P;
            else tmpArray[i] = array[i-1];
        }

        array = tmpArray;
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
        double max = array[0], min, tmp;
        int indexMax = 0, indexMin;
        // code here
        for(int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                indexMax = i;
            }
        }
        
        if(indexMax != array.Length - 1)
        {   min = array[indexMax + 1];
            indexMin = indexMax + 1;
            
            for (int i = indexMax + 2; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    indexMin = i;
                }
            }
        
            tmp = array[indexMax];
            array[indexMax] = array[indexMin];
                array[indexMin] = tmp;
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
        double min = double.MaxValue;
        double[] tmpArray = new double[array.Length - 1];
        int indexMin = -1;
        // code here

        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                if(array[i] < min)
                {
                    min = array[i];
                    indexMin = i;
                }
            }
        }
        if(indexMin != -1) 
        {    for (int i = 0; i < array.Length - 1; i++)
            {
                if(i < indexMin) tmpArray[i] = array[i];
                else tmpArray[i] = array[i + 1];
            }

            array = tmpArray;
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
        double sum = 0, max = array[0], firstNegative;
        int indexMax = 0, indexNegative = -1;
        // code here
        for(int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                indexMax = i;
            }
        }

        if(indexMax != array.Length - 1)
        {
            for(int i = indexMax + 1; i < array.Length; i++)
            {
                sum += array[i];
            }

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0 )
                {
                    firstNegative = array[i];
                    indexNegative = i;
                    break;
                }
            }

            if(indexNegative != -1)
            {
                array[indexNegative] = Math.Round(sum, 2);
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
        double max = array[0], firstNegative, tmp;
        int indexMax = 0, indexNegative = -1;

        // code here
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                firstNegative = array[i];
                indexNegative = i;
                break;
            }
        }
        
        if(indexNegative != -1)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                        indexMax = i;
                    }
                }

                tmp = array[indexMax];
                array[indexMax] = array[indexNegative];
                array[indexNegative] = tmp;
                
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
        double sum = 0;
        int[] output = null;
        int lessSum = 0;

        // code here
        foreach(double item in array)
        {
            sum += item;
        }

        sum /= array.Length;

        foreach(double item in array)
        {
            if(item < sum) lessSum++;
        }

        if (lessSum != 0)
        {
            output = new int[lessSum];

            for(int i = 0, k = 0; i < array.Length; i++)
            {
                if (array[i] < sum)
                {
                    output[k++] = i;
                }
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
        double maxEven = double.MinValue, maxOdd = double.MinValue;
        int indexEven, indexOdd;
        
        // code here
        for(int i = 0; i < array.Length; i++)
        {
            if(i % 2 ==0)
            {
                if (array[i] > maxEven)
                {
                    maxEven = array[i];
                    indexEven = i;
                }
            }
            else
            {
                if (array[i] > maxOdd)
                {
                    maxOdd = array[i];
                    indexOdd = i;
                }
            }
        }

        if(maxEven > maxOdd)
        {
            for(int i = 0; i < Math.Ceiling(array.Length / 2.0); i++)
            {
                array[i] = 0;
            }
        }
        else
        {
            for (int i = array.Length - 1; i >= Math.Floor(array.Length / 2.0); i--)
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
        double sum = 0, firstNegative, min = double.MaxValue;
        int indexFirst = -1, indexMin = -1;

        // code here
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                firstNegative = array[i];
                indexFirst = i;
                break;
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                indexMin = i;
            }
        }

        if (indexFirst != -1 && indexFirst < indexMin)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0) sum += array[i];
            }
        }

        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0) sum += array[i];
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
        double max = array[0];

        // code here
        foreach(double item in array)
        {
            if(item > max)
                max = item;
        }

        for (int i = 0, k = 1; i < array.Length; i++)
        {
            if (array[i] == max) array[i] += k++;
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
        for(int i = 0; i < array.Length - 2; i += 2)
        {
            double min = array[i];
            int imin = i;

            for(int j = i + 2; j < array.Length; j += 2)
            {
                if (array[j] < min)
                {
                    min = array[j];
                    imin = j;
                }
            }

            array[imin] = array[i];
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
        for(int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < 0)
            {
                double max = array[i];
                int imax = i;

                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > max && array[j] < 0)
                    {
                        max = array[j];
                        imax = j;
                    }
                }

                array[imax] = array[i];
                array[i] = max;

            }
        }
        // end
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
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
        double[] X = null, Y = null;
        double globalMax, globalMin, shift, max = double.MinValue, min = double.MaxValue;

        // code here
        shift = (b - a) / (n - 1);
        X = new double[n];
        Y = new double[n];

        for (int i = 0; i < n; i++)
        {
            X[i] = a + shift * i;
            Y[i] = Math.Round(Math.Cos(X[i]) + X[i] * Math.Sin(X[i]), 2);
            X[i] = Math.Round(X[i], 2);
        }

        globalMax = Math.Max(Y[0], Y[n - 1]);
        globalMin = Math.Min(Y[0], Y[n - 1]);

        for(int i = 1; i < n - 2; i++)
        {
            if (Y[i-1] < Y[i] && Y[i] > Y[i+1])
            {
                Console.WriteLine("Локальный максимум: x = {0:f2}, y = {1:f2}", X[i], Y[i]);
                if (Y[i] > max) { max = Y[i];}
            }
            if (Y[i - 1] > Y[i] && Y[i] < Y[i + 1])
            {
                Console.WriteLine("Локальный минимум: x = {0:f2}, y = {1:f2}", X[i], Y[i]);
                if (Y[i] < min) { min = Y[i];}
            }
        }

        globalMax = Math.Max(globalMax, max);
        globalMin = Math.Min(globalMin, min);
        // end

        return (X, Y, globalMax, globalMin);
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
        double[] normalizedArray = new double[array.Length];
        double max = double.MinValue, min = double.MaxValue;

        // code here
        foreach(double item in array)
        {
            if (item > max) max = item;
            if (item < min) min = item;
        }

        for(int i = 0; i < array.Length; i++)
        {
            normalizedArray[i] = Math.Round(2 * (array[i] - min) / (max - min) - 1, 2);
        }

        //Обратное преобразование

        double[] originalArray = new double[normalizedArray.Length];

        for(int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round((1 + normalizedArray[i]) * (max - min) / 2 + min, 1);
            Console.WriteLine(array[i]);
        }
        
        return normalizedArray;
    }
    #endregion
}