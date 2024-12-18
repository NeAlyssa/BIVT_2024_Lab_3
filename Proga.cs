using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
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

        // end
        double sum = 0;
        for (int i=0; i < 6; i++)
        {
            sum += array[i];
        }
        for (int j = 0; j < 6; j++)
        {
            array[j] /= sum;
        }
        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here

        // end
        double sum = 0;
        double count = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                sum += array[i];
                count++;
            }
        }
        double sredn = sum/count;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] > 0) array[j] = sredn;
        }
        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here

        // end
        for (int i=0; i < first.Length; i++)
        {
            sum[i] = first[i] + second[i];
            dif[i] = first[i] - second[i];

        }
        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here

        // end
        double sum = 0;
        double count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            count++;

        }
        double sredn = sum / count;
        for(int j=0; j < array.Length; j++)
        {
            array[j] -= sredn;
        }
        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here

        // end
        for (int i = 0; i < 4; i++)
        {
            product += vector1[i] * vector2[i];
        }
        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here

        // end
        for (int i=0; i < vector.Length; i++)
        {
            length += vector[i] * vector[i];
        }
        length = Math.Sqrt(length);
        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here

        // end
        double sr = 0;
        for (int i = 0; i < array.Length; i++) sr += array[i];
        sr /= array.Length;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] > sr) array[j] = 0;
        }
        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here

        // end
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) count++;
        }
        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here

        // end
        double sr = 0;
        for (int i = 0; i < array.Length; i++) sr += array[i];
        sr /= array.Length;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j]>sr)
            {
                count++;
            }
        }
        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here

        // end
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > P && array[i] < Q) count++;
        }
        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here

        // end
        int count = 0;
        int a = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) count++;
        }
        output = new double[count];
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] > 0)
            {
                output[a] = array[j];
                a++;
            }
        }
        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        // code here

        // end
        for(int i = array.Length-1; i > 0; i--)
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
        double[] odd = new double[array.Length/2];

        // code here

        // end
        for(int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0) even[i / 2] = array[i];
            else odd[i / 2] = array[i];
        }
        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here

        // end
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) break;
            sum += array[i] * array[i];
        }
        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here

        // end
        for (int i = 0; i < x.Length; i++)
        {
            y[i] = (x[i] > 0) ? 0.5 * Math.Log(x[i]) : double.NaN;
        }
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

        // end
        double maxx = 0;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxx)
            {
                maxx = array[i];
                index = i;
            }
        }
        for (int j = 0; j < index; j++) sum += array[j];
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

        // end
        double maxx = 0;
        double sum = 0;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxx)
            {
                maxx = array[i];
                index = i;
            }
            sum += array[i];
        }
        double sr = sum / array.Length;
        for (int j = index + 1; j < array.Length; j++)
        {
            array[j] = sr;
        }
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

        // end
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum+= array[i];
        }
        double sr = sum / array.Length;
        int index = 0;
        double raz = Math.Abs(array[0] - sr);
        for (int j = 0; j < array.Length; j++)
        {
            double raznicha = Math.Abs(array[j] - sr);
            if (raznicha < raz)
            {
                index = j;
                raz = raznicha;
            }
        }
        double[] arra = new double [array.Length + 1];
        for(int k = 0,i=0 ; k < arra.Length; k++,i++)
        {
            if (k == index + 1)
            {
                arra[k] = P;
                i--;
            }
            else
            {
                arra[k] = array[i];
            }
        }
        return arra;
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

        // end
        int index = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[index]) index = i;
        }
        if (index == array.Length - 1) return array;
        int mindex = index + 1;
        for(int j = index; j < array.Length; j++)
        {
            if (array[j] < array[mindex]) mindex = j;
        }
        double peremen = array[index];
        array[index] = array[mindex];
        array[mindex] = peremen;
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

        // end
        int mindex = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && (mindex == -1 || array[i] < array[mindex])) { mindex = i; }
        }
        double[] arra = new double[array.Length - 1];

        if (mindex != -1)
        {
            for(int i = 0,j=0; i < array.Length; i++)
            {
                if (i != mindex)
                {
                    arra[j++] = array[i];
                }
            }
            return arra;

        }
        else
        {
            return array;

        }
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

        // end
        int otr = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                otr = i;
                break;
            }
        }
        int index = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[index]) {index = i;}
        }
        if (otr != -1)
        {
            double sum = 0;
            for (int i = index + 1; i < array.Length; i++) sum += array[i];
            array[otr] = Math.Round(sum, 2);

        }


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

        // end
        int maxx = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[maxx]) { maxx = i; }
        }

        int otr = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                otr = i;
                break;
            }
        }

        if (otr != -1)
        {
            double peremen = array[maxx];
            array[maxx] = array[otr];
            array[otr] = peremen;
        }
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

        // end
        double sum = 0;
        for (int i = 0; i < array.Length; i++) sum += array[i];
        double sr = sum / array.Length;

        int len = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr) len++;
        }
        if (len > 0)
        {
            int[] outic = new int[len];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sr) outic[index++] = i;
            }
            return outic;
        }
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

        // end
        double chet = 0;
        double nechet = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0 && array[i] > chet)
            {
                chet = array[i];
            }
            else if (i % 2 != 0 && array[i] > nechet)
            {
                nechet = array[i];
            }
        }

        int ser = array.Length / 2;
        if (chet > nechet)
        {
            for (int i = 0; i < ser; i++) array[i] = 0;
        }
        else
        {
            for (int i = ser; i < array.Length; i++) array[i] = 0;
        }
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

        // end
        int otr = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                otr = i;
                break;
            }
        }

        int minn = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[minn])
                minn = i;
        }

        if (otr != -1 && otr < minn)
        {
            for (int i = 0; i < array.Length; i += 2) sum += array[i];
        }
        else
        {
            for (int i = 1; i < array.Length; i += 2) sum += array[i];
        }

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

        // end
        int index = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[index]) index = i;
        }
        for (int j = 0; j < index - 1; j += 2)
        {
            double peremen = array[j];
            array[j] = array[j + 1];
            array[j + 1] = peremen;
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
        int count = 0;

        // code here

        // end
        int minlen = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i - 1]) minlen++;
            else
            {
                if (minlen > count)
                {
                    count = minlen;
                }
                minlen = 1;
            }
        }

        if (minlen > count) count = minlen;
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

        // end
        int minlen = 1;
        bool flag = false;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[i - 1])
            {
                if (!flag)
                {
                    minlen = 2;
                    flag = true;
                }
                else minlen++;
            }
            else if (array[i] < array[i - 1])
            {
                if (flag)
                {
                    minlen = 2;
                    flag = false;
                }
                else minlen++;
            }
            else minlen = 1;
            if (minlen > count) count = minlen;
        }
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

        // end
        int len = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0) len++;
        }        
        
            double[] newva = new double[len];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    newva[index++] = array[i];
                }
            }
            return newva;
        
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