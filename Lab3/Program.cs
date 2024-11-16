using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
        // code here
        double s = 0;
        for(int i = 0; i < 6; i++)
        {
            s += array[i];
        }
        for (int i = 0; i < 6; i++)
        {
            array[i] = Math.Round(array[i]/s, 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        int k = 0;
        double sum = 0;
        for(int i = 0; i<8; i++)
        {
            if (array[i] > 0)
            {
                k += 1;
                sum += array[i];
            }
        }
        double sr = Math.Round(sum / k, 2);
        for(int i = 0; i < 8; i++)
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
        for(int i = 0; i < 4; i++)
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
        for(int i = 0; i < 5; i++)
        {
            sum += array[i];
        }
        double sr = sum / 5;
        for(int i = 0; i < 5; i++)
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
        for(int i = 0; i < 4; i++)
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
        for(int i = 0; i < 5; i++)
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
        double s = 0;
        for(int i = 0; i < 7; i++)
        {
            s += array[i];
        }
        double sr = s / 7;
        for(int i = 0; i < 7; i++)
        {
            if (array[i] > sr)
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
        for(int i = 0; i < 6; i++)
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
        for(int i = 0; i < 8; i++)
        {
            sum += array[i];
        }
        double sr = sum / 8;
        for(int i = 0; i < 8; i++)
        {
            if (array[i] > sr)
            {
                count += 1;
            }
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for(int i = 0; i < 10; i++)
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
        int j = 0;
        for(int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                j++;
            }
        }
        output = new double[j];
        int k = 0;
        for(int i = 0; i < 10; i++)
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
        for(int i = 0; i < 8; i++)
        {
            if (array[i] < 0 && i > index)
            {
                index = i;
                value = array[i];
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
        int k = 0;
        int j = 0;
        for(int i = 0; i < 10; i++)
        {
            if(i % 2 == 0)
            {
                even[k] = array[i];
                k++;
            }
            if(i % 2 != 0)
            {
                odd[j] = array[i];
                j++;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for(int i = 0; i < 11; i++)
        {
            if (array[i] >= 0)
            {
                sum += array[i] * array[i];
            }
            else
            {
                break;
            }
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for(int i = 0; i < 10; i++)
        {
            if (x[i] <= 0)
            {
                y[i] = double.NaN;
            }
            else
            {
                y[i] = Math.Round(0.5 * Math.Log(x[i], Math.E), 2);
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
        double min = array[0];
        int nmin = 0;
        for(int n = 0; n < array.Length; n++)
        {
            if (array[n] < min)
            {
                min = array[n];
                nmin = n;
            }
        }
        if (array[nmin] > 0)
        {
            array[nmin] *= 2;
        }
        else
        {
            array[nmin] /= 2;
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
        int imin = 0;
        double minel = array[0];
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < minel)
            {
                imin = i;
                minel = array[i];
            }
        }
        for(int j = 0; j < imin; j++)
        {
            if (array[j] > 0)
            {
                array[j] *= 2;
            }
            else
            {
                array[j] /= 2;
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
        int nmin = 0;
        int nmax = 0;
        double maxel = array[0];
        double minel = array[0];
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxel)
            {
                maxel = array[i];
                nmax = i;
            }
            if (array[i] < minel)
            {
                minel = array[i];
                nmin = i;
            }
        }
        int k = 0;
        for(int j = Math.Min(nmin, nmax)+1; j < Math.Max(nmin, nmax); j++)
        {
            if (array[j] < 0)
            {
                k++;
            }
        }
        double[] array1 = new double[k];
        int tk = 0;
        for (int j = Math.Min(nmin, nmax) + 1; j < Math.Max(nmin, nmax); j++)
        {
            if (array[j] < 0)
            {
                array1[tk] = array[j];
                tk++;
            }
        }
        // end

        return array1;
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
        int nmax = 0;
        double maxel = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxel)
            {
                nmax = i;
                maxel = array[i];
            }
        }
        if (nmax < (array.Length-1) && array[nmax+1] > 0)
        {
            array[nmax + 1] *= 2;
        }
        else if(nmax < (array.Length-1) && array[nmax + 1] < 0)
        {
            array[nmax + 1] /= 2;
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
        int nmin = 0;
        int nmax = 0;
        double maxel = array[0];
        double minel = array[0];
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxel)
            {
                maxel = array[i];
                nmax = i;
            }
            if (array[i] < minel)
            {
                minel = array[i];
                nmin = i;
            }
        }
        double sum = 0;
        for(int j = (1 + Math.Min(nmin,nmax)); j < Math.Max(nmin, nmax); j++)
        {
            sum += array[j];
        }
        if(sum == 0)
        {
            average = 0;
        }
        else
        {
            average = sum / (Math.Abs(nmin - nmax) - 1);
            if (average >= 1)
            {
                average = Math.Round(average, 2);
            }
            else
            {
                average = Math.Round(average, 3);
            }
        }
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
        int index = -1;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                index = i;
            }
        }
        double[] array1 = new double[array.Length + 1];
        if (index != -1)
        {
            array1[index + 1] = P;
            for(int j = 0; j < index + 1; j++)
            {
                array1[j] = array[j];
            }
            for (int n = index+2; n < array1.Length; n++)
            {
                array1[n] = array[n-1];
            }
        }
        else
        {
            array1 = array;
        }
        // end

        return array1;
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
        int index = 0;
        double maxel = array[0];
        for(int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > maxel)
            {
                maxel = array[i];
                index = i;
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
        double[] output = new double[A.Length + B.Length];

        // code here
        if(k < A.Length)
        {
            for (int i = 0; i <= k; i++)
            {
                output[i] = A[i];
            }

            for (int i = 0; i < B.Length; i++)
            {
                output[k + 1 + i] = B[i];
            }

            for (int i = k+1; i < A.Length; i++)
            {
                output[i + B.Length] = A[i];
            }
        }
        else
        {
            output = A;
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
        int nmin = 0;
        int nmax = 0;
        double maxel = array[0];
        double minel = array[0];
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < minel)
            {
                nmin = i;
                minel = array[i];
            }
            if (array[i] > maxel)
            {
                nmax = i;
                maxel = array[i];
            }
        }
        double srotr = 0;
        double srpol = 0;
        int kpol = 0;
        int kotr = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                srpol += array[i];
                kpol += 1;
            }
            if (array[i] < 0)
            {
                srotr += array[i];
                kotr += 1;
            }
        }
        srpol /= kpol;
        srotr /= kotr;
        if(nmin > nmax && kpol != 0)
        {
            average = srpol;
        }
        else if(nmin < nmax && kotr != 0)
        {
            average = srotr;
        }
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
        double sum = 0;
        int index = 0;
        double maxel = array[0];
        for(int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            if (array[i] > maxel)
            {
                maxel = array[i];
                index = i;
            }
        }
        if(maxel > sum)
        {
            array[index] = 0;
        }
        else
        {
            array[index] *= 2;
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
        double maxel = array[0];
        int count = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxel)
            {
                maxel = array[i];
                count = 1;
            }
            else if (array[i] == maxel)
            {
                count++;
            }
        }
        output = new int[count];
        int k = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] == maxel)
            {
                output[k++] = i;
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
        double maxel = array[0];
        int count = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxel)
            {
                maxel = array[i];
                count = 1;
            }
            else if (array[i] == maxel)
            {
                count++;
            }
        }
        double sum = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] == maxel)
            {
                array[i] = sum;
                sum += maxel;
            }
            else
            {
                sum += array[i];
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
        int k = array.Length - 1;
        for(int i = k; i >= 0; i--)
        {
            if (array[i] < 0)
            {
                double c = array[i];
                array[i] = array[k];
                array[k] = c;
                k--;
            }
        }
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

        // end

        return count;
    }
    public double[] Task_3_10(double[] array)
    {
        // code here
        int step = array.Length / 2;
        for(int i = step-1; i >= 0; i--)
        {
            array[i + step--] = array[i];

        }
        for(int i = 0; i < (array.Length-1); i+=2)
        {
            array[i] = array[i + 1];
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
        // code here
        int len = 0;
        for(int i = 0; i < array.Length; i++)
        {
            double tel = array[i];
            for(int j = i+1; j < array.Length; j++)
            {
                if (array[j] == tel)
                {
                    len++;
                    array[j] = double.NaN;
                }
            }
            
        }
        double[] array1 = new double[array.Length - len];
        int k = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (!double.IsNaN(array[i]))
            {
                array1[k++] = array[i];
            }
        }
        // end

        return array1;
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
