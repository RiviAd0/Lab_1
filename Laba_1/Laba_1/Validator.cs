using System;
using System.Collections.Generic;
using System.Text;


internal class Validator
{
    public static int CheckInt()
    {
        int value;
        while (!int.TryParse(Console.ReadLine(), out value))
        {
            Console.WriteLine("\tОшибка ввода.");
            Console.Write("\tВведите целое число: ");
        }
        return value;
    }

    public static double CheckDouble()
    {
        double value;
        while (!double.TryParse(
            Console.ReadLine()?.Replace('.', ','), out value))
        {
            Console.WriteLine("\tОшибка ввода.");
            Console.Write("\tВведите вещественное число: ");
        }
        return value;
    }

    public static char ChechDigit()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (input.Length == 1 && char.IsDigit(input[0]))
            {
                return input[0];
            }
            Console.Write("\tОшибка ввода. Введите одну цифру от 0 до 9: ");
        }
    }

    public static int CheckIntPositive()
    {
        int value;
        while (!int.TryParse(Console.ReadLine(), out value) || value < 0)
        {
            Console.Write("\tОшибка ввода. Введите целое число не меньше нуля: ");
        }
        return value;
    }

    public static long CheckLong()
    {
        long value;
        while (!long.TryParse(Console.ReadLine(), out value))
        {
            Console.Write("\tОшибка ввода. Введите целое число: ");
        }
        return value;
    }

    public static int CheckIntArr(int minValue, int maxValue)
    {
        int value;
        while (!int.TryParse(Console.ReadLine(), out value) || value < minValue || value > maxValue)
        {
            Console.Write($"\tОшибка ввода. Введите число от {minValue} до {maxValue}: ");
        }
        return value;
    }
}
