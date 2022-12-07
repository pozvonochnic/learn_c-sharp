using System;
using static System.Console;                // Методы, объявленные в строках 49 и 59,
                                            // используются в двух задачах.
Clear();



            // Задача 47. Задайте двумерный массив размером m×n,
            // заполненный случайными вещественными числами.


double [,] CreateDoubleArray (int row, int column)
{
    double [,] array = new double [row, column];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
        {
            int dec = new Random().Next(0, 3);
            array[i, j] = Math.Round((new Random().NextDouble())*10, dec);
        }
    return array;
}

void ShowArray (double [,] array)
{
    WriteLine("\nAn array was created:\n");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Write(array[i, j] + "  ");
        WriteLine();
    }
}
WriteLine("Задача 47.\nГенерация двумерного double-массива\n");
Write("Input number of rows M: ");
int m = Convert.ToInt32(ReadLine());
Write("Input number of columns N: ");
int n = Convert.ToInt32(ReadLine());
ShowArray (CreateDoubleArray (m, n));



            // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
            // и возвращает значение этого элемента или же указание, что такого элемента нет.

            // В программе генерируется массив размером не менее 4х4


int [,] Create2dArray(int row, int column)
{
    int [,] created2dArray = new int [row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            created2dArray [i, j] = new Random().Next(10, 100);
    return created2dArray;
}

void Show2dArray(int [,] array)
{
    WriteLine();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Write(array[i,j] + " ");
        }
        WriteLine();
    }
    WriteLine();
}

Write("\nPush ENTER to clear console");
ReadLine();
Clear();
WriteLine("\nЗадача 50.\nПоиск элемента по заданной позиции\n(В программе гарантированно генерируется\nмассив размером не менее 4х4)\n");
int row = new Random().Next(4, 11);
int column = new Random().Next(4, 11);
int [,] newArray = Create2dArray(row, column);

Write("Input index 'i' within the range [0; 10]: ");
int i = Convert.ToInt32(ReadLine());
Write("Input index 'j' within the range [0; 10]: ");
int j = Convert.ToInt32(ReadLine());

if(i < row && j < column)
    WriteLine("\nThe element [" + i + ", " + j + "] is: " + newArray[i, j]);    
else
    WriteLine($"\nThe element [{i}, {j}] does not exist!");

WriteLine("\nThe initial array is:");
Show2dArray(newArray);



            // Задача 52. Задайте двумерный массив из целых чисел.
            // Найдите среднее арифметическое элементов в каждом столбце.


double ColumnAverage (int [,] array, int j)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        sum += array [i, j];
    double columnAve = Convert.ToDouble(sum) / Convert.ToDouble(array.GetLength(0));
    return columnAve;
}

void ShowAveArray (double [] array)
{
    for(int i = 0; i < array.Length; i++)
        Write(array[i] + " ");
    WriteLine();
}

Write("\nPush ENTER to clear console");
ReadLine();
Clear();
WriteLine("\nЗадача 52.\nПоиск среднего арифметического по столбцам двумерного массива\n");

Write("Input number of rows: ");
int row52 = Convert.ToInt32(ReadLine());
Write("Input number of columns: ");
int column52 = Convert.ToInt32(ReadLine());

int [,] task52 = Create2dArray(row52, column52);
Show2dArray(task52);

double [] result = new double [column52];
for(int ind = 0; ind < column52; ind++)
    result[ind] = Math.Round(ColumnAverage(task52, ind), 3);
ShowAveArray(result);
WriteLine();

