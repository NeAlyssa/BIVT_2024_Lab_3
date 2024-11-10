using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json.Nodes;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        double[] input1 = new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 };
        program.Task_3_1(input1);
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double answer = 0;
        for (int i = 0; i <= 5; i++) answer += array[i];
        for (int i = 0; i <= 5; i++) array[i]=Math.Round(array[i]/=answer,2);
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sum = 0;
        int n = 0;
        for (int i = 0; i <= 7; i++)
        {
            if (array[i] > 0)
            {
                sum += array[i];
                n++;
            }
        }
        double sr=Math.Round(sum / n, 2);
        for (int i = 0; i <= 7; i++)
        {
            if (array[i] > 0) array[i] = Math.Round(array[i] = sr, 2);
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i <= 3; i++)
        {
            sum[i]= Math.Round(first[i] + second[i],2);
            dif[i]= Math.Round(first[i] - second[i],2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sum = 0;
        for (int i = 0; i <= 4; i++) sum += array[i];
        double sr = sum / 5;
        for (int i = 0; i <= 4; i++) array[i]=Math.Round(array[i] -= sr,2);
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i <= 3; i++) product += (vector1[i] * vector2[i]);
        product = Math.Round(product, 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i <= 4; i++) length += vector[i] * vector[i];
        // end
        length=Math.Sqrt(length);
        return Math.Round(length, 2); 
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sum = 0;
        for (int i=0;i<=6;i++) sum += array[i];
        double sr = sum / 7;
        for (int i = 0; i <= 6; i++)
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
        for (int i = 0; i <= 5; i++)
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
        for (int i=0;i<=7;i++) sum+=array[i];
        double sr= sum / 8;
        for (int i = 0; i <= 7; i++)
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
        for (int i = 0; i <= 9; i++)
        {
            if (array[i] > P && array[i] < Q) count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;
        int count = 0;
        // code here
        for (int i = 0; i <= 9; i++) if (array[i] > 0) count++;
        output = new double[count];
        count = 0;
        for (int i = 0; i <= 9; i++)
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
        for (int i = 0; i <= 7; i++)
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
        int evenindex = 0, oddindex = 0;
        for (int i = 0; i <= 9; i++)
        {
            if (i % 2 == 0)
            {
                even[evenindex] = array[i];
                evenindex++;
            }
            else
            {
                odd[oddindex] = array[i];
                oddindex++;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i <= 10; i++)
            if (array[i] >= 0) sum += array[i] * array[i];
            else break;
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i = 0; i <= 9; i++)
            if (x[i] <= 0) y[i] = double.NaN;
            else y[i] = Math.Round(Math.Log(x[i], Math.E)/2,2);
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
        double mx = 0;
        int mxindex = 0;
        for (int i = 0; i <= (array.Length-1); i++)
        {
            if (array[i] > mx)
            {
                mx = array[i];
                mxindex = i;
            }
        }
        for (int i = 0; i <= array.Length; i++)
        {
            if (i < mxindex) sum += array[i];
            else break;
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
        double mx = 0;
        int mxindex = 0;
        for (int i = 0; i <= (array.Length - 1); i++)
        {
            sum+= array[i];
            if (array[i] > mx)
            {
                mx = array[i];
                mxindex = i;
            }
        }
        double sr=sum/array.Length;
        for (int i = 0; i <= (array.Length - 1); i++)
        {
            if (i > mxindex) array[i] = Math.Round(sr,2);
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
        for (int i=0;i<=(array.Length-1);i++) sum+= array[i];
        double sr=sum/array.Length;
        double mndif = 100000000000000000;
        int mndifindex = 0;
        for (int i = 0; i <= (array.Length - 1); i++)
        {
            if (Math.Abs(array[i] - sr) < mndif)
            {
                mndifindex = i;
                mndif = Math.Abs(array[i] - sr);
            }
        }
        double[] answer = new double[array.Length + 1];
        for (int i = 0; i <= mndifindex; i++) answer[i] = array[i];
        answer[mndifindex + 1] = P;
        for (int i = mndifindex + 1; i <= (array.Length - 1); i++) answer[i+1] = array[i];
        // end

        return answer;
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
        double mx = 0;
        int mxindex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mx)
            {
                mx = array[i];
                mxindex = i;
            }
        }
        if (mxindex==array.Length-1) return array;
        double mn = Double.MaxValue;
        int mnindex = 0;
        for (int i = mxindex+1; i < array.Length; i++)
        {
            if (array[i] < mn)
            {
                mn = array[i];
                mnindex = i;
            }
        }
        array[mxindex] = mn;
        array[mnindex] = mx;
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
        double mn = Double.MaxValue;
        int mnindex = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && array[i] < mn)
            {
                mn= array[i];
                mnindex = i;
            }
        }
        if (mnindex==-1) return array;
        double[] answer= new double[array.Length-1];
        for (int i = 0; i < mnindex; i++) answer[i] = array[i];
        for (int i = mnindex+1; i < array.Length; i++) answer[(i - 1)] = array[i];
        // end

        return answer;
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
        double mx = -100000000;
        int mxindex = -1, fminusindex = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mx)
            {
                mx = array[i];
                mxindex = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                fminusindex = i;
                break;
            }
        }
        if ((fminusindex == -1) || (mxindex == array.Length - 1)) return array;
        double sum = 0;
        for (int i = mxindex + 1; i < array.Length; i++) sum += array[i];
        array[fminusindex] = Math.Round(sum,2);
        Console.WriteLine(sum);
        Console.WriteLine(mxindex);
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
        double mx = -1000000, fminus = 0;
        int mxindex = -1, fminusindex = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mx)
            {
                mx = array[i];
                mxindex = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            { 
                fminusindex = i;
                fminus = array[i];
                break;
            }
        }
        if (fminusindex == -1 || mxindex == -1) return array;
        array[fminusindex] = mx;
        array[mxindex] = fminus;

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
        for (int i = 0; i < array.Length; i++) sum += array[i];
        double sr = sum / array.Length;
        int count = 0;
        for (int i = 0; i < array.Length; i++) if (array[i] < sr) count++;
        output = new int[count];
        for (int iarray = 0, ioutput = 0; iarray < array.Length; iarray++)
        {
            if (array[iarray] < sr)
            {
                output[ioutput] = iarray;
                ioutput++;
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
        double[] a = array;
        double mxeven = -1000000, mxodd = -1000000;
        for (int i = 0; i < array.Length; i++)
            if (i % 2 == 0 && array[i] > mxodd) mxodd = array[i];
            else if (i % 2 == 1 && array[i] > mxeven) mxeven = array[i];
        if (mxodd > mxeven) for (int i = 0; i < array.Length/2; i++) array[i] = 0;

        else for (int i = array.Length/2; i < array.Length; i++) array[i] = 0;
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
        double mn = Double.MaxValue;
        int fminusindex = -1, mnindex = -1;
        for (int i = 0; i < array.Length; i++)
            if (array[i] < mn)
            {
                mn = array[i];
                mnindex = i;
            }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                fminusindex = i;
                break;
            }
        }
        if (fminusindex == -1) return 0;
        if (fminusindex < mnindex) for (int i = 0; i < array.Length; i += 2) sum += array[i];
        else for (int i = 1; i < array.Length; i += 2) sum += array[i];
        // end

        return sum;
    }
    #endregion
    #region Level 3
    public int[] Task_3_1(double[] array)
    {
        int[] output = null;
        double mx = -1000000;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mx)
            {
                output=new int[] {i};
                mx= array[i];
            }
            else if (array[i] == mx)
            {
                int[] need = output;
                output=new int[need.Length+1];
                for (int j=0;j <need.Length; j++) output[j] = need[j];
                output[output.Length - 1] = i;
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
        double[] need;
        double mx = -10000000000;
        int mxindex = -1, count = 0;
        for (int i = 0; i < array.Length; i++) if (array[i] > mx) mx = array[i];
        for (int i = 0; i < array.Length; i++) if (array[i] == mx) count ++;
        need = new double[count];
        for (int i = 0, ineed = 0; i < array.Length; i++)
        {
            if (array[i] == mx)
            {
                need[ineed] = i;
                ineed++;
            }
        }
        for (double sum1=0,sum2 = 0, i = 0, ineed = 0; i < array.Length; i++)
        {
            sum2 = array[(int)i] + sum2;
            if ((int)i == need[(int)ineed])
            {
                array[(int)i] = sum1;
                ineed++;
                if (ineed == need.Length) break;
            }
            sum1 = sum2;

            

         }
        Console.WriteLine(2.5+3);
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
        int count = 0;
        //for (int i = 0; i < array.Length; i++) if (array[i] < 0) count++;
        double[] need= new double[array.Length];
        for (int i = array.Length - 1, ineed = array.Length-1; i >=0; i--)
        {
            if (array[i] < 0)
            {
                need[ineed] = array[i];
                ineed -= 1;
                count++;
            }
        }
        for (int i = array.Length - 1, ineed = array.Length - 1-count; i >= 0; i--)
        {
            if (array[i] >= 0)
            {
                need[ineed] = array[i];
                ineed -= 1;
            }
        }
        array = need;
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
        double[] need = new double[array.Length ];
        for (int i = 0; i < array.Length/2; i++)
        {
            need[i * 2] = array[i];
            need[i * 2 + 1] = array[i];
        }
        array = need;
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
        int count = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] != double.MaxValue)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] == array[i])
                    {
                        array[j] = double.MaxValue;
                        count++;
                    }
                }
            }
        }
        Console.WriteLine(count);
        double[] answer = new double[array.Length - count];
        for (int i = 0, ianswer = 0; i < array.Length; i++)
        {
            if (array[i] != double.MaxValue)
            {
                answer[ianswer] = array[i];
                ianswer++;
            }
        }
        array = answer;
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