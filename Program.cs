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
        foreach (double x in array) { sum += x; }
        for (int i = 0; i < array.Length; i++)
        {
            if ( sum == 0) { return array; }
            else { array[i] = Math.Round(array[i] / sum, 2); }
        }

        return array;
    }//done
    public double[] Task_1_2(double[] array)
    {
        double amount = 0, sum = 0;
        double sr_ar = 0;

        foreach (double x in array)
        {
            if ( x > 0 ) { amount++; sum += x; }
        }

        if (amount == 0) { return array; }
        else { sr_ar = sum / amount; }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) { array[i] = Math.Round(sr_ar,2); }
        }
        return array;
    }//done
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        for (int i = 0; i < first.Length; i++)
        {
            double s = Math.Round(first[i]+second[i],2);
            double d = Math.Round(first[i] - second[i], 2);
            sum[i] = s; dif[i] = d;
        }

        return (sum, dif);
    }//done
    public double[] Task_1_4(double[] array)
    {
        double sr = 0;

        foreach (double x in array) { sr += x; }
        sr = sr / 5;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - sr,2);
        }

        return array;
    }//done
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        for (int i = 0; i < vector1.Length; i++)
        {
            product += Math.Round(vector1[i] * vector2[i],2);
        }

        return Math.Round(product,2);
    }//done
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        foreach (double x in vector)
        {
            length += x * x;
        }
        length = Math.Sqrt(length);

        return Math.Round(length, 2);
    }//done
    public double[] Task_1_7(double[] array)
    {
        double sr = 0;

        foreach (double x in array) { sr += x; }
        sr = sr / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sr) { array[i] = 0; }
        }
        return array;
    }//done
    public int Task_1_8(double[] array)
    {
        int count = 0;

        foreach (double x in array) { if (x < 0) { count++; } }

        return count;
    }//done
    public int Task_1_9(double[] array)
    {
        int count = 0;

        double sr = 0;

        foreach (double x in array) { sr += x; }
        sr = sr / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sr) { count++; }
        }

        return count;
    }//done
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        if (P > Q || P == Q) return 0;

        for(int i = 0; i < array.Length; i++) {
            if ( P < array[i] && array[i] < Q) { count++; }
        }

        return count;
    }//done
    public double[] Task_1_11(double[] array)
    {
        
        int count = 0;
        foreach (double x in array)
        {
            if (x < 0) { count++; }
        }
        double[] output;
        output = new double[array.Length - count];
        int count1 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) { output[count1] = array[i]; count1++; }
        }
        
        return output;
        } // done
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        for (int i = 0; i < array.Length;i++)
        {
            if (array[i] < 0) {
                value = array[i]; index = i;
            }
        }

        return (value, index);
    }//done
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];
        int chetchik_ch = -1;
        int chetch_nech = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0) {
                chetchik_ch += 1;
                even[chetchik_ch] = array[i];
            } else
            {
                chetch_nech += 1;
                odd[chetch_nech] = array[i];
            }
        }
        

        return (even, odd);
    }//done
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0) { sum += array[i] * array[i]; }
            else { break; }
        }

        return Math.Round(sum,2);
    }//done
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] <= 0) { y[i] = double.NaN; }
            else { y[i] = Math.Round(0.5 * Math.Log(x[i]),2); } 
        }

        for (int i = 0; i < x.Length; i++)
        {
            Console.WriteLine($"{x[i]:F3} \t {y[i]:F3}");
        }

        return y;
    } // done
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        //Минимальный элемент заданного одномерного массива увеличить в два раза.
     

        return array;
    } // -
    public double Task_2_2(double[] array)
    {
        double sum = 0;
        double max_el = -1000000000000;
        int place_max_el = 0;

        for ( int i = 0; i < array.Length; i++)
        {
            if (array[i] > max_el) {
                max_el = array[i]; place_max_el = i;
            }
        }

        for (int i = 0; i < place_max_el; i++)
        {
            sum += array[i];
        }
        

        return Math.Round(sum,2);
    } //done
    public double[] Task_2_3(double[] array)
    {
        // code here

        // end

        return array;
    } // -
    public double[] Task_2_4(double[] array)
    {
        // 1 part
        double max_el = -1000000000000;
        int place_max_el = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max_el)
            {
                max_el = array[i]; place_max_el = i;
            }
        }
        // 2 part
        double sr_ar = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sr_ar += array[i];
        }
        sr_ar = sr_ar / array.Length;
        //3 part
        for (int i = place_max_el + 1; i < array.Length; i++)
        {
            array[i] = Math.Round(sr_ar,2);
        }

        return array;
    } //done
    public double[] Task_2_5(double[] array)
    {
        // code here

        // end

        return array;
    }// -
    public double[] Task_2_6(double[] array, double P)
    {
        // 1 part
        double sum = 0;
        double sr_ar = 0;
        foreach(double x in array)
        {
            sum += x;
        }
        sr_ar = Math.Round(sum/array.Length,2);

        // 2 part
        double per_for_close_srar = 100000000000000000;
        int number_el = 0;
        for (int i = 0; i < array.Length; i++)
        {
            
            if (Math.Abs(array[i] - sr_ar) < per_for_close_srar)
            {
                per_for_close_srar = Math.Abs(array[i] - sr_ar);
                number_el = i;
            }
        }
        double[] array1 = new double[array.Length + 1];
        int chetchik = 0;
        for (int i = 0; i <= number_el; i++)
        {
            array1[chetchik] = array[i];
            chetchik++;
        }
        array1[number_el + 1] = P;
        int element = number_el + 2;
        for (int i = number_el+1; i < array.Length; i++)
        {
            array1[element] = array[i];
            element++;
        }
        
        return array1;
    } // done
    public double[] Task_2_7(double[] array)
    {
        // code here

        // end

        return array;
    } // -
    public double[] Task_2_8(double[] array)
    {
        //Поменять местами максимальный элемент массива и минимальный элемент части массива, расположенной после максимального.
        double maxx = -10000000; int number_maxx = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] > maxx)
            {
                maxx = array[i];
                number_maxx = i;
                
            }
        }
        double minn = 100000000; int number_minn = 0;
        for (int i = number_maxx+1; i < array.Length; i++) {
            if (array[i] < minn)
            {
                minn = array[i]; 
                number_minn = i;
            }
        }
        double transp;
        if (number_maxx != array.Length - 1)
        {
            transp = array[number_maxx]; 
            array[number_maxx] = array[number_minn]; // 10
            array[number_minn] = transp; // 100
        }
        return array;
    } // done
    public double Task_2_9(double[] array)
    {
        double average = 0;

        // code here

        // end

        return average;
    } // -
    public double[] Task_2_10(double[] array)
    {
        double minn = 10000000000000; int minind = 0, plusnum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) { 
                if (array[i] < minn) {
                    minn = array[i];
                    minind = i;
                }
                plusnum++;
        }
        }
        if (plusnum > 0)
        {
            for (int i = minind; i < array.Length-1; i++) {
                array[i] = array[i+1];
            }
            double[] array1 = new double[array.Length - 1];
            int l = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                array1[l] = array[i];
                l++;
            }
            array = array1;
        }
        return array;
    } // done
    public double[] Task_2_11(double[] array, double P)
    {
        // code here

        // end

        return array;
    } // -
    public double[] Task_2_12(double[] array)
    {
        //Первый отрицательный элемент массива заменить суммой элементов, расположенных после максимального.
        double max_el = -1000000000000;
        int place_max_el = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max_el)
            {
                max_el = array[i]; place_max_el = i;
            }
        }
        double sum = 0;
       for (int i = place_max_el+1; i < array.Length; i++)
       {
            sum += array[i];
       }
       int ch = 0;
       for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0  && ch == 0)
            {
                array[i] = Math.Round(sum,2); ch += 1;
            }
        }

       return array;
    } // done
    public double[] Task_2_13(double[] array)
    {
        // code here

        // end

        return array;
    } // -
    public double[] Task_2_14(double[] array)
    {
        //true
        double max_el = -1000000000000;
        int place_max_el = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max_el)
            {
                max_el = array[i]; 
                place_max_el = i;
            }
        }
        //

        //
        int place = 0, cnt = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                cnt += 1;
                place = i;
                break;
            }
        }
        if (cnt == 1)
        {
            double temp = array[place_max_el];
            array[place_max_el] = array[place];
            array[place] = temp;
        }
        return array;
    } // done
    public double[] Task_2_15(double[] A, double[] B, int k)
    {
        double[] output = null;

        // code here

        // end

        return output;
    } // -
    public int[] Task_2_16(double[] array)
    {
        int[] output;

        double sr = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sr += array[i];
        }
        sr = sr / array.Length;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr)
            {
                count++;
            }
        }
        output = new int[count];
        int ch = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr)
            {
                output[ch] = i; ch++;
            }
        }
        return output;
    } // done
    public double Task_2_17(double[] array)
    {
        double average = 0;

        // code here

        // end

        return average;
    } // -
    public double[] Task_2_18(double[] array)
    {
        double maxx_ch = -100000000000; double maxx_nech = -1000000000000000;

        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0 && array[i] > maxx_ch)
            {
                maxx_ch = array[i];
            } else if (i % 2 == 1 && array[i] > maxx_nech)
            {
                maxx_nech = array[i];
            }
        }
        if (maxx_ch > maxx_nech)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                array[i] = 0;
            }
        }
        else if (maxx_nech > maxx_ch)
        {
            for (int i = array.Length/2; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }
           
        return array;
        }  // done
    public double[] Task_2_19(double[] array)
    {
        // code here

        // end

        return array;
    } // -
    public double Task_2_20(double[] array)
    {
        double sum = 0;

        double min = 10000000000000; int place = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i]; place = i;
            }
        }
        int place_min = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0 && place_min == 0)
            {
               place_min = i;
            }
        }
        if (place_min == 0) return 0;
        if (place_min < place) {
            for (int i = 0; i < array.Length; i++)
            {
                if (i%2==0)
                {
                    sum += array[i];
                }
            }
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 1)
                {
                    sum += array[i];
                }
            }

        }

        return sum;
    } // done
    #endregion
    #region Level 3
    public int[] Task_3_1(double[] array)
    {
        int[] output = null;

        // code here

        // end

        return output;
    } // -
    public double[] Task_3_2(double[] array)
    {
        // code here

        // end

        return array;
    } // -
    public double[] Task_3_3(double[] array)
    {
        double maxx_el = -10100000000000;
        int indmax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxx_el)
            {
                indmax = i;
                maxx_el = array[i]; 
            }
        }
        // 0 1 2 3 4 5 6  // 6 - indmax
        // 1 0 3 2 5 4 
        // 0   2   4

        // 0, 1.5, 1, 3, -2.2, -0.5, 3  // indmax = 3
        // 1.5, 0, 1, 3, -2.2, -0.5, 3 
        if (indmax == 0) return array;
        for (int i = 0; i < indmax-1; i+=2) // [0,1]
        { // i = 0
            double temp = array[i]; // 0
            array[i] = array[i+1]; // 1,5
            array[i+1] = temp; // 0 
        } 
        return array;
    } // done
    public double[] Task_3_4(double[] array)
    {
        // code here

        // end

        return array;
    } // -
    public double[] Task_3_5(double[] array)
    {
        // code here

        // end

        return array;
    } // -
    public int Task_3_6(double[] A)
    {
        // В массиве А найти максимальное количество следующих подряд упорядоченных по убыванию элементов.
        int cnt = 1, maxx = 0; // 2 1 0 15 31 2 14 32 2 1 0 12
        for (int i = 1; i < A.Length; i++)
        {
            if (A[i] <= A[i - 1]) 
            {
                cnt++;
                if (cnt > maxx) maxx = cnt;
            }
            else
            {
                cnt = 1;
            }
            
        }

        return maxx;
    } // done
    public double[] Task_3_7(double[] array)
    {
        // code here

        // end

        return array;
    } // - 
    public double[] Task_3_8(double[] array)
    {
        // code here

        // end

        return array;
    } // -
    public int Task_3_9(double[] array)
    {
        int cnt1 = 1, maxx1 = 0; int cnt2 = 1, maxx2 = 0; int maxx = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] <= array[i - 1])
            {
                cnt1++;
                if (cnt1 > maxx1) maxx1 = cnt1;
            }
            else
            {
                cnt1 = 1;
            }  
        }
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] >= array[i - 1])
            {
                cnt2++;
                if (cnt2 > maxx2) maxx2 = cnt2;
            }
            else
            {
                cnt2 = 1;
            }
        }
        if ( maxx1 >= maxx2 ) maxx = maxx1;
        else { maxx = maxx2; }
        return maxx;
    } // done
    public double[] Task_3_10(double[] array)
    {
        // code here

        // end

        return array;
    } // -
    public (double[], double[], double, double) Task_3_11(double a, double b, int n)
    {
        double[] X = null, Y = null;
        double globalMax = 0, globalMin = 0;

        // code here

        // end

        return (X, Y, globalMax,globalMin);
    } // -
    public double[] Task_3_12(double[] array)
    {
        int amount_plus = 0;
        
        foreach (double x in array)
        {
            if (x >= 0 )
            {
                amount_plus++;
            }
        }
        double[] arra1 = new double[amount_plus];
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) continue;
            arra1[k] = array[i];
            k++;
        }

        return arra1;
    }
    public double[] Task_3_13(double[] array)
    {
        // code here

        // end

        return array;
    } // -
    public double[] Task_3_14(double[] array)
    {
        double[] normalizedArray = null;

        // code here

        // end

        return normalizedArray;
    } // -
    #endregion
}