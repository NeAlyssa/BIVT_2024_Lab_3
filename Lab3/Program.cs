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
        for(int i = 0; i < array.Length; i++) s += array[i];
        for(int i = 0; i < array.Length; i++) array[i] = Math.Round(array[i] / s, 2);

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        double s = 0, n = 0, sr;
        for(int i = 0; i < array.Length; i++) 
        {
            if(array[i] > 0) 
            {
                s += array[i];
                n++;
            }
        }
        sr = Math.Round(s / n, 2);
        for(int i = 0; i < array.Length; i++) 
        {
            if(array[i] > 0) array[i] = sr;
        }
        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        for(int i = 0; i < first.Length; i++) 
        {
            sum[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = Math.Round(first[i] - second[i], 2);
        }

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        double s = 0, sr;
        for(int i = 0; i < array.Length; i++) s += array[i];
        sr = Math.Round(s / array.Length, 2);
        for(int i = 0; i < array.Length; i++) array[i] = Math.Round(array[i] - sr, 2);
        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;
        for(int i = 0; i < vector1.Length; i++) product += vector1[i]*vector2[i];
        product = Math.Round(product, 2);
        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        for(int i = 0; i < vector.Length; i++) length += vector[i]*vector[i];
        length = Math.Sqrt(length);
        return Math.Round(length, 2);
    }
    public double[] Task_1_7(double[] array)
    {
        double s = 0, sr;
        for(int i = 0; i < array.Length; i++) s += array[i];
        sr = s / array.Length;
        for(int i = 0; i < array.Length; i++) 
        {
            if(array[i] > sr) array[i] = 0;
        }
        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        for(int i = 0; i < array.Length; i++) count += (array[i] < 0) ? 1 : 0;
        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;
        double s = 0, sr;
        for(int i = 0; i < array.Length; i++) s += array[i];
        sr = s / array.Length;
        for(int i = 0; i < array.Length; i++) count += (array[i] > sr) ? 1 : 0;
        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        for(int i = 0; i < array.Length; i++) count += (array[i] < Q && array[i] > P) ? 1 : 0;

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        int count = 0, j = 0;
        for(int i = 0; i < array.Length; i++) count += (array[i] > 0) ? 1 : 0;
        double[] output = new double[count];
        for(int i = 0; i < array.Length; i++) 
        {
            if(array[i] > 0) 
            {
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

        for(int i = 0; i < array.Length; i++) 
        {
            if(array[i] < 0) 
            {
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
        
        for(int i = 0; i < array.Length; i += 2) even[i / 2] = array[i];
        for(int i = 1; i < array.Length; i += 2) odd[i / 2] = array[i];
        
        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        for(int i = 0; i < array.Length; i++) 
        {
            if(array[i] < 0) break;
            sum += array[i]*array[i];
        }

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        for(int i = 0; i < y.Length; i++) y[i] = (x[i] > 0) ? Math.Round(0.5*Math.Log(x[i]), 2) : double.NaN; 
        
        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        double min = Double.PositiveInfinity;
        int minIndex = -1;
        for(int i = 0; i < array.Length; i++) 
        {
            if(array[i] < min) 
            {
                min = array[i];
                minIndex = i;
            }
        }

        array[minIndex] *= 2;
        
        return array;
    }
    public double Task_2_2(double[] array)
    {
        double max = Double.NegativeInfinity, s = 0;
        int maxIndex = -1;
        for(int i = 0; i < array.Length; i++) 
        {
            if(array[i] > max) 
            {
                max = array[i];
                maxIndex = i;
            }
        }
        
        for(int i = 0; i < maxIndex; i++) s += array[i];
        
        return s;
    }
   public double[] Task_2_3(double[] array)
    {
        double min = Double.PositiveInfinity;
        int minIndex = -1;
        for(int i = 0; i < array.Length; i++) 
        {
            if(array[i] < min) 
            {
                min = array[i];
                minIndex = i;
            }
        }

        for(int i = 0; i < minIndex; i++) array[i] *= (array[i] >= 0) ? 2 : 0.5;
        
        return array;
    }
    public double[] Task_2_4(double[] array)
    {
        double max = Double.NegativeInfinity, s = 0, sr;
        int maxIndex = -1;
        for(int i = 0; i < array.Length; i++) 
        {
            s += array[i];
            if(array[i] > max) 
            {
                max = array[i];
                maxIndex = i;
            }
        }
        sr = Math.Round(s / array.Length, 2);
        for(int i = maxIndex + 1; i < array.Length; i++) array[i] = sr;

        return array;
    }
    public double[] Task_2_5(double[] array)
    {
        double max = Double.NegativeInfinity, min = Double.PositiveInfinity;
        int maxIndex = -1, minIndex = -1, count = 0, l = -1, r = -1;
        
        for(int i = 0; i < array.Length; i++) 
        {
            if(array[i] < min) {min = array[i]; minIndex = i;}
            if(array[i] > max) {max = array[i]; maxIndex = i;}
        }
        
        if(maxIndex == minIndex) return new double[0];
        else if (maxIndex > minIndex) {l = minIndex; r = maxIndex;}
        else {l = maxIndex; r = minIndex;}
        
        for(int i = l + 1; i < r; i++) count += (array[i] < 0) ? 1 : 0;
        
        if (count == 0) return new double[0];
        double[] newArr = new double[count];
        int j = 0;
        for(int i = l + 1; i < r; i++) 
        {
            if(array[i] < 0) 
            {
                newArr[j] = array[i];
                j++;
            } 
        }
        // Console.WriteLine($"{string.Join(", ", newArr)}");
        return newArr;
    }
    public double[] Task_2_6(double[] array, double P)
    {
        double[] newArr = new double[array.Length + 1];
        double s = 0, minDiff = Double.PositiveInfinity, sr;
        int minIndex = -1;
        
        for(int i = 0; i < array.Length; i++) s += array[i];
        sr = s / array.Length;
        for(int i = 0; i < array.Length; i++) 
        {
            if(Math.Abs(array[i] - sr) < minDiff) {minDiff = Math.Abs(array[i] - sr); minIndex = i;} 
        }
        
        // Console.WriteLine($"{minDiff} {minIndex}");
        
        newArr[minIndex + 1] = P; 
        for(int i = 0; i <= minIndex; i++) newArr[i] = array[i];
        for(int i = minIndex + 1; i < array.Length; i++) newArr[i + 1] = array[i];
        
        // Console.WriteLine($"{P}: {string.Join(", ", newArr)}");
        
        return newArr;
    }
    public double[] Task_2_7(double[] array)
    {
        double max = Double.NegativeInfinity;
        int maxIndex = -1;
        for(int i = 0; i < array.Length; i++) 
        {
            if(array[i] > max) {max = array[i]; maxIndex = i;}
        }

        if((maxIndex + 1) < array.Length) array[maxIndex + 1] *= (array[maxIndex + 1] >= 0) ? 2 : 0.5;
        
        return array;
    }
    public double[] Task_2_8(double[] array)
    {
        double max = Double.NegativeInfinity, min = Double.PositiveInfinity;
        int maxIndex = -1, minIndex = -1;
        
        for(int i = 0; i < array.Length; i++) 
        {
            if(array[i] > max) {max = array[i]; maxIndex = i;}
        }
        
        if(maxIndex == (array.Length - 1)) return array;
        
        for(int i = maxIndex + 1; i < array.Length; i++) 
        {
            if(array[i] < min) {min = array[i]; minIndex = i;}
        }
        
        array[minIndex] = max;
        array[maxIndex] = min;
        
        return array;
    }
    public double Task_2_9(double[] array)
    {
        double average = 0, max = Double.NegativeInfinity, min = Double.PositiveInfinity, s = 0;
        int maxIndex = -1, minIndex = -1, count = 0, l = -1, r = -1;
        
        for(int i = 0; i < array.Length; i++) 
        {
            if(array[i] < min) {min = array[i]; minIndex = i;}
            if(array[i] > max) {max = array[i]; maxIndex = i;}
        }
        
        
        
        if(maxIndex > minIndex) {r = maxIndex; l = minIndex;}
        else {l = maxIndex; r = minIndex;}
        
        count = r - l - 1;
        if(count <= 0) return average;
        
        for(int i = l + 1; i < r; i++) s += array[i];
        average = s / count;
        
        return Math.Round(average, 2);
    }
    public double[] Task_2_10(double[] array)
    {
        double minPositive = Double.PositiveInfinity;
        int minIndex = -1;
        
        
        for(int i = 0; i < array.Length; i++) 
        {
            if(array[i] > 0 && minPositive > array[i]) {minIndex = i; minPositive = array[i];}
        }
        // Console.WriteLine($"{minPositive} {minIndex}");
        if(minIndex == -1) return array;
        
        double[] newArr = new double[array.Length - 1];
        for(int i = 0; i < minIndex; i++) newArr[i] = array[i];
        for(int i = minIndex + 1; i < array.Length; i++) newArr[i - 1] = array[i];

        return newArr;
    }
    public double[] Task_2_11(double[] array, double P)
    {
        int lastPositive = -1;
        double[] newArr = new double[array.Length + 1];
        
        for(int i = array.Length - 1; i >= 0; i--) 
        {
            if (array[i] > 0) 
            {
                lastPositive = i;
                break;
            }
        }
        
        if(lastPositive == -1) return array;
        
        for(int i = 0; i <= lastPositive; i++) newArr[i] = array[i];
        newArr[lastPositive + 1] = P;
        for(int i = lastPositive + 1; i < array.Length; i++) newArr[i + 1] = array[i];

        return newArr;
    }
    public double[] Task_2_12(double[] array)
    {
        double max = Double.NegativeInfinity, s = 0;
        int maxIndex = -1;
        for(int i = 0; i < array.Length; i++) 
        {
            if(array[i] > max) {max = array[i]; maxIndex = i;}
        }
        for(int i = maxIndex + 1; i < array.Length; i++) s += array[i];
        for(int i = 0; i < array.Length; i++) 
        {
            if(array[i] < 0) 
            {
                array[i] = Math.Round(s, 2);
                break;
            }
        }
        
        return array;
    }
    public double[] Task_2_13(double[] array)
    {
        double max = Double.NegativeInfinity;
        int maxIndex = -1;
        
        for(int i = 0; i < array.Length; i += 2) 
        {
            if (array[i] > max) {maxIndex = i; max = array[i];}
        }
        
        array[maxIndex] = maxIndex;
        
        return array;
    }
    public double[] Task_2_14(double[] array)
    {
        double max = Double.NegativeInfinity, negative = 10;
        int maxIndex = -1, negativeIndex = -1;
        
        for(int i = 0; i < array.Length; i ++) 
        {
            if (negative > 0 && array[i] < 0) {negative = array[i]; negativeIndex = i;} 
            if (array[i] > max) {maxIndex = i; max = array[i];}
        }
        
        if(negativeIndex == -1) return array;

        array[negativeIndex] = max;
        array[maxIndex] = negative;
        
        return array;
    }
    public double[] Task_2_15(double[] A, double[] B, int k)
    {
        double[] output = new double[A.Length + B.Length];
        
        if(k > A.Length) return A;
        
        k -= 1;
        
        for(int i = 0; i <= k; i++) output[i] = A[i];
        for(int i = 0; i < B.Length; i++) output[k + 1 + i] = B[i];
        for(int i = k + 1; i < A.Length; i++) output[B.Length + i] = A[i];
        
        return output;
    }
    public int[] Task_2_16(double[] array)
    {
        double s = 0, sr;
        for(int i = 0; i < array.Length; i++) s += array[i];
        sr = s / array.Length;
        
        int count = 0, j = 0;
        for(int i = 0; i < array.Length; i++) count += (array[i] < sr) ? 1 : 0;
        int[] output = new int[count];
        for(int i = 0; i < array.Length; i++) 
        {
            if (array[i] < sr) {output[j]=i; j++;}
        }

        return output;
    }
    public double Task_2_17(double[] array)
    {
        double average = 0, max = Double.NegativeInfinity, min = Double.PositiveInfinity, s = 0;
        bool isNegative = false;
        int maxIndex = -1, minIndex = -1, count = 0, l = -1, r = -1;
        
        for(int i = 0; i < array.Length; i++) 
        {
            if(array[i] < min) {min = array[i]; minIndex = i;}
            if(array[i] > max) {max = array[i]; maxIndex = i;}
        }
        
        if(minIndex == maxIndex) return average;
        else if(maxIndex > minIndex) isNegative = true;
        
        for(int i = 0; i < array.Length; i++) 
        {
            if(isNegative && array[i] < 0) {s += array[i]; count++;}
            else if(!isNegative && array[i] > 0) {s += array[i]; count++;}
        }
        
        if(count == 0) return average;
        
        average = Math.Round(s / count, 2);
        
        return average;
    }
    public double[] Task_2_18(double[] array)
    {
        double maxEven = Double.NegativeInfinity, maxOdd = Double.NegativeInfinity;
        for(int i = 0; i < array.Length; i++) 
        {
            if(i % 2 == 0 && array[i] > maxEven) maxEven = array[i];
            else if(i % 2 == 1 && array[i] > maxOdd) maxOdd = array[i];
        }
        int l = -1, r = -1, mid = array.Length / 2;
        if(maxEven > maxOdd) {l = 0; r = mid;}
        else {l = mid; r = array.Length;}
        
        Console.WriteLine($"{maxEven}, {maxOdd}: {string.Join(", ", array)}");
        
        for(int i = l; i < r; i++) array[i] = 0;

        Console.WriteLine($"{string.Join(", ", array)}");
        
        return array;
    }
    public double[] Task_2_19(double[] array)
    {
        double max = Double.NegativeInfinity, s = 0;
        int maxIndex = -1;
        
        for(int i = 0; i < array.Length; i++) 
        {
            if(array[i] > max) {max=array[i]; maxIndex = i;}
            s += array[i];
        }
        if(max > s) array[maxIndex] = 0;
        else array[maxIndex] *= (array[maxIndex] >= 0) ? 2 : 0.5;
        
        return array;
    }
    public double Task_2_20(double[] array)
    {
        double sum = 0;
        
        double min = Double.PositiveInfinity;
        int minIndex = -1, negativeIndex = -1;
        
        for(int i = 0; i < array.Length; i++) 
        {
            if(array[i] < min) {min=array[i]; minIndex = i;}
            if(negativeIndex == -1 && array[i] < 0) negativeIndex = i;
        }
        
        for(int i = 0; i < array.Length; i += (negativeIndex < minIndex) ? 2 : 1) sum += array[i];
       
        return sum;
    }
    #endregion
    #region Level 3
    public int[] Task_3_1(double[] array)
    {
        int[] output = new int[array.Length];

        double max = Double.NegativeInfinity;
        int count = 0, j = 0;
        
        for(int i = 0; i < array.Length; i++) 
        {
            if(array[i] > max) 
            {
                max = array[i];
                output = new int[array.Length];
                output[0] = i;
                j = 1;
                count = 1;
            } else if (array[i] == max) {
                output[j] = i;
                j++;
                count++;
            }
        }
        
        Array.Resize(ref output, count);
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
        double max = Double.NegativeInfinity, s = 0;
        
        for(int i = 0; i < array.Length; i++) 
        {
            if (array[i] > max) max = array[i];
        }
        for(int i = 0; i < array.Length; i++) 
        {
            s += array[i];
            if (array[i] == max) array[i] = s - array[i];
        }
        
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
        double[] negatives = new double[array.Length];
        int j = 0;
        for(int i = 0; i < array.Length; i++) 
        {
            if(array[i] < 0) 
            {
                negatives[j] = array[i];
                j++;
            }
        }
        
        Array.Resize(ref negatives, j);
        
        double[] nonnegatives = new double[array.Length - j];
        
        j = 0;
        for(int i = 0; i < array.Length; i++) 
        {
            if(array[i] >= 0) {nonnegatives[j] = array[i]; j++;}
        }

        nonnegatives.CopyTo(array, 0);
        negatives.CopyTo(array, nonnegatives.Length);
        
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
        double[] newArr = new double[array.Length];
        for(int i = 0; i < array.Length; i++) 
        {
            if(i % 2 == 1) newArr[i] = newArr[i - 1];
            else newArr[i] = array[i / 2];
        }
        // end

        return newArr;
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
        int count = 0;
        bool isUnique;
        double[] set = new double[array.Length];
        for(int i = 0; i < array.Length; i++) 
        {
            isUnique = true;
            for(int j = 0; j < count; j++) 
            {
                if(array[i] == set[j]) {isUnique = false; break;}
            }
            if(isUnique) {set[count] = array[i]; count++;}
        }
        
        Array.Resize(ref set, count);
        
        // end

        return set;
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