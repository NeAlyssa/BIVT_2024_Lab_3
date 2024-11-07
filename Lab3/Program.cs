using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_3_11(-2.5, 2.5, 9);
        //program.Task_3_11(1.5, 3, 4);
        program.Task_3_14(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 });



    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        const int n = 6;
        double s = 0;
        for (int i = 0; i < n; i++)
        {
            s += array[i];
        }

        for (int i = 0; i < n; i++)
        {
            array[i] = Math.Round(array[i] / s, 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        const int n = 8;
        double s = 0;
        int cnt = 0;
        for (int i = 0; i < n; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                cnt++;
            }
        }
        s /= cnt;
        s = Math.Round(s, 2);
        for (int i = 0; i < n; i++)
        {
            if (array[i] > 0) array[i] = s;
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0;i < first.Length; i++)
        {
            sum[i] = Math.Round(first[i] + second[i],2);
            dif[i] = Math.Round(first[i] - second[i],2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        const int n = 5;
        double s = 0;
        for (int i = 0; i < n; i++)
        {
            s += array[i];

        }
        s /= n;
        s = Math.Round(s, 2);
        for (int i = 0; i < n; i++)
        {
            array[i] = Math.Round(array[i] - s, 2);
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
        for(int i = 0; i < vector.Length; i++)
        {
            length += vector[i] * vector[i];
        }
        length = Math.Sqrt(length);
        length = Math.Round(length, 2);
        // end

        return Math.Round(length, 4); 
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        s /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > s) array[i] = 0;
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
            if (array[i] < 0) count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        s /= array.Length;

        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > s) count++;
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
            if (array[i] > P && array[i] < Q) count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int cnt = 0;
        for (int i = 0; i < array.Length;i++)
        {
            if (array[i] > 0)
            {
                cnt++;
            }
        }
        output = new double[cnt];
        for (int i = 0, j = 0; i < array.Length; i++)
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
        for(int i = 0; i < array.Length; i++)
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
        for(int i = 0, even_index = 0, odd_index = 0; i < array.Length; i++)
        {
            if (i % 2 == 0) even[even_index++] = array[i];
            else odd[odd_index++] = array[i];
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        int i = 0;
        while (i < array.Length && array[i] >= 0)
        {
            sum += array[i] * array[i];
            i++;
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i = 0; i< x.Length; i++)
        {
            if (x[i] <= 0) y[i] = double.NaN;
            else y[i] = Math.Round(Math.Log(x[i]) * 0.5, 2);
            Console.WriteLine($"{x[i]}    {y[i]}");
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        int min_index = -1;
        double min_value = double.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min_value)
            {
                min_value = array[i];
                min_index = i;
            }
        }
        array[min_index] *= 2;
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
        int min_index = -1;
        double min_value = double.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min_value)
            {
                min_value = array[i];
                min_index = i;
            }
        }

        for (int i = 0; i < min_index; i++)
        {
            if (array[i] > 0) array[i] *= 2;
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
        int min_index = -1, max_index = -1;
        double min_value = double.MaxValue, max_value = double.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min_value)
            {
                min_value = array[i];
                min_index = i;
            }
            if (array[i] > max_value)
            {
                max_value = array[i];
                max_index = i;
            }
        }

        double[] new_array = new double[Math.Abs(min_index - max_index) - 1];

        for (int i = Math.Min(min_index, max_index) + 1, j = 0; i < Math.Max(min_index, max_index); i++)
        {
            if (array[i] < 0) new_array[j++] = array[i];
        }
        // end

        return new_array;
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
        int max_index = -1;
        double max_value = double.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max_value)
            {
                max_value = array[i];
                max_index = i;
            }
        }
        if (max_index != array.Length - 1)
        {
            if (array[max_index + 1] > 0) array[max_index + 1] *= 2;
            else array[max_index + 1] /= 2;
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
        int min_index = -1, max_index = -1;
        double min_value = double.MaxValue, max_value = double.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min_value)
            {
                min_value = array[i];
                min_index = i;
            }
            if (array[i] > max_value)
            {
                max_value = array[i];
                max_index = i;
            }
        }
        
        for (int i = Math.Min(min_index, max_index) + 1; i < Math.Max(min_index, max_index); i++)
        {
            average += array[i];
        }
        if (average == 0) return 0;
        average /= Math.Abs(min_index - max_index) - 1;
        average = Math.Round(average, 2);
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
        int positive_index = -1;
        double[] new_array = new double[array.Length + 1];
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] > 0) 
            { 
                positive_index = i; 
                break;
            }
        }

        if (positive_index == -1) return array;
        else
        {
            for(int i = 0, j = 0; i < array.Length; i++)
            {
                new_array[j] = array[i];
                if (i == positive_index && j == positive_index)
                {
                    j++;
                    new_array[j] = P;
                }
                j++;
                
            }
            array = new_array;
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
        int max_index = 0;
        for (int i = 2; i < array.Length; i += 2)
        {
            if (array[i] > array[max_index]) max_index = i;
        }
        array[max_index] = max_index;
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
        if (k + 1 >= A.Length) return A;
        double[] array = new double[A.Length+B.Length];
        int n = 0; //сдвиг

        for (int i = 0; i < A.Length; i++)
        {
            if (i == k + 1)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    array[i + j] = B[j];
                }
                n = B.Length;
            }
            array[i + n] = A[i];
        }
        output = array;
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
        int max_index = 0, min_index = 0, neg_cnt = 0, pos_cnt = 0;
        double neg_sum =0, pos_sum =0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                pos_sum += array[i];
                pos_cnt++;
            }
            else
            {
                neg_sum += array[i];
                neg_cnt++;
            }
            if (array[i] > array[max_index]) max_index = i;
            if (array[i] < array[min_index]) min_index = i;
        }

        if (max_index < min_index && pos_cnt != 0) average = pos_sum / pos_cnt;
        else if (neg_cnt!= 0) average = neg_sum / neg_cnt;
        average = Math.Round(average,2);
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
        int max_index = 0;
        double sum = array[max_index];
        for (int i = 1; i < array.Length; i++)
        {
            sum += array[i];
            if (array[i] > array[max_index]) max_index = i;
        }
        if (array[max_index] > sum) array[max_index] = 0;
        else array[max_index] *= 2;
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
        double max_elem = array[0];
        for(int i = 1; i < array.Length; i++)
        {
            if (array[i] > max_elem) max_elem = array[i];
        }
        int n = 1;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] == max_elem)
            {
                array[i] += n;
                n++;
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
        double temp = 0;
        double[] elems = new double[array.Length/2];
        for (int i = 0;i<array.Length;i += 2)
        {
            for (int j = 0; j < array.Length - 2 - i; j += 2)
            {
                if (array[j] > array[j + 2])
                {
                    temp = array[j];
                    array[j] = array[j + 2];
                    array[j + 2] = temp;
                }
            }
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
        int cnt = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) cnt++;
        }
        double[] negatives = new double[cnt];
        for(int i = 0, j = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                negatives[j] = array[i];
                j++;
            }
        }
        double temp = 0;
        for (int i = 1; i < cnt;)
        {
            if (negatives[i] > negatives[i - 1])
            {
                int j = i;
                temp = negatives[i];
                negatives[i] = negatives[i - 1];
                negatives[i - 1] = temp;
                if (i > 1) i--;
                else i = j;
            }
            else i++;
        }

        for (int i = 0, j = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = negatives[j];
                j++;
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
        double[] X = null, Y = null;
        double globalMax = 0, globalMin = 0;

        // code here
        double[] X_ = new double[n], Y_ = new double[n];
        int ind = 0;
        bool flag_max = false, flag_min = false;
        for (double x = a; x <= b; x += (b - a) / (n-1))
        {

            X_[ind] = Math.Round(x, 2);
            Y_[ind] = Math.Round(Math.Cos(X_[ind]) + X_[ind] * Math.Sin(X_[ind]), 2);
            //Console.WriteLine(x);
            Console.WriteLine(Y_[ind]);
            ind++;
            
        }
        
        for (int i = 1; i < Y_.Length - 1; i++)
        {
            if (Y_[i - 1] < Y_[i] && Y_[i + 1] < Y_[i])
            {
                if (Y_[i] > Math.Max(Y_[0], Y_[n - 1]))
                {
                    globalMax = Y_[i];
                    flag_max = true;
                }
                
            }


            if (Y_[i - 1] > Y_[i] && Y_[i + 1] > Y_[i])
            {
                if (Y_[i] < Math.Min(Y_[0], Y_[n - 1]))
                {
                    globalMin = Y_[i];
                    flag_min = true;
                }
            }
            
        }
        if (!flag_max) globalMax = Math.Max(Y_[0], Y_[n - 1]);
        if (!flag_min) globalMin = Math.Min(Y_[0], Y_[n - 1]);
        X = X_; Y = Y_;
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
        double[] norm = new double[array.Length];
        double min_x = array[0], max_x = array[0];
        for (int i = 1;i < array.Length; i++)
        {
            min_x = Math.Min(min_x, array[i]);
            max_x = Math.Max(max_x, array[i]);
        }

        for (int i = 0; i < array.Length; i++)
        {
            double x = array[i];
            double norm_x = 2 * (x - min_x) / (max_x - min_x) - 1;
            norm[i] = Math.Round(norm_x, 2);

        }

        normalizedArray = norm;

        for (int i = 0; i < array.Length; i++)
        {
            double x = norm[i];
            x = (norm[i] + 1) * (max_x - min_x) / 2 + min_x;
            Console.WriteLine(Math.Round(x, 1));

        }
        // end

        return normalizedArray;
    }
    #endregion
}
