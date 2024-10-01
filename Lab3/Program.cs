using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_1(0.9, 1.23);
        //program.Task_1_2(0.9, 1.23);
        //program.Task_1_3(0.9, 1.23);
        //program.Task_1_4(0.9, 1.23, -0.1);
        //program.Task_1_5(0.9, 1.23);
        //program.Task_1_6(0.9, 1.23);
        //program.Task_1_7(0.9);
        //program.Task_1_8(0.9);
        //program.Task_1_9(0.9);
        //program.Task_1_10(0.9);
        //program.Task_2_1(10);
        //program.Task_2_2(5, 3, 2, 1);
        //program.Task_2_2(5, 1.5, 1.5, 1);
        //program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_3(10);
        //program.Task_2_4(5, 1, 2);
        //program.Task_2_5(10, 30);
        //program.Task_2_6(5);
        //program.Task_2_7(5);
        //program.Task_2_8(10);
        //program.Task_2_9(10);
        //program.Task_2_10(10);
        //program.Task_2_11(10);
        //program.Task_2_12(10, 0);
        //program.Task_2_13(10, 5, 0);
        //program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_3();
        //program.Task_3_4(1, 2);
        //program.Task_3_5(30);
        //program.Task_3_6();
        //program.Task_3_7();
        //program.Task_3_8();
        //program.Task_3_9();
        //program.Task_3_10();
        program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here
        const double eps = 0.001;
        answer = Math.Abs(x * x + y * y - 4.0) < eps;
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y <= 1 + x && y <= 1 - x && y >= 0)
            answer = true;
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0)
        {
            if (a > b)
                answer = a;
            else
                answer = b;
        }
        else
        {
            if (a > b)
                answer = b;
            else
                answer = a;
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        answer = Math.Max(Math.Min(a, b), c);
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double radius = Math.Sqrt(r / Math.PI);
        double diagonal = Math.Sqrt(s) * Math.Sqrt(2) / 2.0;
        if (diagonal <= radius)
            answer = true;
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double diameter = Math.Sqrt(r / Math.PI) * 2;
        double side = Math.Sqrt(s);
        if (diameter <= side)
            answer = true;
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1)
            answer = 1;
        else
            answer = Math.Abs(x);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1)
            answer = 0;
        else
            answer = x * x - 1;
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 0;
        else if (x > 0)
            answer = 1;
        else
            answer = 1 + x;
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 1;
        else if (x > 1)
            answer = -1;
        else
            answer = -x;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double height = double.Parse(Console.ReadLine());
            answer += height;
        }
        answer = answer / n;
        Console.WriteLine(answer);
        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(" ");
            x = double.Parse(input[0], CultureInfo.InvariantCulture);
            y = double.Parse(input[1], CultureInfo.InvariantCulture);
            if ((x - a) * (x - a) + (y - b) * (y - b) < r * r)
                answer++;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double weight;
        for (int i = 0; i < n; i++)
        {
            weight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (weight < 30)
            {
                answer += 0.2;
            }

        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(" ");
            x = double.Parse(input[0], CultureInfo.InvariantCulture);
            y = double.Parse(input[1], CultureInfo.InvariantCulture);
            if ((x * x + y * y < r2 * r2) && (x * x + y * y > r1 * r1))
                answer++;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        double result;
        for (int i = 0; i < n; i++)
        {
            result = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (result < norm)
            {
                answer++;
            }

        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(" ");
            x = double.Parse(input[0], CultureInfo.InvariantCulture);
            y = double.Parse(input[1], CultureInfo.InvariantCulture);
            if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x))
                answer++;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        double x, y;
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(" ");
            x = double.Parse(input[0], CultureInfo.InvariantCulture);
            y = double.Parse(input[1], CultureInfo.InvariantCulture);
            if (x >= 0 && y >= 0)
            {
                Console.WriteLine("I");
                answer1++;
            }
            else if (x <= 0 && y >= 0)
            {
                Console.WriteLine("II");
            }
            else if (x <= 0 && y <= 0)
            {
                Console.WriteLine("III");
                answer3++;
            }
            else
            {
                Console.WriteLine("IV");
            }
        }
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double x, y;
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(" ");
            x = double.Parse(input[0], CultureInfo.InvariantCulture);
            y = double.Parse(input[1], CultureInfo.InvariantCulture);
            double dist = Math.Sqrt(x * x + y * y);
            if (dist < answerLength)
            {
                answer = i + 1;
                answerLength = dist;
            }
        }
        Console.WriteLine($"{answer} {answerLength}");
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double result;
        for (int i = 0; i < n; i++)
        {
            result = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            answer = Math.Min(answer, result);

        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        for (int i = 0; i < n; i++)
        {
            bool has23 = false;
            for (int j = 0; j < 4; j++)
            {
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 3)
                {
                    has23 = true;
                }
            }
            if (has23)
                answer++;
        }
        Console.WriteLine("answer={0}", answer);
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            bool has2 = false;
            for (int j = 0; j < 4; j++)
            {
                int grade = int.Parse(Console.ReadLine());
                if (grade == 2)
                {
                    has2 = true;
                }
                sum += grade;
            }
            if (has2)
                answer++;
        }
        avg = sum / 40.0;
        Console.WriteLine("answer={0} avg={1}", answer, avg);
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r <= 0)
            return 0;

        switch (type)
        {
            case 0:
                answer = r * r;
                break;
            case 1:
                answer = r * r * Math.PI;
                break;
            case 2:
                answer = r * r * Math.Sqrt(3) / 4.0;
                answer = Math.Round(answer, 2);
                break;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A <= 0 || B <= 0)
            return 0;

        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                if (A >= B)
                    return 0;
                answer = (B * B - A * A) * Math.PI;
                break;
            case 2:
                if (A >= 2 * B)
                {
                    answer = 0;
                    break;
                }
                answer = A * Math.Sqrt(4 * B * B - A * A) / 4.0;
                break;
            default:
                break;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;
        int n = 0;

        // code here

        // end

        // for test input in console: 168, 147, 174, 154, 180, 149, 166, 160, 175, 161
        // answer should be equal to the task_2_1 answer

        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here
        double x, y;
        // ввод дробных чисел через .
        // каждая координата в отдельной строке
        // чтобы закончить ввод, введите некорректное значение
        // или нажмите Enter после конца ввода
        while (double.TryParse(Console.ReadLine(), 
            CultureInfo.InvariantCulture, out x)
            && double.TryParse(Console.ReadLine(), 
            CultureInfo.InvariantCulture, out y))
        {
            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r)
                answer++;
        }
        Console.WriteLine(answer);

        // end
        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -2.5 -0.5
        // answer should be equal to the task_2_2 answer

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_3 answer

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;

        // code here
        double x, y;
        // чтобы закончить ввод, введите некорректное значение
        // или нажмите Enter после конца ввода
        while (double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out x) && double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out y))
        {
            if ((x * x + y * y <= r2 * r2) && (x * x + y * y >= r1 * r1))
                answer++;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 2, 4.5 0.1, -1 1.5, -0.5 -0.5
        // answer should be equal to the task_2_4 answer

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;

        // code here
        // ввод дробных чисел через .
        // чтобы закончить ввод, введите некорректное значение
        // или нажмите Enter после конца ввода
        double res;
        while (double.TryParse(Console.ReadLine(),
            CultureInfo.InvariantCulture, out res))
        {
            if (res < norm)
                answer++;
        }
        Console.WriteLine(answer);
        // end
        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_5 answer

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;

        // code here
        double x, y;
        // чтобы закончить ввод, введите некорректное значение
        // или нажмите Enter после конца ввода
        while (double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out x) && double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out y))
        {
            if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x))
                answer++;
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 1.2 0.7, 2 0.2, 0.5 0.9, -1 1.5, 0.5 0.1
        // answer should be equal to the task_2_6 answer

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;

        // code here

        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_7 answer

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;

        // code here
        double x, y;
        // чтобы закончить ввод, введите некорректное значение
        // или нажмите Enter после конца ввода
        int idx = 0;
        while (double.TryParse(Console.ReadLine(), 
            CultureInfo.InvariantCulture, out x) 
            && double.TryParse(Console.ReadLine(), 
            CultureInfo.InvariantCulture, out y))
        {
            idx++;
            if (x * x + y * y < answerLength)
            {
                answer = idx;
                answerLength = x * x + y * y;
            }
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: -1.2 0.7, 2 -2, 0.5 0.9, 1 1.5, -0.5 -1.5
        // answer should be equal to the task_2_8 answer

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;

        // code here

        // end

        // for test input in console: 27.5, 32.5, 30, 22.3, 26.8, 36.6, 30, 29.9, 20.1, 28.5
        // answer should be equal to the task_2_9 answer

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;

        // code here;
        // чтобы закончить ввод, введите некорректное значение
        // или нажмите Enter после конца ввода
        int cnt = 0;
        bool has23 = false;
        int grade;
        while (int.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out grade))
        {
            cnt++;
            if (grade <= 3)
                has23 = true;
            if (cnt == 4)
            {
                if (has23)
                    answer++;
                cnt = 0;
                has23 = false;
            }
        }
        Console.WriteLine(answer);
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_10 answer

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, n = 0;
        double avg = 0.0;

        // code here;
        int cnt = 0, sm = 0, totalCnt = 0;
        bool has2 = false;
        int grade;
        while (int.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out grade))
        {
            cnt++;
            sm += grade;
            if (grade == 2)
                has2 = true;
            if (cnt == 4)
            {
                avg += sm;
                sm = 0;
                totalCnt++;
                if (has2)
                    answer++;
                cnt = 0;
                has2 = false;
            }
        }
        avg /= (totalCnt * 4.0);
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        // for test input in console: 5, 3, 3, 4, 5, 2, 4, 5, 5, 4, 5, 4, 2, 5, 3, 5, 4, 5, 5, 5, 5, 5, 5, 5, 4, 4, 4, 4, 4, 4, 2, 5, 2, 2, 4, 2, 5, 4, 5, 4
        // answer should be equal to the task_2_11 answer

        return (answer, avg);
    }
    public double Task_3_12(double r, int type)
    {
        double answer = 0;

        // code here;
        
        // end
        // answer should be equal to the task_2_12 answer

        return answer;
    }
    public double Task_3_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;

        // end
        // answer should be equal to the task_2_13 answer

        return answer;
    }
    #endregion
}
