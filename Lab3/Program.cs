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
        int index = 0;
        foreach (var item in array)
        {
            Console.WriteLine($"Элемент исходного массива под номером {index + 1} есть {item}.");
            sum += item;
            index++;
        }
        Console.WriteLine($"{sum} == сумма элементов.");
        if (sum != 0)
        {
            index = 0;
            foreach (var item in array)
            {
                double result = item / sum;
                array[index] = Math.Round(result, 2);
                Console.WriteLine($"Элемент нового массива под номером {index + 1} есть {result}.");
                index++;
            }
        }
        else { Console.WriteLine("Сумма элементов массива равна нулю. Деление невозможно."); }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sum = 0;
        int count = 0;
        int index = 0;
        foreach (var item in array)
        {
            if (item > 0)
            {
                sum += item;
                count++;
            }
            Console.WriteLine($"Элемент исходного массива под номером {index + 1} есть {item}.");
            index++;
        }
        if (count != 0)
        {
            double sredn = sum / count;
            Console.WriteLine($"Среднее арифм. есть {sredn}");
            index = 0;
            foreach (var item in array)
            {
                if (item > 0)
                {
                    array[index] = Math.Round(sredn, 2);
                }
                Console.WriteLine($"Элемент исходного массива под номером {index + 1} есть {array[index]}.");
                index++;
            }
        }
        else { Console.WriteLine("Нет положительных элементов."); }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"Элемент первого исходного массива под номером {i + 1} есть {first[i]}.");
            Console.WriteLine($"Элемент второго исходного массива под номером {i + 1} есть {second[i]}.");
            sum[i] = Math.Round(first[i] + second[i], 4);
            dif[i] = Math.Round(first[i] - second[i], 4);
            Console.WriteLine($"Элемент массива суммы под номером {i + 1} есть {sum[i]}.");
            Console.WriteLine($"Элемент массива разности под номером {i + 1} есть {dif[i]}.");
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sum = 0;
        int count = 0;
        int index = 0;
        foreach (var item in array)
        {
            Console.WriteLine($"Элемент исходного массива под номером {index + 1} есть {item}.");
            sum += item;
            count++;
            index++;
        }
        double sredn = sum / count;
        index = 0;
        foreach (var item in array)
        {
            array[index] = Math.Round(array[index] - sredn, 4);
            Console.WriteLine($"Элемент нового массива под номером {index + 1} есть {item}.");
            index++;
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
            Console.WriteLine($"Элемент исходного первого массива под номером {i + 1} есть {vector1[i]}.");
            Console.WriteLine($"Элемент исходного второго массива под номером {i + 1} есть {vector2[i]}.");
            product += vector1[i] * vector2[i];
        }
        product = Math.Round(product, 4);
        Console.WriteLine($"{product} и есть искомое значение.");
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        double sum = 0;
        int index = 0;
        foreach (var item in vector)
        {
            Console.WriteLine($"Элемент исходного массива под номером {index + 1} есть {item}.");
            sum += Math.Pow(item, 2);
            index++;
        }
        length = Math.Pow(sum, 0.5);
        Console.WriteLine($"{length} и есть искомое значение.");
        // end

        return Math.Round(length, 2);
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sum = 0;
        int count = 0;
        int index = 0;
        foreach (var item in array)
        {
            Console.WriteLine($"Элемент исходного массива под номером {index + 1} есть {item}.");
            sum += item;
            count++;
            index++;
        }
        index = 0;
        double sredn = sum / count;
        foreach (var item in array)
        {
            if (item > sredn)
            {
                array[index] = 0;
            }
            Console.WriteLine($"Элемент массива под номером {index + 1} есть {array[index]}.");
            index++;
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        int index = 0;
        foreach (var item in array)
        {
            if (item < 0)
            {
                count++;
            }
            Console.WriteLine($"Элемент исходного массива под номером {index + 1} есть {item}.");
        }
        Console.WriteLine($"{count} — искомое число.");
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double sum = 0;
        int count2 = 0;
        int index = 0;
        foreach (var item in array)
        {
            sum += item;
            count2++;
            Console.WriteLine($"Элемент исходного массива под номером {index + 1} есть {item}.");
            index++;
        }
        index = 0;
        double sredn = sum / count2;
        foreach (var item in array)
        {
            if (item > sredn)
            {
                count++;
            }
        }
        Console.WriteLine($"{count} — искомое число.");
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        int index = 0;
        foreach (var item in array)
        {
            Console.WriteLine($"Элемент исходного массива под номером {index + 1} есть {item}.");
            if (item > P && item < Q)
            {
                count++;
            }
            index++;
        }
        Console.WriteLine($"{count} — искомое число.");
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
            Console.WriteLine($"Элемент исходного массива под номером {i + 1} есть {array[i]}.");
            if (array[i] > 0)
            {
                count++;
            }
        }
        output = new double[count];
        int index = 0;
        foreach (var item in array)
        {
            if (item > 0)
            {
                Console.WriteLine($"Элемент массива под номером {index + 1} есть {item}.");
                output[index++] = item;
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
        int count = 0;
        int i = 0;
        foreach (var item in array)
        {
            if (item < 0)
            {
                count++;
            }
            Console.WriteLine($"Элемент массива под номером {i + 1} есть {item}.");
            i++;
        }
        i = 0;
        foreach (var item in array)
        {
            if (item < 0)
            {
                count--;
                if (count == 0)
                {
                    value = item;
                    index = i;
                }
            }
            i++;
        }
        Console.WriteLine($"{value} и {index} — искомые числа.");
        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length / 2];

        // code here
        int index = 0;
        foreach (var item in array)
        {
            Console.WriteLine($"Элемент исходного массива под номером {index + 1} есть {item}.");
            if (index % 2 == 0)
            {
                even[index / 2] = item;
                Console.WriteLine("И он же будет в массиве чётных индексов.");
            }
            else
            {
                odd[index / 2] = item;
                Console.WriteLine("И он же будет в массиве нечётных индексов.");
            }
            index++;
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        int index = 0;
        while (index < array.Length && array[index] >= 0)
        {
            Console.WriteLine($"Элемент массива под номером {index + 1} есть {array[index]}.");
            sum += Math.Pow(array[index], 2);
            index++;
        }
        Console.WriteLine($"{sum} — искомое число.");
        // end

        return sum;
    }

    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        int index = 0;
        foreach (var item in x)
        {
            if (x[index] > 0)
            {
                y[index] = Math.Round(0.5 * Math.Log(x[index]), 2);
            }
            else { y[index] = double.NaN; }
            Console.WriteLine($"{x[index]}      {y[index]}");
            index++;
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
        double max = -10000;
        int index = 0;
        foreach (var item in array)
        {
            if (item > max)
            {
                max = item;
            }
            Console.WriteLine($"Элемент исходного массива под номером {index + 1} есть {item}.");
            index++;
        }
        index = 0;
        while (index < array.Length && array[index] != max)
        {
            sum += array[index];
            index++;
        }
        Console.WriteLine($"{sum} — искомые числа.");
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
        int count = 0;
        int index = 0;
        int index_max = 0;
        double max = -10000;
        foreach (var item in array)
        {
            Console.WriteLine($"Элемент исходного массива под номером {index + 1} есть {item}.");
            sum += item;
            count++;
            if (item > max)
            {
                max = item;
                index_max = index;
            }
            index++;
        }
        index = 0;
        double sredn = sum / count;
        while (index < array.Length)
        {
            if (index > index_max)
            {
                array[index] = Math.Round(sredn, 2);
            }
            Console.WriteLine($"Элемент исходного массива под номером {index + 1} есть {array[index]}.");
            index++;
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
        int count = 0;
        int index = 0;
        foreach (var item in array)
        {
            sum += item;
            count++;
            Console.WriteLine($"Элемент исходного массива под номером {index + 1} есть {item}.");
            index++;
        }
        double sredn = sum / count;
        index = 0;
        double raznost = 100000;
        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - sredn) < raznost)
            {
                raznost = Math.Abs(array[i] - sredn);
                index = i;
            }
        }
        double[] P_array = new double[array.Length + 1];
        for (int i = 0; i <= index; i++)
        {
            P_array[i] = array[i];
        }
        P_array[index + 1] = P;
        Console.WriteLine($"{P_array[index + 1]} = P, индекс {index + 1}.");
        for (int i = index + 1; i < array.Length; i++)
        {
            P_array[i + 1] = array[i];
        }
        array = P_array;
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
        double max = -10000;
        int index_max = 0;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index_max = i;
            }
            Console.WriteLine($"Элемент исходного массива под номером {index + 1} есть {array[index]}.");
        }
        if (index_max != array.Length - 1)
        {
            double min = 1000000;
            int index_min = 0;
            for (int i = index_max + 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index_min = i;
                }
            }
            array[index_min] = max;
            array[index_max] = min;
            Console.WriteLine($"{array[index_min]} и {array[index_max]} были поменены местами.");
        }
        else { Console.WriteLine("Замена невозможна, ибо максимум в самом конце."); }
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
        int index_min = -1;
        int index = 0;
        double min = 100000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && array[i] < min)
            {
                min = array[i];
                index_min = i;
            }
            Console.WriteLine($"Элемент исходного массива под номером {index + 1} есть {array[index]}.");
            index++;
        }
        if (index_min != -1)
        {
            Console.WriteLine($"{array[index_min]} будет удалён.");
            double[] result = new double[array.Length - 1];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (i != index_min)
                {
                    result[j++] = array[i];
                }
            }
            array = result;
        }
        else { Console.WriteLine("Удаление невозможно."); }

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
        double max = -10000;
        int index_max = -1;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index_max = i;
            }
            Console.WriteLine($"Элемент исходного массива под номером {index + 1} есть {array[index]}.");
            index++;
        }
        int index_neg = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                index_neg = i;
                break;
            }
        }
        if (index_max != -1 && index_neg != -1)
        {
            double sum = 0;
            for (int i = index_max + 1; i < array.Length; ++i)
            {
                sum += array[i];
            }
            Console.WriteLine($"{array[index_neg]} и есть первое отрицательное число, {max} и есть максимум, {Math.Round(sum, 4)} и есть сумма.");
            array[index_neg] = Math.Round(sum, 4);
        }
        else { Console.WriteLine("Невозможно."); }
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
        double max = -100000;
        int index_max = -1;
        int index_neg = -1;
        int index = 0;
        int count = 0;
        double neg = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index_max = i;
            }
            if (array[i] < 0 && count == 0)
            {
                neg = array[i];
                index_neg = i;
                count++;
            }
            Console.WriteLine($"Элемент исходного массива под номером {index + 1} есть {array[index]}.");
            index++;
        }
        if (count == 1)
        {
            array[index_max] = neg;
            array[index_neg] = max;
            Console.WriteLine($"{array[index_neg]} и {array[index_max]} были поменены местами.");
        }
        else { Console.WriteLine($"Нет отрицательных."); }
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

        double sum = 0;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            Console.WriteLine($"Элемент исходного массива под номером {index + 1} есть {array[index]}.");
            index++;
        }
        double sredn = sum / array.Length;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sredn)
            {
                count++;
            }
        }
        if (count != 0)
        {
            output = new int[count];
            index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sredn)
                {
                    output[index] = i;
                    Console.WriteLine($"{i} есть элемент искомого массива.");
                    index++;
                }
            }
        }
        else { Console.WriteLine($"Массив пуст"); }
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
        double max0 = -10000;
        double max1 = -10000;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0 && array[i] > max0)
            {
                max0 = array[i];
            }
            else if (i % 2 != 0 && array[i] > max1)
            {
                max1 = array[i];
            }
            Console.WriteLine($"Элемент исходного массива под номером {index + 1} есть {array[index]}.");
            index++;
        }
        int mid = (array.Length % 2 == 0) ? (array.Length / 2) : ((array.Length - 1) / 2);
        if (max0 > max1)
        {
            for (int i = 0; i < mid; i++)
            {
                array[i] = 0;
            }
        }
        else if (max1 > max0)
        {
            for (int i = mid; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }
        else { Console.WriteLine("Максимумы равны."); }
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
        double min = 10000;
        int index = 0;
        int count = 0;
        int index_neg = -1;
        int index_min = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                index_min = i;
            }
            if (array[i] < 0 && count == 0)
            {
                index_neg = i;
                count++;
            }
            Console.WriteLine($"Элемент исходного массива под номером {index + 1} есть {array[index]}.");
            index++;
        }
        switch (index_neg)
        {
            case -1:
                Console.WriteLine("Отрицательных элементов нет.");
                break;
            default:
                if (index_neg < index_min)
                {
                    for (int i = 0; i < array.Length; i = i + 2)
                    {
                        sum += array[i];
                    }
                }
                else
                {
                    for (int i = 1; i < array.Length; i = i + 2)
                    {
                        sum += array[i];
                    }
                }
                break;
        }
        Console.WriteLine($"{sum} и есть искомая сумма.");
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
        double max = -100000;
        int index = 0;
        int index_max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index_max = i;
            }
            Console.WriteLine($"Элемент исходного массива под номером {index + 1} есть {array[index]}.");
            index++;
        }
        if (index_max % 2 != 0)
        {
            index_max--;
        }
        for (int i = 0; i < index_max; i += 2)
        {
            double temp = array[i];
            array[i] = array[i + 1];
            array[i + 1] = temp;
            Console.WriteLine($"Элемент нового массива под номером {i + 1} есть {array[i + 1]}.");
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

        //code here
        int maxLength = 1;
        int index = 0;
        count = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i - 1])
            {
                count++;
            }
            else
            {
                maxLength = Math.Max(maxLength, count);
                count = 1;
            }
            Console.WriteLine($"Элемент исходного массива под номером {index + 1} есть {array[index]}.");
            index++;
        }
        count = Math.Max(maxLength, count);
        Console.WriteLine($"{count} и есть искомое число.");
        //end

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
        int count = 0;

        // code here
        int maxLength_ubuv = 1;
        int maxLength_vozr = 1;
        int index = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i + 1] < array[i])
            {
                count++;
            }
            else
            {
                maxLength_ubuv = Math.Max(maxLength_ubuv, count);
                count = 1;
            }
            Console.WriteLine($"Элемент исходного массива под номером {index + 1} есть {array[index]}.");
            index++;
        }
        maxLength_ubuv = Math.Max(maxLength_ubuv, count);
        int count_2 = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i + 1] > array[i])
            {
                count_2++;
            }
            else
            {
                maxLength_vozr = Math.Max(maxLength_vozr, count_2);
                count_2 = 1;
            }
        }
        maxLength_vozr = Math.Max(maxLength_vozr, count_2);
        count = Math.Max(maxLength_ubuv, maxLength_vozr);
        Console.WriteLine($"{count} и есть искомое число.");
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

        return (X, Y, globalMax, globalMin);
    }
    public double[] Task_3_12(double[] array)
    {
        // code here
        int count_neg = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                count_neg++;
            }
            Console.WriteLine($"Элемент исходного массива под номером {i + 1} есть {array[i]}.");
        }
        if (count_neg > 0)
        {
            double[] array_2 = new double[array.Length - count_neg];
            int index = 0;

            foreach (var item in array)
            {
                if (item >= 0)
                {
                    array_2[index++] = item;
                }
            }
            array = array_2;
        }
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
