using System;

internal class Lab1
{
    private static void Main(string[] args)
    {
        Lab1 program = new Lab1();
        Random random = new Random();
        //1_1
        Console.WriteLine(program.fraction(5.25));
        Console.WriteLine();
        //1_3
        Console.WriteLine(program.charToNum('3'));
        Console.WriteLine();
        //1_5
        Console.WriteLine(program.is2Digits(32));
        Console.WriteLine(program.is2Digits(516));
        Console.WriteLine();
        //1_7
        Console.WriteLine(program.isInRange(5,1,3));
        Console.WriteLine(program.isInRange(2,15,33));
        Console.WriteLine();
        //1_9
        Console.WriteLine(program.isEqual(3,3,3));
        Console.WriteLine(program.isEqual(2,15,2));
        Console.WriteLine();
        //2_1
        Console.WriteLine(program.abs(5));
        Console.WriteLine(program.abs(-3));
        Console.WriteLine();
        //2_3
        Console.WriteLine(program.is35(5));
        Console.WriteLine(program.is35(8));
        Console.WriteLine(program.is35(15));
        Console.WriteLine();
        //2_5
        Console.WriteLine(program.max3(5,7,7));
        Console.WriteLine(program.max3(8,-1,4));
        Console.WriteLine();
        //2_7
        Console.WriteLine(program.sum2(5,7));
        Console.WriteLine(program.sum2(8,-1));
        Console.WriteLine();
        //2_9
        Console.WriteLine(program.day(5));
        Console.WriteLine();
        //3_1
        Console.WriteLine(program.listNums(5));
        Console.WriteLine();
        //3_3
        Console.WriteLine(program.chet(9));
        Console.WriteLine();
        //3_5
        Console.WriteLine(program.numLen(12567));
        Console.WriteLine();
        //3_7
        program.square(2);
        program.square(5);
        Console.WriteLine();
        //3_9
        program.rightTriangle(5);
        Console.WriteLine();
        //4_1
        int[] findFirst = { 1, 2, 3, 4, 2, 2, 5 };
        Console.WriteLine(program.findFirst(findFirst, 2));
        Console.WriteLine();
        //4_3
        int[] mas2 = new int[10];
        for (int i = 0; i < 10; i++)
        {
            mas2[i] = random.Next(-10, 11);
        }
        Console.WriteLine(string.Join(", ", mas2));
        Console.WriteLine($"Результат: {program.maxAbs(mas2)}");
        Console.WriteLine();
        //4_5
        int[] mas3 = new int[5];
        for (int i = 0; i < 5; i++)
        {
            mas3[i] = random.Next(1, 11);
        }
        Console.WriteLine($"Исходный массив: [{string.Join(", ", mas3)}]");

        int[] mas32 = new int[4];
        for (int i = 0; i < 4; i++)
        {
            mas32[i] = random.Next(1, 11);
        }
        Console.WriteLine($"Исходный массив: [{string.Join(", ", mas32)}]");

        Console.WriteLine("Введите позицию a ");
        int a3 = Convert.ToInt32(Console.ReadLine());
        int[] result = program.add(mas3, mas32, a3);
        Console.WriteLine($"Результат: [{string.Join(", ", result)}]");
        Console.WriteLine();
        //4_7
        int[] mas4 = new int[10];
        for (int i = 0; i < 10; i++)
        {
            mas4[i] = random.Next(1, 11);
        }
        Console.WriteLine($"Исходный массив: [{string.Join(", ", mas4)}]");
        int[] reversed = program.reverseBack(mas4);
        Console.WriteLine($"Результат: [{string.Join(", ", reversed)}]");
        Console.WriteLine();
        //4_9
        int[] mas5 = new int[10];
        for (int i = 0; i < 10; i++)
        {
            mas5[i] = random.Next(1, 11);
        }
        Console.WriteLine($"Исходный массив: [{string.Join(", ", mas5)}]");

        Console.WriteLine("Введите число x ");
        int a5 = Convert.ToInt32(Console.ReadLine());
        int[] indices = program.findAll(mas5, a5);
        Console.WriteLine($"Результат: Индексы вхождений {a5}: [{string.Join(", ", indices)}]");
    }

    //1_1
    public double fraction(double x)
    {
        int tmp = Convert.ToInt32(x);
        x = x - tmp;
        return x;
    }
    //1_3
    public int charToNum(char x)
    {
        switch (x)
        {
            case '0':
                return 0;
            case '1':
                return 1;
            case '2':
                return 2;
            case '3':
                return 3;
            case '4':
                return 4;
            case '5':
                return 5;
            case '6':
                return 6;
            case '7':
                return 7;
            case '8':
                return 8;
            case '9':
                return 9;
            default:
                return -1;
        }
    }
    //1_5
    public bool is2Digits(int x)
    {
        string t = x.ToString();
        return t.Length == 2 ? true : false;
    }
    //1_7
    public bool isInRange(int a, int b, int num)
    {
        if (a > b)
        {
            return (b <= num) && (num <= a) ? true : false;
        }
        else
        {
            return (b >= num) && (num >= a) ? true : false;
        }
    }
    //1_9
    public bool isEqual(int a, int b, int c)
    {
        return (a == b) && (b == c) ? true : false;
    }
    
    //2_1
    public int abs(int x)
    {
        if (x >= 0)
        {
            return x;
        }
        else
        {
            x = x * -1;
            return x;
        }
    }
    //2_3
    public bool is35(int x)
    {
        return (x % 3 == 0 || x % 5 == 0) && !(x % 3 == 0 && x % 5 == 0) ? true : false;
    }
    //2_5
    public int max3(int x, int y, int z)
    {
        if (x > y)
        {
            return x > z ? x : z;
        }
        else
        {
            return y > z ? y : z;
        }

    }
    //2_7
    public int sum2(int x, int y)
    {
        var t = x + y;
        return t >= 10 && t < 20 ? 20 : t;
    }
    //2_9
    public String day(int x)
    {
        switch(x)
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
                return "Воскресение";
            default:
                return "Это не день недели!";
        }
    }

    //3_1
    public String listNums(int x)
    {
        string answ = "";
        for (int i = 0; i <= x; i++)
        {
            answ += i.ToString();
        }
        return answ;
    }
    //3_3
    public String chet(int x)
    {
        string answ = "";
        for (int i = 0; i <= x; i+=2)
        {
            answ+=i.ToString();
        }
        return answ;
    }
    //3_5
    public int numLen(long x)
    {
        int i = 0;
        do
        {
            x /= 10;
            i++;
        } while (x > 0);
        return i;
    }
    //3_7
    public void square(int x)
    {
        int y = x;
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    //3_9
    public void rightTriangle(int x)
    {
        int nStars = 1;
        int y = x;
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                if (j >= y-nStars)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            nStars++;
            Console.WriteLine();
        }
    }

    //4_1
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
    //4_3
    public int maxAbs(int[] arr)
    {
        return arr.Max(Math.Abs);
    }
    //4_5
    public int[] add(int[] arr, int[] ins, int pos)
    {
        var result = new int[arr.Length + ins.Length];
        Array.Copy(arr, 0, result, 0, pos);
        Array.Copy(ins, 0, result, pos, ins.Length);
        Array.Copy(arr, pos, result, pos + ins.Length, arr.Length - pos);
        return result;
    }
    //4_7
    public int[] reverseBack(int[] arr)
    {
        int[] result = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            result[i] = arr[arr.Length - 1 - i];
        }

        return result;
    }
    //4_9
    public int[] findAll(int[] arr, int x)
    {
        var indices = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                indices.Add(i);
            }
        }
        return indices.ToArray();
    }
}