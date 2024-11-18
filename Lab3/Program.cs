using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection.Emit;
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
        double suma = 0;
        for (int i = 0; i < 6; i++) 
        {
            suma += array[i];
        }
        for (int i = 0; i < 6; i++)
        {
            array[i] = Math.Round(array[i] / suma, 2);
        }
         // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double suma = 0;
        int k = 0;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                suma += array[i];
                k++;
            }        
        }
        double mean = suma / k;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                array[i] = Math.Round(mean,2);
            }
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for(int i = 0; i < 4; i++)
        {
            sum[i] = Math.Round(first[i] + second[i], 1);
            dif[i] = Math.Round(first[i] - second[i], 1);
        }

        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double suma = 0;
        for (int i = 0; i < 5; i++)
        {
            suma += array[i];
        }
        double mean = suma / 5;
        for (int i = 0; i < 5; i++)
        {
            array[i] = Math.Round(array[i] - mean, 2);
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
        double suma = 0;
        for (int i = 0; i < 5; i++)
        {
            suma += Math.Pow(vector[i], 2);
        }
        length = Math.Sqrt(suma);
            // end

            return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double suma = 0;
        for (int i = 0; i < 7; i++)
        {
            suma += array[i];
        }
        double mean = suma / 7;
        for (int i = 0; i < 7; i++)
        {
            if (array[i] > mean)
            {
                array[i] = 0;
            }
        }

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        for (int i = 0; i < 6; i++)
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
        double suma = 0;
        for (int i = 0; i < 8; i++)
        {
            suma += array[i];
        }
        double mean = suma / 7;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > mean)
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
        for (int i = 0; i < 10; i++)
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
        // code here
        int lenght = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                lenght++;
            }
        }
        double[] output = new double[lenght];
        int index = 0; // Индекс для заполнения выходного массива
        for (int j = 0; j < 10; j++)
        {
            if (array[j] > 0)
            {
                output[index] = array[j];
                index++;
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
        for(int i = 0; i < 8; i++)
        {
            if (array[i] < 0)
            {
                if (i > index)
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
        int index1 = 0;
        int index2 = 0;
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                even[index1] = array[i];
                index1++;
            }
            else
            {
                odd[index2] = array[i];
                index2++;
            }
        }
            // end

            return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i < 11; i++)
        {
            if (array[i] < 0)
            {
                break;
            }

            sum += Math.Pow(array[i], 2);
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
            if(x[i] > 0)
            {
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            }
            else
            {
                y[i] = double.NaN; //назначает элементу массива y значение, которое обозначает "не число" (Not a Number, NaN) 
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

        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        int lenght = array.Length;
        double max_el = -1000000000;
        int index = 0;
        for (int i = 0; i < lenght; i++)
        {
            if (array[i] > max_el)
            {
                max_el = array[i];
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

        // end

        return array;
    }
    public double[] Task_2_4(double[] array)
    {
        // code here
        double sum = 0;
        int lenght = array.Length;
        double max_el = -1000000000;
        int index = 0;
        for (int i = 0; i < lenght; i++)
        {
            if (array[i] > max_el)
            {
                max_el = array[i];
                index = i;
            }
            sum += array[i]; 
        }
        double main = 0;
        main = sum / lenght;
        for (int i = index + 1; i < lenght; i++)
        {
            array[i] = main;
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
        double sum = 0;
        int length = array.Length;

        for (int i = 0; i < length; i++)
        {
            sum += array[i];
        }

        double average = sum / length;
        double minDiff = 1000000000000;
        int index = -1; 

        for (int i = 0; i < length; i++)
        {
            double dif = Math.Abs(array[i] - average);
            if (dif < minDiff)
            {
                minDiff = dif;
                index = i; 
            }
        }
        double[] result = new double[length + 1];

        for (int i = 0; i <= index; i++)
        {
            result[i] = array[i];
        }

        // Вставляем элемент P
        result[index + 1] = P;

        for (int i = index + 1; i < length; i++)
        {
            result[i + 1] = array[i];
        }

        array = result;

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
        int length = array.Length;
        double max_el = double.MinValue;
        double min_el = double.MaxValue;
        int index_max =-1;
        int index_min = -1;

        for (int i = 0; i < length; i++)
        {
            if (array[i] > max_el)
            {
                max_el = array[i];
                index_max = i;
            }
        }

        for(int i = index_max + 1; i < length; i++)
        {
            if (array[i] < min_el)
            {
                min_el = array[i];
                index_min = i;
            }
        }
        if (index_max != -1 && index_min != -1)
        {
            double temp = array[index_max];
            array[index_max] = array[index_min];
            array[index_min] = temp;
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
        int lenght = array.Length;
        double min_el = double.MaxValue;
        int index = -1;
        for (int i = 0; i < lenght; i++)
        {
            if (array[i] > 0) 
            {
                if (array[i] < min_el)
                {
                    min_el = array[i];
                    index = i;
                }
            }
        }
        if (index == -1)
        {
            return array;
        }

        double[] result = new double[lenght - 1];
        for (int i = 0, j = 0; i < lenght; i++)
        {
            if (i != index) // Пропускаем элемент с минимальным положительным значением
            {
                result[j] = array[i];
                j++;
            }
        }
        
        // end

        return result;
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
        int lenght = array.Length;
        int index_minus = -1;
        double max_el = double.MinValue;
        int index_max = -1;
        double suma = 0;
        for (int i = 0; i < lenght; i++)
        {
            if (array[i] < 0)
            {               
                index_minus = i;
                break;
            }
        }
        for (int i = 0; i < lenght; i++)
        {
            if (array[i] > max_el)
            {
                max_el = array[i];
                index_max = i;
            }
        }
        for (int i = index_max + 1; i < lenght; i++)
        {
            suma += array[i];
        }
        
        if (index_minus != -1)
        {
            array[index_minus] = suma;
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
        int lenght = array.Length;
        int index_minus = -1;
        double max_el = double.MinValue;
        int index_max = -1;
        double suma = 0;
        for (int i = 0; i < lenght; i++)
        {
            if (array[i] < 0)
            {
                index_minus = i;
                break;
            }
        }
        for (int i = 0; i < lenght; i++)
        {
            if (array[i] > max_el)
            {
                max_el = array[i];
                index_max = i;
            }
        }

        if (index_minus != -1)
        {
            double temp = array[index_minus];
            array[index_minus] = array[index_max];
            array[index_max] = temp;
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
        int length = array.Length;
        double suma = 0;
        for (int i = 0; i < length; i++)
        {
            suma += array[i];
        }
        double average = suma / length;

        int countM = 0;
        for (int i = 0; i < length; i++)
        {
            if (array[i] < average)
            {
                countM++;
            }
        }

        output = new int[countM];
        for (int i = 0, j = 0; i < length; i++)
        {
            if (array[i] < average)
            {
                output[j] = i;
                j++;
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
        int length = array.Length;
        double max_even = 0;
        double max_odd = 0;
        for (int i = 0; i < length; i+=2)
        {
            if (array[i] > max_even)
            {
                max_even = array[i];
            }
        }
        for (int i = 1; i < length - 1; i += 2)
        {
            if (array[i] > max_odd)
            {
                max_odd = array[i];
            }
        }
        if (max_even > max_odd)
        {
            for (int i = 0; i < length / 2; i++)
            {
                array[i] = 0;
            }
        }
        else
        {
            for (int i = length / 2; i < length; i++)
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
        int length = array.Length;
        double index_minus = -1;
        double min_el = double.MaxValue;
        int index_min = -1;

        for (int i = 0; i < length; i++)
        {
            if (array[i] < min_el)
            {
                min_el = array[i];
                index_min = i;
            }
        }
        for (int i = 0; i < length; i++)
        {
            if (array[i] < 0)
            {
                index_minus = i;
                break;
            }
        }
        if (index_minus < index_min && index_minus != -1)
        {
            for (int i = 0; i < length; i += 2)
            {
                sum += array[i];
            }
        }
        else
        {
            for (int i = 1; i < length; i += 2)
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
        double max_el = double.MinValue;
        int length = array.Length;
        int count = 1;

        for (int i = 0; i < length; i++)
        {
            if (array[i] > max_el)
            {
                max_el = array[i];
                count = 1; // Обновляем количество максимальных элементов
            }
            else if (array[i] == max_el)
            {
                count++;
            }
        }
        output = new int[count];
        for (int i = 0, j = 0; i < length; i++)
        {
            if (array[i] == max_el)
            {
                output[j] = i;
                j++;
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
        double[] output = new double[array.Length];
        double m = double.MinValue, sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > m)
            {
                m = array[i];
            }
            output[i] = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            sum += output[i];
            if (output[i] == m)
            {
                output[i] = sum - m;
            }
        }
        return output;
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
        int length = array.Length;
        double[] result = new double[length];
        int j = 0;

        for (int i = 0; i < length; i++)
        {
            if (array[i] >= 0)
            {
                result[j] = array[i];
                j++;
            }
        }
        
        for (int i = 0; i < length; i++)
        {
            if (array[i] < 0)
            {
                result[j] = array[i];
                j++;
            }
        }
       
        for (int i = 0; i < length; i++)
        {
            array[i] = result[i];
        }

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
        double[] temp = new double[array.Length];
        for (int i = 0; i < array.Length / 2; i++)
        {
            temp[2 * i] = array[i];
            temp[2 * i + 1] = array[i];
        }
        array = temp;
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
        int length = array.Length;
        double[] array2 = new double[length];
        int k = 0; //указатель
      
        for (int i = 0; i < length; i++)
        {
            bool state = false;
            for (int j = 0; j < k; j++)
            {
                if (array2[j] == array[i])
                {
                    state = true;
                }
            }
            if (state == false)
                {
                    array2[k] = array[i];
                    k++;
                }
            
        }
        double[] array3 = new double[k];
        for (int i = 0; i < k; i++)
        {
            array3[i] = array2[i];
        }
        // end
        Console.WriteLine(array);
        Console.WriteLine(array2);
        return array3;
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