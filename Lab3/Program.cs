using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        program.Task_1_1(new double[] {1, 2, 3, 4, 5, 6});
        program.Task_1_15(new double[] { 1, 2, 3, 4, 5, 6 });
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
            sum[i] = first[i] +  second[i];
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

        product = vector1[0] * vector2[0] + vector1[1] * vector2[1] + vector1[2] * vector2[2] + vector1[3] * vector2[3];
        product = Math.Round(product, 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        length = Math.Sqrt(vector[1] * vector[1] + vector[0] * vector[0] + vector[2] * vector[2] + vector[3] * vector[3] + vector[4] * vector[4]);
        // end

        return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double avarage = array.Sum() / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > avarage)
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
        double avarage = array.Sum() / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > avarage)
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
        output = new double[array.Length];
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[count] = array[i];
                count++;
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
            // end

            
        }
        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        // code here
        for (int i = 0; i < array.Length; i+=2)
        {
            even[i/2] = array[i];
        }
        for (int i = 1; i < array.Length; i += 2)
        {
            odd[i / 2] = array[i];
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
            } else
            {
                sum += array[i] * array[i];
            }
        }
        sum = Math.Round(sum, 2);
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i = 0; i < x.Length; i++)
        {   if (x[i]<=0)
            {
                y[i] = double.NaN;
                Console.WriteLine(x[i] + " не число");
            } else
            {
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
                Console.WriteLine(x[i] + " " + y[i]);
            }
            
            //Console.WriteLine(x[i] + " " + y[i]);
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
        int max_index = 0;
        double max = -100000000;
        for (int i = 0; i < array.Length; i++)
        {
            if ((array[i] > max))
            {
                max = array[i];
                max_index = i;
            }
        }
        for (int i = 0; i < max_index; i++)
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
        double avarage = 0;
        double sum = 0;
        int max_index = 0;
        double max = -100000000;
        for (int i = 0; i < array.Length; i++)
        {
            if ((array[i] > max))
            {
                max = array[i];
                max_index = i;
            }
            sum += array[i];
        }
        avarage = Math.Round(sum / array.Length, 2);
        for (int i = max_index+1; i < array.Length; i++)
        {
            array[i] = avarage;
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

        double average = sum / array.Length;
        double closestValue = array[0];
        int closestIndex = 0;
        double minDifference = Math.Abs(array[0] - average);

        for (int i = 1; i < array.Length; i++)
        {
            double difference = Math.Abs(array[i] - average);
            if (difference < minDifference)
            {
                minDifference = difference;
                closestValue = array[i];
                closestIndex = i;
            }
        }

        double[] newArray = new double[array.Length + 1];

        for (int i = 0; i <= closestIndex; i++)
        {
            newArray[i] = array[i];
        }

        newArray[closestIndex + 1] = P;

        for (int i = closestIndex + 1; i < array.Length; i++)
        {
            newArray[i + 1] = array[i];
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
        int max_index = -1;
        double max = -10000000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max_index = i;
                max = array[i];
            }
        }

        int min_index = -1;
        double min = 10000000;
        if (max_index == array.Length -1)
        {
            return array;
        } else
        {
            for (int i = max_index + 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    min_index = i;
                }
            }
            double tmp = array[max_index];
            array[max_index] = array[min_index];
            array[min_index] = tmp;
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
        double min = 100000000000;
        int min_index = -1;
        for (int i = 0; i< array.Length; i++)
        {
            if (array[i] > 0 && array[i] < min)
            {
                min = array[i];
                min_index = i;
            }
        }
        if (min_index == -1)
        {
            return array;
        }
        double[] newArray = new double[array.Length - 1];
        for (int i = 0, j = 0; i < array.Length; i++)
        {
            if (i != min_index)
            {
                newArray[j] = array[i];
                j++;
            }
        }
        //array = newArray;
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
        int min_index = -1;
        for ( int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                min_index = i;
                break;
            }
        }
        if (min_index == -1)
        {
            return array;
        }
        double max = -100000000;
        int max_index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                max_index = i;
            }
        }
        double sum = 0;
        for (int i = max_index+1; i < array.Length; i++)
        {
            sum += array[i];
        }

        array[min_index] = Math.Round(sum,2);
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
        int min_index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                min_index = i;
                break;
            }
        }
        if (min_index == -1)
        {
            return array;
        }
        double max = -100000000;
        int max_index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                max_index = i;
            }
        }
        double tmp = array[min_index];
        array[min_index] = array[max_index];
        array[max_index] = tmp;
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
        double average = 0;
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        //int[] output = new int[array.Length];
        average = sum / array.Length;
        int count = 0;
        for (int i = 0, j = 0; i < array.Length; i++)
        {
            if (array[i] < average)
            {
                count++;
            }
        }
        output = new int[count];
        for (int i = 0, j = 0; i < array.Length; i++)
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
        double max_chet = -1000000000;
        for (int i = 0; i < array.Length; i+=2)
        {
            if (array[i] > max_chet )
            {
                max_chet = array[i];
            }
        }

        double max_nechet = -10000000000;
        for (int i = 1; i < array.Length; i += 2)
        {
            if (array[i] > max_nechet)
            {
                max_nechet = array[i];
            }
        }

        if (max_nechet < max_chet)
        {
            for (int i = 0; i < array.Length/2; i++)
            {
                array[i] = 0;
            }
        } else
        {
            for (int i = array.Length / 2; i < array.Length; i++)
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
        int first_dif = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                first_dif = i;
                break;
            }
        }
        if (first_dif == -1)
        {
            return 0;
        }
        double min = 1000000000;
        int min_index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                min_index = i;
            }
        }

        if (first_dif < min_index)
        {
            for (int i = 0; i < array.Length; i+=2)
            {
                sum += array[i];
            }
        } else
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
        double max = -100000000;
        int max_index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                max_index = i;
            }
        }

        for (int i = 0; i < max_index-1; i+=2)
        {
            double tmp = array[i];
            array[i] = array[i+1];
            array[i+1] = tmp;
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
        int max = 0;
        int current = 0;
        // code here
        for (int i = 0; i < array.Length-1; i++)
        {

            if (array[i] > array[i+1])
            {
                current++;   
                if (current > max)
                {
                    max=current;
                }
            } else
            {
                current = 0;
            }
        }
        count = max+1;
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
        int count = 0;

        // code here
        int max = 0;
        int current = 0;
        // code here
        for (int i = 0; i < array.Length - 1; i++)
        {

            if (array[i] > array[i + 1])
            {
                current++;
                if (current > max)
                {
                    max = current;
                }
            }
            else
            {
                current = 0;
            }
        }


        int maxx = 0;
        current = 0;
        // code here
        for (int i = 0; i < array.Length - 1; i++)
        {

            if (array[i] < array[i + 1])
            {
                current++;
                if (current > maxx)
                {
                    maxx = current;
                }
            }
            else
            {
                current = 0;
            }
        }

        if (max > maxx)
        {
            count = max;
        } else
        {
            count = maxx;
        }
        // end

        return count+1;
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
        int countPositive = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                countPositive++;
            }
        }

        // Создание нового массива для положительных элементов
        double[] newArray = new double[countPositive];
        int index = 0;

        // Заполнение нового массива положительными элементами
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                newArray[index] = array[i];
                index++;
            }
        }
        // end

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
