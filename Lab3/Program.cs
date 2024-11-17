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
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {   
        // code here
        double summa = 0.0;
        
        for (int i = 0; i < array.Length; i++)
        {
            summa += array[i];
        }
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array[i] / summa;
        }
        
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double foo = 0.0;
        double bar = 0.0;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                foo += array[i];
                bar++;
            }

        }

        foo /= bar;
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = (array[i] > 0 ? foo : array[i]);
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
            sum[i] = first[i] + second[i];
            dif[i] = first[i] - second[i];
        }
        
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double foo = 0.0;
        for (int i = 0; i < array.Length; i++)
        {
            foo += array[i];
        }

        foo /= array.Length;
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] -= foo;
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
            product += vector1[i] * vector2[i];
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

        return Math.Round(length, 4);
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double foo = 0.0;
        for (int i = 0; i < array.Length; i++)
        {
            foo += array[i];
        }

        foo /= array.Length;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > foo) array[i] = 0;
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
        double foo = 0.0;
        for (int i = 0; i < array.Length; i++)
        {
            foo += array[i];
        }

        foo /= array.Length;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > foo) count++;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        if (P >= Q) return 0;
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
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) j++;
        }

        int k = 0;
        output = new double[j];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) {
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
        int foo = 0;
        int bar = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[bar] = array[i];
                bar++;
            }
            else
            {
                odd[foo] = array[i];
                foo++;
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
            y[i] = (x[i] <= 0 ? double.NaN : 0.5 * Math.Log(x[i], Math.E));
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
        double maxFoo = 0.0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxFoo) maxFoo = array[i];
        }
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == maxFoo) break;
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
        double maxFoo = 0.0;
        int index = 0;
        double bar = 0.0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxFoo)
            {
                maxFoo = array[i];
                index = i;
            }
            bar += array[i];
        }

        bar /= array.Length;
        
        for (int i = index + 1; i < array.Length; i++)
        {
            array[i] = bar;
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
        double foo = 0.0;
        for (int i = 0; i < array.Length; i++)
        {
            foo += array[i];
        }
        foo /= array.Length;

        double minRazn = 99999;
        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(foo - array[i]) < minRazn)
            {
                minRazn = Math.Abs(foo - array[i]);
                index = i;
            }
        }

        double[] arr = new double[array.Length + 1];
        for (int i = 0; i <= index; i++)
        {
            arr[i] = array[i];
        }
        arr[index + 1] = P;
        for (int i = index + 1; i < arr.Length - 1; i++)
        {
            arr[i + 1] = array[i];
        }

        array = arr;
        
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
        
        double maxFoo = 0.0;
        int indexMaxFoo = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxFoo)
            {
                maxFoo = array[i];
                indexMaxFoo = i;
            }
        }

        double maxBar = 0.0;
        int indexMaxBar = 0;
        double minBar = 9999;
        int indexMinBar = 0;
        for (int i = indexMaxFoo; i < array.Length; i++)
        {
            if (array[i] > maxBar)
            {
                maxBar = array[i];
                indexMaxBar = i;
            }
            if (array[i] < minBar)
            {
                minBar = array[i];
                indexMinBar = i;
            }
        }

        array[indexMinBar] = maxBar;
        array[indexMaxBar] = minBar;
        
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
        double minFoo = 9999;
        int minFooIndex = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minFoo && array[i] > 0)
            {
                minFoo = array[i];
                minFooIndex = i;
            }
        }
        
        if (minFooIndex == -1) return array;
        
        double[] arr = new double[array.Length - 1];
        for (int i = 0; i < minFooIndex; i++)
        {
            arr[i] = array[i];
        }
        for (int i = minFooIndex + 1; i < array.Length; i++)
        {
            arr[i - 1] = array[i];
        }

        array = arr;
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
        double maxFoo = -9999;
        int indexMaxFoo = -1;

        int firstBar = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                firstBar = i;
                break;
            }
        }
        
        if (firstBar == -1) return array;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxFoo)
            {
                maxFoo = array[i];
                indexMaxFoo = i;
            }
        }

        double foo = 0.0;
        for (int i = indexMaxFoo + 1; i < array.Length; i++)
        {
            foo += array[i];
        }
        
        array[firstBar] = foo;

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
        double maxFoo = -9999;
        int indexMaxFoo = -1;

        int firstBar = -1;
        double bar = 0.0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0 && firstBar == -1)
            {
                firstBar = i;
                bar = array[i];
            }
            if (array[i] > maxFoo)
            {
                maxFoo = array[i];
                indexMaxFoo = i;
            }
        }
        
        if (firstBar == -1) return array;
        
        array[firstBar] = maxFoo;
        array[indexMaxFoo] = bar;

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
        double foo = 0.0;
        for (int i = 0; i < array.Length; i++)
        {
            foo += array[i];
        }
        
        foo /= array.Length;

        int countBar = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < foo) countBar++;
        }
        
        output = new int[countBar];
        countBar = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < foo)
            {
                output[countBar] = i;
                countBar++;
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
        double maxFoo = -9999;
        double maxBar = -9999;

        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (array[i] > maxFoo) maxFoo = array[i];
            }
            else
            {
                if (array[i] > maxBar) maxBar = array[i];
            }
        }

        if (maxFoo > maxBar)
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
        int firstNumIndex = -1;

        double minFoo = 9999;
        int minFooIndex = -1;
        
        for (int i = 0; i < array.Length; i++)
        {
           if (array[i] < 0 && firstNumIndex == -1) firstNumIndex = i;
           if (minFoo > array[i])
           {
               minFoo = array[i];
               minFooIndex = i;
           }
        }

        double fooResult = 0.0;
        if (firstNumIndex < minFooIndex && firstNumIndex != -1 && minFooIndex != -1)
        {
            for (int i = 0; i < array.Length; i += 2)
            {
                fooResult += array[i];
            }
        }
        else
        {
            for (int i = 1; i < array.Length; i += 2)
            {
                fooResult += array[i];
            }
        }

        sum = fooResult;
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
        double maxFoo = -9999;
        int maxFooIndex = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (maxFoo < array[i])
            {
                maxFoo = array[i];
                maxFooIndex = i;
            }
        }

        if (maxFooIndex == -1 || array.Length < 2) return array;
        
        for (int i = 0; i < maxFooIndex; i += 2)
        {
            if (i + 1 == maxFooIndex) break;
            double temp = array[i];
            array[i] = array[i + 1];
            array[i + 1] = temp;
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

        // code here
        int foo = 1;
        int maxFoo = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i - 1])
            {
                foo++;
            }
            else
            {
                if (foo > maxFoo) maxFoo = foo;
                foo = 1;
            }
        }
        
        if (foo > maxFoo) maxFoo = foo;
        count = maxFoo;
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
        int foo = 1;
        int maxFoo = 1;
        
        int bar = 1;
        int minBar = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i - 1]) foo++;
            else
            {
                if (foo > maxFoo) maxFoo = foo;
                foo = 1;
            }
            
            if (array[i] > array[i - 1]) bar++;
            else
            {
                if (bar > minBar) minBar = bar;
                bar = 1;
            }
        }
        
        if (foo > maxFoo) maxFoo = foo;
        if (bar > minBar) minBar = bar;

        count = (maxFoo > minBar ? maxFoo : minBar);
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

        // end

        return (X, Y, globalMax,globalMin);
    }
    public double[] Task_3_12(double[] array)
    {
        // code here
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) count++;
        }

        int j = 0;
        double[] arr = new double[array.Length - count];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                arr[j] = array[i];
                j++;
            }
        }

        array = arr;
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

        // end

        return normalizedArray;
    }
    #endregion
}