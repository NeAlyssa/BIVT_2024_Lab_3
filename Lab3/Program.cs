using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        program.Task_2_20(new double[] { 2, 1, 3, 3, 5, 6, 3, 4 });
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
        for (int i = 0;i < array.Length; i++ )
        {
            array[i] = Math.Round(array[i]/s, 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0;
        double count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                count++;

            }
        }
        s = s / count;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] > 0)
            {
                array[j] = Math.Round(s, 2);
            }
        }
        
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        double a, b = 0;
        for (int i = 0; i < first.Length; i++)
        {
            a = first[i];
            b = second[i];
            sum[i] = Math.Round(a + b, 2);
            dif[i] = Math.Round(a - b, 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        int count = 0;
        double s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
            count++;
        }
        s /= count;
        for (int i = 0; i < array.Length; i++)
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
        double pr = 1;
        for (int i = 0; i < vector1.Length; i++)
        {
            pr = vector1[i] * vector2[i];
            product = Math.Round(product + pr, 2);
        }
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < vector.Length; i++)
        {
            length += vector[i] * vector[i];
        }
        length = Math.Sqrt(length);

        // end

        return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        for (int i = 0;i < array.Length;i++)
        {
            s += array[i];
        }
        s /= array.Length;
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
                count++;
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
        double[] output = null;

        // code here
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                count++;
            }
        }
        output = new double[count];
        count = 0;
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
        }
        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        // code here
        int cnt1 = 0;
        int cnt2 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(i % 2 == 0)
            {
                even[cnt1] = array[i];
                cnt1++;
            }
            else
            {
                odd[cnt2] = array[i];
                cnt2++;

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
            if (array[i] < 0) break;
            sum += array[i] * array[i];
                
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
                Console.WriteLine($" {x[i]} {y[i]}");
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
        // code here
       
        // end

            return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        double s = double.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > s)
                s = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == s) break;
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
        double s = 0;
        double sr = 0;
        int count = 0;
        int ind = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sr += array[i];
            count++;
        }
        sr /= count;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > s)
            {
                s = array[i];
                ind = i;
            }
        }
        for (int i = ind + 1; i < array.Length; i++)
        {
            array[i] = Math.Round(sr, 2);
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
        double sr = 0;
        int count = 0;
        int ind = 0;
        double d = double.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            sr += array[i];
            count++;
        }
        sr /= count;
        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - sr) < d)
            {
                d = Math.Abs(array[i] - sr);
                ind = i;
            }
        }
        double[]b = new double[array.Length + 1];
        for (int i = 0; i <= ind; i++)
        {
            b[i] = array[i];

        }
        b[ind + 1] = P;
        for (int i = ind + 2; i < b.Length; i++)
        {
            b[i] = array[i-1];

        }


        // end

        return b;
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
        int ind1 = 0;
        int ind2 = 0;
        double mini = double.MaxValue;
        double maxx = double.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxx)
            {
                maxx = array[i];
                ind1 = i;
            }
        }
        for (int i = ind1; i < array.Length; i++)
        {
            if (array[i] < mini)
            {
                mini = array[i];
                ind2 = i;
            }
        }
        array[ind1] = mini; 
        array[ind2] = maxx;
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
        double mini = double.MaxValue;
        int ind1 = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < mini && array[i] > 0)
            {
                mini = array[i];
                ind1 = i;
            }
        }
        if (ind1 == -1)
        {
            return array;
        }
        double[]b = new double[array.Length - 1];
        for (int i = 0; i < ind1; i++)
        {
            b[i] = array[i];
        }
        for (int i = ind1; i < array.Length - 1; i++)
        {
            b[i] = array[i + 1];
        }

        // end
        array = b;
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
        int ind1 = 0;
        double sum = 0;
        double maxx = double.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxx)
            {
                maxx = array[i];
                ind1 = i;
            }
        }
        for (int i = ind1 + 1; i < array.Length; i++)
        {
            sum += array[i];
        }
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] < 0)
            {
                array[i] = Math.Round(sum, 2);
                break;
            }
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
        int ind1 = 0;
        int ind2 = 0;
        double otr = 0;
        double maxx = double.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxx)
            {
                maxx = array[i];
                ind1 = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                otr = array[i];
                ind2 = i;
                array[ind1] = otr;
                array[ind2] = maxx;
                break;
            }
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
        double sr = 0;
        int count = 0;
        int count2 = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            sr += array[i];
            count++;
        }
        sr /= count;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr)
                count2++;
        }
        output = new int[count2];
        count2 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr)
            {
                output[count2] = i;
                count2++;
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
        double max1 = double.MinValue; 
        double max2 = double.MinValue;
        for (int i = 0; i < array.Length; i+=2)
        {
            if (array[i] > max1)
            {
                max1 = array[i];
            }
        }
        for (int i = 1; i < array.Length; i += 2)
        {
            if (array[i] > max2)
            {
                max2 = array[i];
            }
        }
       if (max1 > max2)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                array[i] = 0;
            }
        }
        else
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
        double mini = double.MaxValue;
        int ind1 = 0;
        int ind2 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < mini)
            {
                mini = array[i];
                ind1 = i;//индекс минимального
            }
        }
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                count++;//количество отрицательных
            }
        }
        if(count == 0)
        {
            for (int j = 0; j < array.Length; j += 2)
            {
                sum += array[j];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                ind2 = i;
                if (ind2 < ind1 && count != 0)
                {
                    for (int j = 0; j < array.Length; j += 2)
                    {
                        sum += array[j];
                    }
                }
                else
                {
                    for (int j = 1; j < array.Length; j += 2)
                    {
                        sum += array[j];
                    }
                }
                break;
            }
        }
        Console.WriteLine(sum);
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
        double maxx = double.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxx)
            {
                maxx = array[i];
            }
        }
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] == maxx)
            {
                count++;
                array[i] += count;
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
        double a = 0;
        for (int i = 0; i < array.Length; i+=2)
        {
            for (int j = 0; j < array.Length - i - 2; j = j + 2)
            {
                if (array[j] > array[j + 2])
                {
                    a = array[j];
                    array[j] = array[j + 2];
                    array[j + 2] = a;
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
        
        double minn = 0;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                count++; 
            }
        }
        double[] array2 = new double[count];
        count = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array2[count] = array[i];
                count++;
            }
        }
        for (int i = 0; i < array2.Length; i++)
           
        {
            for (int j = 0; j < array2.Length-1; j++)
            {
                if (array2[j] < array2[j + 1])
                {
                    minn = array2[j + 1];
                    array2[j + 1] = array2[j];
                    array2[j] = minn;
                }
            }
        }
        count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if( array[i] < 0)
            {
                array[i] = array2[count];
                count++;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
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
        X = new double[n]; 
        Y = new double[n];
        double r = (b - a) / (n - 1);
        int ind = 0;
        for (double i = a; i <= b; i += r)
        {
            X[ind] = i;
            Y[ind] = Math.Cos(i) + i * Math.Sin(i);
            ind++;
        }
        globalMax = Y[0];
        globalMin = Y[0];
        foreach(double i in Y)
        {
            if (i > globalMax)
            {
                globalMax = i;
            }
            if (i < globalMin)
            {
                globalMin = i;
            }
        }

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
        normalizedArray = new double[array.Length];
        int imax = 0; int imin = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[imax])
            {
                imax = i;
            }
            if (array[i] < array[imin])
            {
                imin = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            normalizedArray[i] = ((2 * (array[i] - array[imin]) / (array[imax] - array[imin])) - 1);
        }


        // end

        return normalizedArray;
    }
    #endregion
}