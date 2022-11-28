using static System.Console;
using System;

// МЕТОДЫ, ОБЪЯВЛЕННЫЕ В СТРОКАХ 51 и 62, ИСПОЛЬЗУЮТСЯ В ДВУХ ЗАДАЧАХ.

        // Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами.
        // Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateIntArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
void ShowIntArray(int[] array)
{
    Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]}, ");
    }
    WriteLine("\b\b]");
}
void NumberOfEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;
    WriteLine($"Количество чётных элементов массива равно {count}.");
}

Clear();
WriteLine("Задача 34. Определение количества чётных чисел в массиве.\n");
Write("Задайте размер массива: ");
int arraySize = Convert.ToInt32(ReadLine());
int[] createdArray = CreateIntArray(arraySize);
WriteLine($"{arraySize} elements array was created:");
ShowIntArray(createdArray);
NumberOfEven(createdArray);




        // Задача 36: Задайте одномерный массив, заполненный случайными числами.
        // Найдите сумму элементов, стоящих на нечётных позициях.

double[] CreateDoubleArray(int size)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble();
        array[i] = Math.Round(array[i]*1000, 2);
    }
    return array;
}

void ShowDoubleArray(double[] array)
{
    Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]}, ");
    }
    WriteLine("\b\b]");
}

void OddIndexSum(double[] array)
{
    double sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    sum += array[i];
    WriteLine($"Сумма элементов с нечётными индексами равна {Math.Round(sum, 2)}.");
}

WriteLine("\n\nЗадача 36. Вычисление суммы элементов, стоящих на нечётных позициях.\n");
Write("Задайте размер массива: ");
int arrSize = Convert.ToInt32(ReadLine());
double[] createdArr = CreateDoubleArray(arrSize);
WriteLine($"{arrSize} elements array was created:");
ShowDoubleArray(createdArr);
OddIndexSum(createdArr);



        // Задача 38: Задайте массив вещественных чисел.
        // Найдите разницу между максимальным и минимальным элементами массива.

double FindMax(double[] array)
{
    double max = array[0];
    for(int i = 0; i < array.Length - 1; i++)
    {
        if (array[i + 1] > array[i])
            max = array[i + 1];
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for(int i = 0; i < array.Length - 1; i++)
    {
        if (array[i + 1] < array[i])
            min = array[i + 1];
    }
    return min;
}

WriteLine("\n\nВычисление разницы между максимальным и минимальным элементами массива.\n");
Write("Задайте размер массива: ");
int arrayLength = Convert.ToInt32(ReadLine());
double[] newArray = CreateDoubleArray(arrayLength);
WriteLine($"{arrayLength} elements array was created:");
ShowDoubleArray(newArray);
double minElement = FindMin(newArray);
double maxElement = FindMax(newArray);
Write($"Разница между максимальным и минимальным элементами массива равна {Math.Round((maxElement - minElement), 2)}.");