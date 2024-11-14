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
        double sum = 0;

        for (int i = 0; i < 6; i++) {
            sum += array[i];
        }

        for (int i = 0; i < 6; i++) {
            array[i] = Math.Round(array[i] / sum, 2);
        }

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        double sum = 0;
        int len = 0;

        for (int i = 0; i < 8; i++) {
            if (array[i] > 0) {
                sum += array[i];
                len++;
            }
        }

        sum = Math.Round(sum / len, 2);

        for (int i = 0; i < 8; i++) {
            if (array[i] > 0) array[i] = sum;
        }

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        for (int i = 0; i < 4; i++) {
            sum[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = Math.Round(first[i] - second[i], 2);
        }

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        double sr = 0;

        for (int i = 0; i < 5; i++) {
            sr += array[i];
        }

        sr /= array.Length;

        for (int i = 0; i < 5; i++) array[i] = Math.Round(array[i] - sr, 2);

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        for (int i = 0; i < 4; i++) {
            product += vector1[i] * vector2[i];
        }

        return Math.Round(product, 2);
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        for (int i = 0; i < 5; i++) {
            length += vector[i] * vector[i];
        }

        return Math.Round(Math.Sqrt(length), 2);
    }
    public double[] Task_1_7(double[] array)
    {
        double sr = 0;

        for (int i = 0; i < 7; i++) {
            sr += array[i];
        }

        sr /= array.Length;

        for (int i = 0; i < 7; i++) {
            if (array[i] > sr) array[i] = 0;
        }

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        for (int i = 0; i < 6; i++) {
            if (array[i] < 0) count++;
        }

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;
        double sr = 0;

        for (int i = 0; i < 8; i++) {
            sr += array[i];
        }

        sr /= array.Length;

        for (int i = 0; i < 8; i++) {
            if (array[i] > sr) count++;
        }

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        for (int i = 0; i < 10; i++) {
            if (P < array[i] && array[i] < Q) count++;
        }

        return count;
    }
    public double[] Task_1_11(double[] array)
    {

        int len = 0;

        for (int i = 0; i < 10; i++) {
            if (array[i] > 0) len++;
        }

        double[] output = new double[len];

        int j = 0;

        for (int i = 0; i < 10; i++) {
            if (array[i] > 0) {
                output[j] = array[i];
                j++;
            }
        }

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        for (int i = 0; i < 8; i++) {
            if (array[i] < 0) {
                value = array[i];
                index = i;
            }
        }

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        int j = 0;
        int jj = 0;

        for (int i = 0; i < 10; i++) {
            if (i % 2 == 0) {
                even[j] = array[i];
                j++;
            } else {
                odd[jj] = array[i];
                jj++;
            }
        }

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        for (int i = 0; i < 11; i++) {
            if (array[i] < 0) break;
            
            sum += array[i] * array[i];
        }

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        for (int i = 0; i < 10; i++) {
            if (x[i] <= 0) y[i] = double.NaN;
            else y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
        }

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        double min = double.MaxValue;
        int index = -1;

        for (int i = 0; i < array.Length; i++) {
            if (array[i] < min) {
                min = array[i];
                index = i;
            }
        }
        
        array[index] = (min > 0 ? 2 : 0.5) * min;

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
        double min = double.MaxValue;
        int index = -1;

        for (int i = 0; i < array.Length; i++) {
            if (array[i] < min) {
                min = array[i];
                index = i;
            }
        }

        for (int i = 0; i < index; i++) {
            array[i] = array[i] * (array[i] > 0 ? 2 : 0.5);
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
        double min = double.MaxValue, max = double.MinValue;
        int indexMin = -1, indexMax = -1;

        for (int i = 0; i < array.Length; i++) {
            if (array[i] < min) {
                min = array[i];
                indexMin = i;
            }
            if (array[i] > max) {
                max = array[i];
                indexMax = i;
            }
        }

        int startIndex = Math.Min(indexMin, indexMax);
        int endIndex = Math.Max(indexMin, indexMax);
        int howMany = 0, j = 0;

        for (int i = startIndex + 1; i < endIndex; i++) {
            if (array[i] < 0) howMany++;
        }

        double[] newArray = new double[howMany];

        for (int i = startIndex + 1; i < endIndex; i++) {
            if (array[i] < 0) {
                newArray[j] = array[i];
                j++;
            }
        }

        return newArray;
    }
    public double[] Task_2_6(double[] array, double P)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_7(double[] array)
    {
        double max = double.MinValue;
        int index = -1;

        for (int i = 0; i < array.Length; i++) {
            if (array[i] > max) {
                max = array[i];
                index = i;
            }
        }
        if (array.Length > index + 1)
            array[index + 1] *= (array[index + 1] > 0 ? 2 : 0.5);

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

        double max = double.MinValue, min = double.MaxValue;
        int indexMax = -1, indexMin = -1;

        for (int i = 0; i < array.Length; i++) {
            if (array[i] < min) {
                min = array[i];
                indexMin = i;
            }
            if (array[i] > max) {
                max = array[i];
                indexMax = i;
            }
        }

        int startIndex = Math.Min(indexMax, indexMin);
        int endIndex = Math.Max(indexMax, indexMin);

        for (int i = startIndex + 1; i < endIndex; i++) {
            average += array[i];
        }

        if ((endIndex - 1 - startIndex) == 0) return 0;

        average /= (endIndex - 1 - startIndex);

        return Math.Round(average, 3);
    }
    public double[] Task_2_10(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_11(double[] array, double P)
    {
        int index = -1;

        for (int i = 0; i < array.Length; i++) {
            if (array[i] > 0) index = i;
        }

        if (index == -1) return array;

        double[] newArray = new double[array.Length + 1];

        for (int i = 0; i <= index; i++)
        {
            newArray[i] = array[i];
        }

        newArray[index + 1] = P;

        for (int i = index + 1; i < array.Length; i++)
        {
            newArray[i + 1] = array[i];
        }

        Console.WriteLine(string.Join(" ", array));
        Console.WriteLine(string.Join(" ", newArray));
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
        double max = double.MinValue;
        int index = -1;

        for (int i = 0; i < array.Length; i += 2) {
            if (array[i] > max) {
                max = array[i];
                index = i;
            }
        }

        array[index] = index;

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

        if (k >= A.Length) return A;

        for (int i = 0; i < k + 1; i++) {
            output[i] = A[i];
        }

        for (int i = 0; i < B.Length; i++) {
            output[k + 1 + i] = B[i];
        }

        for (int i = k + 1; i < A.Length; i++) {
            output[B.Length + i] = A[i];
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

        double averageFirst = 0, averageSecond = 0;
        int counterFirst = 0, counterSecond = 0;

        double max = double.MinValue, min = double.MaxValue;
        int indexMax = -1, indexMin = -1;

        for (int i = 0; i < array.Length; i++) {
            if (array[i] > max) {
                max = array[i];
                indexMax = i;
            }
            if (array[i] < min) {
                min = array[i];
                indexMin = i;
            }

            if (array[i] > 0) {
                averageFirst += array[i];
                counterFirst++;
            } else if (array[i] < 0) {
                averageSecond += array[i];
                counterSecond++;
            }
        }

        averageFirst /= counterFirst;
        averageSecond /= counterSecond;

        average = (indexMax < indexMin) ? averageFirst : averageSecond;
        
        if (double.IsNaN(average)) average = 0;

        return Math.Round(average, 3);
    }
    public double[] Task_2_18(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_19(double[] array)
    {
        double max = double.MinValue;
        int index = -1;
        double sum = 0;

        for (int i = 0; i < array.Length; i++) {
            sum += array[i];
            if (array[i] > max) {
                max = array[i];
                index = i;
            }
        }
        
        if (max > sum) {
            array[index] = 0;
        } else {
            array[index] *= (array[index] > 0 ? 2 : 0.5);
        }

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
        double max = double.MinValue;
        double counter = -1;

        for (int i = 0; i < array.Length; i++) {
            if (array[i] > max) max = array[i];
        }

        counter = max + 1;

        for (int i = 0; i < array.Length; i++) {
            if (array[i] == max) {
                array[i] = counter;
                counter++;
            }
        }

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
        double[] evenElements = new double[(array.Length + 1) / 2];

        for (int i = 0; i < array.Length; i += 2) {
            evenElements[i / 2] = array[i];
        }

        for (int i = 0; i < evenElements.Length; i++) {
            for (int j = i + 1; j < evenElements.Length; j++) {
                if (evenElements[j] < evenElements[i]) {
                    (evenElements[j], evenElements[i]) = (evenElements[i], evenElements[j]);
                }
            }
        }

        for (int i = 0; i < array.Length; i += 2) {
            array[i] = evenElements[i / 2];
        }

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
        int negLength = 0;

        for (int i = 0; i < array.Length; i++) {
            if (array[i] < 0) negLength++;
        }

        double[] negElements = new double[negLength];

        int counter = 0;
        for (int i = 0; i < array.Length; i++) {
            if (array[i] < 0) {
                negElements[counter] = array[i];
                counter++;
            }
        }

        for (int i = 0; i < negElements.Length; i++) {
            for (int j = i + 1; j < negElements.Length; j++) {
                if (negElements[j] > negElements[i]) {
                    (negElements[j], negElements[i]) = (negElements[i], negElements[j]);
                }
            }
        }

        counter = 0;

        for (int i = 0; i < array.Length; i++) {
            if (array[i] < 0) {
                array[i] = negElements[counter];
                counter++;
            }
        }

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
        double[] X = new double[n], Y = new double[n];
        double globalMax = double.MinValue, globalMin = double.MaxValue;

        double step = (b - a) / ((double)n - 1);

        int j = 0;
        for (double i = a; i <= b; i += step) {
            X[j] = Math.Round(i, 2);
            Y[j] = Math.Round(Math.Cos(i) + i * Math.Sin(i), 2);
            j++;
        }

        for (int i = 0; i < n; i++) {
            if (globalMax < Y[i]) globalMax = Y[i];
            if (globalMin > Y[i]) globalMin = Y[i];
        }

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
        double[] normalizedArray = new double[array.Length];

        double max = double.MinValue, min = double.MaxValue;

        for (int i = 0; i < array.Length; i++) {
            if (max < array[i]) max = array[i];
            if (min > array[i]) min = array[i];
        }

        for (int i = 0; i < array.Length; i++) {
            normalizedArray[i] = Math.Round(2 * ( (array[i] - min) / (max - min) ) - 1, 2);
        }

        return normalizedArray;
    }
    #endregion
}
