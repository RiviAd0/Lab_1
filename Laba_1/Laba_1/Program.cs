using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        Nums nums = new Nums();
        while (true)
        {
            Console.WriteLine("\tЛабораторная работа №1\n");
            Console.WriteLine("\tЗадания:");
            Console.WriteLine("\t1. Методы.");
            Console.WriteLine("\t2. Условия.");
            Console.WriteLine("\t3. Циклы.");
            Console.WriteLine("\t4. Массивы.");
            Console.WriteLine("\t0. Для выхода.\n");
            Console.Write("\tВведите ваш выбор: ");

            int numOfTask = Validator.CheckInt();
            switch (numOfTask)
            {
                case 1:
                    while (true)
                    {
                        Console.WriteLine("\tВы выбрали:\n");
                        Console.WriteLine("\tЗадание 1. Методы.");
                        Console.WriteLine("\t1. Дробная часть.");
                        Console.WriteLine("\t2. Букву в число.");
                        Console.WriteLine("\t3. Двузначное.");
                        Console.WriteLine("\t4. Диапазон.");
                        Console.WriteLine("\t5. Равенство.");
                        Console.WriteLine("\t0. Вернуться к выбору задания ->\n");
                        Console.Write("\tВведите ваш выбор: ");

                        int SecondNumOfTask = Validator.CheckInt();
                        switch (SecondNumOfTask)
                        {
                            case 1:
                                Console.WriteLine("\tВы выбрали: 1. Дробная часть.\n");
                                Console.Write("\tВведите число: ");
                                double number = Validator.CheckDouble();
                                Console.WriteLine($"\n\tОстаток: {nums.fraction(number):0.####}");
                                Console.Write("\n\tДля продолжения нажмите Enter");
                                Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("\tВы выбрали: 2. Букву в число.\n");
                                Console.Write("\tВведите цифру: ");
                                char digit = Validator.ChechDigit();
                                int code = digit;
                                Console.WriteLine($"\n\tВведённый символ: {digit}");
                                Console.WriteLine($"\tКод символа: {code}");
                                Console.WriteLine($"\tРезультат преобразования в число: {nums.charToNum(digit)}");
                                Console.Write("\n\tДля продолжения нажмите Enter");
                                Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("\tВы выбрали: 3. Двузначное.\n");
                                Console.Write("\tВведите целое число: ");
                                int numIsTwo = Validator.CheckInt();
                                Console.WriteLine($"\tРезультат: {nums.is2Digits(numIsTwo)}");
                                Console.Write("\n\tДля продолжения нажмите Enter");
                                Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("\tВы выбрали: 4. Диапазон.\n");
                                Console.Write("\tВведите границу: ");
                                int a = Validator.CheckInt();
                                Console.Write("\tВведите вторую границу: ");
                                int b = Validator.CheckInt();
                                Console.Write("\tВведите число: ");
                                int num = Validator.CheckInt();
                                Console.WriteLine($"\n\tРезультат: {nums.isInRange(a, b, num)}");
                                break;
                            case 5:
                                Console.WriteLine("\tВы выбрали: 5. Равенство.\n");
                                Console.Write("\tВведите первое число: ");
                                int one = Validator.CheckInt();
                                Console.Write("\tВведите второе число: ");
                                int two = Validator.CheckInt();
                                Console.Write("\tВведите третье число: ");
                                int three = Validator.CheckInt();
                                Console.WriteLine($"\n\tРезультат: {nums.isEqual(one, two, three)}");
                                break;
                            case 0:                                
                                Console.WriteLine("\tВозвращаемся....\n");
                                break;
                            default:
                                Console.WriteLine("\tВы ввели несуществующее задание.");
                                Console.Write("\n\tДля продолжения нажмите Enter");
                                Console.ReadLine();
                                break;

                        }
                        if (SecondNumOfTask == 0)
                        {
                            break;
                        }

                    }
                    break;

                case 2:
                    while (true)
                    {
                        Console.WriteLine("\tВы выбрали:\n");
                        Console.WriteLine("\tЗадание 2. Условия.");
                        Console.WriteLine("\t1. Модуль числа.");
                        Console.WriteLine("\t2. Тридцать пять.");
                        Console.WriteLine("\t3. Тройной максимум.");
                        Console.WriteLine("\t4. Двойная сумма.");
                        Console.WriteLine("\t5. День недели.");
                        Console.WriteLine("\t0. Вернуться к выбору задания ->\n");
                        Console.Write("\tВведите ваш выбор: ");

                        int SecondNumOfTask = Validator.CheckInt();
                        switch (SecondNumOfTask)
                        {
                            case 1:
                                Console.WriteLine("\tВы выбрали: 1. Модуль числа.\n");
                                Console.Write("\tВведите целое число: ");
                                int num = Validator.CheckInt();
                                Console.WriteLine($"\n\tМодуль числа: {nums.abs(num)}");
                                Console.Write("\n\tДля продолжения нажмите Enter");
                                Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("\tВы выбрали: 2. Тридцать пять.\n");
                                Console.Write("\tВведите целое число: ");
                                int numThirtyFive = Validator.CheckInt();
                                Console.WriteLine($"\n\tРезультат: {nums.is35(numThirtyFive)}");
                                Console.Write("\n\tДля продолжения нажмите Enter");
                                Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("\tВы выбрали: 3. Тройной максимум.\n");
                                Console.Write("\tВведите первое число: ");
                                int one = Validator.CheckInt();
                                Console.Write("\tВведите второе число: ");
                                int two = Validator.CheckInt();
                                Console.Write("\tВведите третье число: ");
                                int three = Validator.CheckInt();
                                Console.WriteLine($"\n\tМаксимальное число: {nums.max3(one,two, three)}");
                                Console.Write("\n\tДля продолжения нажмите Enter");
                                Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("\tВы выбрали: 4. Двойная сумма.\n");
                                Console.Write("\tВведите первое число: ");
                                int first = Validator.CheckInt();
                                Console.Write("\tВведите второе число: ");
                                int second = Validator.CheckInt();
                                Console.WriteLine($"\n\tСумма: {nums.sum2(first, second)}");
                                Console.Write("\n\tДля продолжения нажмите Enter");
                                Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("\tВы выбрали: 5. День недели.\n");
                                Console.Write("\tВведите номер дня недели от 1 до 7: ");
                                int day = Validator.CheckInt();
                                Console.WriteLine($"\n\tДень недели: {nums.day(day)}");
                                Console.Write("\n\tДля продолжения нажмите Enter");
                                Console.ReadLine();
                                break;
                            case 0:
                                Console.WriteLine("\tВозвращаемся....\n");
                                break;
                            default:
                                Console.WriteLine("\tВы ввели несуществующее задание.");
                                Console.Write("\n\tДля продолжения нажмите Enter");
                                Console.ReadLine();
                                break;

                        }
                        if (SecondNumOfTask == 0)
                        {
                            break;
                        }

                    }
                    break;

                case 3:
                    while (true)
                    {
                        Console.WriteLine("\tВы выбрали:\n");
                        Console.WriteLine("\tЗадание 3. Циклы.");
                        Console.WriteLine("\t1. Числа подряд.");
                        Console.WriteLine("\t2. Четные числа.");
                        Console.WriteLine("\t3. Длина числа.");
                        Console.WriteLine("\t4. Квадрат.");
                        Console.WriteLine("\t5. Правый треугольник.");
                        Console.WriteLine("\t0. Вернуться к выбору задания ->\n");
                        Console.Write("\tВведите ваш выбор: ");

                        int SecondNumOfTask = Validator.CheckInt();
                        switch (SecondNumOfTask)
                        {
                            case 1:
                                Console.WriteLine("\tВы выбрали: 1. Числа подряд.\n");
                                Console.Write("\tВведите целое число: ");
                                int num = Validator.CheckInt();
                                Console.WriteLine($"\n\tСтрока: {nums.listNums(num)}");
                                Console.Write("\n\tДля продолжения нажмите Enter");
                                Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("\tВы выбрали: 2. Четные числа.\n");
                                Console.Write("\tВведите число: ");
                                int number = Validator.CheckIntPositive();
                                Console.WriteLine($"\n\tЧетные числа: {nums.chet(number)}");
                                Console.Write("\n\tДля продолжения нажмите Enter");
                                Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("\tВы выбрали: 3. Длина числа.\n");
                                Console.Write("\tВведите число: ");
                                long numberLength = Validator.CheckLong();
                                Console.WriteLine($"\n\tКоличество знаков в числе: {nums.numLen(numberLength)}");
                                Console.Write("\n\tДля продолжения нажмите Enter");
                                Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("\tВы выбрали: 4. Квадрат.\n");
                                Console.Write("\tВведите размер стороны квадрата: ");
                                int squareP = Validator.CheckIntPositive();
                                Console.WriteLine("\tРезультат:");
                                Console.WriteLine();
                                nums.square(squareP);
                                Console.Write("\n\tДля продолжения нажмите Enter");
                                Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("\tВы выбрали: 5. Правый треугольник.\n");
                                Console.Write("\tВведите высоту треугольника: ");
                                int height = Validator.CheckIntPositive();
                                Console.WriteLine();
                                nums.rightTriangle(height);
                                Console.Write("\n\tДля продолжения нажмите Enter");
                                Console.ReadLine();
                                break;
                            case 0:
                                Console.WriteLine("\tВозвращаемся....\n");
                                break;
                            default:
                                Console.WriteLine("\tВы ввели несуществующее задание.");
                                Console.Write("\n\tДля продолжения нажмите Enter");
                                Console.ReadLine();
                                break;

                        }
                        if (SecondNumOfTask == 0)
                        {
                            break;
                        }

                    }
                    break;

                case 4:
                    while (true)
                    {
                        Console.WriteLine("\tВы выбрали:\n");
                        Console.WriteLine("\tЗадание 4. Массивы.");
                        Console.WriteLine("\t1. Поиск первого значения.");
                        Console.WriteLine("\t2. Поиск максимального.");
                        Console.WriteLine("\t3. Добавление массива в массив.");
                        Console.WriteLine("\t4. Возвратный реверс.");
                        Console.WriteLine("\t5. Все вхождения.");
                        Console.WriteLine("\t0. Вернуться к выбору задания ->\n");
                        Console.Write("\tВведите ваш выбор: ");

                        int SecondNumOfTask = Validator.CheckInt();
                        switch (SecondNumOfTask)
                        {
                            case 1:
                                Console.WriteLine("\tВы выбрали: 1. Поиск первого значения.\n");
                                int[] arr = CreateArr(nums);
                                Console.WriteLine("\n\tИсходный массив:");
                                PrintArr(arr);
                                Console.Write("\n\tВведите число для поиска: ");
                                int x = Validator.CheckInt();
                                Console.WriteLine($"\n\tРезультат: {nums.findFirst(arr, x)}");
                                Console.Write("\n\tДля продолжения нажмите Enter");
                                Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("\tВы выбрали: 2. Поиск максимального.\n");
                                int[] maxArr = CreateArr(nums);
                                Console.WriteLine("\n\tИсходный массив:");
                                PrintArr(maxArr);
                                Console.WriteLine($"\n\tРезультат: {nums.maxAbs(maxArr)}");
                                Console.Write("\n\tДля продолжения нажмите Enter");
                                Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("\tВы выбрали: 3. Добавление массива в массив.\n");
                                Console.WriteLine("\tПервый массив:");
                                int[] one = CreateArr(nums);
                                Console.WriteLine("\n\tВторой массив:");
                                int[] two = CreateArr(nums);
                                Console.WriteLine("\n\tИсходные массивы:");
                                PrintArr(one);
                                PrintArr(two);
                                Console.Write($"\n\tВведите позицию вставки от 0 до {one.Length}: ");
                                int position = Validator.CheckIntArr(0, one.Length);
                                int[] newArr = nums.add(one, two, position);
                                Console.WriteLine("\n\tРезультат:");
                                PrintArr(newArr);
                                Console.Write("\n\tДля продолжения нажмите Enter");
                                Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("\tВы выбрали: 4. Возвратный реверс.\n");
                                int[] reverse = CreateArr(nums);
                                Console.WriteLine("\n\tМассив:");
                                PrintArr(reverse);
                                int[] revNew = nums.reverseBack(reverse);
                                Console.WriteLine("\n\tРезультат:");
                                PrintArr(revNew);
                                Console.Write("\n\tДля продолжения нажмите Enter");
                                Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("\tВы выбрали: 5. Все вхождения.\n");
                                int[] findAllArray = CreateArr(nums);
                                Console.WriteLine("\n\tИсходный массив:");
                                PrintArr(findAllArray);
                                Console.Write("\n\tВведите число для поиска: ");
                                int searchNumber = Validator.CheckInt();
                                int[] index = nums.findAll(findAllArray, searchNumber);
                                Console.WriteLine("\n\tИндексы всех вхождений:");
                                PrintArr(index);
                                Console.Write("\n\tДля продолжения нажмите Enter");
                                Console.ReadLine();
                                break;
                            case 0:
                                Console.WriteLine("\tВозвращаемся....\n");
                                break;
                            default:
                                Console.WriteLine("\tВы ввели несуществующее задание.");
                                Console.Write("\tНажмите Enter, чтобы продолжить...");
                                Console.ReadLine();
                                break;

                        }
                        if (SecondNumOfTask == 0)
                        {
                            break;
                        }

                    }
                    break;

                case 0:
                    return;
                default:
                    Console.WriteLine("\tВы ввели несуществующее задание.");
                    Console.Write("\n\tДля продолжения нажмите Enter");
                    Console.ReadLine();
                    break;
            }
            
        }
        
    }

    private static int[] CreateArr(Nums nums)
    {
        Console.Write("\tВведите количество элементов: ");
        int size = Validator.CheckIntPositive();

        Console.Write("\n\tВведите минимальное значение: ");
        int minValue = Validator.CheckInt();
        Console.Write("\tВведите максимальное значение: ");
        int maxValue = Validator.CheckInt();
        while (minValue > maxValue)
        {
            Console.Write("\tОшибка: минимум не может быть больше максимума.\n");
            Console.Write("\tВведите минимальное значение: ");
            minValue = Validator.CheckInt();
            Console.Write("\tВведите максимальное значение: ");
            maxValue = Validator.CheckInt();
        }

        Random random = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(minValue, maxValue + 1);
        }
        return arr;
    }

    private static void PrintArr(int[] arr)
    {
        Console.Write("\t[");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
            if (i < arr.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}