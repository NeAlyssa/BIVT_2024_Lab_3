using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double s = 0;

        for (int i = 0; i < array.Length; i++)
        {
            s += array[i]; 
        }
        // end
        

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] / s,2);
        }

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0;
        double n = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                n++;
            }
        }
        s = s / n;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = Math.Round(s,2);
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
            sum[i] = Math.Round(first[i] + second[i],1);
            dif[i] = Math.Round(first[i] - second[i],1);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s = 0;
        double n = 0;

        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
            n++;
        }

        s = s / n;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - s,2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        double ScalarProduct = 0;

        for (int i = 0; i < vector1.Length; i++)
        {
            ScalarProduct += vector1[i] * vector2[i];   
        }
        // end
        ScalarProduct = Math.Round(ScalarProduct,2);
        return ScalarProduct;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here

        for (int i = 0; i < vector.Length; i++)
        {
            length += vector[i] * vector[i];
        }
        // end
        length = Math.Round(Math.Sqrt(length),2);
        return Math.Round(length, 4);
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        double n = 0;

        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
            n++;
        }

        s = s / n;

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
        double s = 0;
        double n = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
            n++;
        }

        s = s / n;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > s)
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
            if (P<array[i] && array[i]<Q)
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
        int count = 0;
        int n = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                count++;
            }
        }

        output = new double[count];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) 
            {
                output[n] = array[i];
                n++;
            }
                

           
        }
        //end

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        // code here
        for (int i = 0 ; i < array.Length; i++)
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
        int n_even = 0;
        int n_odd = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[n_even] = array[i];
                n_even++;
            }
            else
            {
                odd[n_odd] = array[i];
                n_odd++;
            }

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
            if (array[i] >= 0)
            {
                sum += array[i] * array[i];
            }
            else
                break;
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
            if (x[i] == 0)
                y[i] = double.NaN;
            else
                y[i] = Math.Round(0.5 * Math.Log(x[i]),2);
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        double mini = double.MaxValue;
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < mini)
            {
                mini = array[i];
                index = i;
            }
        }
        if (array[index] > 0) array[index] = mini * 2;
        else array[index] = mini / 2;
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
        double mini = 1.7976931348623157E+308;
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < mini)
            {
                mini = array[i];
                index = i;
            }
        }
        
        for (int i = 0; i < index; i++)
        {
            if (array[i] < 0)
            {
                array[i] /= 2;
            }
            else 
            {
                array[i] *= 2;
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
        // code here
        

        double maxi = double.MinValue;
        double mini = double.MaxValue;
        int count_minus = 0;

        int index_mx = 0;
        int index_mn = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                index_mx = i;
            }
            if (array[i] < mini)
            {
                mini = array[i];
                index_mn = i;
            }   
        }
        
        int n = 0;
        int length = Math.Abs(index_mx - index_mn - 1);
     
        double[] arrayy = new double[length];

        for (int i = Math.Min(index_mn, index_mx) + 1; i < Math.Max(index_mn, index_mx); i++)
        {
            if (array[i] < 0) count_minus++;
        }

        if (Math.Abs(index_mn - index_mx) <= 1 || count_minus == 0) return array = new double[count_minus];
        else
        {
            for (int i = Math.Min(index_mn, index_mx) + 1; i < Math.Max(index_mn, index_mx); i++)
            {
                if (array[i] < 0) arrayy[n++] = array[i];
            }
            array = arrayy;
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
        double maxi = -1.7976931348623157E+308;
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                index = i;
            }
        }

        if (index != array.Length - 1)
        {
            if (array[index + 1] < 0)
            {
                array[index + 1] /= 2;
            }
            else
            {
                array[index + 1] *= 2;
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

        // code here
        double maxi = -1.7976931348623157E+308;
        int index_mx = 0;
        double mini = 1.7976931348623157E+308;
        int index_mn = 0;

        double counter = 0;
        double arithmetic_mean = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < mini)
            {
                mini = array[i];
                index_mn = i;
            }
            if (array[i] > maxi)
            {
                maxi = array[i];
                index_mx = i;
            }
        }

        for (int i = Math.Min(index_mn, index_mx)+1; i < Math.Max(index_mn, index_mx); i++)
        {
            arithmetic_mean += array[i];
            counter++;
        }

        if (arithmetic_mean == 0) return 0;
        average = arithmetic_mean / counter;
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
        int index_p = -1;
        

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                index_p = i;
                
            }
        }

        double[] new_array = new double[array.Length + 1];

        new_array[index_p + 1] = P;

        if (index_p == -1) return array;
        else
        {
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                new_array[j] = array[i];
                if (i == index_p && j == index_p)
                {
                    j++;
                    new_array[j] = P;
                }
                j++;

            }
            array = new_array;
        }

        array = new_array;
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
        double maxi = double.MinValue;
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (maxi < array[i])
                {
                    maxi = array[i];
                    index = i;
                }
            }
        }
        array[index] = index; 
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
        output = new double[A.Length + B.Length];
        int tab = 0;

        if (A.Length <= k + 1) return A;

        for (int i = 0; i < A.Length; i++)
        {
            if (i == k + 1)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    output[i + j] = B[j];
                }
                tab = B.Length;
            }
            output[i + tab] = A[i];
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

        // code here
        double maxi = double.MinValue;
        int index_mx = 0;
        double mini = double.MaxValue;
        int index_mn = 0;

        double sum_neg = 0;
        double counter_neg = 0;
        double sum_pos = 0;
        double counter_pos = 0;


        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < mini)
            {
                mini = array[i];
                index_mn = i;
            }
            if (array[i] > maxi)
            {
                maxi = array[i];
                index_mx = i;
            }
            if (array[i] > 0)
            {
                sum_pos += array[i];
                counter_pos++;
            }
            if (array[i] < 0)
            {
                sum_neg += array[i];
                counter_neg++;
            }
        }


        if (index_mx < index_mn && counter_pos != 0)
        {
            average = Math.Round(sum_pos / counter_pos, 3);
        }
        else if (index_mx > index_mn && counter_neg != 0)
        {
            average = Math.Round(sum_neg / counter_neg, 3);
        }
        else return 0;


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
        double maxi = double.MinValue;
        int index_mx = 0;
        double sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                index_mx = i;
            }
            sum += array[i];
        }

        if (maxi > sum) array[index_mx] = 0;
        else array[index_mx] = maxi * 2;
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
        int index_max = 0;
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[index_max])
            {
                index_max = i;
                count = 1;
            }
            else if (array[i] == array[index_max])
                count++;
        }

        output = new int[count];
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == array[index_max])
                output[k++] = i;
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
        int index_mx = 0;
        double maxi = double.MinValue;

        double[] new_array = new double[array.Length];
        
        for (int i = 0; i < array.Length; i++)
        {
            new_array[i] = array[i];
            if (array[i] > maxi)
            {
                index_mx = i;
                maxi = array[i];
            }
        }

        double sum = 0;

        for (int i = 0; i < array.Length; i++)
        {

            if (new_array[i] == maxi) // i - индекс максимального числа
            {
                if (i != 0)
                {
                    sum = 0;
                    for (int j = 0; j < i; j++) // текущий идекс неизменяемого массива сравнивается с индексом максимального
                    {
                        sum += new_array[j];
                    }
                    array[i] = sum;
                }
                else array[i] = 0;
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
        // code here
        
        double[] new_array = new double[array.Length];
        int n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0) new_array[n++] = array[i];
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) new_array[n++] = array[i];
        }


        // end

        return new_array;
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
        double[] new_array = new double[array.Length];

        for (int i = 0, n = 0; n < array.Length - 1; i++)
        {
            new_array[n] = array[i];
            new_array[n + 1] = array[i];
            n+=2;
        }
        // end

        return new_array;
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
        int count_reps = 0;

        for (int i = 0; i < array.Length; i++)
        {
            bool unique = true;
            for (int j = 0; j < i; j++)
            {
                if (array[i] == array[j])
                {
                    unique = false;
                    break;
                }
            }
            if (unique == true) count_reps++;
        }

        double[] new_array = new double[count_reps];
        int k = 0;

        for (int i = 0; i < array.Length; i++)
        {
            bool unique = true;
            for (int j = 0; j < i; j++)
            {
                if (array[i] == array[j])
                {
                    unique = false;
                    break;
                }
            }
            if (unique == true) new_array[k++] = array[i];
        }
        // end

        return new_array;
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
