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
        Console.WriteLine(string.Join(" ", program.Task_2_6([0, 1.5, -1, -3, -2.2, -0.5, 6], 2.3)));
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double s = 0;
        foreach (var element in array)
        {
            s += element;
        }

        for (int i = 0; i < array.Length; i++)
        {
            array[i] /= s;
            array[i] = Math.Round(array[i], 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double n=0, s=0;
        foreach (var element in array)
        {
            if (!(element > 0)) continue;
            n++;
            s += element;
        }

        s /= n;
        s = Math.Round(s, 2);

        for (int i = 0; i < array.Length; i++)
        {
            if (!(array[i]>0)) continue;
            array[i] = s;
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
            sum[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = Math.Round(first[i] - second[i], 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s = 0;
        foreach (var element in array)
        {
            s += element;
        }

        s /= array.Length;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] -= s;
            array[i] = Math.Round(array[i], 2);
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
        foreach (var element in vector)
        {
            length += element * element;
        }

        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 2);
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        foreach (var element in array)
        {
            s += element;
        }

        s /= array.Length;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > s)
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
        foreach (var element in array)
        {
            if (element < 0)
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
        double s = 0;
        foreach (var element in array)
        {
            s += element;
        }

        s /= array.Length;

        foreach (var element in array)
        {
            if (element > s)
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
        foreach (var element in array)
        {
            if (P < element && element < Q)
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
        output = [];
        foreach (var element in array)
        {
            if (element > 0)
            {
                 output = output.Append(element).ToArray();
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
        for (int i = 0; i < array.Length; i+=2)
        {
            even[i / 2] = array[i];
            odd[i/2] = array[i + 1];
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        foreach (var element in array)
        {
            if (element < 0) break;
            sum += element * element;
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[0];

        // code here
        foreach (var element in x)
        {
            if (element <= 0)
            {
                y = y.Append(double.NaN).ToArray();
                continue;
            }
            y = y.Append(Math.Round(0.5 * Math.Log(element), 2)).ToArray();
        }

        for (int i = 0; i < x.Length; i++)
        {
            Console.WriteLine($"{x[i]:F3} \t {y[i]:F3}");
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
        double max = double.MinValue;
        foreach (var element in array)
        {
            if (element > max)
            {
                max = element;
            }
        }

        foreach (var element in array)
        {
            if (Math.Abs(element - max) < 0.001) break;
            sum += element;
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
        double max = double.MinValue, average = 0;
        foreach (var element in array)
        {
            if (element > max) max = element;
            average += element;
        }

        average /= array.Length;

        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (Math.Abs(array[i] - max) < 0.001) break;
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
        double average = 0, min_diff = double.MaxValue;
        int index = -1;
        
        foreach (var element in array) average += element;

        average /= array.Length;

        for (int i=0; i < array.Length; i++)
        {
            if (min_diff < Math.Abs(average - array[i])) continue;
            index = i;
            min_diff = Math.Abs(average - array[i]);
        }
        
        List<double> temp = array.ToList();
        temp.Insert(index+1, P);
        array = temp.ToArray();
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
        double max = double.MinValue, min = double.MaxValue;
        int max_i = -1, min_i = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < max) continue;
            max = array[i];
            max_i = i;
        }

        for (int i = array.Length - 1; i > max_i; i--)
        {
            if (array[i] > min) continue;
            min = array[i];
            min_i = i;
        }

        if (min_i != -1)
        {
            (array[max_i], array[min_i]) = (array[min_i], array[max_i]);
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
        double min = double.MaxValue;
        int min_i = -1;


        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] <= 0) continue;
            if (min < array[i]) continue;
            min = array[i];
            min_i = i;
        }

        if (min_i != -1)
        {
            List<double> temp = array.ToList();
            temp.RemoveAt(min_i);
            array = temp.ToArray();

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
        Console.WriteLine($"Before: {string.Join(" ", array)}");
        double max = double.MinValue;
        int maxI = -1, firstNegativeI = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (!(array[i] < 0)) continue;
            firstNegativeI = i;
            break;
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (max > array[i]) continue;
            maxI = i;
            max = array[i];
        }

        if (firstNegativeI != -1 && maxI != -1)
        {
            double sum = 0;
            for (int i = maxI+1; i < array.Length; i++)
            {
                sum += array[i];
            }

            array[firstNegativeI] = Math.Round(sum, 2);
        }
        Console.WriteLine($"After: {string.Join(" ", array)}");

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
        double max = double.MinValue;
        int maxI = -1, firstNegativeI = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (!(array[i] < 0)) continue;
            firstNegativeI = i;
            break;
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (max > array[i]) continue;
            maxI = i;
            max = array[i];
        }

        if (firstNegativeI != -1)
        {
            (array[maxI], array[firstNegativeI]) = (array[firstNegativeI], array[maxI]);
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
        int[] output = [];

        // code here
        double average = 0;
        foreach (var element in array) average += element;
        average /= array.Length;

        for (int i = 0; i < array.Length; i++)
        {
            if (!(array[i] < average)) continue;
            output = output.Append(i).ToArray();
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
        double maxOdd = double.MinValue, maxEven = double.MinValue;

        for (int i = 0; i < array.Length; i+=2)
        {
            if (array[i] < maxEven) continue;
            maxEven = array[i];
        }
        
        for (int i = 1; i < array.Length; i+=2)
        {
            if (array[i] < maxOdd) continue;
            maxOdd = array[i];
        }

        Console.WriteLine(string.Join(" ", array));
        
        if (maxEven > maxOdd)
        {
            for (int i = 0; i < array.Length / 2; i++) array[i] = 0;
        }
        else
        {
            for (int i = array.Length / 2; i < array.Length; i++) array[i] = 0;
        }

        Console.WriteLine(string.Join(" ", array));
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
        int firstNegativeI = int.MaxValue, minI = -1;
        double min = double.MaxValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0) continue;
            firstNegativeI = i;
            break;
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > min) continue;
            min = array[i];
            minI = i;
        }

        if (firstNegativeI < minI)
        {
            for (int i = 0; i < array.Length; i+=2) sum += array[i];
        }
        else
        {
            for (int i = 1; i < array.Length; i += 2) sum += array[i];
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
        // Find max element
        double maxElement = double.MinValue;
        foreach (double d in array)
        {
            if (d > maxElement) maxElement = d;
        }

        int counter = 1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != maxElement) continue;
            array[i] += counter;
            counter++;
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
        for (int i = 0; i < array.Length; i+=2)
        {
            for (int j = 2; j < array.Length; j+=2)
            {
                if (array[j - 2] > array[j])
                {
                    (array[j - 2], array[j]) = (array[j], array[j - 2]);
                }
            }
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
        Console.WriteLine("Before:\t" + string.Join("; ", array));
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0) continue;
            for (int j = i+1; j < array.Length; j++)
            {
                if (array[j] >= 0) continue;
                if (array[i] < array[j])
                {
                    (array[i], array[j]) = (array[j], array[i]);
                }
            }
        }
        Console.WriteLine("After:\t" + string.Join("; ", array));
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
        double[] x = new double[n], y = new double[n];
        double globalMax = double.MinValue, globalMin = double.MaxValue;
        double dx = (b - a) / (n - 1);
        double currentX, prev, next, current, xMax=0, xMin=0;
        
        // code here
        Console.WriteLine($"a={a}; b={b}; n={n}");
        for (int i = 0; i < n; i++)
        {
            currentX = a + i * dx;
            x[i] = currentX;
            y[i] = Math.Cos(currentX) + currentX * Math.Sin(currentX);
            y[i] = Math.Round(y[i], 2);
            x[i] = Math.Round(x[i], 2);
        }

        Console.WriteLine($"Xs:\t" + string.Join(";\t", x));
        Console.WriteLine($"Ys:\t" + string.Join(";\t", y));

        for (int i = 1; i < (n-1); i++)
        {
            currentX = a + i * dx;
            prev = y[i - 1];
            current = y[i];
            next = y[i + 1];
            if (prev < current && next < current)
            {
                Console.WriteLine($"Функция достигает локального максимума в точке X={currentX:f3}, Y={current:f3}");
            }
            if (prev > current && next > current)
            {
                Console.WriteLine($"Функция достигает локального минимума в точке X={currentX:f3}, Y={current:f3}");
            }
        }

        for (int i = 0; i < n; i++)
        {
            if (y[i] <= globalMax) continue;
            xMax = a + dx * i;
            globalMax = y[i];
        }
        for (int i = 0; i < n; i++)
        {
            if (y[i] >= globalMin) continue;
            xMin = a + dx * i;
            globalMin = y[i];
        }

        Console.WriteLine($"Функция достигает глобального максимума в точке X={xMax:f3}, Y={globalMax:f3}");
        Console.WriteLine($"Функция достигает глобального минимума в точке X={xMin:f3}, Y={globalMin:f3}");
        
        // end

        return (x, y, globalMax,globalMin);
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

        // code here
        double max = double.MinValue, min = double.MaxValue;

        Console.WriteLine("Before:\t" + string.Join(";\t", array));

        foreach (var i in array)
        {
            if (i > max)
            {
                max = i;
            }
        }
        foreach (var i in array)
        {
            if (i < min)
            {
                min = i;
            }
        }
        
        Console.WriteLine($"Min: {min};\tMax: {max}");

        for (int i = 0; i < array.Length; i++)
        {
            normalizedArray[i] = -1 + (array[i] - min) * 2 / (max - min);
            normalizedArray[i] = Math.Round(normalizedArray[i], 2);
        }
        Console.WriteLine("After:\t" + string.Join(";\t", normalizedArray));

        // end

        return normalizedArray;
    }
    #endregion
}