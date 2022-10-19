using System;
using System.Security.Cryptography.X509Certificates;

public class Prog
{
    static void Main()
    {
        var tuple = CalcVar();
        Calculations(tuple.Item1,tuple.Item2,tuple.Item3); 
    }
    static (double, double, string) CalcVar()
    {
        double a;
        double b;
        string oper;

        Console.WriteLine("Введите первое число:");
        a = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите оператор:");
        oper = Console.ReadLine();

        Console.WriteLine("Введите второе число:");
        b = double.Parse(Console.ReadLine());

        (double, double, string) result = (a, b, oper);
        return result;
    }

    static double Calculations(double a, double b, string oper)
    {
        double result;

        switch (oper)
        {
            case "+":
                result = a + b;
                Console.WriteLine(result);
                return result;
                break;

            case "-":
                result = a - b;
                Console.WriteLine(result);
                return result;
                break;

            case "*":
                result = a * b;
                Console.WriteLine(result);
                return result;
                break;

            case "/":
                result = a / b;
                Console.WriteLine(result);
                return result;
                break;
            default:
                Console.WriteLine("Вы указали некорректный оператор.");
                break;
        }
        return 1.0;
    }



}