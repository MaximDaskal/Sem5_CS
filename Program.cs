

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//Создаём массив
int [] CreateArray(int size)
{
    int [] Result = new int[size];
    for(int i =0; i<Result.Length; i++)
    {
        Result[i] = new Random().Next(100, 1000);
    }
    return Result;
}

// Количество чётных чисел
int CountsOfEvenNumb(int [] array)
{
    int res =0;
    for(int i =0; i< array.Length; i++)
    {
        if(array[i]%2 == 0)
        res++;
    }
    return res;
}

// выводим массив и подсчитанное колво чётных элементов на экран
void ShowArray(int [] array)
{
    for(int i =0; i< array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("");
    int res = CountsOfEvenNumb(array);
    Console.WriteLine($"Количество чётных элементов массива составляет: {res}");
}


//Пользовательский интерфейс
Console.Write("Input size of your array: ");
int numA = Convert.ToInt32(Console.ReadLine());

ShowArray(CreateArray(numA));



/*
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//Создаём массив
int [] CreateArray(int size, int minVal, int maxVal)
{
    int [] Result = new int[size];
    for(int i =0; i<Result.Length; i++)
    {
        Result[i] = new Random().Next(minVal, maxVal+1);
    }
    return Result;
}
//Вычисляем сумму элементов на нечётных позициях
long sumOddNum(int [] array)
{
    long res =0;
    for(int i=1; i<array.Length; i++)
    {
        if(i%2 !=0)
        res = res + array[i];
    }
    return res;
}

// выводим массив и сумму элементов стоящих на нечётных позициях на экран
void ShowArray(int [] array)
{
    Console.WriteLine("Your array is: ");
    for(int i =0; i< array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("");
    long res = sumOddNum(array);
    Console.WriteLine($"Сумма значений элементов массива стоящих на нечётных позициях составляет: {res}");
}

//Пользовательский интерфейс
Console.Write("Input size of your array: ");
int sizeA = Convert.ToInt32(Console.ReadLine());


Console.Write("Input min value of your array: ");
int minV = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value of your array: ");
int maxV = Convert.ToInt32(Console.ReadLine());

ShowArray(CreateArray(sizeA, minV, maxV));
*/


/*
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. Math.Min Math.Max не использовать
//Создали массив
float [] CreateArrayFloatNums(int size, float minVal, float maxVal)
{
    float [] Result = new float[size];
    float space = maxVal - minVal; // определили диапазон из которого должны быть получены значения элементов массива
   
    for(int i = 0; i<Result.Length; i++)
    {
        float ranNum = Convert.ToSingle(Math.Round((new Random().NextSingle()), 3)); // Получили значение из диапазона [0.000; 1.000]
        Result[i] = Convert.ToSingle(Math.Round((ranNum*space + minVal), 3));//  Получили вещественное  число из диапазона [minVal; maxVal]
    }
    return Result;
}

// Вычисляем разницу между максимальным и минимальным элементами массива
float max_min_diff(float [] array)
{
    float res;
    float maxV = array[0];
    float minV = array[0];
    for(int i=1; i<array.Length; i++)
    {
        if(maxV < array[i])
            maxV = array[i];
        if(minV > array[i])
            minV = array[i];
    }

    return res = Convert.ToSingle(Math.Round((maxV - minV), 3));
}

// выводим массив и разницу между минимальным и максимальным значениями на экран
void ShowArray(float [] array)
{
    Console.WriteLine("Your array is: ");
    for(int i =0; i< array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("");
    float res = max_min_diff(array);
    Console.WriteLine($"Разница значений максимально и минимального элементов массива составляет: {res}");
}





Console.Write("Input size of your array: ");
int sizeA = Convert.ToInt32(Console.ReadLine());


Console.Write("Input min value of your array: ");
float minV = Convert.ToSingle(Console.ReadLine());

Console.Write("Input max value of your array: ");
float maxV = Convert.ToSingle(Console.ReadLine());

ShowArray(CreateArrayFloatNums(sizeA, minV, maxV));
*/



