using Microsoft.VisualBasic;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        program.Task_3_14(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double sm = 0;
        for (int i = 0; i < array.Length; ++i)
        {
            sm += array[i];
        }
        for (int i = 0; i<array.Length; ++i)
        {
            array[i] /= sm;
            array[i] = Math.Round(array[i],2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double mean = 0;
        int numb = 0;
        for(int i = 0; i < array.Length; ++i)
        {
            if (array[i] > 0)
            {
                mean += array[i];
                numb++;
            }
        }
        if (numb > 0)
        {
            mean /= numb;
        }
        mean = Math.Round(mean,2);
        for (int i = 0; i< array.Length; ++i)
        {
            if (array[i] > 0)
            {
                array[i] = mean;
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
            for (int i = 0; i < first.Length; ++i)
            {
                sum[i] = Math.Round(first[i] + second[i],2);
                dif[i] = Math.Round(first[i] - second[i], 2);
            }
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double mean = 0;
        for (int i = 0; i < array.Length; ++i)
        {
            mean += array[i]; 
        }
        if (array.Length != 0)
        {
            mean = Math.Round(mean / array.Length, 2);
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = Math.Round(array[i] - mean, 2);
            }
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
            for ( int i = 0; i < vector1.Length; ++i)
            {
                product += vector1[i] * vector2[i];
            }
            product = Math.Round(product, 2);
        }
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < vector.Length; ++i)
        {
            length += vector[i] * vector[i];
        }
        length = Math.Round(Math.Sqrt(length), 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double mean = 0;
        if(array.Length != 0)
        {
            for( int i = 0;i < array.Length; ++i)
            {
                mean += array[i];
            }
            mean = Math.Round(mean/array.Length, 2);
            for( int i = 0; i < array.Length; ++i)
            {
                if (array[i] > mean)
                {
                    array[i] =0;
                }
            }
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        if (array.Length != 0)
        {
            for( int i = 0; i<array.Length; ++i)
            {
                if (array[i] < 0)
                {
                    count++;
                }
            }
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double mean = 0;
        if (array.Length != 0)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                mean += array[i];
            }
            mean = Math.Round(mean / array.Length, 2);
            for ( int i = 0; i < array.Length; ++i)
            {
                if ( array[i] > mean)
                {
                    count++;
                }
            }
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        if(array.Length != 0)
        {
            if(P < Q)
            {
                for (int i = 0; i < array.Length; ++i)
                {
                    if(P < array[i] && Q > array[i])
                    {
                        count++;
                    }
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
        for (int i = 0; i < array.Length; ++i)
        {
            if (array[i] > 0)
            {
                n++;
            }
        }
        output = new double[n];
        int j = 0;
        for (int i = 0; i < array.Length; ++i)
        {
            if (array[i] > 0)
            {
                output[j] = array[i];
                j++;
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
        if (array.Length != 0)
        {
            for(int i =  0; i < array.Length; ++i)
            {
                if(array[i] < 0)
                {
                    value = array[i];
                    index = i;
                }
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
        if(array.Length != 0)
        {
            int ei = 0, oi = 0;
            for(int i = 0; i < array.Length; ++i)
            {
                if(i % 2 == 0)
                {
                    even[ei] = array[i];
                    ei++;
                } else
                {
                    odd[oi] = array[i];
                    oi++;
                }
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        if(array.Length != 0)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                if(array[i] >= 0)
                {
                    sum += array[i] * array[i];
                } else
                {
                    break;
                }
            }
            sum = Math.Round(sum, 2);
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        if(x.Length != 0)
        {
            for(int i = 0;i < x.Length; ++i)
            {
                if (x[i] > 0)
                {
                    y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
                } else
                {
                    y[i] = double.NaN;
                }
 
            }
            for( int i = 0; i <x.Length; ++i)
            {
                Console.WriteLine($"x = {x[i]}; y = {y[i]}");
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
        double miar = array[0];
        int mi = 0;
        Console.Write("Исходный массив: ");
        for(int i = 0; i < array.Length; ++i)
        {
            Console.Write($"{array[i]} ");
            if(array[i] < miar)
            {
                miar = array[i];
                mi = i;
            }
            
        }
        if (array[mi] < 0)
        {
            array[mi] /= 2;
        }
        else
        {
            array[mi] *= 2;
        }
        Console.Write("\n");
        Console.WriteLine($"Минимальный элемент: {miar}");
        Console.Write("Измененный массив: ");
        for(int i = 0; i < array.Length; ++i)
        {
            Console.Write($"{array[i]} ");
        }
        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        double maar = array[0];
        int mai = 0;
        Console.Write("Исходный массив: ");
        for (int i = 0; i < array.Length; ++i)
        {
            Console.Write($"{array[i]} ");
            if (array[i] > maar)
            {
                maar = array[i];
                mai = i;
            }
        }
        Console.Write("\n");
        Console.WriteLine($"Максимальный элемент массива: {maar}");
        for(int i = 0;i < mai; ++i)
        {
            sum += array[i];
        }
        Console.WriteLine($"Сумма элементов до максимального: {sum}");
        // end

        return sum;
    }
    public double[] Task_2_3(double[] array)
    {
        // code here
        double miar = array[0];
        int mi = 0;
        Console.Write("Исходный массив: ");
        for (int i = 0; i < array.Length; ++i)
        {
            Console.Write($"{array[i]}; ");
            if (array[i] < miar)
            {
                miar = array[i];
                mi = i;
            }

        }
        Console.Write("\n");
        Console.WriteLine($"Минимальный элемент: {miar}");
        Console.Write("Измененный массив: ");
        for(int i = 0;i < array.Length; ++i)
        {
            if(i < mi)
            {
                if (array[i] > 0)
                {
                    array[i] *= 2;
                } else
                {
                    array[i] -= 0.5 * array[i];
                }
            }
            Console.Write($"{array[i]}; ");

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
        Console.Write("Исходный массив: ");
        double mi = array[0], ma = array[0];
        int mind = 0, mand = 0;
        for (int i = 0; i < array.Length; ++i)
        {
            Console.Write($"{array[i]}; ");
            if(array[i] < mi)
            {
                mi = array[i];
                mind = i;
            }
            if ( array[i] > ma)
            {
                ma = array[i];
                mand = i;
            }
        }
        Console.Write("\n");
        Console.WriteLine($"Максимальный элемент: {ma}");
        Console.WriteLine($"Минимальный элемент: {mi}");
        int cotr = 0;
        for(int i = mind+1; i < mand; ++i)
        {
            if (array[i] < 0)
            {
                cotr++;
            }
        }
        double[] arr1 = new double[cotr];
        int c = 0;
        for (int i = mind + 1; i < mand; ++i)
        {
            if (array[i] < 0)
            {
                arr1[c] = array[i];
                c++;
            }
        }
        array = arr1;
        Console.Write("Измененный массив: ");
        for (int i = 0;i < array.Length; ++i)
        {
            Console.Write($"{array[i]}; ");
        }
        // end

        return array;
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
        Console.Write("Исходный массив: ");
        double  ma = array[0];
        int mand = 0;
        for (int i = 0; i < array.Length; ++i)
        {
            Console.Write($"{array[i]}; ");
            if( array[i] > ma)
            {
                ma = array[i];
                mand = i;
            }
        }
        Console.Write("\n");
        Console.WriteLine($"Максимальный элемент {ma}");
        if (mand < array.Length - 1)
        {
            if( array[mand+1] > 0)
            {
                array[mand + 1] *= 2;
            } else
            {
                array[mand + 1]+= array[mand+1]*(-0.5);
            }
        }
        Console.Write("Измененный массив: ");
        for (int i = 0; i < array.Length; ++i)
        {
            Console.Write($"{array[i]} ");
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
        Console.Write("Исходный массив: ");
        double mi = array[0], ma = array[0];
        int mind = 0, mand = 0;
        for (int i = 0; i < array.Length; ++i)
        {
            Console.Write($"{array[i]}; ");
            if (array[i] < mi)
            {
                mi = array[i];
                mind = i;
            }
            if (array[i] > ma)
            {
                ma = array[i];
                mand = i;
            }
        }
        Console.Write("\n");
        Console.WriteLine($"Максимальный элемент: {ma}");
        Console.WriteLine($"Минимальный элемент: {mi}");
        int p1 = 0, p2 = 0;
        if(mind> mand)
        {
            p1 = mand;
            p2 = mind;
        } else
        {
            p1 = mind;
            p2 = mand;
        }
        for (int i = p1+1 ; i < p2; ++i)
        {
            average += array[i];
        }
        if((Math.Abs(mind - mand) - 1) != 0)
        {
            average /= (Math.Abs(mind - mand) - 1);
        }
        Console.WriteLine($"Среднее значение {average}");
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
        Console.Write("Исходный массив: ");
        int lastpol = -1;
        bool pol = false;
        for (int i = 0; i < array.Length; ++i)
        {
            Console.Write($"{array[i]}; ");
            if (array[i] > 0)
            {
                lastpol = i;
                pol = true;
            }
        }
        if (pol)
        {
            Console.WriteLine($"Последний положительный элемент: {array[lastpol]}");
            Console.Write("Измененный массив: ");
            double[] temp = new double[array.Length + 1];
            for (int i = 0; i <= lastpol; ++i)
            {
                temp[i] = array[i];
            }
            temp[lastpol + 1] = P;
            for (int i = lastpol + 2; i < temp.Length; ++i)
            {
                temp[i] = array[i - 1];
            }
            array = temp;
            Console.Write("Измененный массив: ");
            for (int i = 0; i < array.Length; ++i)
            {
                Console.Write($"{array[i]}; ");
            }
        }
        else
        {
            Console.Write("Измененный массив: ");
            for (int i = 0; i < array.Length; ++i)
            {
                Console.Write($"{array[i]}; ");
            }
        }

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
        Console.Write("Исходный массив: ");
        double mach = -double.MaxValue;
        int mi = 0;
        for (int i = 0; i < array.Length; ++i)
        {
            Console.Write($"{array[i]}; ");
        }
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > mach)
            {
                mach = array[i];
                mi = i;
            }
        }
        Console.Write("\n");
        Console.WriteLine($"Максимальный элемент массива с четным индексом: {mach}");
        array[mi] = mi;
        Console.Write("\n");
        Console.Write("Измененный массив: ");
        for (int i = 0; i < array.Length; ++i)
        {
            Console.Write($"{array[i]}; ");
        }
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
        Console.Write("Исходный массив A: ");
        for (int i = 0; i < A.Length; ++i)
        {
            Console.Write($"{A[i]}; ");
        }
        Console.Write("\n");
        Console.Write("Исходный массив B: ");
        for (int i = 0; i < B.Length; ++i)
        {
            Console.Write($"{B[i]}; ");
        }
        Console.Write("\n");
        int pos = 0;
        if (A.Length > k)
        {
            output = new double[A.Length + B.Length];
            for (int i = 0; i <= k; i++)
            {
                output[pos] = A[i];
                pos++;
            }
            for (int i = 0; i < B.Length; i++)
            {
                output[pos] = B[i];
                pos++;
            }
            for (int i = k + 1; i < A.Length; i++)
            {
                output[pos] = A[i];
                pos++;
            }
        }
        else
        {
            output = new double[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                output[i] = A[i];
            }
        }
        // end
        for (int i = 0; i < output.Length; i++)
            Console.WriteLine(output[i]);

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
        double mael = -100000, miel = 100000;
        int ma = 0, mi = 0;
        Console.Write("исходный массив: ");
        for(int i = 0 ; i<array.Length; ++i)
        {
            Console.Write($"{array[i]}; ");
            if(array[i] > mael)
            {
                mael = array[i];
                ma = i;
            }
            if (array[i] < miel)
            {
                miel = array[i];
                mi = i;
            }
        }
        Console.WriteLine("\n");
        Console.WriteLine($"максимлаьный элемент: {mael}");
        Console.WriteLine($"минимальный элемент: {miel}");
        int n = 0;
        if (ma < mi)
        {
            foreach( double el in array)
            {
                if(el > 0)
                {
                    average += el;
                    n++;
                }
            }
        } else
        {
            foreach (double el in array)
            {
                if (el < 0)
                {
                    average += el;
                    n++;
                }
            }
        }
        if (n!= 0)
        {
            average /= n;
        }
        Console.WriteLine($"искомое значение {average}");
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
        double sum = 0, mael = -double.MaxValue;
        int mind = -1;
        Console.Write("Исходный массив: ");
        for (int i = 0; i < array.Length; ++i)
        {
            Console.Write($"{array[i]}; ");
            sum += array[i];
            if(array[i] > mael)
            {
                mael = array[i];
                mind = i;
            }
        }
        Console.Write("\n");
        Console.WriteLine($"Максимальный элемент массива: {mael}");
        if (mael > sum)
        {
            array[mind] = 0;
        } else
        {
            if (array[mind] > 0)
            {
                array[mind] *= 2;
            }
        }
        Console.Write("Измененный массив: ");
        for( int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}; ");
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
        Console.Write("Исходный массив: ");
        double mael = -double.MaxValue;
        int pos = 1;
        for(int i = 0 ; i < array.Length; ++i)
        {
            Console.Write($"{array[i]}; ");
            if(array[i] > mael)
            {
                mael = array[i];
            }
        }
        Console.Write("\n");
        Console.WriteLine($"Максимальный элемент {mael}");
        for(int i = 0; i < array.Length; ++i)
        {
            if(array [i] == mael)
            {
                array[i] += pos;
                pos++;
            }
        }
        Console.Write($"измененный массив: "); 
        for(int i = 0; i < array.Length; ++i)
        {
            Console.Write($"{array[i]}; ");
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
        double temp = -double.MaxValue, mi = double.MaxValue;
        Console.Write("исходный массив: ");
        for(int i = 0; i < array.Length; ++i)
        {
            Console.Write($"{array[i]}; ");
            if(i % 2 == 0)
            {
                if (array[i] < mi)
                {
                    mi = array[i];
                }
            }
        }
        Console.Write("\n");
        for (int i = 0; i < array.Length; i+=2)
        {
            for (int j = 0; j < array.Length - 2-i; j += 2)
            {
                if (array[j] > array[j + 2])
                {
                    temp = array[j + 2];
                    array[j + 2] = array[j];
                    array[j] = temp;
                }
            }
        }
        Console.Write("Измененный массив: ");
        for(int i = 0; i < array.Length; ++i)
        {
            Console.Write($"{array[i]}; ");
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
        Console.Write("Исходный массив: ");
        int cpol = 0;
        for(int i = 0; i < array.Length; ++i)
        {
            Console.Write($"{array[i]}; ");
            if (array[i] < 0)
            {
                cpol++;
            }
        }
        double[] pol = new double[cpol];
        int reg = 0;
        for (int i = 0; i < array.Length; ++i)
        {
            if (array[i] < 0)
            {
                pol[reg] = array[i];
                reg++;
            }
        }
        for(int i = 0; i < pol.Length; ++i)
        {
            for(int j =0; j < pol.Length - 1 - i; j++)
            {
                if (pol[j] < pol[j + 1])
                {
                    double temp = pol[j];
                    pol[j] = pol[j + 1];
                    pol[j + 1] = temp;
                }
            }
        }
        reg = 0;
        for(int i = 0; i < array.Length; ++i)
        {
            if (array[i] < 0)
            {
                array[i] = pol[reg];
                reg++;
            }
        }
        Console.Write("\n");
        Console.Write("Измененный массив: ");
        for(int i = 0; i < array.Length; ++i)
        {
            Console.Write($"{array[i]}; ");
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
        double[] X = null, Y = null;
        double globalMax = 0, globalMin = 0;

        // code here
        X = new double[n];
        Y = new double[n];
        globalMax = -100000000000000;
        globalMin = 100000000000000;
        double shag = Math.Abs(b - a)/(n-1);
        int reg = 0;
        Console.WriteLine("X : Y");
        for(double i = a; i <= b; i += shag)
        {
            X[reg] = Math.Round(i,2);
            Y[reg] = Math.Round((Math.Cos(i)+i* Math.Sin(i)),2);
            Console.WriteLine($"{X[reg]} {Y[reg]}");
            reg++;
        }
        for(int i = 0; i < Y.Length; i++)
        {
            if (Y[i]>= globalMax)
            {
                globalMax = Y[i];
            }
            if (Y[i]< globalMin)
            {
                globalMin = Y[i];
            }
        }
        Console.WriteLine("Global Max:\n");
        Console.WriteLine(globalMax);
        Console.WriteLine("Global Min:\n");
        Console.WriteLine(globalMin);
        for(int i = 1; i < Y.Length - 1; ++i)
        {
            if (Y[i - 1] < Y[i] && Y[i] > Y[i + 1])
            {
                Console.WriteLine($"Local Max: {X[i]} : {Y[i]}");
            } else if (Y[i - 1] > Y[i] && Y[i] < Y[i + 1])
            {
                Console.WriteLine($"Local Min: {X[i]} : {Y[i]}");
            }
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
        double[] normalizedArray = null;

        // code here
        normalizedArray = new double[array.Length];
        double miel = 1000000000, mael = -100000000000;
        Console.Write("Исходный массив: ");
        for(int i = 0; i < array.Length; ++i)
        {
            Console.Write($"{array[i]}; ");
            if (array[i] > mael)
            {
                mael = array[i];
            }
            if (array[i]< miel)
            {
                miel = array[i];
            }
        }
        Console.Write("\n");
        Console.WriteLine("Нормализованный массив:");
        for(int i = 0; i < array.Length; ++i)
        {
            normalizedArray[i] = 2 * ((array[i] - miel) / (mael - miel)) - 1;
        }
        for(int i = 0; i < normalizedArray.Length; ++i)
        {
            Console.Write($"{Math.Round(normalizedArray[i], 2)}; ");
        }
        // end

        return normalizedArray;
    }
    #endregion
}