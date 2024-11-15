using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        program.Task_2_6(new double[] { 0, 1.5, -1, -3, -2.2, -0.5, 6 }, 2.3);
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
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] / sum, 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sum = 0;
        double n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                sum += array[i];
                n += 1;
            }

        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = Math.Round(sum / n, 2);
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
            sum[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = Math.Round(first[i] - second[i], 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sum = 0;
        double n = 0;
        for (int i = 0; i < array.Length; i++)
        {

            sum += array[i];
            n += 1;


        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - sum / n, 2);
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
            product += Math.Round(vector1[i] * vector2[i], 2);
        }
        // end
        product = Math.Round(product, 2);
        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < vector.Length; i++)
        {
            length += Math.Round(vector[i] * vector[i], 2);
        }
        // end
        length = Math.Round(Math.Sqrt(length), 4);
        return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sum = 0;
        double n = 0;
        for (int i = 0; i < array.Length; i++)
        {

            sum += array[i];
            n += 1;


        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sum / n)
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
        double n = 0;
        for (int i = 0; i < array.Length; i++)
        {

            sum += array[i];
            n += 1;


        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sum/n)
            {
                count++;
            }
        }
        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < Q && array[i] > P)
            {
                count++;
            }
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {

        int count = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                count++;
            }
        }
        double[] output = new double[count];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[j] = array[i];
                j += 1;
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
        for (int i = array.Length-1; i >0; i--)
        {
            if (array[i] < 0)
            {
                return (array[i], i);
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
        int j = 0;
        for (int i = 0; i < array.Length; i+=2)
        {
            even[j] = array[i];
            odd[j] = array[i+1];
            j += 1;
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] < 0)
            {
                return sum;
            }
            sum += array[i]*array[i];

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
            else
            {
                y[i] =double.NaN;
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
        int index_min = -1;
        double max_e = -9999999;
        for(int i = array.Length-1; i >= 0; i--)
        {
            Console.WriteLine(array[i]);
            if (array[i] > max_e)
            {
                max_e = array[i];
                index_min = i;
            }
        }
        Console.WriteLine("5555");
        Console.WriteLine(max_e);
        for(int i= 0; i < index_min; i++)
        {
            sum += array[i];
        }


        // code here

        // end
        Console.WriteLine(sum);
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
        int index_min = -1;
        double max_e = -9999999;
        for (int i = array.Length-1; i >= 0; i--)
        {
            Console.WriteLine(array[i]);
            if (array[i] > max_e)
            {
                max_e = array[i];
                index_min = i;
            }
            sum += array[i];
        }
        Console.WriteLine("5555");
        Console.WriteLine(max_e);
        for (int i = index_min + 1; i < array.Length; i++)
        {
            array[i] = Math.Round(sum / array.Length,2);
            Console.WriteLine(array[i]);
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
        for(int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        int el_most_simular = -1;
        double dif_most_sim = 999999;

        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - (sum/array.Length)) < dif_most_sim)
            {
                dif_most_sim = Math.Abs(array[i] - (sum/array.Length));
                el_most_simular = i;
            }
        }

        double[] array2 = new double[array.Length + 1];
        int index = 0;

        for(int i = 0; i < array.Length + 1; i++)
        {
            if(i < (el_most_simular+1))
            {
                array2[i] = array[i];
            }
            else if(i == (el_most_simular+1))
            {
                array2[i] = P;
            }
            else
            {
                array2[i] = array[i - 1];
            }
        }

        for(int i = 0; i < array2.Length; i++)
        {
            Console.WriteLine(array2[i]);
        }
        // end

        return array2;
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
        int ind_max = -1;
        double max_el = -999999999;
        for(int i = 0; i < array.Length; i++)
        {
            if(max_el < array[i])
            {
                max_el = array[i];
                ind_max = i;
            }
        }


        int ind_min = -1;
        double min_el = 99999999;
        for (int i = ind_max; i < array.Length; i++)
        {
            if (min_el > array[i])
            {
                min_el = array[i];
                ind_min = i;
            }
        }
        array[ind_max] = min_el;
        array[ind_min] = max_el;
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
        double min_el = 9999999;
        int ind_min = -1;
        for(int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
            if (min_el > array[i] && array[i] > 0)
            {
                min_el = array[i];
                ind_min = i;
            }
        }
        if(ind_min == -1)
        {
            return array;
        }
        double[] newA = new double[array.Length - 1];
        for(int i =0; i < array.Length; i++)
        {
            Console.WriteLine(i);
            if(i < ind_min)
            {
                newA[i] = array[i];
                Console.WriteLine("1111");
            }
            else if(i == ind_min)
            {
                Console.WriteLine("No");
                continue;

            }
            else
            {
                Console.WriteLine("---");
                newA[i-1] =  array[i];
            }
        }
        
        // end

        return newA;
    }
    public double[] Task_2_11(double[] array, double P)
    {
        // code here

        // end

        return array;
    }
    public (double, int) find_max(double[] array)
    {
        double max_el = -9999999;
        int index_max = -1;
        for(int i = 0; i < array.Length; i++)
        {
            if(max_el < array[i])
            {
                max_el = array[i];
                index_max = i;
            }
        }
        return (max_el, index_max);
    }


    public (double, int) find_min(double[] array)
    {
        double min_el = 9999999;
        int index_min = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (min_el > array[i])
            {
                min_el = array[i];
                index_min = i;
            }
        }
        return (min_el, index_min);
    }


    public double[] Task_2_12(double[] array)
    {
        // code here
        double sum_after_max = 0;

        double max_el = -9999999;
        int index_max = -1;
        (max_el, index_max) = find_max(array);
        // end
        Console.WriteLine("ma");
        Console.WriteLine((max_el, index_max));
        int first_minus = -1;
        for(int i = 0; i<array.Length; i++)
        {
            Console.WriteLine(array[i]);
            if (array[i] < 0 && first_minus == -1)
            {
                first_minus = i;
            }
        }
        Console.WriteLine("00000");
        for (int i = index_max +1; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
            sum_after_max += array[i];
        }
        Console.WriteLine("f");
        Console.WriteLine(first_minus);
        Console.WriteLine(sum_after_max);
        sum_after_max = Math.Round(sum_after_max, 2);
        if(first_minus != -1)
        {
            array[first_minus] = sum_after_max;
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
        double max_el = -9999999;
        int index_max = -1;
        (max_el, index_max) = find_max(array);
        int first_minus = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                first_minus = i;
                break;
            }
        }
        // end
        if (first_minus == -1)
        {
            return array;
        }
        double temp = array[index_max];
        array[index_max] = array[first_minus];
        array[first_minus] = temp;
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
        for(int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        int c = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sum/array.Length)
            {
                c++;
            }
        }
        int[] output = new int[c];
        c = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sum/array.Length)
            {
                output[c] = i;
                c ++;
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
        double even_max = -999999, odd_max = -999999;
        for(int i =0; i<array.Length; i++)
        {
            if(i%2 == 0)
            {
                if (array[i] > even_max)
                {
                    even_max = array[i];
                }
            }
            else
            {
                if (array[i] > odd_max)
                {
                    odd_max = array[i];
                }
            }
        }
        if(odd_max < even_max)
        {
            for(int i = 0; i<array.Length/2; i+=1)
            {
                array[i] = 0;
            }
        }
        else
        {
            for (int i = array.Length/2; i<array.Length; i+=1)
            {
                array[i] = 0;
            }
        }


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
        

        double min_el = -9999999;
        int index_min = -1;
        (min_el, index_min) = find_min(array);
        Console.WriteLine("rrrt");
        for(int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
        Console.WriteLine("mi");
        Console.WriteLine((min_el, index_min));
        int first_min = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                first_min = i;
                break;
            }
        }
        Console.WriteLine("fisrt");
        Console.WriteLine(first_min);
        int start = 0;
        if(first_min == -1)
        {
            return 0;
        }
        Console.WriteLine((first_min, index_min));
        if (first_min < index_min)
        {
            start = 0;
        }
        else
        {
            start = 1;
        }
        Console.WriteLine(start);
        double sum = 0;
        for (int i = start; i<array.Length; i+=2)
        {
            Console.WriteLine(array[i]);
            sum += array[i];
        }
        // end

        Console.WriteLine(Math.Round(sum, 2));
        return Math.Round(sum,2);
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
        double max_el = -9999999;
        int index_max = -1;
        (max_el, index_max) = find_max(array);

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }

        Console.WriteLine("index_max");
        Console.WriteLine(index_max);
        Console.WriteLine("check");
        if(index_max % 2 == 1)
        {
            index_max = index_max-1;
        }


        for (int i = 0; i < index_max; i+=2)
        {
            double temp = array[i];
            array[i] = array[i + 1];
            array[i + 1] = temp;
        }

        for(int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
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
        double last = 999999;
        int max_go = -9;
        int cur = 0;

        for(int i = 0; i < array.Length; i++)
        {
            if(last > array[i])
            {
                if(last != 999999 && cur == 0)
                {
                    cur += 1;
                }
                cur += 1;
                last = array[i];
            }
            else
            {
                if(cur > max_go)
                {
                    max_go = cur;
                }
                cur = 0;
                last = array[i];
            }
            Console.WriteLine((array[i], cur, last));
        }
        // code here

        // end

        return max_go;
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
        int maxLength = 1; 
        int currentLengthAsc = 1; 
        int currentLengthDesc = 1; 

        for (int i = 1; i < array.Length; i++)
        {
            
            if (array[i] > array[i - 1])
            {
                currentLengthAsc++;
                currentLengthDesc = 1; 
            }
            
            else if (array[i] < array[i - 1])
            {
                currentLengthDesc++;
                currentLengthAsc = 1;
            }
            else 
            {
                currentLengthAsc = 1;
                currentLengthDesc = 1;
            }

            
            maxLength = Math.Max(maxLength, Math.Max(currentLengthAsc, currentLengthDesc));
        }

        return maxLength;

        
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
        int c = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] < 0)
            {
                c += 1;
            }

        }
        Console.WriteLine(c);
        double[] n = new double[array.Length - c];
        c = 0;
        for(int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);

            if (array[i] < 0)
            {
                c += 1;
            }
            else
            {
                n[i - c] = array[i];
            }
        }
        // end

        return n;
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
