using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
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
        int l = array.Length;
        for (int i = 0; i < l; i++)
        {
            s+= array[i];
        }
        if (s != 0)
        {
            for (int i = 0; i < l; i++)
            {
                array[i] /= s;
                array[i] = Math.Round(array[i], 2);
            }
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0;
        double p = 0;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                p += 1;
            }
        }
        s /= p;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                array[i] = Math.Round(s, 2);
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
            double s = 0;
            for (int i = 0; i < 5; i++)
            {
                s += array[i];
            }
            s = s / 5;
            for (int i = 0; i < 5; i++)
            {
                double t = array[i] - s;
                array[i]= Math.Round(t, 2);
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

        for (int i = 0; i < 5; i++)
        {
            length += vector[i] * vector[i];
        }    
        length = Math.Round(Math.Sqrt(length), 2);
        // end
        return length ;
    }
    public double[] Task_1_7(double[] array)
    {
            // code here
            double s = 0;
            for (int i = 0; i < 7; i++)
            {
                s += array[i];
            }
            double m = s / 7;
            for (int i = 0; i < 7; i++)
            {
                if (array[i] > m)
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
            double s = 0;
            for (int i = 0; i < 8; i++)
            {
                s += array[i];
            }
            double m = s / 8;
            for (int i = 0; i < 8; i++)
            {
                if (array[i] > m)
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
            for (int i = 0; i < 10; i++)
            {
                if ((array[i] > P) && (array[i] < Q))
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
            int c = 0;
            double l = array.Length;
            for (int i = 0; i < l; i++)
            {
                if (array[i] > 0)
                {
                    c++;
                } 
            }
            output = new double[c];
            c = 0;
            for (int i = 0; i < l; i++)
            {
                if (array[i] > 0)
                {
                    output[c++] = array[i];
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
        int k = 0; 
        int j = 0;
        int l= array.Length;
        even = new double[array.Length];
        odd = new double[array.Length];
        for (int i = 0; i < l; i++)
        {
            if (i % 2 == 0)
            {
                even[k] = array[i];
                k++;
            }
            else if (i % 2 != 0)
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
            for (int i = 0; i < 11; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i] * array[i];
                }
                if (array[i] < 0)
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
            for (int i = 0; i < 10; i++)
            {
                if (x[i] <= 0)
                {
                    y[i] = Double.NaN;
                    continue;
                }
                y[i] = Math.Log(x[i]) / 2;
                y[i] = Math.Round(y[i], 2);
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
        double max=-100000000000000000;
            double num = 0;
            double l = array.Length;
            for (int i = 0; i < l; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    num = i;
                }
            }
            for (int i = 0; i < num; i++)
            {
                sum+= array[i];
            }

            sum = Math.Round(sum, 2); 
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
            double max = -1000000050000000000;
            int num = 0;
            double srz = 0;
            int l = array.Length;
            for (int i = 0; i < l; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    num = i;
                }
            }
            for (int i = 0; i < l; i++)
            {
                srz= srz+array[i];
            }
            for (int i = num + 1; i < l; i++)
            {
                array[i] = Math.Round(srz / l, 2);
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
        double c = 0;
        int l = array.Length;
        double[] a = new double[l + 1];
        int l2 = a.Length;
        int n = 0;
        for (int i = 0; i < l; i++)
        {
            c += array[i];
        }
        c = c / l;
        
        for (int i = 1; i < l; i++)
        {
            if (Math.Abs(array[i] - c) < Math.Abs(array[n] - c))
            {
                n = i;
            }
        }
        for (int i = 0; i <= n; i++)
        {
            a[i] = array[i];
        }
        a[n + 1] = P;
        for (int i = n + 2; i < l2; i++)
        {

            a[i] = array[i - 1];
        }
        array = a;

        // end

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
            double max = -100000000;
            int indexmax = 0;
            int indexmin = 0;
            double l = array.Length;
            double min = 100000000000;
            for (int i = 0; i < l; i++)
            {
                if (array[i] > max)
                {
                    max= array[i];
                    indexmax = i;
                }
            }
            if (indexmax == l - 1)
            {
                return array;
            }
            for (int i = indexmax; i < l; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    indexmin = i;
                }
            }
            array[indexmax] = min;
            array[indexmin] = max;

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
        int index = -1;
        int l = array.Length;
        for (int i = 0; i < l; i++)
            if (array[i] > 0)
            {

                index = i;
                break;
            }
        if (index == -1)
        {
            return array;
        }
        for (int i = 0; i < l; i++)
        {
            if (array[i] > 0 && array[i] < array[index])
            {
                index = i;
            }
        }
        double[] a = new double[l - 1];
        int l2 = a.Length;
        for (int j = 0; j < index; j++)
        {
            a[j] = array[j];
        }
        for (int j = index; j < l2; j++)
        {
            a[j] = array[j + 1];
        }
        array = a;
        // end

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
        int index = 0;
        int p = 0;
        int l = array.Length;
        int indexmin = 0;
        for (int i = 0; i < l; i++)
        {
            if (array[i] > array[index])
            {
                index = i;
            }
            if (array[i] < 0) p++;

        }
        if (p == 0)
        {
            return array;
        }
        double s = 0;
        for (int i = index + 1; i < l; i++)
        {
            s += array[i];
        } 
        s = Math.Round(s, 1);
        for (int i = 0; i < l; i++)
        {
            if (array[i] < 0)
            {
                indexmin = i;
                break;
            }
        }
        array[indexmin] = s;
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
            int p = 0;
            double l = array.Length;
            double max = -1000;
            double min = 0;
            int index = 0;
            int indexmax = 0;
            for (int i = 0; i < l; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    indexmax = i;
                }
                if (array[i] < 0)
                {
                    p++;
                } 
            }
            if (p == 0)
            {
                return array;
            } 
            for (int i = 0; i < l; i++)
            {
                if (array[i] < 0)
                {
                    min = array[i];
                    index = i;
                    break;
                }
            }
            array[index] = max;
            array[indexmax] = min;
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
            double srznach = 0;
            double l = array.Length;
            int c = 0;
            int el = 0;
            for (int i = 0; i < l; i++)
            {
                srznach += array[i];
            }
            srznach /= l;
            for (int i = 0; i < l; i++)
            {
                if (array[i] < srznach)
                {
                    c++;
                }
            }
            output = new int[c];
            for (int i = 0; i < l; i++)
            {
                if ((array[i] < srznach))
                {
                    output[el] = i;
                    el++;
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
        int l = array.Length;
        int indexmax1 = 0;
        int indexmax2 = 0;
        for (int i = 1; i < l; i += 2)
        {
            if (array[i] > array[indexmax1])
            {
                indexmax1 = i;
            }
        }
        for (int i = 0; i < l; i += 2)
        {
            if (array[i] > array[indexmax2])
            {
                indexmax2 = i;
            }
        }
        if (array[indexmax2] >= array[indexmax1])
        {
            for (int i = 0; i < (l / 2); i++)
            {
                array[i] = 0;
            }
        }
        else
        {
            for (int i = l / 2; i < l; i++)
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
        int l = array.Length;
        int indexmin= 0;
        int p = 0;
        int v = 0;
        for (int i = 0; i < l; i++)
        {
            if (array[indexmin] > array[i])
            {
                indexmin = i;
            }
        }
        for (int i = 0; i < l; i++)
        {
            if (array[i] < 0)
            {
                p = i;
                v++;
                break;
            }
        }
        if (v == 0)
        {
            return 0;
        } 
        if (p < indexmin)
        {
            for (int i = 0; i < l; i += 2)
            {
                sum += array[i];
            }
        }
        else
        {
            for (int i = 1; i < l ; i += 2)
            {
                sum += array[i];
            }
        }
        sum = Math.Round(sum, 1);

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
        double max = -10000000000000;
        double c = -1;
        double l = array.Length;
        for (int i = 0; i < l; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            } 
        }
        c = max + 1;
        for (int i = 0; i < l; i++)
        {
            if (array[i] == max)
            {
                array[i] = c;
                c++;
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
            int l = array.Length;
            double[] e = new double[(l + 1) / 2];
            int l2 = e.Length;
            for (int i = 0; i < l; i += 2)
            {
                e[i / 2] = array[i];
            }
            for (int i = 0; i < l2; i++)
            {
                for (int j = i + 1; j < l2; j++)
                {
                    if (e[j] < e[i])
                    {
                        (e[j], e[i]) = (e[i], e[j]);
                    }
                }
            }
            for (int i = 0; i < l; i += 2)
            {
                array[i] = e[i / 2];
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
               
        int l = array.Length;
        double ip;
        for (int i = 0; i < l; i++)
        {
            if (array[i] < 0)
            {
                for (int j = i + 1; j < l; j++)
                {
                    if ((array[j] < 0) && (array[j] > array[i]))
                    {
                        ip = array[i];
                        array[i] = array[j];
                        array[j] = ip;
                    }
                }
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
        X = new double[n];
        Y = new double[n];
        double x;
        globalMax = Y[0];
        globalMin = Y[0];
        double p = (b - a) / ((double)(n - 1));
        for (int i = 0; i < n; i++)
        {
            x = a + i * p;
            x = Math.Round(x, 2);
            X[i] = x;
            Y[i] = Math.Round(Math.Cos(x) + x * Math.Sin(x), 2);

        }
        globalMax = Y[0];
        globalMin = Y[0];
        foreach (double y in Y)
        {
            if (y > globalMax) globalMax = y;
            if (y < globalMin) globalMin = y;
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
        // code here
        double[] norm = new double[array.Length];
        int imax = 0; 
        int imin = 0;
        int l = array.Length;
        double t;
        for (int i = 0; i < l; i++)
        {
            if (array[i] > array[imax]) imax = i;
            if (array[i] < array[imin]) imin = i;
        }
        t = 2 / (array[imax] - array[imin]);
        for (int i = 0; i < l ; i++)
        {
            norm[i] = Math.Round((array[i] - array[imin]) * t - 1, 2);
        }
        // end

        return norm;
    }
    #endregion
}