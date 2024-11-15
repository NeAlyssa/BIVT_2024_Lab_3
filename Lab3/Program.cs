using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_3_1(new double[] { -1, -2, -8, -1, -9, -1, -1, -4, -6, -2 });
        //program.Task_1_2(new double[]{2,1,3,3,5,6,3,4});
        //program.Task_1_3(new double[]{0, 1.5, 4, 3}, new double[]{2, 1, 3, 3});
        //program.Task_1_4(new double[] { 0, 1.5, 1, 3, -2.2 });
        //program.Task_1_5(new double[] { -2.2, -0.5, 2, -1 }, new double[] {  0, 1.5, 4, 3});
        //program.Task_1_6(new double[] {  1.5, 1, 3, -2.2, -0.5 });
        //program.Task_1_7(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_1_8(new double[] { 0, 1.5, 1, 3, -2.2, -0.5 });
        //program.Task_1_9(new double[] {  0, 1.5, 1, 3, -2.2, -0.5, 2, -1  });
        //program.Task_1_10(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, -1, 1.8, 2.4  }, 2,8);
        //program.Task_1_11(new double[] {0, 1.5, 1, 3, -2.2, -0.5, 2, 2, 3.1, -0.7 });
        //program.Task_1_12(new double[] {  0, 1.5, 1, 3, -2.2, -0.5, 2, -1 });
        //program.Task_1_13(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, -1.9, 3.9, -0.1 });
        //program.Task_1_14(new double[] {  0, 1.5, 1, 3, -2.2, -0.5, 2, -1, 2, 2.5, -1.4 });
        //program.Task_1_15(new double[] {  0, 1.5, 1, 3, -2.2, -0.5, 2, 2, 3.1, -0.7});
        //program.Task_2_10(new double[] { -5, -2, -8, -1, -9, -3, -7, -4, -6, -2 });
        //program.Task_2_20(new double[] { 12, 1, 3, 3, 5, 6, 3, -4 });
        //program.Task_2_6(new double[] { 0, 1.5, -1, -3, -2.2, -0.5, 6 }, 2.3);
        //program.Task_2_16(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_3_13(new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 10 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        double sum = 0;
        // code here
        for (int i =0; i<6; i++)
        {
            sum += array[i];
            
        }
        for (int j = 0; j < 6; j++)
        {
            array[j] = Math.Round(array[j]/sum, 2);
           
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        double sum = 0;
        double cnt = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                cnt++;
                sum += array[i];
            }
        }
        double sred = Math.Round(sum / cnt,2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                array[i] = sred;
            
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i< first.Length; i++)
        {
            sum[i] = Math.Round(first[i] + second[i],2);
            dif[i] = Math.Round(first[i] - second[i],2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sred = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sred += array[i];
        }
        sred = Math.Round(sred/array.Length,2);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - sred, 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i =0; i<vector1.Length; i++)
        {
            product += (vector1[i] * vector2[i]);
        }
        // end

        return Math.Round(product,2);
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i=0; i< vector.Length; i++)
        {
            length += (vector[i] * vector[i]);
        }
        // end
        length = Math.Sqrt(length);
        return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sred = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sred += array[i];
        }
        sred = Math.Round(sred / array.Length, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sred)
                array[i] = 0;
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        for (int i=0; i<array.Length; i++)
        {
            if (array[i] < 0)
                count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double sred = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sred += array[i];
        }
        sred = Math.Round(sred / array.Length, 2);
        for(int i =0; i<array.Length; i++)
        {
            if (array[i] > sred)
                count++;
        }

        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for (int i = 0; i<array.Length; i++)
        {
            if (P < array[i] && array[i] < Q)
                count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = new double[array.Length];
        int cnt = 0;
        // code here
        for (int i = 0; i<array.Length; i++)
        {
            if (array[i] > 0)
            {
               
                output[cnt] = array[i];
                cnt++;
            }
                
        }
        // end
        Console.WriteLine(output);
        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]<0)
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
        int s = 0, c = 0;
        // code here
        for (int i =0; i< array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[s] = array[i];
                s++;
            }
            else
            {
                odd[c] = array[i];
                c++;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i<array.Length; i++)
        {
            if (array[i] < 0)
                break;
            sum += array[i] * array[i];
            
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
      
        for (int i =0; i<x.Length; i++)
        {
            if (x[i] > 0)
                y[i] = Math.Round((0.5 * Math.Log(x[i])),2);
            else
                y[i] = Double.NaN;
              
        }
        // end
        for (int i =0; i<x.Length; i++)
        {
            Console.WriteLine("{0} {1}", x[i], (x[i] <= 0) ? Double.NaN : y[i]);
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
        double maxElem = -10000000000000;
        double maxi=0;
        // code here
        for (int i =0; i<array.Length; i++)
        {
            if (array[i] > maxElem)
            {
                maxElem = array[i];
                maxi = i;
            }
        }
        for (int i =0; i<maxi; i++)
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
        double sred = 0;
        double maxElem = -10000000000000;
        double maxi = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sred += array[i];
            if (array[i] > maxElem)
            {
                maxElem = array[i];
                maxi = i;
            }
        }
        sred = Math.Round(sred / array.Length,2);
        for (int i =0; i<array.Length; i++)
        {
            if (i > maxi)
            {
                array[i] = sred;
            }
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
        double minRazn = double.MaxValue;
        double sred = 0;
        int mini = 0;
        for (int i = 0; i<array.Length; i++)
        {
            sred += array[i];
        }
        sred = sred / array.Length;
        for (int i = 0; i<array.Length; i++)
        {
            if (Math.Abs(array[i]-sred)< minRazn)
            {
                minRazn = Math.Abs(array[i] - sred);
                mini = i;
            }
        }
        int n = array.Length + 1;
        double [] arr = new double[n];
        
        for (int j = 0; j< arr.Length; j++)
        {
            if (j < mini + 1)
                arr[j] = array[j];
            else
                arr[j] = array[j - 1];
        }
        // end
        arr[mini + 1] = P;
        for (int j = 0; j < arr.Length; j++)
        {
            Console.WriteLine(arr[j]);

        }
        return arr;
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
        double maxElem = double.MinValue;
        double minElem = double.MaxValue;
        int maxi = 0;
        int mini = 0;
        for (int i =0; i<array.Length; i++)
        {
            if (maxElem < array[i])
            {
                maxElem = array[i];
                maxi = i;
            }
        }
        for (int j =maxi; j < array.Length; j++)
        {
            if (minElem > array[j])
            {
                minElem = array[j];
                mini = j;
            }
        }
        double temp = array[maxi];
        array[maxi] = array[mini];
        array[mini] = temp;
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
        
        double minElem = double.MaxValue;
        int mini = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minElem && array[i]>0)
            {
                minElem = array[i];
                mini = i;
            }
        }
        if (minElem != double.MaxValue)
        {
            int n = array.Length - 1;
            for (int i = mini; i < n; i++)
            {
                array[i] = array[i + 1];

            }
        }
       

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
        double maxElem = double.MinValue;
        double sum = 0;
        int maxi = 0;
        for (int i=0; i<array.Length; i++)
        {
            if (array[i]> maxElem)
            {
                maxElem = array[i];
                maxi = i;
            }
        }
        for (int j = maxi+1; j < array.Length; j++)
        {
            sum +=array[j];
        }
        sum = Math.Round(sum, 2);
        for (int k = 0; k < array.Length; k++)
        {
            if (array[k] < 0)
            {
                array[k] = sum;
                break;
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
        double maxElem = double.MinValue;
        int maxi = 0;
        for (int i =0; i<array.Length; i++)
        {
            if (array[i] > maxElem)
            {
                maxElem = array[i];
                maxi = i;
            }
        }
        for (int j =0; j< array.Length; j++)
        {
            if (array[j] < 0)
            {
                double temp = array[maxi];
                array[maxi] = array[j];
                array[j] = temp;
                break;
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

        int newSize = 0;
        int c = 0;
        // code here
        double sred = 0; 
        for (int i = 0; i<array.Length; i++)
        {
            sred += array[i];
        }
        sred /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sred)
                newSize++;
        }
        int[] output = new int[newSize];
        for (int i = 0; i<array.Length; i++)
        {
            if (array[i] < sred)
            {
                output[c] = i;
                c++;
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
        double maxNech = double.MinValue;
        double maxChet = double.MinValue;
        int maxCheti = 0;
        int maxNechi = 0;
        int poli = array.Length/2;
        for (int i =0; i<array.Length; i++)
        {
            if (array[i] > maxChet && i % 2 == 0)
            {
                maxChet = array[i];
                maxCheti = i;
            }
            if (array[i]>maxNech && i % 2 != 0)
            {
                maxNech = array[i];
                maxNechi = i;
            }
        }
        if (maxChet > maxNech)
        {
            for (int i =0; i<poli; i++)
            {
                array[i] = 0;
            }
        }
        else
        {
            for (int i = poli; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }
        // code here

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
        double minElem = double.MaxValue;
        int mini = 0;
        int minuscnt = 0;
        bool flag = false;
        for (int i = 0; i<array.Length; i++)
        {
            if (array[i] < minElem)
            {
                minElem = array[i];
                mini = i;
            }
        }
        Console.WriteLine("{0} {1}", mini, minElem);
        for (int j = 0; j<array.Length; j++)
        {
            if (array[j] < 0)
            {
                minuscnt++;
                if (j < mini)
                    flag = true;
                break;
            }
        }
        Console.WriteLine(flag);
        if (minuscnt == 1)
        {
            if (flag)
            {
                for (int k = 0; k < array.Length; k++)
                {
                    if (k % 2 == 0)
                        sum += array[k];
                }
            }
            else
            {
                for (int k = 0; k < array.Length; k++)
                {
                    if (k % 2 != 0)
                        sum += array[k];
                }
            }
        }
        // code here

        // end
        Console.WriteLine(sum);
        return sum;
    }
    #endregion
    #region Level 3
    public int[] Task_3_1(double[] array)
    {
        int[] a= new int[array.Length];
        double maxElem = double.MinValue;
        int k = 0;
        
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxElem)
            {
                k = 0;
                a[k] = i;
                maxElem = array[i];
            } 
            else if(array[i] == maxElem)
            {
                k++;
                a[k] = i;
            }
        }
       
        
        // code here

        // end

        return a;
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
        int index=0;
        double sum = 0, maxElem = double.MinValue;
        double[] newar = new double[array.Length];
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxElem)
            {
                maxElem = array[i];
                index = i;
            }
            newar[i] = array[i];
        }
        for (int i =0; i< newar.Length; i++)
        {
            sum += newar[i];
            if (newar[i] == maxElem)
            {
                newar[i] = sum - maxElem;
            }
        }
        // end
        
        return newar;
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
        int j = array.Length - 1;
        
        for (int i = array.Length-1; i>0; i--)
        {
            if (array[i] < 0)
            {
                double temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                j--;
            }
        }
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
        
        int c = 1;
        for (int i = array.Length/2-1; i>=0; i--)
        {
            array[array.Length-(c)] = array[i];
            array[array.Length-(c+1)] = array[i];
            c += 2;
        }
        // end
        

        
        return array;
    }
    public (double[], double[], double, double) Task_3_11(double a, double b, int n)
    {
        double[] X = new double[n], Y = new double[n];
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
        int n = array.Length;
        int k = 1;
        double[] A = new double[n];
        for (int i = 0; i < n; i++) A[i] = array[i];
        for (int i = 0; i < n; i++)
        {
            for (int j = k; j < n; j++)
            {
                if (array[i] == array[j]) A[j] = double.E;
            }
            k++;
        }

        int sum = 0;
        for (int i = 0; i < n; i++) if (A[i] == double.E) sum++;
        Console.WriteLine(sum);
        double[] B = new double[n - sum];
        int l = 0;
        for (int i = 0; i < n; i++)
        {
            if (A[i] != double.E)
            {
                B[l] = A[i];
                l++;
            }
        }
        array = B;
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
