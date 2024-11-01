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
        double s = 0;

        foreach (double el in array)
        {
            s += el;
        }

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] / s, 2);
        }

        return array;
    }

    public double[] Task_1_2(double[] array)
    {
        double avg = 0;
        int cnt = 0;

        foreach (double el in array)
        {
            if (el > 0)
            {
                avg += el;
                cnt++;
            }
        }

        avg /= cnt;
        avg = Math.Round(avg, 2);

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) array[i] = avg;
        }

        return array;
    }

    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        for (int i = 0; i < first.Length; i++)
        {
            sum[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = Math.Round(first[i] - second[i], 2);
        }

        return (sum, dif);
    }

    public double[] Task_1_4(double[] array)
    {
        double avg = 0;

        foreach (double el in array)
        {
            avg += el;
        }

        avg /= array.Length;
        avg = Math.Round(avg, 2);

        for (int i = 0; i < array.Length; i++)
        {
            array[i] -= avg;
            array[i] = Math.Round(array[i], 2);
        }

        return array;
    }

    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        for (int i = 0; i < vector1.Length; i++)
        {
            product += vector1[i] * vector2[i];
        }

        product = Math.Round(product, 2);

        return product;
    }

    public double Task_1_6(double[] vector)
    {
        double length = 0;

        foreach (double el in vector)
        {
            length += el * el;
        }

        length = Math.Sqrt(length);

        return Math.Round(length, 2);
    }

    public double[] Task_1_7(double[] array)
    {
        double avg = 0;

        foreach (double el in array)
        {
            avg += el;
        }

        avg /= array.Length;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > avg) array[i] = 0;
        }

        return array;
    }

    public int Task_1_8(double[] array)
    {
        int count = 0;

        foreach (double el in array)
        {
            if (el < 0) count++;
        }

        return count;
    }

    public int Task_1_9(double[] array)
    {
        int count = 0;
        double avg = 0;

        foreach (double el in array)
        {
            avg += el;
        }

        avg /= array.Length;

        foreach (double el in array)
        {
            if (el > avg) count++;
        }

        return count;
    }

    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        foreach (double el in array)
        {
            if (P < el && el < Q) count++;
        }

        return count;
    }

    public double[] Task_1_11(double[] array)
    {
        double[] output = new double[array.Length];
        int i = 0;

        foreach (double el in array)
        {
            if (el > 0)
            {
                output[i++] = el;
            }
        }

        return output;
    }

    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] < 0)
            {
                value = array[i];
                index = i;
                break;
            }
        }

        return (value, index);
    }

    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length / 2];
        int i = 0, j = 0;

        for (int k = 0; k < array.Length; k++)
        {
            if (k % 2 == 0) even[i++] = array[k];
            else odd[j++] = array[k];
        }

        return (even, odd);
    }

    public double Task_1_14(double[] array)
    {
        double sum = 0;

        foreach (double el in array)
        {
            if (el < 0) break;
            sum += el * el;
        }

        return sum;
    }

    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] > 0) y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            else y[i] = Double.NaN;
        }

        for (int i = 0; i < x.Length; i++)
        {
            Console.WriteLine($"{x[i],-6}{((x[i] > 0) ? y[i] : "NaN")}");
        }

        return y;
    }

    #endregion

    #region Level 2

    public double[] Task_2_1(double[] array)
    {
        double min = array[0];
        int index = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                index = i;
            }
        }

        array[index] *= 2;

        return array;
    }

    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here

        // end

        return sum;
    }

    public double[] Task_2_3(double[] array) // в тесте ошибка (вместо -0.5 должно быть -2)
    {
        double min = array[0];
        int index = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                index = i;
            }
        }

        for (int i = 0; i < index; i++)
        {
            if (array[i] > 0) array[i] *= 2;
            else array[i] /= 2;
        }

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
        double min = array[0], max = array[0];
        int minIndex = 0, maxIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                minIndex = i;
            }
            else if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
        }

        int j = 0;
        for (int i = minIndex + 1; i < maxIndex; i++)
        {
            array[j++] = array[i];
        }

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
        double max = array[0];
        int maxIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
        }

        if (maxIndex + 1 < array.Length)
        {
            if (array[maxIndex + 1] > 0) array[maxIndex + 1] *= 2;
            else array[maxIndex + 1] /= 2;
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
        double max = array[0], min = array[0];
        int maxIndex = 0, minIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                minIndex = i;
            }
            else if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
        }

        if (minIndex > maxIndex)
        {
            int temp = minIndex;
            minIndex = maxIndex;
            maxIndex = temp;
        }

        for (int i = minIndex + 1; i < maxIndex; i++)
        {
            average += array[i];
        }

        if (maxIndex - minIndex - 1 == 0) average = 0;
        else average /= (maxIndex - minIndex - 1);
        average = Math.Round(average, 2);

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
        int index = 0;
        bool isPositive = false;

        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] > 0)
            {
                index = i;
                isPositive = true;
                break;
            }
        }

        if (!isPositive) return array;

        double[] newArray = new double[array.Length + 1];

        for (int i = 0, j = 0; i < newArray.Length; i++)
        {
            if (i == index + 1)
            {
                newArray[i] = P;
            }
            else
            {
                newArray[i] = array[j++];
            }
        }

        return newArray;
    }

    public double[] Task_2_12(double[] array)
    {
        // code here

        // end

        return array;
    }

    public double[] Task_2_13(double[] array)
    {
        double max = array[0];
        int maxIndex = 0;

        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
        }

        array[maxIndex] = maxIndex;

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

        if (k > A.Length - 1) return A;

        for (int i = 0, j = 0, n = 0; i < output.Length; i++)
        {
            if (k < i && n != B.Length)
            {
                output[i] = B[n];
                n++;
            }
            else
            {
                output[i] = A[j];
                j++;
            }
        }

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

        double max = array[0], min = array[0];
        int maxIndex = 0, minIndex = 0;

        double avgPos = 0, avgNeg = 0;
        int cntPos = 0, cntNeg = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                minIndex = i;
            }
            else if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }

            if (array[i] < 0)
            {
                avgNeg += array[i];
                cntNeg++;
            }
            else if (array[i] > 0)
            {
                avgPos += array[i];
                cntPos++;
            }
        }

        if (maxIndex < minIndex && cntPos != 0) average = avgPos / cntPos;
        else if (maxIndex > minIndex && cntNeg != 0) average = avgNeg / cntNeg;
        else average = 0;

        average = Math.Round(average, 2);

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
        double max = array[0], sum = 0;
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index = i;
            }

            sum += array[i];
        }

        if (max > sum) array[index] = 0;
        else array[index] *= 2;

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

        // end

        return array;
    }

    public double[] Task_3_3(double[] array)
    {
        double max = array[0];
        int index = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index = i;
            }
        }

        for (int i = 0; i != index && i + 1 != index; i += 2)
        {
            double temp = array[i];
            array[i] = array[i + 1];
            array[i + 1] = temp;
        }

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
        int count = 1, answer = 1;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] > array[i])
            {
                count += 1;
            }
            else
            {
                if (count > answer) answer = count;
                count = 1;
            }
        }

        return answer;
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
        int answer = 1, countDec = 1, countInc = 1;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] > array[i]) // убывание
            {
                if (countInc > answer) answer = countInc;
                countInc = 1;
                countDec++;
            }
            else if (array[i - 1] < array[i]) // возрастание
            {
                if (countDec > answer) answer = countDec;
                countDec = 1;
                countInc++;
            }
        }

        if (countDec > answer) answer = countDec;
        if (countInc > answer) answer = countInc;

        Console.WriteLine(answer);

        return answer;
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

        return (X, Y, globalMax, globalMin);
    }

    public double[] Task_3_12(double[] array)
    {
        int len = array.Length;
        for (int i = 0; i < len; i++)
        {
            if (array[i] < 0)
            {
                len--;
                for (int j = i; j < len; j++)
                {
                    array[j] = array[j + 1];
                }

                i--;
            }
        }
        Array.Resize(ref array, len);
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