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
        // program.Task_1_1(new int[] {1, 2, 3, 4, 5, 6});
        // program.Task_2_6(new double[] { 0, 1.5, -1, -3, -2.2, -0.5, 6 }, 2.3);
        // program.Task_2_8(new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 2 });
        program.Task_3_5(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        double summa=0;
        for(int i=0;i<=5;i++)
        {
            summa+=array[i];
        }
        for(int i=0;i<=5;i++)
        {
            array[i]=Math.Round(array[i]/summa,2);
        }

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        double summa=0;
        double count=0;
        for(int i=0;i<=7;i++)
        {
            if (array[i]>0)
            {
                summa+=array[i];
                count++;
            }
        }
        for(int i=0;i<=7;i++)
        {
            if (array[i]>0)
            {
                array[i]=Math.Round(summa/count,2);
            }
        }

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];
        for(int i=0;i<=3;i++)
        {
            sum[i]=Math.Round(first[i]+second[i],2);
            dif[i]=Math.Round(first[i]-second[i],2);
        }

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {

        double summa=0;
        for(int i=0;i<=4;i++)
        {
            summa+=array[i];
        }
        for(int i=0;i<=4;i++)
        {
            array[i]=Math.Round(array[i]-summa/5,2);
        }

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        for(int i=0;i<=3;i++)
        {
            product+=vector1[i]*vector2[i];
        }

        return Math.Round(product,2);
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        for(int i=0;i<=4;i++)
        {
            length+=vector[i]*vector[i];
        }

        return Math.Round(Math.Sqrt(length), 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        double summa=0;
        for(int i=0;i<=6;i++)
        {
            summa+=array[i];
        }
        for(int i=0;i<=6;i++)
        {
            if(array[i]>summa/7)
            {
                array[i]=0;
            }
        }

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        for(int i=0;i<=5;i++)
        {
            if(array[i]<0)
            {
                count++;
            }
        }

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        double summa=0;
        for(int i=0;i<=7;i++)
        {
            summa+=array[i];
        }
        for(int i=0;i<=7;i++)
        {
            if(array[i]>summa/8)
            {
                count++;
            }
        }

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        for(int i=0;i<=9;i++)
        {
            if(array[i]>P && array[i]<Q)
            {
                count++;
            }
        }

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;
        int j=0;

        for(int i=0;i<=9;i++)
        {
            if(array[i]>0) j++;
        }
        output = new double[j];
        int k=0;
        foreach (double a in array)
        {
            if (a>0)
            {
                output[k]=a;
                k++;
            }
        }


        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;
        int count=0;

        foreach (double a in array)
        {
            if (a<0)
            {
                value=a;
                index=count;
            }
            count++;
        }

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        for(int i=0;i<5;i++)
        {
            even[i]=array[2*i];
            odd[i]=array[2*i+1];
        }

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        foreach (double a in array)
        {
            if (a<0) break;
            sum+=a*a;
        }

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];
        int count=0;

        foreach (double a in x)
        {
            y[count]=double.NaN;
            if (a>0)
            y[count]=Math.Round(0.5 * Math.Log(a), 2);
            count++;
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
        double mina=double.NegativeInfinity;

        foreach (double a in array)
        {
            if(a>mina)
            mina=a;
        }
        foreach (double a in array)
        {
            if(a==mina) break;
            sum+=a;
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
        double mina=double.NegativeInfinity;
        double sum=0;
        foreach (double a in array)
        {
            if(a>mina)
            mina=a;
            sum+=a;
        }
        bool flag=false;
        int count=0;
        foreach (double a in array)
        {
        if (flag==true) array[count]=Math.Round(sum/array.Length,2);
            if(a==mina) flag=true;
            count++;
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
        double[] array_p = new double[array.Length+1];
        double sum=0;

        foreach (double a in array)
        {
            sum+=a;
        }
        double sred=sum/array.Length;
        int count=0;
        int pos=0;
        double min_pos=double.PositiveInfinity;;
        for (int i=0;i<array.Length;i++)
        {
            if (Math.Abs(array[i]-sred)<min_pos)
            {
                min_pos=Math.Abs(array[i]-sred);
                pos=i;
            }
        }
        int j=0;
        for (int i=0;i<array.Length;i++)
        {
            if (pos+1==i)
            {
                array_p[j]=P;
                j++;
            }
            array_p[j]=array[i];
            j++;
        }

        return array_p;
    }
    public double[] Task_2_7(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_8(double[] array)
    {
        double mina=double.PositiveInfinity;
        double maxa=double.NegativeInfinity;
        int maxa_index=-1;
        int mina_index=-1;
        for(int i = 0;i<array.Length;i++)
        {
            if(array[i]>=maxa)
            {
                maxa=array[i];
                maxa_index=i;
            }
        }
        for(int i = 0;i<array.Length;i++)
        {
            if(i>=maxa_index)
            {
                if(array[i]<mina)
                {
                    mina=array[i];
                    mina_index=i;
                }
            }
        }
        (array[maxa_index],array[mina_index])=(mina,maxa);

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
        double[] array_new = new double[array.Length-1];
        double mina=double.PositiveInfinity;
        int mina_index=-1;
        for(int i = 0;i<array.Length;i++)
        {
            if(array[i]<mina && array[i]>0)
            {
                mina=array[i];
                mina_index=i;
            }
        }
        if (mina_index==array.Length || mina_index==-1) return array;
        for(int i=0;i<array_new.Length;i++)
        {
            if(i<mina_index)
                array_new[i]=array[i];
            else
                array_new[i]=array[i+1];
        }

        return array_new;
    }
    public double[] Task_2_11(double[] array, double P)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_12(double[] array)
    {
        double maxa=double.NegativeInfinity;
        int maxa_index=-1;
        for(int i = 0;i<array.Length;i++)
        {
            if(array[i]>=maxa)
            {
                maxa=array[i];
                maxa_index=i;
            }
        }
        double sum=0;
        for(int k=maxa_index+1;k<array.Length;k++)
        {
            sum+=array[k];
        }

        for(int i = 0;i<array.Length;i++)
        {
            if(array[i]<0)
            {
                array[i]=sum;
                break;
            }
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
        double maxa=double.NegativeInfinity;
        int maxa_index=-1;
        for(int i = 0;i<array.Length;i++)
        {
            if(array[i]>=maxa)
            {
                maxa=array[i];
                maxa_index=i;
            }
        }

        for(int i = 0;i<array.Length;i++)
        {
            if(array[i]<0)
            {
                double k =array[i];
                (array[i],array[maxa_index])=(maxa,k);
                break;
            }
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
        double sum=0;

        foreach (double a in array)
        {
            sum+=a;
        }
        int count = 0;
        for(int i = 0;i<array.Length;i++)
        {
            if (array[i]<sum/array.Length)
            count++;
        }
        int[] output = new int[count];
        int j=0;

        for(int i = 0;i<array.Length;i++)
        {
            if (array[i]<sum/array.Length)
            {
                output[j]=i;
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
        double maxa_1=double.NegativeInfinity;
        double maxa_2=double.NegativeInfinity;
        for(int i = 0;i<array.Length;i++)
        {
            if(array[i]>=maxa_1 && i%2==0)
            {
                maxa_1=array[i];
            }
            if(array[i]>=maxa_2 && i%2!=0)
            {
                maxa_2=array[i];
            }
        }
        if(maxa_1>maxa_2)
        {
            for(int i=0;i<array.Length/2;i++)
            {
                array[i]=0;
            }
        }
        else
        {
            for(int i=array.Length/2;i<array.Length;i++)
            {
                array[i]=0;
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

        double mina=double.PositiveInfinity;
        int mina_index=-1;
        double first_negative=double.PositiveInfinity;
        int first_negative_index=int.MaxValue;
        int F=1;
        for(int i = 0;i<array.Length;i++)
        {
            if(array[i]<mina)
            {
                mina=array[i];
                mina_index=i;
            }
            if(array[i]<0 && F==1)
            {
                first_negative=array[i];
                first_negative_index=i;
                F=0;
            }
        }
        if(first_negative_index<mina_index)
        {
            for(int i=0;i<array.Length;i+=2)
            {
                sum+=array[i];
            }
        }
        else
        {
            for(int i=1;i<array.Length;i+=2)
            {
                sum+=array[i];
            }
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
        double maxa=double.NegativeInfinity;
        for(int i = 0;i<array.Length;i++)
        {
            if(array[i]>=maxa)
            {
                maxa=array[i];
            }
        }
        int count=0;
        for(int i = 0;i<array.Length;i++)
        {
            if(array[i]==maxa)
            {
                array[i]=maxa+1+count;
                count++;
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
        double[] array_new = null; 
        if ((array.Length / 2) * 2 == array.Length)  
        {  
            array_new = new double[array.Length / 2]; 
        } 
        else  
        {  
            array_new = new double[array.Length / 2 + 1];  
        } 
        for (int i = 0; i < array.Length; i += 2)  
        {  
            array_new[i / 2] = array[i]; 
        } 

        for (int i = 0; i < array_new.Length - 1; i++) 
        { 
            double amin = array_new[i]; 
            int imin = i; 
            for (int j = i + 1; j < array_new.Length ; j++) 
            { 
                if (array_new[j] < amin) 
                { 
                    amin = array_new[j]; 
                    imin = j; 
                } 
            } 
            array_new[imin] = array_new[i]; 
            array_new[i] = amin; 
        } 
        for (int i = 0; i < array_new.Length; i++)  
        {  
            array[i*2] = array_new[i]; 
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
        int count=0;
        foreach(double a in array)
        {
            if (a<0) count++;
        }
        double[] array_new = new double[count];

        int k=0;
        for (int i = 0; i < array.Length; i++)  
        {
            if (array[i]<0)
            {
                array_new[k]=array[i];
                k++;
            }
        } 

        for (int i = 0; i < array_new.Length - 1; i++) 
        { 
            double amax = array_new[i]; 
            int imax = i; 
            for (int j = i + 1; j < array_new.Length ; j++) 
            { 
                if (array_new[j] > amax) 
                { 
                    amax = array_new[j]; 
                    imax = j; 
                } 
            } 
            array_new[imax] = array_new[i]; 
            array_new[i] = amax; 
        } 
        int h=0;
        for (int i = 0; i < array.Length; i++)  
        {  
            if (array[i]<0)
            {
                array[i]=array_new[h];
                h++;
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
        double[] X = null, Y = null;
        double globalMax = 0, globalMin = 0;
        X = new double[n];
        Y = new double[n];

        double m = (b-a)/(n-1);
        int j=0;

        for (double i=a;i<=b;i+=m)
        {
            X[j]=i;
            Y[j]=Math.Cos(i) + i * Math.Sin(i);
            j++;
        }
        globalMax = Y[0]; 
        globalMin = Y[0];

        for (int i=0;i<n-2;i++)
        {
            if (Y[i]<Y[i+1] && Y[i+1]>Y[i+2])
            {
                if (Y[i+1]>globalMax)
                {
                    globalMax=Y[i+1];
                }
            }
            if (Y[i]>Y[i+1] && Y[i+1]<Y[i+2])
            {
                if (Y[i+1]>globalMin)
                {
                    globalMin=Y[i+1];
                }
            }
        }
        if (Y[n - 1] > globalMax) 
        { 
            globalMax = Y[n - 1]; 
        }
        if (Y[n - 1] < globalMin) 
        { 
            globalMin = Y[n - 1]; 
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
        double[] normalizedArray = null;

        double maxa=double.MinValue;
        double mina=double.MaxValue;
        foreach(double a in array)
        {
            if(a>maxa)
            {
                maxa=a;
            }
            if(a<mina)
            {
                mina=a;
            }
        }
        
        normalizedArray= new double[array.Length];

        for(int i=0;i<normalizedArray.Length;i++)
        {
            normalizedArray[i]=(2.0 * (array[i] - mina) / (maxa - mina)) - 1.0;
        }

        return normalizedArray;
    }
    #endregion
}
