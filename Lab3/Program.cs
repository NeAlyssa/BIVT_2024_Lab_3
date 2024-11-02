using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
        program.Task_3_13(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 });
        program.Task_3_13(new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 10, 10 });
        program.Task_3_13(new double[] { -1, -2, -8, -1, -9, -1, -1, -4, -6, -2 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double sum = 0;
        foreach(double x in array) {
            sum += x;
        }
        if(sum == 0) {
            return array;
        }
        for(int i = 0; i < 6; ++i) {
            array[i] /= sum;
            array[i] = Math.Round(array[i], 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sum = 0, cnt = 0;
        foreach(double x in array) {
            if(x > 0) {
                sum += x;
                ++cnt;
            }
        }
        if(cnt > 0) {
            sum /= cnt;
            sum = Math.Round(sum, 2);
        } else {
            return array;
        }
        for(int i = 0; i < 8; ++i) {
            if(array[i] > 0) {
                array[i] = sum;
            }
        } 
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for(int i = 0; i < 4; ++i) {
            sum[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = Math.Round(first[i] - second[i], 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        if(array.Length != 5) {
            return array;
        }
        double sum = 0;
        for(int i = 0; i < 5; ++i) {
            sum += array[i];
        }
        sum /= 5;
        for(int i = 0; i < 5; ++i) {
            array[i] -= sum;
            array[i] = Math.Round(array[i], 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        if(vector1.Length != 4 || vector2.Length != 4) {
            return product;
        }
        for(int i = 0; i < 4; ++i) {
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
        if(vector.Length != 5) {
            return length;
        }
        foreach(double x in vector) {
            length += x * x;
        }
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        if(array.Length != 7) {
            return array;
        }
        double sum = 0;
        foreach(double x in array) {
            sum += x;
        }
        sum /= 7;
        for(int i = 0; i < 7; ++i) {
            if(array[i] > sum) {
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
        if(array.Length != 6) {
            return count;
        }
        foreach(double x in array) {
            if(x < 0) {
                ++count;
            }
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        if(array.Length != 8) {
            return 0;
        }
        double sum = 0;
        foreach(double x in array) {
            sum += x;
        }
        sum /= 8;
        for(int i = 0; i < 8; ++i) {
            if(array[i] > sum) {
                ++count;
            }
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        foreach(double x in array) {
            if(x > P && x < Q) {
                ++count;
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
        foreach(double x in array) {
            if(x > 0) {
                ++count;
            }
        }
        output = new double[count];
        count = 0;
        foreach(double x in array) {
            if(x > 0) {
                output[count] = x;
                ++count;
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
        for(int i = 0; i < array.Length; ++i) {
            if(array[i] < 0) {
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
        for(int i = 0; i < array.Length; ++i) {
            if(i % 2 == 0) {
                even[i / 2] = array[i];
            } else {
                odd[i / 2] = array[i]; 
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        foreach(double x in array) {
            if(x < 0) {
                break;
            }
            sum += x * x;
        }
        // end

        return Math.Round(sum, 2);
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        Console.WriteLine("Task_1_15");
        for(int i = 0; i < x.Length; ++i) {
            if(x[i] == 0) {
                y[i] = double.NaN;
            }
            else {
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            }
            Console.WriteLine($"{x[i]}, {y[i]}");
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        if(array.Length == 0) {
            return array;
        }
        int ind = 0; 
        double minimum = array[0];
        for(int i = 0; i < array.Length; ++i) {
            if(array[i] < minimum) {
                minimum = array[i];
                ind = i;
            }
        }
        if(array[ind] > 0) {
            array[ind] *= 2;
        } else {
            array[ind] /= 2;
        }
        array[ind] = Math.Round(array[ind], 2);
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
         if(array.Length == 0) {
            return array;
        }
        int ind = 0; 
        double minimum = array[0];
        for(int i = 0; i < array.Length; ++i) {
            if(array[i] < minimum) {
                minimum = array[i];
                ind = i;
            }
        }
        for(int i = 0; i < ind; ++i) {
            if(array[i] > 0) {
                array[i] = Math.Round(array[i] * 2, 2);
            } else {
                array[i] = Math.Round(array[i] / 2, 2);
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
        if(array.Length == 0) {
            return array;
        }
        int indmax = 0, indmin = 0;
        double maximum = array[0], minimum = array[0];
        for(int i = 1; i < array.Length; ++i) {
            if(array[i] > maximum) {
                maximum = array[i];
                indmax = i;
            }
            if(array[i] < minimum) {
                minimum = array[i];
                indmin = i;
            }
        }
        int count = 0;
        if(indmin > indmax) {
            int temp = indmax;
            indmax = indmin;
            indmin = temp;
        }
        for(int i = indmin + 1; i < indmax; ++i) {
            if(array[i] < 0) {
                ++count;
            }
        }
        double[] result = new double[count];
        count = 0;
        for(int i = indmin + 1; i < indmax; ++i) {
            if(array[i] < 0) {
                result[count] = array[i];
                ++count;
            }
        }
        // end

        return result;
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
        if(array.Length == 0) {
            return array;
        }
        int ind = 0; 
        double maximum = array[0];
        for(int i = 0; i < array.Length; ++i) {
            if(array[i] > maximum) {
                maximum = array[i];
                ind = i;
            }
        }
        if(ind != array.Length - 1) {
            if(array[ind + 1] > 0) {
                array[ind + 1] = Math.Round(array[ind + 1] * 2, 2);
            } else {
                array[ind + 1] = Math.Round(array[ind + 1] / 2, 2);
            }
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
         if(array.Length == 0) {
            return average;
        }
        int indmax = 0, indmin = 0;
        double maximum = array[0], minimum = array[0];
        for(int i = 1; i < array.Length; ++i) {
            if(array[i] > maximum) {
                maximum = array[i];
                indmax = i;
            }
            if(array[i] < minimum) {
                minimum = array[i];
                indmin = i;
            }
        }
        if(indmin > indmax) {
            int temp = indmax;
            indmax = indmin;
            indmin = temp;
        }
        for(int i = indmin + 1; i < indmax; ++i) {
            average += array[i];
        }
        if(indmax - indmin - 1 == 0) {
            return 0;
        }
        average = Math.Round(average / (indmax - indmin - 1), 2);
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
        int ind = -1;
        for(int i = 0; i < array.Length; ++i) {
            if(array[i] > 0) {
                ind = i + 1;
            }
        }
        if(ind == -1) {
            return array;
        }
        double[] result = new double[array.Length + 1];
        for(int i = 0; i < array.Length; ++i) {
            if(ind == i) {
                result[i] = P;
                result[i + 1] = array[i];
                continue;
            }
            if(ind < i) {
                result[i + 1] = array[i];
                continue;
            } 
            result[i] = array[i];
        }
        if(ind == array.Length) {
            result[ind] = P;
        }
        array = result;
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
        if(array.Length == 0) {
            return array;
        }
        int ind = 0; 
        double maximum = array[0];
        for(int i = 0; i < array.Length; i += 2) {
            if(array[i] > maximum) {
                maximum = array[i];
                ind = i;
            }
        }
        array[ind] = ind;
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
        output = new double[A.Length + B.Length];
        if(k >= A.Length) {
            k = A.Length - 1;
        }
        for(int i = 0; i <= k; ++i) {
            output[i] = A[i];
        }
        for(int i = 0; i < B.Length; ++i) {
            output[i + k + 1] = B[i];
        }
        for(int i = k + 1; i < A.Length; ++i) {
            output[i + B.Length] = A[i];
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
        if(array.Length == 0) {
            return average;
        }
        bool before = true;
        double maximum = array[0], minimum = array[0];
        for(int i = 0; i < array.Length; ++i) {
            if(array[i] > maximum) {
                before = false;
                maximum = array[i];
            }
            if(array[i] < minimum) {
                before = true;
                minimum = array[i];
            }
        }
        int cnt = 0;
        double sum = 0;
        for(int i = 0; i < array.Length; ++i) {
            if(before && array[i] > 0) {
                sum += array[i];
                ++cnt;
            }
            if(!before && array[i] < 0) {
                sum += array[i];
                ++cnt;
            }
        }
        if(cnt == 0) {
            return average;
        } else {
            average = Math.Round(sum / cnt, 2);
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
        if(array.Length == 0) {
            return array;
        }
        double sum = 0, maximum = array[0];
        int ind = 0;
        for(int i = 0; i < array.Length; ++i) {
            sum += array[i];
            if(array[i] > maximum) {
                maximum = array[i];
                ind = i;
            }
        }
        if(maximum > sum) {
            array[ind] = 0;
        } else if(maximum < sum) {
            if(maximum < 0) {
                array[ind] /= 2;
            } else {
                array[ind] *= 2;
            }
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
        if(array.Length == 0) {
            return output;
        }
        double maximum = array[0] - 1;
        int cnt = 0;
        int[] temp = new int[array.Length];
        for(int i = 0; i < array.Length; ++i) {
            if(array[i] > maximum) {
                maximum = array[i];
                temp[0] = i;
                cnt = 1;
            } else if(array[i] == maximum) {
                temp[cnt] = i;
                ++cnt;
            }
        }
        output = new int[cnt];
        for(int i = 0; i < cnt; ++i) {
            output[i] = temp[i];
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
        if(array.Length == 0) {
            return array;
        }
        double maximum = array[0] - 1;
        for(int i = 0; i < array.Length; ++i) {
            if(array[i] > maximum) {
                maximum = array[i];
            } 
        }
        double sum = 0;
        for(int i = 0; i < array.Length; ++i) {
            if(array[i] == maximum) {
                array[i] = sum;
                sum += maximum;
                continue;
            }
            sum += array[i];
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
        double[] temp = new double[array.Length];
        int[] ind = new int[array.Length];
        int cnt = 0, neg = 0;
        for(int i = 0; i < array.Length; ++i) {
            if(array[i] >= 0) {
                temp[cnt] = array[i];
                ++cnt;
            } else {
                ind[neg] = i;
                ++neg;
            }
        }
        for(int i = 0; i < neg; ++i) {
            temp[i + cnt] = array[ind[i]];
        }
        array = temp;
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
        double[] temp = new double[array.Length];
        for(int i = 0; i < array.Length / 2; ++i) {
            temp[2 * i] = array[i];
            temp[2 * i + 1] = array[i];
        }
        array = temp;
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
        Console.WriteLine("meow");
        double[] temp = new double[array.Length];
        int cnt = 0;
        for(int i = 0; i < array.Length; ++i) {
            bool f = true;
            for(int j = 0; j < cnt; ++j) {
                if(array[i] == temp[j]) {
                    f = false;
                    break;
                }
            }
            if(f) {
                temp[cnt] = array[i];
                ++cnt;
            }
        }
        array = new double[cnt];
        for(int i = 0; i < cnt; ++i) {
            array[i] = temp[i];
            Console.WriteLine(array[i]);
        }
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