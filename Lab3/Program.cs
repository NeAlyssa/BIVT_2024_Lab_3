using System.Net.Mail;
using System.Data;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Versioning;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        program.Task_1_1(new double[] {1, 2, 3, 4, 5, 6});
    }
    #region Level 1
    public double[] Task_1_1(double[] array) // dotnet test --filter Tests.ProgramTests.Task_1_1Test
    {
        // code here
        double sumArray = 0;
        for (int i=0; i<6; i++) {
            sumArray += array[i];
        };
        
        for (int i=0; i<6; i++) {
            array[i] = Math.Round(array[i] / sumArray, 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array) // dotnet test --filter Tests.ProgramTests.Task_1_2Test
    {
    {
        // code here
        double arithmeticMean = 0;
        int count = 0;
        for (int i=0; i<8; i++) {
            double element = array[i];
            if (element > 0) {
                arithmeticMean += element;
                count++;
            };
        }
        arithmeticMean /= count;
        arithmeticMean = Math.Round(arithmeticMean, 2);
        for (int i=0; i<8; i++) {
            double element = array[i];
            if (element > 0) {
                array[i] = arithmeticMean;
            }
        }
        // end

        return array;
    }}
    public (double[], double[]) Task_1_3(double[] first, double[] second) // dotnet test --filter Tests.ProgramTests.Task_1_3Test
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i=0; i<4; i++) {
            double el1 = first[i], el2 = second[i];
            sum[i] = Math.Round(el1 + el2, 2);
            dif[i] = Math.Round(el1 - el2, 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array) // dotnet test --filter Tests.ProgramTests.Task_1_4Test
    {
        // code here
        double avg = 0;
        for (int i=0; i<5; i++) {
            avg += array[i];
        }
        avg /= 5;
        for (int i=0; i<5; i++) {
            double element = array[i];
            array[i] = Math.Round(element - avg, 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2) // dotnet test --filter Tests.ProgramTests.Task_1_5Test
    {
        double product = 0;

        // code here
        for (int i=0; i<4; i++) {
            product += vector1[i] * vector2[i];
        }

        product = Math.Round(product, 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector) // dotnet test --filter Tests.ProgramTests.Task_1_6Test
    {
        double length = 0;

        // code here
        for (int i=0; i<5; i++) {
            length += Math.Pow(vector[i], 2);
        }
        length = Math.Round(Math.Sqrt(length), 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array) // dotnet test --filter Tests.ProgramTests.Task_1_7Test
    {
        // code here
        double avg = 0;
        for (int i=0; i<7; i++) {
            avg += array[i];
        }
        avg /= 7;

        for (int i=0; i<7; i++) {
            double element = array[i];
            if (element > avg) {
                array[i] = 0;
            }
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array) // dotnet test --filter Tests.ProgramTests.Task_1_8Test
    {
        int count = 0;

        // code here
        for (int i=0; i<6; i++) {
            if (array[i] < 0) count += 1;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array) // dotnet test --filter Tests.ProgramTests.Task_1_9Test
    {
        int count = 0;

        // code here
        double avg = 0;
        for (int i=0; i<8; i++) {
            avg += array[i];
        }
        avg /= 8;

        for (int i=0; i<8; i++) {
            if (array[i] > avg) count += 1;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q) // dotnet test --filter Tests.ProgramTests.Task_1_10Test
    {
        int count = 0;

        // code here
        for (int i=0; i<10; i++) {
            double el = array[i];
            if (el > P && el < Q) count += 1;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array) // dotnet test --filter Tests.ProgramTests.Task_1_11Test
    {

        // code here
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                count++;
            }
        }

        double[] output = new double[count];

        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[index] = array[i];
                index++;
            }
        }

        return output;
    }
    public (double, int) Task_1_12(double[] array) // dotnet test --filter Tests.ProgramTests.Task_1_12Test
    {
        double value = 0;
        int index = -1;

        // code here
        for (int i=0; i<8; i++) {
            if (array[i] < 0) {
                value = array[i];
                index = i;
            }
        }
        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array) // dotnet test --filter Tests.ProgramTests.Task_1_13Test
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        // code here
        for (int i=0; i<10; i++) {
            if (i%2==0) even[i / 2] = array[i]; else odd[i / 2] = array[i];
        }
        // end
        
        return (even, odd);
    }
    public double Task_1_14(double[] array) // dotnet test --filter Tests.ProgramTests.Task_1_14Test
    {
        double sum = 0;

        // code here
        for (int i=0; i<11; i++) {
            double el = array[i];
            if (el < 0) break;
            sum += el * el;
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x) // dotnet test --filter Tests.ProgramTests.Task_1_15Test
    {
        double[] y = new double[x.Length];

        // code here
        for (int i=0; i<10; i++) {
            double y_el = 0.5*Math.Log(x[i]);
            if (y_el == double.NegativeInfinity) y_el = double.NaN;
            if (y_el != double.NaN) y_el = Math.Round(y_el, 2);
            y[i] = y_el;
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
    public double Task_2_2(double[] array) // dotnet test --filter Tests.ProgramTests.Task_2_2Test
    {
        double sum = 0;

        // code here
        double max_c = -100000;
        foreach (double i in array) {
            if (i > max_c) max_c = i;
        }

        foreach (double i in array) {
            if (i == max_c) break;
            sum += i;
        }
        // end

        return sum;
    }
    public double[] Task_2_3(double[] array) // dotnet test --filter Tests.ProgramTests.Task_2_3Test
    {
        // code here
        // end

        return array;
    }
    public double[] Task_2_4(double[] array) // dotnet test --filter Tests.ProgramTests.Task_2_4Test
    {
        // code here
        double max_c = -100000;
        bool flag = false;
        foreach (double i in array) {
            if (i > max_c) max_c = i;
        }

        double avg = 0;
        foreach (double i in array) avg += i;
        avg /= array.Length;
        avg = Math.Round(avg, 2);

        for (int i=0; i<array.Length; i++) {
            if (flag) {
                array[i] = avg;
            }
            if (array[i] == max_c && !flag) flag = true;
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
    public double[] Task_2_6(double[] array, double P) // dotnet test --filter Tests.ProgramTests.Task_2_6Test
    {
        // code here
        double avg = 0;
        for (int i=0; i<array.Length; i++) {
            avg += array[i];
            Console.WriteLine(array[i]);
        }
        avg /= array.Length;
        avg = Math.Round(avg, 2);

        int index = -1;
        double last_difference = 1000;
        for (int i=0; i<array.Length; i++) {
            double el = array[i];
            if (Math.Abs(el - avg) < last_difference) {
                last_difference = Math.Abs(el - avg);
                index = i + 1;
            }
        }
        
        double[] result = new double[array.Length + 1];
        
        for (int i = 0; i < index; i++)
        {
            result[i] = array[i];
        }

        result[index] = P;
        for (int i = index; i < array.Length; i++)
        {
            result[i + 1] = array[i];
        }
        array = result;

        return array;
    }
    public double[] Task_2_7(double[] array) // dotnet test --filter Tests.ProgramTests.Task_2_7Test
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_8(double[] array) // dotnet test --filter Tests.ProgramTests.Task_2_8Test
    {
        // code here
        double max_element = -10000, min_element = 10000;
        
        int max_index = 0, min_index = 0;

        for (int i=0; i<array.Length; i++) {
            double element = array[i];
            if (element > max_element) {
                max_index = i;
                max_element = element;
            }
        }
        for (int i=max_index; i<array.Length; i++) {
            double element = array[i];
            if (element < min_element) {
                min_element = element;
                min_index = i;
            }
        }

        array[max_index] = min_element;
        array[min_index] = max_element;
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
   public double[] Task_2_10(double[] array) // dotnet test --filter Tests.ProgramTests.Task_2_10Test
   {
        double minPositiveValue = 1000000;
        int indexOfMinPositiveValue = -1; 

        for (int i=0; i<array.Length; i++) {
            double element = array[i];
            if (array[i] > 0 && array[i] < minPositiveValue) {
                minPositiveValue = array[i];
                indexOfMinPositiveValue = i;
            }
        }
        
        if (indexOfMinPositiveValue == -1) return array;

        double[] arrayResult = new double[array.Length - 1];
        int resultIndex = 0;
        for (int i = 0; i < array.Length; i++) {
            if (i != indexOfMinPositiveValue) {
                arrayResult[resultIndex] = array[i];
                resultIndex++;
            }
        }
        return arrayResult;
    }

    public double[] Task_2_11(double[] array, double P)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_12(double[] array) // dotnet test --filter Tests.ProgramTests.Task_2_12Test
    {
        // code here
        int indexFirstNegativeElement = -1;
        int indexMaxEl = -1;
        
        double maxEl = -1000;

        for (int i = 0; i<array.Length; i++) {
            double element = array[i];
            if (element < 0 && indexFirstNegativeElement == -1) indexFirstNegativeElement = i;
            if (element > maxEl) {
                maxEl = element;
                indexMaxEl = i;
            }
        }
        if (indexFirstNegativeElement == -1) return array;

        double sumElementsAfterMaxEl = 0;
        for (int i=indexMaxEl + 1; i<array.Length; i++) {
            double element = array[i];
            sumElementsAfterMaxEl += element;
        }

        sumElementsAfterMaxEl = Math.Round(sumElementsAfterMaxEl, 2);
        array[indexFirstNegativeElement] = sumElementsAfterMaxEl;

        // end

        return array;
    }
    public double[] Task_2_13(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_14(double[] array) // dotnet test --filter Tests.ProgramTests.Task_2_14Test
    {
        // code here
        int indexMax = -1;
        int indexNegative = -1;
        double maxEl = -1000000;

        for (int i = 0; i < array.Length; i++) {
            if (array[i] > maxEl) {
                maxEl = array[i];
                indexMax = i;
            }
            if (array[i] < 0 && indexNegative == -1) {
                indexNegative = i;
            }
        }
        if (indexNegative == -1) return array;

        double ii = array[indexMax];
        array[indexMax] = array[indexNegative];
        array[indexNegative] = ii;
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
    public int[] Task_2_16(double[] array) // dotnet test --filter Tests.ProgramTests.Task_2_16Test
    {
        int[] output = null;

        // code here
        double avg = 0;
        for (int i=0; i<array.Length; i++) {
            avg += array[i];
        }
        avg /= array.Length;

        int counter = 0;
        for (int i=0; i<array.Length; i++) {
            if (array[i] < avg) counter += 1;
        }

        output = new int[counter];
        int index = 0;

        for (int i=0; i<array.Length; i++) {
            if (array[i] < avg) {
                output[index] = i;
                index++;
            };
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
    public double[] Task_2_18(double[] array) // dotnet test --filter Tests.ProgramTests.Task_2_18Test
    {
        // code here
        double maxEvenElement = -100000;
        double maxOddElement = -10000;

        for (int i=0; i<array.Length; i++) {
            if (i % 2 == 0 && maxEvenElement < array[i]) {
                maxEvenElement = array[i];
            } else if (i % 2 != 0 && maxOddElement < array[i]) {
                maxOddElement = array[i];
            }
        }

        if (maxEvenElement > maxOddElement) {
            for (int i=0; i<array.Length/2; i++) {
                array[i] = 0;
            }
        } else {
            for (int i=array.Length/2; i<array.Length; i++) {
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
    public double Task_2_20(double[] array) // dotnet test --filter Tests.ProgramTests.Task_2_20Test
    {
        double sum = 0;

        // code here
        double minEl = 10000;
        int indexMinEl = -1;
        int indexNegative = -1;

        for (int i=0; i<array.Length; i++) {
            if (array[i] < minEl) {
                minEl = array[i];
                indexMinEl = i;
            }
        }

        for (int i=0; i<array.Length; i++) {
            if (array[i] < 0) {
                indexNegative = i;
                break;
            }
        }
        
        if (indexMinEl > indexNegative && indexMinEl != -1 && indexNegative != -1) {
            for (int i=0; i<array.Length; i+=2) sum += array[i];
            Console.WriteLine((indexMinEl, indexNegative));
        } else {
            for (int i=1; i<array.Length; i+=2) sum += array[i];
            Console.WriteLine((indexMinEl, indexNegative, "хуй"));
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
    public double[] Task_3_2(double[] array) // dotnet test --filter Tests.ProgramTests.Task_3_2Test
    {
        // code here
        double maxEl = -10000;
        int number = 1;

        for (int i=0; i<array.Length; i++) {
            maxEl = Math.Max(array[i], maxEl);
        }

        for (int i=0; i<array.Length; i++) {
            if (array[i] == maxEl) {
                array[i] += number;
                number += 1;
            }
        }

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

        // end

        return array;
    }
    public double[] Task_3_5(double[] array) // dotnet test --filter Tests.ProgramTests.Task_3_5Test
    {
        // code here
        double[] onlyEven = new double[(array.Length+1)/2];
        int index = 0;

        for (int i=0; i<array.Length; i+=2) {
            onlyEven[index] = array[i];
            index++;
        }
        
        for (int i=0; i<onlyEven.Length-1; i++) {
            for (int j=0; j<onlyEven.Length-1-i; j++) {
                if (onlyEven[j] > onlyEven[j + 1]) {
                    double element = onlyEven[j];
                    onlyEven[j] = onlyEven[j + 1];
                    onlyEven[j + 1] = element;
                }
            }
        }

        index = 0;
        for (int i=0; i<array.Length; i+=2) {
            array[i] = onlyEven[index];
            index++;
        }
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

        // end

        return array;
    }
    public double[] Task_3_8(double[] array) // dotnet test --filter Tests.ProgramTests.Task_3_8Test
    {
        // code here
        int counter = 0;
        for (int i=0; i<array.Length; i++) {
            if (array[i] < 0) counter++;
        }
        double[] onlyNegative = new double[counter];
        int index = 0;

        for (int i=0; i<array.Length; i++) {
            if (array[i] < 0) {
                onlyNegative[index] = array[i];
                index++;
            }
        }

        for (int i=1; i<counter; i++) {
            double k = onlyNegative[i];
            int j = i-1;
            while (j >= 0 && onlyNegative[j] < k)
            {
                onlyNegative[j+1] = onlyNegative[j];
                j--;
            }
            onlyNegative[j+1] = k;
        }

        index = 0;
        for (int i = 0; i < array.Length; i++) {
            if (array[i] < 0) {
                array[i] = onlyNegative[index];
                index++;
            }
        }
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

        // end

        return array;
    }
    public (double[], double[], double, double) Task_3_11(double a, double b, int n)
    {
        double[] X =  new double[n], Y = new double[n];

        double splitStep = (b - a) / (n - 1);

        for (int i = 0; i < n; i++)
        {
            X[i] = a + i * splitStep;
            Y[i] = Math.Round(Math.Cos(X[i]) + X[i] * Math.Sin(X[i]), 2);
            X[i] = Math.Round(a + i * splitStep, 2);
        }

        double globalMax = Math.Max(Y[0], Y[n-1]), globalMin = Math.Min(Y[0], Y[n-1]);

        // code here
        for (int i=1; i<Y.Length-1; i++) {
            double el = Y[i], befEl = Y[i-1], aftEl = Y[i+1];
            
            if (befEl < el && aftEl < el) {
                Console.WriteLine($"Найден экстремум! Аргумент: {X[i]}, Значение функции: {el}, Вид экстремума: локальный максимум");

            };
            if (befEl > el && aftEl > el) {
                Console.WriteLine($"Найден экстремум! Аргумент: {X[i]}, Значение функции: {el}, Вид экстремума: локальный минимум");
            };

            globalMin = Math.Min(globalMin, el);
            globalMax = Math.Max(globalMax, el);
        }

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

        // end

        return array;
    }
    public double[] Task_3_14(double[] array)
    {
        double[] normalizedArray = new double[array.Length];

        double maxEl = -100000, minEl = 100000;

        // code here
        foreach (double el in array) {
            maxEl = Math.Max(maxEl, el);
            minEl = Math.Min(minEl, el);
        }
        for (int i = 0; i < array.Length; i++)
        {
            normalizedArray[i] = Math.Round(-1 + 2 * (array[i] - minEl) / (maxEl - minEl), 2);
        }

        // обратное преобразование
        // double[] originalArray = new double[normalizedArray.Length];
        // for (int i = 0; i < normalizedArray.Length; i++)
        // {
        //     originalArray[i] = minEl + (normalizedArray[i] + 1) * (maxEl - minEl) / 2;
        //     Console.WriteLine(Math.Round(minEl + (normalizedArray[i] + 1) * (maxEl - minEl) / 2, 1));
        // }
        // end

        return normalizedArray;
    }
    #endregion
}