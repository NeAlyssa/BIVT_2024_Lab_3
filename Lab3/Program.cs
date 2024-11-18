using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.IO.IsolatedStorage;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
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
        for (int i = 0; i < 6; i ++)
        {
            s += array[i];
        }
        for (int i = 0; i < 6; i ++)
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
        int count = 0;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                count++;
            }
        }
        if (count == 0) return array;
        double sr = s / count;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                array[i] = Math.Round(sr, 2);
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
        double sum = 0;
        for (int i = 0; i < 5; i++)
        {
            sum += array[i];
        }
        double sr = Math.Round(sum / 5, 2);
        for (int i = 0; i < 5; i++)
        {
            array[i] = Math.Round(array[i]-sr, 2);
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
        product = Math.Round(product, 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        double sum = 0;
        for (int i = 0; i < 5; i++)
        {
            sum += vector[i] * vector[i];
        }
        length = Math.Round(Math.Sqrt(sum), 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sum = 0;
        for (int i = 0; i < 7; i++)
        {
            sum += array[i];
        }
        double sr = Math.Round(sum / 7, 2);
        for (int i = 0; i < 7; i++)
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
        for (int i = 0; i < 6; i++)
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
        double sum = 0;
        for (int i = 0; i < 8; i++)
        {
            sum += array[i];
        }
        double sr = Math.Round(sum / 8, 2);
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
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > P && array[i] < Q) count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {

        // code here
        int count = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                count ++;
            }
        }
        int countOut = 0;
        double[] output = new double[count];
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                output[countOut] = array[i];
                countOut ++;
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
        int evenI = 0;
        int oddI = 0;
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                even[evenI] = array[i];
                evenI++;
            }
            else
            {
                odd[oddI] = array[i];
                oddI++;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        int index = 11;
        for (int i = 0; i < 11; i++)
        {
            if (array[i] < 0)
            {
                index = i;
                break;
            }
        }
        for (int i = 0; i < index; i++)
        {
            sum += array[i] * array[i];
        }
        sum = Math.Round(sum, 2);
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
        int maxIndex = -1;
        double maxElement = -1000000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= maxElement)
            {
                maxElement = array[i];
                maxIndex = i;
            }
        }
        for (int i = 0; i < maxIndex; i++)
        {
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
        double sum = 0;
        int count = 0;
        int maxIndex = -1;
        double maxElement = -1000000;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            count++;
            if (array[i] >= maxElement)
            {
                maxElement = array[i];
                maxIndex = i;
            }
        }
        if (maxIndex == -1) return array;
        if (count == 0) return array;
        double sr = Math.Round(sum / count, 2);
        for (int i = maxIndex += 1; i < array.Length; i++)
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
        int count = array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        double sr = sum / count;

        double minDif = 1000000;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - sr) < minDif)
            {
                minDif = Math.Abs(array[i]-sr);
                index = i;
            }
        }

        double[] newArray = new double[array.Length + 1];
        int indexArray = 0;
        for (int i = 0; i < newArray.Length; i++)
        {
            if (i == 1 + index)
            {
                newArray[i] = P;
            }
            else
            {
                newArray[i] = array[indexArray];
                indexArray++;
            }
        }

        array = newArray;
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
        double maxElement = -1;
        int maxIndex = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= maxElement)
            {
                maxElement = array[i];
                maxIndex = i;
            }
        }
        double minElement = 10000000;
        int minIndex = -1;
        for (int i = maxIndex; i < array.Length; i++)
        {
            if (array[i] < minElement)
            {
                minElement = array[i];
                minIndex = i;
            }
        }
        double x = array[maxIndex];
        array[maxIndex] = array[minIndex];
        array[minIndex] = x;
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
        double minElement = 10000000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                if (array[i] < minElement)
                {
                    minElement = array[i];
                }          
            }
        }
        if (minElement == 10000000) return array;

        double[] newArray = new double[array.Length - 1];
        int indexNewArray = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != minElement)
            {
                newArray[indexNewArray] = array[i];
                indexNewArray++;
            }
        }

        array = newArray;
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
        int index = -111;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                index = i;
                break;
            }
        }
        if (index == -111) return array;

        int indexMax = -1;
        double maxElement = -1000000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxElement)
            {
                maxElement = array[i];
                indexMax = i;
            }
        }

        double sum = 0;
        for (int i = indexMax + 1; i < array.Length; i++)
        {
            sum += array[i];
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (i == index)
            {
                array[i] = Math.Round(sum, 2);
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
        int indexOtric = -111;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                indexOtric = i;
                break;
            }
        }
        if (indexOtric == -111) return array;

        int indexMax = -1;
        double maxElement = -1000000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxElement)
            {
                maxElement = array[i];
                indexMax = i;
            }
        }

        double dopMax = array[indexMax];
        double dopOtric = array[indexOtric];
        for (int i = 0; i < array.Length; i++)
        {
            if (i == indexMax)
            {
                array[i] = dopOtric;
            }
            else if (i == indexOtric)
            {
                array[i] = dopMax;
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

        // code here
        double sum = 0;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            count++;
        }
        double sr = sum / count;

        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr) k++;
        }

        int[] index = new int[k];
        int dopI = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr)
            {
                index[dopI] = i;
                dopI++;
            }
        }
        output = index;
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
        double maxChetI = -1000;
        double maxNeChetI = -1000;

        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (array[i] > maxChetI)
                {
                    maxChetI = array[i];
                }
            }
            else
            {
                if (array[i] > maxChetI)
                {
                    maxNeChetI = array[i];
                }
            }
        }

        bool dop = maxChetI > maxNeChetI;
        if (dop)
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
        int indexOtric = -111;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                indexOtric = i;
                break;
            }
        }
        if (indexOtric == -111) return sum;

        int indexMinim = -111;
        double minElement = 100000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minElement)
            {
                minElement = array[i];
                indexMinim = i;
            }
        }

        if (indexMinim > indexOtric)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0) sum += array[i];
            }
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 1) sum += array[i];
            }
        }
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
        double maxElement = -1000000000;
        int indexMax = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxElement)
            {
                maxElement = array[i];
                indexMax = i;
            }
        }
        if (indexMax == -1) return array;

        for (int i = 0; i < indexMax - 1; i +=2)
        {
            double dop = array[i];
            array[i] = array[i + 1];
            array[i + 1] = dop;
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
        int maxCount = -1;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i + 1] <= array[i]) count++;
            else
            {
                if (count > maxCount) maxCount = count;
                count = 0;
            }
        }
        count = maxCount + 1;
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
        int countVozr = 1;
        int countUbiv = 1;

        int maxCntVozr = -10000;
        int maxCntUbiv = -10000;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] <= array[i + 1])
            {
                countVozr++;
            }
            else
            {
                if (countVozr > maxCntVozr)
                {
                    maxCntVozr = countVozr;
                }
                countVozr = 1;
            }
        }
        if (countVozr > maxCntVozr)
        {
            maxCntVozr = countVozr;
        }
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] >= array[i + 1])
            {
                countUbiv++;
            }
            else
            {
                if (countUbiv > maxCntUbiv)
                {
                    maxCntUbiv = countUbiv;
                }
                countUbiv = 1;
            }
        }
        if (countUbiv > maxCntUbiv)
        {
            maxCntUbiv = countUbiv;
        }

        if (maxCntUbiv > maxCntVozr)
        {
            count = maxCntUbiv;
        }
        else count = maxCntVozr;
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
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                k++;
            }
        }

        double[] x = new double[array.Length - k];
        k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) continue;
            x[k] = array[i];
            k++;
        }
        // end

        return x;

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
