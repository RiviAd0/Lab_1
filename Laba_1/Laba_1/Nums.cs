using System;
using System.Collections.Generic;
using System.Text;


internal class Nums
{
    public double fraction(double x)
    {
        return Math.Abs(x - (int)x);
    }

    public int charToNum(char x)
    {
        return x - '0';
    }

    public bool is2Digits(int x)
    {
        return (x >= 10 && x <= 99) || (x <= -10 && x >= -99);
    }

    public bool isInRange(int a, int b, int num)
    {
        int min = Math.Min(a, b);
        int max = Math.Max(a, b);
        return num >= min && num <= max;
    }

    public bool isEqual(int a, int b, int c)
    {
        return a == b && b == c;
    }


    public int abs(int x)
    {
        if (x < 0)
        {
            return -x;
        }
        else
        {
            return x;
        }
    }

    public bool is35(int x)
    {
        bool div3 = x % 3 == 0;
        bool div5 = x % 5 == 0;
        return div3 != div5;
    }

    public int max3(int x, int y, int z)
    {
        int maximum = x;
        if (y >= maximum)
        {
            maximum = y;
        }
        if (z >= maximum)
        {
            maximum = z;
        }
        return maximum;
    }

    public int sum2(int x, int y)
    {
        int sum = x + y;
        if (sum >= 10 && sum <= 19)
        {
            return 20;
        }
        return sum;
    }

    public String day(int x)
    {
        switch (x)
        {
            case 1:
                return "Понедельник";
            case 2:
                return "Вторник";
            case 3:
                return "Среда";
            case 4:
                return "Четверг";
            case 5:
                return "Пятница";
            case 6:
                return "Суббота";
            case 7:
                return "Воскресенье";
            default:
                return "Такого дня недели нет.";
        }
    }


    public String listNums(int x)
    {
        string line = "";
        if (x >= 0)
        {
            for (int i = 0; i <= x; i++)
            {
                line += i + " ";
            }
        }
        else
        {
            for (int i = x; i <= 0; i++)
            {
                line += i + " ";
            }
        }
        return line;
    }

    public String chet(int x)
    {
        string res = "";
        for (int i = 0; i <= x; i += 2)
        {
            res += i + " ";
        }
        return res;
    }

    public int numLen(long x)
    {
        x = Math.Abs(x);
        int len = 0;

        if (x == 0)
        {
            return 1;
        }       

        while (x > 0)
        {
            x /= 10;
            len++;
        }
        return len;
    }

    public void square(int x)
    {
        for (int i = 0; i < x; i++)
        {
            Console.Write("\t");
            for (int j = 0; j < x; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public void rightTriangle(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            Console.Write("\t");
            for (int j = 0; j < x - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    

    public int findFirst(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                return i;
            }
        }
        return -1;
    }

    public int maxAbs(int[] arr)
    {
        int maxim = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (Math.Abs((long)arr[i]) > Math.Abs((long)maxim))
            {
                maxim = arr[i];
            }
        }
        return maxim;
    }

    public int[] add(int[] arr, int[] ins, int pos)
    {
        int[] inmass = new int[arr.Length + ins.Length];
        for (int i = 0; i < pos; i++)
        {
            inmass[i] = arr[i];
        }
        for (int i = 0; i < ins.Length; i++)
        {
            inmass[pos + i] = ins[i];
        }
        for (int i = pos; i < arr.Length; i++)
        {
            inmass[ins.Length + i] = arr[i];
        }
        return inmass;
    }

    public int[] reverseBack(int[] arr)
    {
        int[] ret = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            ret[i] = arr[arr.Length - i - 1];
        }
        return ret;
    }

    public int[] findAll(int[] arr, int x)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                count++;
            }
        }
        int[] ret = new int[count];
        int j = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                ret[j] = i;
                j++;
            }
        }
        return ret;
    }
}
