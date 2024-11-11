using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
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
        /* Найти сумму элементов одномерного массива размера 6. Разделить каждый
элемент исходного массива на полученное значение. Результат получить в том же
массиве.*/
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        for (int j = 0; j < array.Length; j++)
        {
            array[j] = Math.Round(array[j] / sum, 2);
        }
        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        /* 
         Положительные элементы массива размера 8 заменить средним арифметическим
среди положительных элементов.
         */
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
        double srArifm = sum / count;

        for (int i = 0; i < array.Length; i++) 
        {
            if (array[i] > 0)
            {
                array[i] = Math.Round(srArifm, 2);
            }
        }
        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        /*
         Вычислить сумму и разность двух одномерных массивов размера 4. (Суммой
(разностью) двух массивов одинакового размера называется третий массив такого
же размера, каждый элемент которого равен сумме (разности) соответствующих
элементов исходных массивов.)
        */
        double[] sum = new double[first.Length], dif = new double[first.Length];

        for (int i = 0; i < 4; i++)
        {
            sum[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = Math.Round(first[i] - second[i], 2);
        }   

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        /*
         Найти среднее значение элементов массива размера 5. Преобразовать исходный
массив, вычитая из каждого элемента полученное значение. 
         */
        double sum = 0;
        foreach (double i in array)
        {
            sum += i;
        }
        double averageValue = sum / array.Length;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - averageValue, 2);
        }
        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        /* 
         Вычислить скалярное произведение двух векторов размера 4. (Скалярным
произведением называется сумма попарных произведений соответствующих
элементов массивов.)
         */
        double product = 0;

        for (int i = 0; i < 4; i++)
        {
            product += vector1[i] * vector2[i];
        }
        product = Math.Round(product, 2);
        return product;
    }
    public double Task_1_6(double[] vector)
    {
         
        // Вычислить длину вектора размера 5.
         
        double length = 0;

        foreach (double x in vector)
        {
            length += x * x;
        }
        length = Math.Sqrt(length);

        return Math.Round(length, 2); 
    }
    public double[] Task_1_7(double[] array)
    {
        /* 
        Элементы одномерного массива размера 7, большие среднего значения
элементов массива, заменить на 0. */
        double sum = 0;
        foreach (double elem in  array)
        {
            sum += elem;
        }
        double AverageValue = sum / array.Length;   

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > AverageValue)
            {
                array[i] = 0;
            }
        }
        return array;
    }
    public int Task_1_8(double[] array)
    {
        /* 
         Подсчитать количество отрицательных элементов заданного одномерного
массива размера 6.
         */

        int count = 0;

        foreach (double elem in array)
        {
            if (elem < 0)
            {
                count++;
            }
        }

        return count;
    }
    public int Task_1_9(double[] array)
    {
        /* 
         Определить, сколько элементов заданного одномерного массива размера 8
больше среднего значения элементов этого массива.
         */
        int count = 0;
        double sum = 0;
        foreach (double elem in array)
        {
            sum += elem;
        }
        double avarageValue = sum / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > avarageValue)
            {
                count += 1;
            }
        }
        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        /*
         Дан одномерный массив размера 10 и два числа P и Q (P < Q). Определить,
сколько элементов массива заключено между P и Q. 
         */
        int count = 0;

        foreach (double elem in array)
        {
            if (elem > P && elem < Q)
            {
                count += 1;
            }
        }

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        /* Сформировать массив из положительных элементов заданного массива размера
10. */
        // double[] output = null;
        int count = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                count++;
            }
        }
        double[] output = new double[count];
        int n = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                output[n] = array[i];
                n++;

            }
        }

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        /* Определить значение и номер последнего отрицательного элемента массива
        размера 8. */
        double value = 0;
        int index = -1;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] < 0)
            {
                value = array[i];
                index = i;
                break;
            }
        }

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        /* 
         Дан массив размера 10. Сформировать два массива размера 5, включая в первый 
        массив элементы исходного массива с четными индексами, во второй – с нечетными.
         */
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];
        int nEven = 0;
        int nOdd = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[nEven++] = array[i];           
               
            }
            else if (i % 2 != 0)
            {
                odd[nOdd++] = array[i];     
            }
        }

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        /*
         Найти сумму квадратов элементов, расположенных до первого отрицательного элемента массива размера 11.
         */
        double sum = 0;
        foreach (double x in array)
        {
            if (x < 0)
            {
                break;
            }
            sum += x * x;
        }

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[0];
        /*
        Задан массив х размера 10. Вычислить значения функции у = 0,5lnx при значениях аргумента, заданных в
        массиве х. Вычисленные значения поместить в массив y. Вывести массивы х и y в виде двух столбцов
        }*/
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
        

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        /*
        Минимальный элемент заданного одномерного массива увеличить в два раза.
         */
        double min = array[0];
        int n = 0;
        for (int i = 0; i <  array.Length; i++)
        {
            if (min > array[i])
            {
                min = array[i];
                n = i;
            }
        }
        array[n] = 2 * min;

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        return sum;
    }
    public double[] Task_2_3(double[] array)
    {
        
        double min = array[0];
        int n = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                n = i;
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (i < n && array[i] >= 0) 
                array[i] *= 2;
            else if (i < n && array[i] < 0)
                array[i] /= 2;
            Console.WriteLine(array[i]);    
        }
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
        /*Задан одномерный массив. Сформировать другой одномерный массив из отрицательных
         элементов, расположенных между максимальным и минимальным элементами исходного массива. */
        double max = array[0];
        double min = array[0];
        int maxIndex = -1, minIndex = -1;
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
        }
        double[] array1 = array;
        if (minIndex < maxIndex)
        {
            for (int i = minIndex + 1, j = 0; i < maxIndex; i++, j++)
            {
                if (array1[i] < 0)
                {
                    array[j] = array[i];    
                }
            }
        }
        else
        {
            for (int i = maxIndex + 1, j = 0; i < minIndex; i++, j++)
            {
                if (array1[i] < 0)
                {
                    array[j] = array[i];
                }
            }
        }

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
        /* Увеличить в 2 раза элемент, расположенный непосредственно после максимального элемента массива. */
        double max = array[0];
        int maxIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
                maxIndex = i;
                
            }
        }

        if (maxIndex + 1 < array.Length)
            {
            if (array[maxIndex + 1] >= 0)
            {
                array[maxIndex + 1] *= 2;
            }
            else
            {
                array[maxIndex + 1] /= 2;
            }
        }
       
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
        /* Найти среднее арифметическое значение элементов массива, расположенных 
         между минимальным и максимальным элементами массива. */
       
        double average = 0;
        double min = array[0];
        double max = array[0];
        int minIndex = 0, maxIndex = 0;

    
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }

            if (array[i] < min)
            {
                min = array[i];
                minIndex = i;
            }
        }


        if (minIndex > maxIndex)
        {
            int temp = minIndex;
            minIndex = maxIndex;
            maxIndex = temp;
        }


        double sum = 0;
        int count = 0;
        for (int i = minIndex + 1; i < maxIndex; i++)
        {
            sum += array[i];
            count++;
        }

   
        if (count > 0)
            average = sum / count;

        return Math.Round(average, 2);
    }
    public double[] Task_2_10(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_11(double[] array, double P)
    {
        /* Включить заданный элемент P после последнего положительного элемента массива. */
        int index = -1;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] > 0)
            {
                index = i;
                break;
            }
        }

        double[] newArray = new double[array.Length + 1];

        if (index == -1)
        {

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            newArray[newArray.Length - 1] = P;

            return newArray;
        }


        for (int i = 0; i <= index; i++)
        {
            newArray[i] = array[i];
        }

        newArray[index + 1] = P;


        for (int i = index + 1; i < array.Length; i++)
        {
            newArray[i + 1] = array[i];
        }

        return newArray;
    }


    public double[] Task_2_12(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_13(double[] array)
    {
        /* Максимальный элемент массива среди элементов с четными индексами заменить значением его индекса. */
        double max = array[0];
        int maxindex = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxindex = i;
            }
        }
        array[maxindex] = maxindex;

        return array;
    }
    public double[] Task_2_14(double[] array)
    {
        /* Заданы массивы А и В, содержащие n и m элементов соответственно. 
        Вставить массив В между k-м и (k + 1)-м элементами массива А (k задано). */
        

        return array;
    }
    public double[] Task_2_15(double[] A, double[] B, int k)
    {
        /*Заданы массивы А и В, содержащие n и m элементов соответственно.
        Вставить массив В между k-м и (k + 1)-м элементами массива А (k задано). */
        double[] output = null;
        double[] array = new double[A.Length + B.Length];
        int h = 0, j = 0;
        if (k > A.Length - 1)
            return A;
        else
        {
            for (int i = 0; i < A.Length + B.Length; i++)
            {
                if (i <= k)
                {
                    array[i] = A[h];
                    h++;
                }
                else if (i > k && i <= B.Length + k)
                {
                    array[i] = B[j];
                    j++;
                }
                else
                {

                    array[i] = A[h];
                    h++;
                }
            }

            return array;
        }
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
        /* Если максимальный элемент расположен до минимального, то найти среднее арифметическое 
        положительных элементов массива, иначе - среднее арифметическое отрицательных элементов массива. */
        double average = 0;
        double max = array[0], min = array[0];
        double sum1 = 0, sum2 = 0;
        int count1 = 0, count2 = 0;
        int maxIndex = 0, minIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
            if (array[i] < min)
            {
                min = array[i];
                minIndex = i;
            }
            if (array[i] > 0)
            {
                sum1 += array[i];
                count1++;
            }
            else if (array[i] < 0)
            {
                sum2 += array[i];
                count2++;
            }
        }
        
        if (maxIndex < minIndex && count1 != 0) average = sum1 / count1;

        else if (maxIndex > minIndex && count2 != 0) average = sum2 / count2;

        return Math.Round(average, 2);
    }
    public double[] Task_2_18(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_19(double[] array)
    {
        /* Если максимальный элемент массива больше суммы элементов массива, заменить его нулем, иначе – удвоить. */
        double max = array[0];
        double sum = 0;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index = i;
            }
            sum += array[i];
        }
        if (max > sum) array[index] = 0;
        else
        {
            if (max > 0) array[index] *= 2;
            else array[index] /= 2;
        }

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

        // end

        return array;
    }
    public double[] Task_3_3(double[] array)
    {
        /* В одномерном массиве поменять местами соседние элементы (1-й со 2-м, 3-й с 4-м и т.д.),
         распложенные перед максимальным элементом массива. */
        double max = array[0];
        int index = 0, count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index = i;
               
            }
        }
        for (int i = 0; i < index; i += 2)
        {
            if (i + 1 < index)
            {
                double temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
            
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
        /* В массиве А найти максимальное количество следующих подряд упорядоченных по убыванию элементов. */
        int maxCount = 0;
        int currentCount = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] > array[i])
                currentCount++; 
            else
                currentCount = 1;

            if (currentCount > maxCount)
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
        /* В заданном массиве определить длину самой большой упорядоченной 
        (по возрастанию или по убыванию) последовательности. */
        int maxCount1 = 0;
        int maxCount2 = 0;
        int currentCount1 = 0;
        int currentCount2 = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] > array[i])
                currentCount1++;
            else
                currentCount1 = 1;

            if (currentCount1 > maxCount1)
                maxCount1 = currentCount1;


            if (array[i - 1] < array[i])
                currentCount2++;
            else
                currentCount2 = 1;
            if (currentCount2 > maxCount2)
                maxCount2 = currentCount2;
        }

        if (maxCount1 > maxCount2) return maxCount1;
        else return maxCount2;

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
        /* Из массива размера 12 удалить все отрицательные элементы. */
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0) count++;
        }
        double[] newArray = new double[count];
        int j = 0;
        foreach (double elem  in array)
        {
            if (elem >= 0)
            {
                newArray[j++] = elem;
            }
        }

        return newArray;
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