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
        program.Task_2_3(new double[] { 0, 1.5, -1, 3, -2.2, -0.5, 2 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double summ = 0;
        for (int i=0; i<6; i++)
        {
            summ += array[i];

        }
        for (int i = 0; i < 6; i++)
        {
            array[i] = Math.Round(array[i] / summ, 2);

        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double summ = 0;
        double count = 0;
        for (int i=0; i<8; i++)
        {
            if (array[i] > 0)
            {
                summ += array[i];
                count ++;
            }
        }
        double sr = Math.Round(summ / count, 2);
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                array[i] = sr;
            }
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i< first.Length; i++)
        {
            sum[i] = Math.Round(first[i] + second[i],2);
            dif[i] = Math.Round(first[i] - second[i], 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double summ = 0;
        for (int i = 0; i<5; i++)
        {
            summ += array[i];
        }
        double sr = Math.Round(summ / 5, 2);
        for (int i = 0; i < 5; i++)
        {
            array[i] = Math.Round(array[i] - sr, 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i<4; i++)
        {
            product += vector1[i] * vector2[i];
        }
        // end
        product = Math.Round(product, 2);

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i<5; i++)
        {
            length += vector[i]*vector[i];
        }
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sr = 0;
        for (int i = 0; i<7; i++)
        {
            sr += array[i];
        }
        sr /= 7;
        for (int i = 0; i < 7; i++)
        {
            if (array[i] > sr) array[i] = 0;

        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        for (int i = 0; i<6; i++)
        {
            if (array[i]<0) count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double sr = 0;
        for (int i = 0; i < 8; i++)
        {
            sr += array[i];
        }
        sr /= 8;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > sr) count++;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for ( int i = 0; i<10; i++)
        {
            if (array[i] > P && array[i] < Q) count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;
        int count = 0;
        // code here
        for (int i =0; i<10; i++)
        {
            if (array[i] > 0) count++;
        }
        output = new double[count];
        int k = 0;
        for (int i =0; i<10; i++)
        {
            if (array[i] > 0)
            {
                output[k] = array[i];
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
        for (int i = 7; i>=0; i--)
        {
            if (array[i] < 0)
            {
                value = array[i];
                index = i;
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
        for (int i = 0; i<10; i++)
        {
            if (i % 2 == 0)
            {
                even[(int)Math.Floor((double)i/2)] = array[i];
            }
            else
            {
                odd[(int)Math.Floor((double)i / 2)] = array[i];
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i<11; i++)
        {
            if (array[i] < 0) break;
            sum += array[i]*array[i];
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i = 0; i<10; i++)
        {
            if (x[i] > 0) y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            else y[i] = double.NaN;
        }
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{x[i]}   {y[i]}");
        }
            // end

            return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        double mn = 10000000;
        int index = 0;
        for (int i=0; i<array.Length; i++)
        {
            if (array[i] < mn)
            {
                mn = array[i];
                index = i;
            }
        }
        array[index] *= 2;
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
        double mn = 10000000;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < mn)
            {
                mn = array[i];
                index = i;
            }
        }
        
        for (int i = 0; i < index; i++)
        {
            if (array[i] >0) array[i] *= 2;
            else array[i] /= 2;
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
        double mx = -10000;
        double mn = 10000;
        int index_mx = 0;
        int index_mn = 0;
        for (int i = 0; i< array.Length; i++)
        {
            if (array[i] < mn)
            {
                mn = array[i];
                index_mn = i;
            } 
            if (array[i] > mx)
            {
                mx = array[i];
                index_mx = i;
            }
        }
        int start = 0;
        int end = 0;
        if (index_mx < index_mn)
        {
            start = index_mx;
            end = index_mn;
        } else
        {
            start = index_mn;
            end = index_mx;
        }
        double []answer = new double [end - start - 1];
        int k = 0;
        for (int i = start +1; i<end; i++)
        {
            if (array[i] < 0)
            {
                answer[k] = array[i];
                k++;
            }
        }
        // end

        return answer;
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
        double mx = -10000000;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >mx)
            {
                mx = array[i];
                index = i;
            }
        }

        // end
        if (index+1 < array.Length)
        {
            if (array[index + 1] > 0) array[index + 1] *= 2;
            else array[index + 1] /= 2;
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
        double average = 0;

        // code here
        double mx = -10000;
        double mn = 10000;
        int index_mx = 0;
        int index_mn = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < mn)
            {
                mn = array[i];
                index_mn = i;
            }
            if (array[i] > mx)
            {
                mx = array[i];
                index_mx = i;
            }
        }
        int start = 0;
        int end = 0;
        if (index_mx < index_mn)
        {
            start = index_mx;
            end = index_mn;
        }
        else
        {
            start = index_mn;
            end = index_mx;
        }
        Console.WriteLine(start);
        Console.WriteLine(end);
        for (int i = start+1; i<end; i++)
        {
            average += array[i];
        }
        if (average != 0) average /= (end - start - 1);
        Console.WriteLine(Math.Round(average, 2));
        // end

        return Math.Round(average,2);
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
        int index = -10000;
        for (int i = array.Length-1; i >= 0; i--)
        {
            if (array[i] > 0)
            {
                index = i;
                break;
            }
        }
        if (index == -10000) return array;
        double[] answer = new double[array.Length + 1];
        for (int i = 0; i<index+1; i++)
        {
            answer[i] = array[i];
        }
        answer[index+1] = P;
        for (int i = index+2; i< answer.Length; i++)
        {
            answer[i] = array[i - 1];
        }
        
        // end

        return answer;
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
        double mx = -10000;
        int index = -10000;
        for (int i = 0; i<array.Length; i += 2)
        {
            if (array[i] > mx)
            {
                mx = array[i];
                index = i;
            }
        }
        if (index != -10000)
        {
            array[index] = index;
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
        double[] output = new double[A.Length+B.Length];
        if (k >= A.Length) return A;
        // code here
        for (int i = 0; i <=k; i++)
        {
            output[i] = A[i];
        }
        for (int i = k+1; i<k+1+B.Length; i++)
        {
            output[i] = B[i - k - 1];
        }
        for (int i = k+1+B.Length; i< A.Length + B.Length; i++)
        {
            output[i] = A[i - B.Length];
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
        double mx = -10000;
        double mn = 10000;
        int index_mx = 0;
        int index_mn = 0;
        double positive_sum = 0;
        double negative_sum = 0;
        double positive_count = 0;
        double negative_count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                positive_sum += array[i];
                positive_count++;
            } else if (array[i] < 0)
            {
                negative_sum+= array[i];
                negative_count++;
            }
            if (array[i] < mn)
            {
                mn = array[i];
                index_mn = i;
            }
            if (array[i] > mx)
            {
                mx = array[i];
                index_mx = i;
            }
        }
        if (index_mx < index_mn && positive_count!=0)
        {
            average = positive_sum / positive_count;
        }
        else if (index_mn < index_mx && negative_count!=0)
        {
            average = negative_sum / negative_count;
        }

        // end

        return Math.Round(average,2);
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
        double mx = -10000;
        int index = -10000;
        double sm = 0;
        for (int i = 0; i < array.Length; i ++)
        {
            sm+= array[i];
            if (array[i] > mx)
            {
                mx = array[i];
                index = i;
            }
        }
        if (mx > sm) array[index] = 0;
        else {
            if (mx > 0) array[index] *= 2;
            else array[index] /= 2;
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
        int[] output = new int[array.Length];
        int k = 0;
        // code here
        double mx = -10000;
        for (int i = 0; i<array.Length; i++)
        {
            if (array[i] > mx)
            {
                k = 0;
                mx = array[i];
                Array.Clear(output, 0, output.Length);
                output[k] = i;
            }
            else if (array[i] == mx)
            {
                k += 1;
                output[k] = i;
            }
        }
        int[] new_output = new int[k+1];
        for (int i = 0; i<=k; i++)
        {
            new_output[i] = output[i];
        }
        // end

        return new_output;
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
        double mx = -10000;
        double []ans = new double[array.Length];
        for (int i = 0; i< array.Length; i++)
        {
            ans[i] = array[i];
            if (array[i] > mx) mx= array[i];
        }
        double sm = 0;
        for (int i = 0; i<array.Length; i++)
        {
            if (array[i] == mx)
            {
                array[i] = sm;
            }
            sm += ans[i];
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
        double[] min = new double[array.Length];
        int k = 0;
        for (int i = 0; i<array.Length; i++)
        {
            if (array[i] < 0)
            {
                min[k] = array[i];
                k++;
            }
        }
        int count = 0;
        double []ans = new double[array.Length];
        for (int i = 0; i<array.Length; i++)
        {
            if (array[i] >= 0)
            {
                ans[count] = array[i];
                count++;
            }
        }
        for (int i = 0; i <k; i++)
        {
            ans[count] = min[i];
            count++;
        }
        ;
        return ans;
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
        int len = array.Length;
        for(int i = array.Length-1; i >= 0; i--)
        {
            if (array[i] == 0)
            {
                len--;
            }
            else break;
        }

        double[] arr = new double[len];
        for (int i = 0; i<len; i++)
        {
            arr[i] = array[i];
        }
        double[] new_array = new double[len*2];
        for (int i=0; i<len*2; i+=2)
        {
            new_array[i] = arr[i / 2];
            new_array[i + 1] = arr[i / 2];
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
        int k = 0;
        double[] new_arr = new double[array.Length];
        for(int i = 0; i<array.Length; i++)
        {
            new_arr[i] = -100000000;
        }
        for (int i = 0; i<array.Length; i++)
        {
            double elem = array[i];
            new_arr[k] = elem;
            k++;
            for (int j = 0; j< new_arr.Length; j++)
            {
                if (elem == new_arr[j] && (k-1)!=j) 
                {
                    k--;
                    new_arr[k] = 0;
                    break;
                }
            }
        }
        int co = new_arr.Length;
        for (int i = new_arr.Length-1; i>=0; i--)
        {
            if (new_arr[i] == -100000000 || new_arr[i] == 0)
            {
                co--;
            }
            else break;
        }
        double[] ans = new double[co];
        for (int i = 0; i<co; i++)
        {
            ans[i] = new_arr[i];
        }
        // end

        return ans;
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