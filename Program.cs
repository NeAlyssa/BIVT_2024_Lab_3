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
        //program.Task_1_1(new int[] {1, 2, 3, 4, 5, 6});
        //program.Task_1_15(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, 2, 3.1, -0.7 });
        //program.Task_2_6(new double[] { 0, 1.5, -1, -3, -2.2, -0.5, 6 }, 2.3);
        //program.Task_2_8(new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 2 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double s = 0;
        for (int i = 0; i<array.Length; i++)
        {
            s += array[i];

        }
        for (int i = 0;i < array.Length; i++)
        {
            array[i]=Math.Round(array[i] /s, 2);
        }

        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0; int a = 0;
        for (int i = 0; i<array.Length; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                a++;
            }
        }
        double sr = Math.Round(s / a, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) array[i] = sr;
        }
            // end

            return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i<first.Length; i++)
        {
            sum[i] = Math.Round(first[i]+second[i], 2);
            dif[i]=Math.Round(first[i]-second[i], 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s = 0;
        for (int i = 0; i<array.Length; i++)
        {
            s += array[i];
        }
        double sr = s/array.Length;
        for (int i = 0; i < array.Length; i++)
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
        for (int i = 0; i<vector1.Length; i++)
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
        foreach (double i in vector)
        {
            length += i * i;
        }
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        foreach(double x in array)
        {
            s += x;
        }
        double sr = s/ array.Length;
        for (int i = 0;i < array.Length; i++)
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
        foreach(double x in array)
        {
            if (x < 0) count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double s = 0;
        foreach (double x in array)
        {
            s += x;
        }
        double sr = s / array.Length;
        foreach (double x in array)
        {
            if (x > sr) count++;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        foreach (double x in array)
        {
            if (x>P && x < Q) count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int count = 0;
        foreach (double x in array)
        {
            if (x > 0) count++;
        }
        output = new double[count];
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
        for (int  i = array.Length -1; i>=0; i--)
        {
            if (array[i]< 0)
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
        int j = 0;
        for (int i = 0;i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[j] = array[i];
            }
            else
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
        foreach(double x in array)
        {
            if (x >= 0) sum += x * x;
            else break;
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
            if (x[i] > 0) y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            else y[i] = double.NaN;
        }
        for (int i = 0; i < x.Length; i++)
        {
            Console.WriteLine($"{x[i], 4} {y[i], 4}");
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
        int maxin = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxin]) maxin = i;
        }
        for (int i = 0; i < maxin; i++)
        {
            sum+= array[i];
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
        double maxel = array[0];
        int maxin = 0;
        double sum = array[0];
        for (int i = 1; i<array.Length; i++)
        {
            if (array[i]> maxel)
            {
                maxel = array[i];
                maxin = i;
            }
            sum += array[i];

        }
        double sr = Math.Round(sum / array.Length, 2);
        for (int i = maxin+1; i < array.Length; i++)
        {
            array[i] = sr;
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
        foreach(double x in array)
        {
            sum += x;
        }
        double sr = sum / array.Length;
        double razn = double.MaxValue;
        int elem = 0;
        for(int i = 0; i<array.Length; i++)
        {
            double temp = Math.Abs(array[i] - sr);
            if (temp < razn)
            {
                razn = temp;
                elem = i;
            }
        }
        double[] b = new double[array.Length+1];
        for (int i = 0; i<array.Length; i++)
        {
            if (i <= elem) b[i] = array[i];
            else if (i == elem + 1)
            {
                b[i] = P;
                b[i + 1] = array[i];
            }
            else b[i + 1] = array[i];
        }
        foreach(double x in array) Console.Write($"{x}  ");
        Console.WriteLine();
        foreach (double x in b) Console.Write($"{x}  ");
        array = b;
        Console.WriteLine();
        foreach (double x in array) Console.Write($"{x}  ");
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
        int imin = 0, imax = 0, i ;
        double minel = double.MaxValue, maxel=double.MinValue;
        for (i = 0; i<array.Length; i++)
        {
            if (array[i] > maxel)
            {
                maxel= array[i];
                imax = i;
                minel= array[i];
                imin = i;
            }
            else if (array[i] < minel)
            {
                minel = array[i];
                imin = i;
            }
        }
        double temp = array[imin];
        array[imin] = array[imax];
        array[imax] = temp;
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
        double[] answer = new double[array.Length - 1];
        int imin = -1;
        double minel = double.MaxValue;
        for (int i = 1; i<array.Length; i++)
        {
            if (array[i]>0 && array[i] < minel)
            {
                imin = i; minel= array[i];
            }
        }
        if (imin == -1) return array;
        for (int i = 0; i<array.Length; i++)
        {
            if (i < imin) answer[i] = array[i];
            else if (i == imin) continue;
            else answer[i-1] = array[i];
        }
        array = answer;
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
        int otr=-1;
        double maxel=double.MinValue, sum=0;
        for (int i = 0; i < array.Length; i++)
        {
            if (otr == -1 && array[i] < 0) otr = i;
            if (array[i] > maxel)
            {
                maxel = array[i];
                sum = 0;
                continue;

            }
            else sum += array[i];
        }
        if (otr == -1) return array;
        array[otr] = Math.Round(sum, 2);
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
        int imax = 0, otr = -1;
        for (int i = 0; i<array.Length; i++)
        {
            if (otr == -1 && array[i] < 0) otr = i;
            if (array[i] > array[imax]) imax = i;
        }
        if (otr == -1) return array;
        double temp = array[imax];
        array[imax] = array[otr];
        array[otr] = temp;
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
        double sum = 0;
        foreach(double x in array)
        {
            sum += x;
        }
        double sr = sum/ array.Length;
        int n=0;
        for (int i = 0;i < array.Length; i++)
        {
            if (array[i] < sr)n++;
        }
        output = new int[n];
        for (int i = 0, j=0;j<n; i++)
        {
            if (array[i] < sr)
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
        int ich = 0, inech = 1;
        for (int i = 2; i<array.Length; i+=2)
        {
            if (array[i] > array[ich]) ich = i;
        }
        for (int i = 3; i < array.Length; i += 2)
        {
            if (array[i] > array[inech]) inech = i;
        }
        if (array[ich] > array[inech])
        {
            for (int i = 0; i< array.Length/2; i++)
            {
                array[i] = 0;
            }
        }
        else
        {
            for (int i = array.Length/2; i < array.Length; i++)
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
        int otr = -1, imin=0;

        // code here
        for (int i = 0;i<array.Length; i++)
        {
            if (otr == -1 && array[i] < 0) otr = i;
            if (array[i] < array[imin]) imin = i;
            if (!(otr == -1) && otr < imin)
            {
                for (int j = 0; j<array.Length; j += 2)
                {
                    sum += array[j];
                }
                return sum;
            }
        }
        if (otr == -1) return 0;
        for (int j = 1; j < array.Length; j += 2)
        {
            sum += array[j];
        }
        // end

        return sum;
    }
    #endregion
    #region Level 3   
    public int[] Task_3_1(double[] array)  //2 5 8 11 14
    {
        int[] output = null;

        // code here

        // end

        return output;
    }
    public double[] Task_3_2(double[] array)
    {
        // code here
        double maxel = array[0];
        int n = array.Length;
        for (int i = 1; i<n; i++)
        {
            if (array[i] > maxel) maxel = array[i];
        }
        for (int i = 0, j=1; i<n; i++)
        {
            if (array[i] == maxel)
            {
                array[i] += j;
                j++;
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
        int n = array.Length;
        for (int i = 0; i<n; i += 2)
        {
            for (int j = 0; j<n-i-2; j += 2)
            {
                if (array[j]> array[j + 2])
                {
                    double temp = array[j];
                    array[j] = array[j+2];
                    array[j+2] = temp;
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
        int n = array.Length;
        int ind1otr = -1;
        for (int i = 0, k=0; i<n; i++)    // k - количество поставленных на место отрицательных элементов
        {
            if (array[i] < 0)
            {
                if (ind1otr == -1) ind1otr = i;   //индекс первого отрицательного элемента
                int indtek = ind1otr;
                for (int j = ind1otr+1; j<n-k; j++)
                {
                    if (array[j] < 0)
                    {
                        if (array[j] > array[indtek])   //наименьший элемент продвигаем в конец
                        {
                            double temp = array[j];
                            array[j] = array[indtek];
                            array[indtek] = temp;
                        }
                        indtek = j;
                    }

                }
                k++;
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
        globalMax = double.MinValue;
        globalMin = double.MaxValue;
        X = new double[n];
        Y = new double[n];
        int k = 0;
        double shag = (b - a) / (n - 1);
        for (double x = a; x<=b; x += shag, k++)
        {
            X[k] = Math.Round(x, 2);
            double y = Math.Round(Math.Cos(x) + x * Math.Sin(x), 2);
            Y[k] = y;
            if (y > globalMax) globalMax = y;
            if (y< globalMin) globalMin = y;
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
        int n = array.Length;
        normalizedArray = new double[n];
        int imin = 0, imax = 0;
        for (int i = 1; i<n; i++)
        {
            if (array[i] > array[imax]) imax = i;
            else if (array[i] < array[imin]) imin = i;
        }
        double maxel = array[imax];
        double minel = array[imin];
        for (int i = 0;i<n; i++)
        {
            normalizedArray[i] = Math.Round(2 * (array[i] - minel) / (maxel - minel)-1, 2);
        }

        // end

        return normalizedArray;
    }
    #endregion
}