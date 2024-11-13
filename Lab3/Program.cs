using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Net.Http.Headers;
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
        double summm = 0;
        for(int i = 0; i < 6; i++)
        {
            summm += array[i];
        }
        for (int j = 0; j < 6; j++)
        {
            array[j] = Math.Round(array[j] / summm, 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double summ = 0;
        double num = 0;
        for (int j = 0; j < 8; j++)
        {
            if (array[j] > 0)
            {
                summ += array[j];
                num++;
            }
        }
        summ /= num;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                array[i] = Math.Round(summ, 2);
            }
            
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i < 4; i++)
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
        double summ = 0;
        double num = 0;
        for (int i = 0; i < 5; i++)
        {
            summ += array[i];
            num++;
        }
        summ /= num;
        for (int j = 0; j < 5; j++)
        {
            array[j] = Math.Round(array[j] - summ, 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for(int i = 0; i < 4; i++)
        {
            product += (vector1[i] * vector2[i]);
            
        }
        // end

        return Math.Round(product, 2);
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < 5; i++)
        {
            length += vector[i] * vector[i];
        }
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 2);
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double summm = 0;
        double num = 0;
        for (int i = 0; i < 7; i++)
        {
            summm += array[i];
            num++;
        }
        summm /= num;
        for (int i = 0; i < 7; i++)
        {
            if (array[i] > summm)
            {
                array[i] = 0;
            } 
        }
        summm /= num;
        // end

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
        double summm = 0;
        double num = 0;
        for (int i = 0; i < 8; i++)
        {
            summm += array[i];
            num++;
        }
        summm /= num;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > summm)
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
        double[] output = new double[10];

        // code here
        int j = 0;
        for (int i = 0; i < array.Length; i++)
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
        for (int i = 0; i < 8; i++)
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
        double[] odd = new double[array.Length/2];

        // code here
        int j = 0;
        int n = 0;
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                even[j] = array[i];
                j++;
            }
            if (i % 2 == 1)
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
        for (int i = 0; i < 11; i++)
        {
            if(array[i] < 0)
            {
                break;
            }
            else
            {
                sum += array[i] * array[i];
            }
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
            if (x[i] != 0) 
            {
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            }
            else
            {
                y[i] = double.NaN;
            }
            
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here аааа
        double num = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < num)
            {
                num = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == num)
            {
                array[i] = num * 2;
            }
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
        double num = array[0];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < num)
            {
                num = array[i];
                j = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (i < j)
            {
                if(array[i] < 0)
                {
                    array[i] = array[i] / 2.0;
                }
                else
                {
                    array[i] = array[i] * 2;
                }
                
            }
            
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
        // code here fff
        
        double max = 0;
        int i_min = 0;
        int i_max = 0;
        double min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                i_min = i;
            }
            else if (array[i] >= max)
            {
                max = array[i];
                i_max = i;
            }
        }
        double[] num = new double[i_max - i_min - 1];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(i > i_min && i < i_max)
            {
                num[j] = array[i];
                j++;
            }
        }
        // end 13

        return num;
    }
    public double[] Task_2_6(double[] array, double P)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_7(double[] array)
    {
        // code here ffff
        double max = 0;
        int i_max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] > max)
            {
                max = array[i];
                i_max = i;
            }
        }
        if (i_max + 1 <= array.Length - 1)
        {
            if (array[i_max + 1] < 0)
            {
                array[i_max + 1] = array[i_max + 1] / 2.0;
            }
            else
            {
                array[i_max + 1] = array[i_max + 1] * 2.0;
            }
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

        // code here fff
        double max = 0;
        int i_min = 0;
        int i_max = 0;
        double min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                i_min = i;
            }
            else if (array[i] >= max)
            {
                max = array[i];
                i_max = i;
            }
        }
        int j = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(i_max < i_min)
            {
                if (i > i_max && i < i_min)
                {
                    average += array[i];
                    j++;
                }
            }
            else
            {
                if (i < i_max && i > i_min)
                {
                    average += array[i];
                    j++;
                }
            }
            
        }
        if (j != 0)
        {
            average /= j;
        }
        
        // end

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
        // code here fff
        double pos = -1;
        int i_pos = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                pos = array[i];
                i_pos = i;
            }

        }
        double[] total = new double[array.Length + 1];
        if (pos != -1)
        {
            for (int i = 0; i < total.Length; i++)
            {
                if (i <= i_pos)
                {
                    total[i] = array[i];
                }
                else if (i_pos + 1 == i) 
                {
                    total[i_pos + 1] = P;
                }
                else
                {
                    total[i + 1] = array[i];
                }

            }
        return total;
        }
        else
        {
            return array;
        }
        // end

        
    }
    public double[] Task_2_12(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_13(double[] array)
    {
        // code here ffff
        double max = 0;
        int i_max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    i_max = i;
                }
            }
        }
        array[i_max] = i_max;
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
        double[] output = new double[A.Length + B.Length] ;

        // code here ffff
        for (int i = 0; i < A.Length; i++)
        {
            if(i < k)
            {
                output[i] = A[i];
            }
            else if (i == k)
            {
                output[i] = A[i];
                for (int j = 0; j < B.Length; j++)
                {
                    output[i + j + 1] = B[j];
                }
            }
            else
            {
                output[i + B.Length] = A[i];
            }
        }
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

        // code here fffff
        double max = 0;
        int i_min = 0;
        int i_max = 0;
        double min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                i_min = i;
            }
            else if (array[i] >= max)
            {
                max = array[i];
                i_max = i;
            }
        }
        double pol = 0;
        int i_pol = 0;
        double otr = 0;
        int i_out = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                pol += array[i];
                i_pol++;
            }
            else if(array[i] > 0)
            {
                otr += array[i];
                i_out++;
            }
        }
        if (i_max < i_min && i_pol != 0)
        {
            average = pol / i_pol;
        }
        else if (i_max > i_min && i_out != 0)
        {
            average = otr / i_out;
        }
        // end

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
        // code here fffff
        double summm = 0;
        double max = array[0];
        int i_max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                i_max = i;
            }
            summm += array[i];
        }
        if(max > summm)
        {
            array[i_max] = 0;
        }
        else
        {
            array[i_max] = array[i_max] * 2;
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

        // code here ffff
        int num_max = 0;
        double max = -1000000000;
        int flag = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > max && flag == 0)
            {
                flag = 1;
                max = array[i];
                num_max = 1;
            }
            else if (array[i] == max && flag == 1)
            {
                num_max++;
            }
            else if (array[i] > max && flag == 1)
            {
                flag = 1;
                max = array[i];
                num_max = 1;
            }
        }
        int[] total = new int[num_max];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        { 
            if(array[i] == max)
            {
                total[j] = i;
                j++;
             }
        }
        // end

        return total;
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
        // code here ffff
        double max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        double total = 0;
        double r = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                r = array[i];
                array[i] = total;
                total += r;
            }
            else
            {
                total += array[i];
            }
        }
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

        // end

        return count;
    }
    public double[] Task_3_7(double[] array)
    {
        // code here ffff
        int otr = 0;
        int pol = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                otr++;
            }
            else
            {
                pol++;
            }
        }
        int i_otr = pol;
        int i_pol = 0;
        double[] total = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                total[i_otr] = array[i];
                i_otr++;
            }
            else if (array[i] >= 0)
            {  
                total[i_pol] = array[i];
                i_pol++;
            }
        }
        // end

        return total;
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
        // code here ffff
        int otr = 0;
        int pol = 0;
        int j = 0;
        int i = 0;
        while (array.Length - i * 2 - 1 >= 1)
        {
            array[array.Length - i * 2 - 1] = array[array.Length / 2 - j - 1];
            array[array.Length - i * 2 - 2] = array[array.Length / 2 - j - 1];
            j++;
            i++;
        }

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
        // code here ffff
        double[] answer = new double[array.Length];
        double[] blok = new double[array.Length];
        int num = 0;
        int i_blok = 0;
        int y = 0;
        for (int i  = 0; i < array.Length; i++)
        {
            int total = 0;
            for(int j = 0; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    total += 1;
                }
            }
            if (total == 1)
            {
                answer[y] = array[i];
                num++;
                y++;
            }
            else
            {
                int k = 0;
                for (int t = 0; t < array.Length; t++)
                {
                    if (array[i] == blok[t])
                    {

                        k++;
                    }
                }
                
                if(k == 0)
                {
                    answer[y] = array[i];
                    blok[i_blok] = array[i];
                    i_blok++;
                    num++;
                    y++;
                }
                
            }
        }
        double[] answer_answer = new double[num];
        for (int i = 0; i < num; i++)
        {
            answer_answer[i] = answer[i];
        }
        // end

        return answer_answer;
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
