public class Program
{
    public static void Main()
    {
        Program program = new Program();
        Console.WriteLine(program.Task_3_11(1.5, 3, 4));

    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        double sum = 0;
        for (int i = 0; i < 6; i++)
        {
            sum += array[i];
        }
        for (int i = 0; i < 6; i++)
        {
            array[i] = Math.Round(array[i] / sum, 2);
        }

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        double sum = 0, count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                sum += array[i];
                count++;
            }
        }
        double ar = Math.Round(sum / count, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = ar;
            }
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
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        double ar = sum / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - ar, 2);
        }


        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;
        for (int i = 0; i < 4; i++)
        {
            product += vector1[i] * vector2[i];
        }
        return Math.Round(product, 2);
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        for (int i = 0; i < vector.Length; i++)
        {
            length += vector[i] * vector[i];
        }

        return Math.Round(Math.Sqrt(length), 2);
    }
    public double[] Task_1_7(double[] array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        double ar = sum / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > ar)
            {
                array[i] = 0;
            }
        }
        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) { count++; }
        }
        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        double ar = sum / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > ar) count++;
        }
        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > P && array[i] < Q) count++;
        }

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) count++;
        }
        output = new double[count];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
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

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
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
        double[] odd = new double[array.Length / 2];
        int j = 0, k = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[j++] = array[i];
            }
            else odd[k++] = array[i];
        }

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) break;
            sum += (array[i] * array[i]);
        }

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] <= 0) { y[i] = double.NaN; }
            else y[i] = Math.Round(0.5 * Math.Log(x[i], Math.E), 2);
        }

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        double max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max) break;
            sum += array[i];
        }
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
        double max = 0;
        int maxi = 0;
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) { max = array[i]; maxi = i; }
            sum += array[i];
        }
        double ar = Math.Round(sum / array.Length, 2);
        for (int i = maxi + 1; i < array.Length; i++)
        {
            array[i] = ar;
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
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        double ar = sum / array.Length;
        double res = double.MaxValue;
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - ar) < res)
            {
                res = Math.Abs(array[i] - ar);
                j = i;
            }
        }
        double[] second_array = new double[array.Length + 1];
        for (int i = 0; i < array.Length; i++)
        {
            if (i < j) second_array[i] = array[i];
            if (i == j)
            {
                second_array[i] = array[i];
                second_array[i + 1] = P;
            }
            if (i > j)
            {
                second_array[i + 1] = array[i];
            }
        }
        return second_array;
    }
    public double[] Task_2_7(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_8(double[] array)
    {
        double mini = double.MaxValue;
        int miniI = 0, maxI = 0;
        double max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxI = i;
                mini = double.MaxValue;
                miniI = i;
            }
            if (i > maxI && array[i] < mini)
            {
                miniI = i;
                mini = array[i];
            }
            if (i == array.Length - 1)
            {
                array[maxI] = mini;
                array[miniI] = max;
            }
        }
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
        double mini = double.MaxValue;
        int miniI = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && array[i] < mini)
            {
                mini = array[i];
                miniI = i;
            }
        }
        double[] array_second = new double[array.Length - 1];
        for (int i = 0; i < array.Length; i++)
        {
            if (i < miniI)
            {
                array_second[i] = array[i];
            }
            if (i > miniI)
            {
                array_second[i - 1] = array[i];
            }
        }
        if (mini == double.MaxValue)
        {
            return array;
        }
        return array_second;
    }
    public double[] Task_2_11(double[] array, double P)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_12(double[] array)
    {
        double max = double.MinValue;
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                sum = 0;
            }
            else
            {
                sum += array[i];

            }
        }
        sum = Math.Round(sum, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = sum;
                break;
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
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
        double max = double.MinValue;
        int maxI = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxI = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[maxI] = array[i];
                array[i] = max;
                break;
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
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

        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        double ar = sum / array.Length;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < ar) count++;
        }
        output = new int[count];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < ar)
            {
                output[j] = i;
                j++;
            }
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
        double maxchet = 0;
        double maxnechet = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0 && array[i] > maxchet)
            {
                maxchet = array[i];
            }
            else if (i % 2 != 0 && array[i] > maxnechet)
            {
                maxnechet = array[i];
            }
        }
        if (maxchet > maxnechet)
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
        int firstNegativeI = int.MaxValue, minI = -1;
        double min = double.MaxValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0) continue;
            firstNegativeI = i;
            break;
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > min) continue;
            min = array[i];
            minI = i;
        }

        if (firstNegativeI < minI)
        {
            for (int i = 0; i < array.Length; i += 2) sum += array[i];
        }
        else
        {
            for (int i = 1; i < array.Length; i += 2) sum += array[i];
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
        double maxx = array[0];
        int c = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxx)
            {
                maxx = array[i];
                c = 1;
            }
            else if (array[i] == maxx)
            {
                c++;
            }
        }
        output = new int[c];
        int id = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == maxx)
            {
                output[id++] = i;
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
        if (array.Length == 0)
        {
            return array;
        }
        double maxx = double.MinValue;
        foreach (double i in array)
        {
            if (i > maxx) maxx = i;
        }
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == maxx)
            {
                sum += array[i];
                array[i] = sum - array[i];
            }
            else sum += array[i];
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
        int pI = 0, nI = 0;
        double[] a = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                a[pI++] = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                a[pI + nI] = array[i];
                nI++;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = a[i];
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
        int c = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 0)
            {
                c = i + 1;
            }
        }
        for (int i = c - 1; i >= 0; i--)
        {
            array[2 * i + 1] = array[i];
            array[2 * i] = array[i];
        }

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
        // code here

        // end

        return array;
    }
    public double[] Task_3_13(double[] array)
    {
        // code here
        int n = 0; int p = 0;
        double[] newarray = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            bool dubl = true;
            for (int j = 0; j < newarray.Length; j++)
            {
                if (array[i] == newarray[j])
                {
                    dubl = false;
                }
            }
            if (dubl == true)
            {
                newarray[i] = array[i];
            }
        }
        for (int i = 0; i < newarray.Length; i++)
        {
            if (newarray[i] == 0 && newarray[i] != array[i])
            {
                n++;
            }
        }
        double[] res = new double[newarray.Length - n];

        for (int i = 0; i < newarray.Length; i++)
        {
            if (newarray[i] == array[i])
            {
                res[p] = newarray[i];
                p++;
            }
        }
        array = res;
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