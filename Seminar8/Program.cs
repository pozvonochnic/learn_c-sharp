using System;                               // МЕТОДЫ, ОБЪЯВЛЕННЫЕ В СТРОКАХ 10 И 20,
using static System.Console;                // ИСПОЛЬЗУЮТСЯ В НЕСКОЛЬКИХ ЗАДАЧАХ.



            // Задача 54: Задайте двумерный массив. Напишите программу,
            // которая упорядочит по убыванию элементы каждой строки двумерного массива.


int [,] Create2dArray(int row, int column, int minVal, int maxVal)
{
    int [,] created2dArray = new int [row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            created2dArray [i, j] = new Random().Next(minVal, maxVal+1);
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

int [,] DescOrder(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
            for(int k = j + 1; k < array.GetLength(1); k++)
                if(array[i,j] < array[i,k])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temp;
                }
    }
    return array;
}

Clear();
WriteLine("\nЗадача 54.\nУпорядочивание по убыванию строк массива\n");
Write("Input number of rows: ");
int row = Convert.ToInt32(ReadLine());
Write("Input number of columns: ");
int column = Convert.ToInt32(ReadLine());

int[,] createdArray = Create2dArray(row, column, 10, 99);
Show2dArray(createdArray);
int[,] descArray = DescOrder(createdArray);
Show2dArray(descArray);
Write("Press ENTER to continue");
ReadLine();



            // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
            // которая будет находить строку с наименьшей суммой элементов.


void ShowIndexed(int [,] array)
{
    WriteLine();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Write(i + ":  ");
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Write(array[i,j] + " ");
        }
        WriteLine();
    }
    WriteLine();
}

int FindMinSum(int[,] array, int sumMin)
{
    int iMin = 0;
                // sumMin = 0;                                  ---->   Для варианта без передачи
                // for(int j = 0; j < array.GetLength(1); j++)  ---->   максимально возможной
                //     sumMin += array[0,j];                    ---->   суммы в метод
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sumI = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sumI += array[i,j];
        if(sumI < sumMin)
        {
            iMin = i;
            sumMin = sumI;
        }   
    }
    return iMin;
}

Clear();
WriteLine("\nЗадача 56.\nНахождение строки с наименьшей суммой элементов\n");

Write("Input number of rows: ");
int rows = Convert.ToInt32(ReadLine());
Write("Input different number of columns: ");
int columns = Convert.ToInt32(ReadLine());
if (rows == columns)
{
    Write("\nThe array is absolutely square!\nPress ENTER to continue");
    ReadLine();
}
else
{
    Write("Input minimal value: ");
    int minVal = Convert.ToInt32(ReadLine());
    Write("Input maximal value: ");
    int maxVal = Convert.ToInt32(ReadLine());
    int possibleMaxSum = columns*maxVal;                        // Переменная передаётся в метод для исключения строк 88-90
    int [,] newArray = Create2dArray(rows, columns, minVal, maxVal);
    ShowIndexed(newArray);
    int minSumInd = FindMinSum(newArray, possibleMaxSum);
    WriteLine("The index of minilal sum row is " + minSumInd);
}
Write("Press ENTER to continue");
ReadLine();



            // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

            // Татьяна, простите, пожалуйста, невозможно было остановиться, чтобы не написать программу для общего случая.
            // ОЧЕНЬ ИНТЕРЕСНАЯ ЗАДАЧА! :)


int [,] Right(int[,]array, int curElement, int [] curMaxPosition)       // Метод принимает на входе рабочий массив,
{                                                                       // последнее внесённое значение элемента и его позицию
    int i = curMaxPosition[0];                                          // в виде одномерного массива.
    for(int j = 0; j < array.GetLength(1); j++)                         // Заполняет одну строку слева направо.
    {
        if(array[i,j] ==0)
        {
            if (array[0,0] == 0)            // Для исключения однозначных чисел
                curElement = 9;             // (для красоты)
            array[i,j] = curElement + 1;
            curElement++;
        }
    }
    return array;
}

int[,] Down(int [,] array, int curElement, int [] curMaxPosition)       // Метод принимает на входе рабочий массив,
{                                                                       // последнее внесённое значение элемента и его позицию
    int j = curMaxPosition[1];                                          // в виде одномерного массива.
    for(int i = 0; i < array.GetLength(0); i++)                         // Заполняет один столбец сверху вниз.
    {
        if(array[i,j] ==0)
        {
            array[i,j] = curElement + 1;
            curElement++;
        }
    }
    return array;
}

int[,] Left(int [,] array, int curElement, int [] curMaxPosition)       // Метод принимает на входе рабочий массив,
{                                                                       // последнее внесённое значение элемента и его позицию
    int i = curMaxPosition[0];                                          // в виде одномерного массива.
    for(int j = (array.GetLength(1) - 1); j >= 0; j = (j - 1))          // Заполняет одну строку справа налево.
    {
        if(array[i,j] == 0)
        {
            array[i,j] = curElement + 1;
            curElement++;
        }
    }
    return array;
}

int[,] Up(int [,] array, int curElement, int [] curMaxPosition)         // Метод принимает на входе рабочий массив,
{                                                                       // последнее внесённое значение элемента и его позицию
    int j = curMaxPosition[1];                                          // в виде одномерного массива.
    for(int i = (array.GetLength(0) - 1); i >= 0; i = (i - 1))          // Заполняет один столбец снизу вверх.
    {
        if(array[i,j] == 0)
        {
            array[i,j] = curElement + 1;
            curElement++;
        }
    }
    return array;
}

int CurrentMax (int[,] array)                                           // Метод принимает на входе рабочий массив
{                                                                       // и возвращает последнее внесённое значение элемента.
    int curMax = 0;
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            if(array[i,j] > curMax)
                curMax = array[i,j];
    return curMax;
}

int[] CurMaxPosition (int[,] array, int curMax)                         // Метод принимает на входе рабочий массив, и возвращает
{                                                                       // позицию последнего внесённого элемента в виде одномерного массива.
    int[] position = new int [2];
    if(array[0,0] == 0)
    {
        position[0] = 0;
        position[1] = 0;
    }
    else
    {
        for(int i = 0; i < array.GetLength(0); i++)
            for(int j = 0; j < array.GetLength(1); j++)
                if(array[i,j] == curMax)
                {
                    position[0] = i;
                    position[1] = j;
                }
    }
    return position;
}

Clear();
WriteLine("\nЗадача 56.\nЗаполнение массива по спирали\n");

Write("Input number of rows: ");
int hor = Convert.ToInt32(ReadLine());
Write("Input number of columns: ");
int ver = Convert.ToInt32(ReadLine());

int[,] array = new int [hor, ver];
//Show2dArray(array);
int curMax;
int[] maxPosition;
int lower;
int count;

if(hor < ver)                               // Для ограничения
    lower = hor;                            // числа итерации
else lower = ver;

if(lower % 2 == 0)
    count = lower / 2;
else
    count = lower / 2 + 1;

for(int i = 1; i < count + 1; i++)
{
    curMax = CurrentMax(array);                                 // Можно ли создавать и использовать массивы методов?
    maxPosition = CurMaxPosition(array, curMax);                // Было бы очень кстати!
    array = Right(array, curMax, maxPosition);
    //Show2dArray(array1);
    curMax = CurrentMax(array);
    maxPosition = CurMaxPosition(array, curMax);
    array = Down(array, curMax, maxPosition);
    //Show2dArray(array2);
    curMax = CurrentMax(array);
    maxPosition = CurMaxPosition(array, curMax);
    array = Left(array, curMax, maxPosition);
    //Show2dArray(array3);
    curMax = CurrentMax(array);
    maxPosition = CurMaxPosition(array, curMax);
    array = Up(array, curMax, maxPosition);
    //Show2dArray(array);
}
Show2dArray(array);

WriteLine($"\nЧисло итераций (витков спирали): {count}\n");