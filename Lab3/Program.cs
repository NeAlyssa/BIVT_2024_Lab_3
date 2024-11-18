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
        program.Task_1_1(new double[] { 1, 2, 3, 4, 5, 6 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        int length = array.Length;
        double summ = 0;
        for (int i = 0; i < length; i++)
        {
            summ += array[i];
        }
        for (int i = 0; i < length; i++)
        {
            array[i] /= summ;
            array[i] = Math.Round(array[i], 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        int length = array.Length;
        double summ = 0;
        int count = 0;
        for (int i = 0; i < length; i++)
        {
            if (array[i] > 0)
            {
                count++;
                summ += array[i];
            }
        }
        double avarage = Math.Round(summ / count, 2);
        for (int i = 0; i < length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = avarage;
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
            sum[i] = first[i] + second[i];
            dif[i] = first[i] - second[i];
            sum[i] = Math.Round(sum[i], 2);
            dif[i] = Math.Round(dif[i], 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double avarage = array.Sum() / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] -= avarage;
            array[i] = Math.Round(array[i], 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < 4; i++)
        {
            product += (vector1[i] * vector2[i]);
        }
        product = Math.Round(product, 2);
        // end

        return product;
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
        for (int i = 0; i < 8; i++)
            sum += array[i];
        sum = sum / 8;
        for (int i = 0; i < 8; i++)
            if (array[i] > sum) count++;
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for (int i = 0; i < 10; i++)
            if (array[i] > P && array[i] < Q) count++;
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int sum = 0;
        foreach (double x in array)
            if (x > 0) sum++;
        output = new double[sum];
        int k = 0;
        foreach (double x in array)
        {
            if (x > 0)
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
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                value = array[i];
                index = i;
            }
        }
        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length / 2];
        int k = 0;
        int n = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[k] = array[i];
                k++;
            }
            else
            {
                odd[n] = array[i];
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

        for (int t = 0; t < array.Length; t++)
        {
            if (array[t] >= 0)
            sum += (array[t]*array[t]);
            else break;
            
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
            if (x[i] > 0) y[i] = Math.Round((Math.Log(x[i]) * 0.5), 2);
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
        double len = array[1];
        double min = array[0];
        int nmin = 0;
        for (int n = 0; n < array.Length; n++)
        {
            if (array[n] < min)
            {
                min = array[n];
                nmin = n;
            }
        }
        if (array[nmin] > 0)
        {
            array[nmin] *= 2;
        }
        else
        {
            array[nmin] /= 2;
        }
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
        int d = 0;
        double y = array[0];
        for (int i = 0; i < array.Length; i++) if (array[i] < y) { y = array[i]; d = i; }
        for (int e = 0; e < d; e++)
        {
            if (array[e] >= 0) array[e] *= 2;
            else array[e] /= 2;
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
        int nmin = 0;
        int nmax = 0;
        double max = array[0];
        double min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                nmax = i;
            }
            if (array[i] < min)
            {
                min = array[i];
                nmin = i;
            }
        }
        int k = 0;
        for (int j = Math.Min(nmin, nmax) + 1; j < Math.Max(nmin, nmax); j++)
        {
            if (array[j] < 0)
            {
                k++;
            }
        }
        double[] arraych = new double[k];
        int g = 0;
        for (int j = Math.Min(nmin, nmax) + 1; j < Math.Max(nmin, nmax); j++)
        {
            if (array[j] < 0)
            {
                arraych[g] = array[j];
                g++;
            }
        }
        // end

        return arraych;
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
        int d = 0; double miint = double.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (miint < array[i]) { d = i; miint = array[i]; }

        }
        if (d + 1 < array.Length)
        {
            if (array[d + 1] >= 0) array[d + 1] *= 2;
            else array[d + 1] /= 2;
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
 
        int minIndex = 0;
        int maxIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[minIndex])
            {
                minIndex = i;
            }
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }

        
        int startIndex = Math.Min(minIndex, maxIndex) + 1;
        int endIndex = Math.Max(minIndex, maxIndex);

        
        if (startIndex < endIndex)
        {
            double sum = 0;
            int count = 0;

            for (int i = startIndex; i < endIndex; i++)
            {
                sum += array[i];
                count++;
            }

            average = sum / count;
            
        }
        else
        {
            Console.WriteLine("Нет элементов между минимальным и максимальным значениями.");
        }

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
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] > 0)
            {
                index = i;
                break;
            }
        }
        double[] Array = new double[array.Length + 1];
        if (index < 0) Array = array;
        else
        {
            for (int i = 0; i <= index; i++)
            {
                Array[i] = array[i];
            }
            Array[index + 1] = P;
            for (int i = index + 1; i < array.Length; i++)
            {
                Array[i + 1] = array[i];
            }
        }
        array = Array;
        // end

        return array;
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
        double max = array[0];
        int maxIndex = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
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
        double[] output = new double[A.Length + B.Length];
        if (k >= A.Length) return A;

        // code here
        for (int i = 0; i <= k; i++) 
            output[i] = A[i];
        for (int i = 0; i < B.Length; i++) 
            output[k + i + 1] = B[i];
        for (int i = 0; i < A.Length - k - 1; i++) 
            output[k + B.Length + i + 1] = A[k + i + 1];
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
        double min = array[0], max = array[0], 
        sumOtr = 0, sumPol = 0;
        int minIndex = -1, maxIndex = -1, countOtr = 0, countPol = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                minIndex = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
            if (array[i] > 0)
            {
                sumPol += array[i];
                countPol++;
            }
            else
            {
                sumOtr += array[i];
                countOtr++;
            }
        }
        if (maxIndex < minIndex)
        {
            average = countPol == 0 ? 0 : sumPol / countPol;
        }
        else
        {
            average = countOtr == 0 ? 0 : sumOtr / countOtr;
        }
        
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
        double max = double.MinValue, sum = 0;
        int maxIndex = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
            sum += array[i];
        }
        if (max > sum)
        {
            array[maxIndex] = 0;
        }
        else
        {
            array[maxIndex] *= 2;
        }
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

        // end

        return output;
    }
    public double[] Task_3_2(double[] array)
    {
        // code here
        double sharp = array[0], cum = 0; for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sharp)
            {
                sharp = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == sharp)
            {
                cum++; array[i] += cum;
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
        // code here

        // end

        return array;
    }
    public double[] Task_3_5(double[] array)
    {
        // code here
        for (int i = 0; i < array.Length - 2; i += 2)
        {
            double min = array[i]; int imin = i;
            for (int j = i + 2; j < array.Length; j += 2)
            {
                if (array[j] < min)
                {
                    min = array[j];
                    imin = j;
                }
            }
            array[imin] = array[i]; array[i] = min;
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
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < 0)
            {
                double max = array[i];
                int imax = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > max && array[j] < 0)
                    {
                        max = array[j]; imax = j;
                    }
                }
                array[imax] = array[i];
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

        double shift_ = (b - a) / (n - 1);

        for (int i = 0; i < n; i++)
        {
            X[i] = a + i * shift_;
            Y[i] = Math.Round(Math.Cos(X[i]) + X[i] * Math.Sin(X[i]), 2);
            X[i] = Math.Round(a + i * shift_, 2);
        }

        double globalMax = Math.Max(Y[0], Y[n - 1]), globalMin = Math.Min(Y[0], Y[n - 1]);

        // code here
        for (int i = 1; i < Y.Length - 1; i++)
        {
            double twentyfour_fourteen = Y[i], bivt = Y[i - 1], Proskurin = Y[i + 1];

            if (bivt < twentyfour_fourteen && Proskurin < twentyfour_fourteen)
            {
                Console.WriteLine($"Найден экстремум! Аргумент: {X[i]}, Значение функции: {twentyfour_fourteen}, Вид экстремума: локальный максимум");

            };
            if (bivt > twentyfour_fourteen && Proskurin > twentyfour_fourteen)
            {
                Console.WriteLine($"Найден экстремум! Аргумент: {X[i]}, Значение функции: {twentyfour_fourteen}, Вид экстремума: локальный минимум");
            };

            globalMin = Math.Min(globalMin, twentyfour_fourteen);
            globalMax = Math.Max(globalMax, twentyfour_fourteen);
        }
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

        // end

        return array;
    }
    public double[] Task_3_14(double[] array)
    {
        double[] normalizedArray = new double[array.Length]; 

        // code here
        // code here
        double min = double.MaxValue; double max = double.MinValue;
        foreach (var value in array)
        {
            if (value < min) min = value; if (value > max) max = value;
        }
        for (int i = 0; i < array.Length; i++)
        {
            normalizedArray[i] = Math.Round(2 * (array[i] - min) / (max - min) - 1, 2);
        }
        // end

        return normalizedArray;
    }
    #endregion
}
