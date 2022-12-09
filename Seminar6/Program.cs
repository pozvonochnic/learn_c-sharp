using System;
using static System.Console;

        // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


Clear();


int [] DataInput (int size)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        Write($"Введите число {i + 1}: ");
        array[i] = Convert.ToInt32(ReadLine());
    }
    return array;
}

void CheckPositive(int [] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i] > 0)
            count++;
    WriteLine($"Введено {count} положительных чисел");
}

Write("Введите количество числел для анализа M: ");





Write("Введите количество числел для анализа M: ");
int m = Convert.ToInt32(ReadLine());
/*
Write($"Введите {m} чисел через пробел: ");
string [] numbers=ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

int[] newNumbers = new int[numbers.Length];
for (int i = 0; i < numbers.Length; i++)
{
    newNumbers[i] = Convert.ToInt32(numbers[i]);
    Write($"{newNumbers[i]} ");
*/


int[] numbers = DataInput(m);
CheckPositive(numbers);

        // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
        // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


double[] FindIntersection(double k1, double b1, double k2, double b2)
{
    double [] coord = new double[2];
    coord[0] = (b2 - b1) / (k1 - k2);
    coord[1] = k1*coord[0] + b1;
    return coord;
}

void PrintCoordinates(double[] array)
{
    Write("\nКоординаты пересечения прямых: (");
    for (int i = 0; i < array.Length; i++)
        Write(Math.Round(array [i], 2) + "; ");
    WriteLine("\b\b)");
}

Write("Введите коэффициент k для первой прямой: ");
double a = Convert.ToDouble(ReadLine());
Write("Введите свободный член b для первой прямой: ");
double b = Convert.ToDouble(ReadLine());
Write("Введите коэффициент k для второй прямой: ");
double c = Convert.ToDouble(ReadLine());
Write("Введите свободный член b для второй прямой: ");
double d = Convert.ToDouble(ReadLine());

if(a != c)
{
    double[] coord = FindIntersection(a, b, c, d);
    PrintCoordinates(coord);
}
else WriteLine("Прямые не пересекаются");