using System;

internal class Lab1
{
    private static void Main(string[] args)
    {
        Lab1 program = new Lab1();
        Random random = new Random();
        int x, m, y, c, a;
        bool repeat = true;

        while (repeat)
        {
            Console.WriteLine("\nВыберите раздел:");
            Console.WriteLine("   1. Методы");
            Console.WriteLine("   2. Условия");
            Console.WriteLine("   3. Циклы");
            Console.WriteLine("   4. Массивы");
            Console.Write("Ваш выбор: ");

            x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("Введите цифру, которой нумеруется задача:\n   1. Дробная часть\n   2. Букву в число\n   3. Двузначное\n   4. Диапазон\n   5. Равенство");
                    m = Convert.ToInt32(Console.ReadLine());
                    switch (m)
                    {
                        case 1:
                            Console.WriteLine("\"Дробная часть\" - Возврат дробной части числа\n Введите вещественное число");
                            double m1;
                            m1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Результат: {program.fraction(m1)}");
                            break;
                        case 2:
                            Console.WriteLine("\"Букву в число\" - Преобразование символа в число\n Введите символ (от 0 до 9)");
                            char m2;
                            m2 = Convert.ToChar(Console.ReadLine());
                            Console.WriteLine($"Результат: {program.charToNum(m2) - 48}");
                            break;
                        case 3:
                            Console.WriteLine("\"Двузначное\" - Проверка на двузначность числа\n Введите число");
                            int m3;
                            m3 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Результат: {program.is2Digits(m3)}");
                            break;
                        case 4:
                            Console.WriteLine("\"Диапазон\" - Проверка на вхождение числа в указанный диапазон");
                            int m4l, m4r, num;
                            Console.WriteLine("Введите левую и правую границы диаапазона и число");
                            m4l = Convert.ToInt32(Console.ReadLine());
                            m4r = Convert.ToInt32(Console.ReadLine());
                            num = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Результат: {program.isInRange(m4l, m4r, num)}");
                            break;
                        case 5:
                            Console.WriteLine("\"Равенство\" - Проверка равенства трех чисел\n Введите три числа");
                            int m5a, m5b, m5c;
                            m5a = Convert.ToInt32(Console.ReadLine());
                            m5b = Convert.ToInt32(Console.ReadLine());
                            m5c = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Результат: {program.isEqual(m5a, m5b, m5c)}");
                            break;
                        default:
                            Console.WriteLine("Неправильный выбор задачи.");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Введите цифру, которой нумеруется задача:\n   1. Модуль числа\n   2. Тридцать пять\n   3. Тройной максимум\n   4. Двойная сумма\n   5. День недели");
                    y = Convert.ToInt32(Console.ReadLine());
                    switch (y)
                    {
                        case 1:
                            Console.WriteLine("\"Модуль числа\" - Возврат модуля числа\n Введите число");
                            int y1;
                            y1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Результат: {program.abs(y1)}");
                            break;
                        case 2:
                            Console.WriteLine("\"Тридцать пять\" - Проверка деления нацело на 3 или 5\n Введите число");
                            int y2;
                            y2 = Convert.ToInt32(Console.ReadLine()); ;
                            Console.WriteLine($"Результат: {program.is35(y2)}");
                            break;
                        case 3:
                            Console.WriteLine("\"Тройной максимум\" - Поиск максимального из трех значений\n Введите три числа");
                            int y3x, y3y, y3z;
                            y3x = Convert.ToInt32(Console.ReadLine());
                            y3y = Convert.ToInt32(Console.ReadLine());
                            y3z = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Результат: {program.max3(y3x, y3y, y3z)}");
                            break;
                        case 4:
                            Console.WriteLine("\"Двойная сумма\" - Возврат суммы чисел (если сумма от 10 до 19 - вернуть 20)\n Введите два числа");
                            int y4a, y4b;
                            y4a = Convert.ToInt32(Console.ReadLine());
                            y4b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Результат: {program.sum2(y4a, y4b)}");
                            break;
                        case 5:
                            Console.WriteLine("\"День недели\"\n Введите число от 1 до 7");
                            int y5;
                            y5 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Результат: {program.day(y5)}");
                            break;
                        default:
                            Console.WriteLine("Неправильный выбор задачи.");
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Введите цифру, которой нумеруется задача:\n   1. Числа подряд\n   2. Четные числа\n   3. Длина числа\n   4. Квадрат\n   5. Правый треугольник");
                    c = Convert.ToInt32(Console.ReadLine());
                    switch (c)
                    {
                        case 1:
                            Console.WriteLine("\"Числа подряд\" - Возврат чисел от 0 до x\n Введите х");
                            int c1;
                            c1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Результат: {program.listNums(c1)}");
                            break;
                        case 2:
                            Console.WriteLine("\"Четные числа\" - Возврат четных чисел от 0 до х\n Введите х");
                            int c2;
                            c2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Результат: {program.chet(c2)}");
                            break;
                        case 3:
                            Console.WriteLine("\"Длина числа\" - Возврат количества знаков в числе\n Введите число");
                            long c3;
                            c3 = long.Parse(Console.ReadLine()); ;
                            Console.WriteLine($"Результат: {program.numLen(c3)}");
                            break;
                        case 4:
                            Console.WriteLine("\"Квадрат\" - Вывод квадрата из '*' размерности х\n Введите х");
                            int c4;
                            c4 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Результат: ");
                            program.square(c4);
                            break;
                        case 5:
                            Console.WriteLine("\"Правый треугольник\" - Вывод выравненного по правому краю трегуольника из '*' высотой х\n Введите х");
                            int c5;
                            c5 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Результат: ");
                            program.rightTriangle(c5);
                            break;
                        default:
                            Console.WriteLine("Неправильный выбор задачи.");
                            break;
                    }
                    break;
                case 4:
                    Console.WriteLine("Введите цифру, которой нумеруется задача:\n   1. Поиск первого значения\n   2. Поиск максимального\n   3. Добавление массива в массив\n   4. Возвратный реверс\n   5. Все вхождения");
                    a = Convert.ToInt32(Console.ReadLine());
                    switch (a)
                    {
                        case 1:
                            Console.WriteLine("\"Поиск первого значения\" - Возврат индекса первого вхождения числа в массив ");
                            int[] mas1 = new int[10];
                            for (int i = 0; i < 10; i++)
                            {
                                mas1[i] = random.Next(1, 11);
                            }
                            Console.WriteLine(string.Join(", ", mas1));
                            Console.WriteLine("Введите x ");
                            int a1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Результат: {program.findFirst(mas1, a1)}");
                            break;

                        case 2:
                            Console.WriteLine("\"Поиск максимального\" - Возврат наибольшего по модулю значения массива");
                            int[] mas2 = new int[10];
                            for (int i = 0; i < 10; i++)
                            {
                                mas2[i] = random.Next(-10, 11);
                            }
                            Console.WriteLine(string.Join(", ", mas2));
                            Console.WriteLine($"Результат: {program.maxAbs(mas2)}");
                            break;

                        case 3:
                            Console.WriteLine("\"Добавление массива в массив\" - Добавление массива х в массив у с позиции а");

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
                            break;

                        case 4:
                            Console.WriteLine("\"Возвратный реверс\" - Возврат массива, в котором значения записаны задом наперед");
                            int[] mas4 = new int[10];
                            for (int i = 0; i < 10; i++)
                            {
                                mas4[i] = random.Next(1, 11);
                            }
                            Console.WriteLine($"Исходный массив: [{string.Join(", ", mas4)}]");
                            int[] reversed = program.reverseBack(mas4);
                            Console.WriteLine($"Результат: [{string.Join(", ", reversed)}]");
                            break;

                        case 5:
                            Console.WriteLine("\"Все вхождения\" - Вывод индексов всех вхождений числа х в массив");

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
                            break;
                        default:
                            Console.WriteLine("Неправильный выбор задачи.");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Выберите представленные разделы.");
                    break;
            }

            Console.Write("\nХотите продолжить работу? (1 - да, 0 - нет):");

            string continueChoice = Console.ReadLine();

            repeat = (continueChoice.ToLower() != "0");
        }
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