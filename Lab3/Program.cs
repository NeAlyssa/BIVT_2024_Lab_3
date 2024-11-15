using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        int[] a = new int[]{2, 4, 3, 1, 5};

        foreach (int member in a){
            System.Console.WriteLine(member);
        }


        for (int i = 1; i < a.Length; i++){
            var key = a[i];
            int j = i-1;
            while (j >= 0 && a[j] > key){
                a[j+1] = a[j];
                j--;
            }
            a[j+1] = key;
        }


        // for (int i = 1, j = 2; i < a.Length;){
        //     if (i==0 || a[i]>=a[i-1]){
        //         i=j;
        //         j++;
        //     }
        //     else{
        //         int tmp = a[i];
        //         a[i] = a[i-1];
        //         a[i-1] = tmp;
        //         i--;
        //     }
        // }


        // for (int i = 1; i < a.Length; ){
        //     if (i == 0 || a[i-1] <= a[i]){
        //         i++;
        //     }
        //     else{
        //         int tmp = a[i];
        //         a[i] = a[i-1];
        //         a[i-1] = tmp;
        //         i--;
        //     }
        // }

        // for (int i = 0; i < a.Length; i++){
        //     for (int j = 0; j < a.Length-i-1; j++){
        //         if (a[j] > a[j+1]){
        //             int tmp = a[j+1];
        //             a[j+1] = a[j];
        //             a[j] = tmp;
        //         }
        //     }
        // }

        foreach (int memeber in a){
            System.Console.WriteLine(memeber);
        }

        //program.Task_3_13(new double[]{ -1, -2, -8, -1, -9, -1, -1, -4, -6, -2 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double sumArr = 0;
        for (int i = 0; i < array.Length; i++){
            sumArr += array[i];
        }
        double[] answerArr = new double[array.Length];
        for (int i = 0; i < answerArr.Length; i++){
            answerArr[i] = Math.Round(array[i]/sumArr, 2);
        }
        // end

        return answerArr;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sumPositive = 0;
        int countPositive = 0;
        for (int i = 0; i < array.Length; i++){
            if (array[i] > 0){
                sumPositive += array[i];
                countPositive ++;
            }
        }
        double mean = Math.Round(sumPositive/countPositive, 2);
        for (int i = 0; i < array.Length; i++){
            if (array[i] > 0){
                array[i] = mean;
            }
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i < first.Length; i++){
            sum[i] = Math.Round(first[i]+second[i], 1);
            dif[i] = first[i]-second[i];
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sumMembers = 0;
        double countMembers = 0;
        for (int i = 0; i < array.Length; i++){
            sumMembers += array[i];
            countMembers++;
        }
        double mean = Math.Round(sumMembers/countMembers, 2);
        for (int i = 0; i < array.Length; i++){
            array[i] = Math.Round(array[i]-mean, 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < vector1.Length; i++){
            product += vector1[i]*vector2[i];
        }
        product = Math.Round(product, 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        double sumCoord = 0;
        for (int i = 0; i < vector.Length; i++){
            sumCoord += vector[i]*vector[i];
        }
        length = Math.Sqrt(sumCoord);
        // end

        return Math.Round(length, 2); 
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sumMembers = 0;
        double countMembers = 0;
        for (int i = 0; i < array.Length; i++){
            sumMembers += array[i];
            countMembers ++;
        }
        double mean = sumMembers/countMembers;
        for (int i = 0; i < array.Length; i++){
            if (array[i] > mean){
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
        foreach(double member in array){
            if (member < 0){
                count++;
            }
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double sumMembers = 0;
        foreach (double member in array){
            sumMembers += member;
        }
        double mean = sumMembers/array.Length;

        foreach(double member in array){
            if (member > mean){
                count ++;
            }
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        foreach (double member in array){
            if ((P < member) && (member < Q)){
                count++;
            }
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        // code here
        int count = 0;
        foreach (double member in array){
            if (member > 0){
                count++;
            }
        }
        double[] output = new double[count];
        int iCount = 0;
        for (int i = 0; i < array.Length; i++){
            if (array[i] > 0){
                output[iCount] = array[i];
                iCount++; 
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
        for (int i = array.Length-1; i >= 0; i--){
            if (array[i] < 0){
                value = array[i];
                index = i;
                break;
            }
        }
        // end
        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];
        int iElement = 0;
        // code here
        for (int i = 0; i < array.Length; i++){
            if (i%2 == 0){
                even[iElement] = array[i];
            }
            else{
                odd[iElement] = array[i];
                iElement++;
            }
        }
        // end
        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;
        int difIndex = array.Length;
        // code here
        for (int i = 0; i < array.Length; i++){
            if (array[i] < 0){
                difIndex = i;
                break;
            }
        }
        for (int i = 0; i < difIndex; i++){
            sum += array[i]*array[i];
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i = 0; i < x.Length; i++){
            if (x[i] > 0){
            y[i] = Math.Round(0.5*Math.Log(x[i]), 2);
            }
            else{
                y[i] = double.NaN;
            }
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
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        int iMax = 0;
        double Max = 0;
        for (int i = 0; i < array.Length; i++){
            if (array[i] > Max){
                Max = array[i];
                iMax = i;
            }
        }

        for (int i = 0; i < iMax; i++){
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
        int maxIndex = 0;
        double maxElement = 0;

        double sumElements = 0;
        for (int i = 0; i<array.Length; i++){
            if (array[i] > maxElement){
                maxElement = array[i];
                maxIndex = i;
            }
            sumElements += array[i];
        }
        double mean = Math.Round(sumElements/array.Length, 1);
        for (int i = maxIndex+1; i < array.Length; i++){
            array[i] = mean;
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
        double[] answerArray = new double[array.Length+1];
        double sumMembers = 0;
        foreach(double member in array){
            sumMembers += member;
        }
        double mean = sumMembers/array.Length;
        double minDif = 21231313123;
        int minDifIndex = 0;
        double closeMember = 0;
        for (int i = 0; i < array.Length; i++){
            System.Console.WriteLine($"{array[i]}, {array[i] - mean}");
            if (Math.Abs(array[i] - mean) < minDif){
                minDif = Math.Abs(array[i] - mean);
                minDifIndex = i+1;
                closeMember = array[i];
            }
        }
        System.Console.WriteLine($"{mean}, {minDif}, {minDifIndex}, {closeMember}");
        int arrIndex = 0;
        for (int i = 0; i < answerArray.Length; i++){
            if (i == minDifIndex){
                answerArray[i] = P;
            }
            else{
            answerArray[i] = array[arrIndex];
            arrIndex++;
        }
        }
        // end

        return answerArray;
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
        double maxMember = 0;
        int maxIndex = 0;
        double minMember = 123123123;
        int minIndex = 0;

        for (int i = 0; i < array.Length; i++){
            if (array[i] > maxMember){
                maxMember = array[i];
                maxIndex = i;
                minMember = array[i];
                minIndex = i;
            }
            if (array[i] < minMember){
                minMember = array[i];
                minIndex = i;
            }
        }
        array[maxIndex] = minMember;
        array[minIndex] = maxMember;
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
        double[] answerArr;
        double maxElement = double.MaxValue;
        double minPositiveMember = maxElement;
        
        foreach (double member in array){
            if (member > 0 && member < minPositiveMember){
                minPositiveMember = member;
            }
        }

        if (minPositiveMember != maxElement){
            answerArr = new double[array.Length-1];
        }
        else{
            answerArr = array;
        }

        int arrIndex = 0;
        for (int i = 0; i < array.Length; i++){
            if (array[i] == minPositiveMember){
                continue;
            }
            answerArr[arrIndex] = array[i];
            arrIndex++;
        }
        // end

        return answerArr;
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
        double sumMembers = 0;
        double maxMember = double.MinValue;
        for (int i = 0; i < array.Length; i++){
            if (array[i] > maxMember){
                maxMember = array[i];
                sumMembers = 0;
                continue;
            }
            sumMembers += array[i];
        }
        sumMembers = Math.Round(sumMembers, 1);
        for (int i = 0; i < array.Length; i++){
            if (array[i] < 0){
                array[i] = sumMembers;
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
        double maxValue = double.MinValue;
        int maxIndex = 0;
        double[] anserArr = new double[array.Length];
        for (int i = 0; i < array.Length; i++){
            if (array[i] > maxValue){
                maxValue = array[i];
                maxIndex = i;
            }
        }

        double minValue = 1;
        for (int i = 0; i < array.Length; i++){
            if (array[i] < 0){
                minValue = array[i];
                array[i] = maxValue;
                break;
            }
        }
        if (minValue != 1){
        array[maxIndex] = minValue;
        }
        // end
        foreach(double member in array){
            System.Console.WriteLine(member);
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
        // code here
        double sumMembers = 0;
        foreach(double member in array){
            sumMembers += member;
        }
        double mean = sumMembers/array.Length;

        int count = 0;
        for (int i = 0; i < array.Length; i++){
            if (array[i] < mean){
                count++;
            }
        }

        int[] output = new int[count];
        int indexOutput = 0;
        for (int i = 0; i < array.Length; i++){
            if (array[i] < mean){
                output[indexOutput] = i;
                indexOutput++;
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
        double maxValueEven = double.MinValue;
        double maxValueOdd = double.MinValue;

        for (int i = 0; i < array.Length; i++){
            if (i%2 == 0){
                if (array[i] > maxValueEven){
                    maxValueEven = array[i];
                }
            }
            else{
                if (array[i] > maxValueOdd){
                    maxValueOdd = array[i]; 
                }
            }
        }

        if (maxValueEven > maxValueOdd){
            for (int i = 0; i < array.Length/2; i++){
                array[i] = 0;
            }
        }
        else {
           for (int i = array.Length/2; i < array.Length; i++){
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
    public double Task_2_20(double[] array)
    {
        double sum = 0;

        // code here
        int indexNegativeMember = array.Length+1;
        double MinValue = double.MaxValue;
        int indexMinValue = 0;

        for (int i = 0; i < array.Length; i++){
            if (array[i] < MinValue){
                MinValue = array[i];
                indexMinValue = i;
            }
        }

        for (int i = 0; i < array.Length; i++){
            if (array[i] < 0){
                indexNegativeMember = i;
                break;
            }
        } 

        if (indexNegativeMember < indexMinValue){
            for (int i = 0; i < array.Length; i+=2){
                sum += array[i];
            }
        }
        else{
            for (int i = 1; i < array.Length; i+=2){
                sum += array[i];
            }
        }     
  
        // end
        System.Console.WriteLine($"{indexNegativeMember}, {indexMinValue}");
        return sum;
    }
    #endregion
    #region Level 3
    public int[] Task_3_1(double[] array)
    {
        // code here
        int count = 0;
        double maxValue = double.MinValue;
        for (int i = 0; i < array.Length; i++){
            if (array[i] > maxValue){
                maxValue = array[i];
                count = 1;
            }
            else if (array[i] == maxValue){
                count++;
            }
        }

        int[] output = new int[count];
        int indexOutput = 0;
        for (int i = 0; i < array.Length; i++){
            if (array[i] == maxValue){
                output[indexOutput] = i;
                indexOutput++;
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
        double maxValue = double.MinValue;
        for (int i = 0; i < array.Length; i++){
            if (array[i] > maxValue){
                maxValue = array[i];
            }
        }
        double sumValues = 0;
        for(int i = 0; i < array.Length; i++){
            double member = array[i];
            if (array[i] == maxValue){
                array[i] = sumValues;
                System.Console.WriteLine(sumValues);
            }
            sumValues += member;
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
        double[] answerArr = new double[array.Length];
        int count = 0;
        foreach(double member in array){
            if (member < 0){
                count--;
            }
        }

        for (int i = 0; i< answerArr.Length; i++){
            answerArr[i] = 0;
        }

        int ArrIndex = 0;
        for (int i = 0; i < array.Length; i++){
            if (array[i] >= 0){
                answerArr[ArrIndex] = array[i];
                ArrIndex++;
            }
            else{
                answerArr[array.Length+count] = array[i];
                count++;
            }
        }        
        foreach(double member in answerArr){
            System.Console.WriteLine(member);
        }
        // end

        return answerArr;
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
        double[] answerArr = new double[array.Length];
        // code here
        int Index = 0;
        for (int i = 0; i < array.Length/2; i++){
            answerArr[Index] = answerArr[Index+1] = array[i];
            Index += 2;
        }
        foreach(double member in answerArr){
            System.Console.WriteLine(member);
        }
        System.Console.WriteLine(answerArr.Length);
        // end
        return answerArr;
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
        double[] checkArr = new double[array.Length];
        for (int i = 0; i < checkArr.Length; i++){
            checkArr[i] = double.NaN;
        }
        int count = 0;
        int uniqueCount = 0;
        
        for (int i = 0; i < array.Length; i++){
            int flag = 0;
            for (int member = 0; member < checkArr.Length; member++){
                if (array[i] == checkArr[member]){
                    flag = 1;
                    break;
                }
            }
            if (flag==0){
                uniqueCount++;
                checkArr[i] = array[i];
            }
        }
        System.Console.WriteLine(uniqueCount);
        double[] newArr = new double[uniqueCount];
        for (int i = 0; i < newArr.Length; i++){
            newArr[i] = double.NaN;
        }
        int Index = 0;
        for (int i = 0; i < array.Length; i++){
            count = 0;
            for (int j = 0; j < newArr.Length; j++){
                if (array[i] == newArr[j]){
                    count++;
                }
            }
            //System.Console.WriteLine($"{array[i]} - {count}");
            if (count==0){
                newArr[Index] = array[i];
                Index++;
            }
        }
        foreach(double member in newArr){
            System.Console.WriteLine(member);
        }
        // end

        return newArr;
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