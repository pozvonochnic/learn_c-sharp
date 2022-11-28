using System;
using static System.Console;

// МЕТОД, ОБЪЯВЛЕННЫЙ В СТРОКЕ 10, ИСПОЛЬЗУЕТСЯ В ДВУХ ЗАДАЧАХ.


        // Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
        // и возводит число A в натуральную степень B.

int Raise(int num, int ind)             // Метод возводит число в натуральную степень
{
    int res = 1;
    for(int i = 1; i <= ind; i++)
        res *= num;        
    return res;
}


Clear();

WriteLine("Задача 25. Возведение числа в степень.\n");
Write("Введите число А: ");
int userNum = Convert.ToInt32(ReadLine());
Write("Введите натуральное число B: ");
int exp = Convert.ToInt32(ReadLine());

if(exp > 0)
{
    int result = Raise(userNum, exp);
    WriteLine($"A в степени B равно {result}.");
}
else Write("Число B не натурально!");





        // Задача 27: Напишите программу, которая принимает на вход число
        // и выдаёт сумму цифр в числе.

int Capacity (int num)          // Метод определяет количество цифр в числе
{
    int res = num;
    int count = 1;
    while (res > 9)
    {
        res = res / 10;
        count++;
    }
    return count;
}

int FixNum (int n, int position)           // Метод извлекает цифры из числа
{
    int rem = n % (position);
    int digit = rem / (position / 10);
    return digit;
}

WriteLine("\n\nЗадача 27. Нахождение суммы цифр числа\n");
Write("Введите целое число: ");
int userNumber = Convert.ToInt32(ReadLine());

if (userNumber < 0)
    userNumber = -1 * userNumber;

int size = Capacity(userNumber);
int sum = 0;

for (int i = 0; i < size; i++)
    sum += FixNum(userNumber, Raise(10, size - i));

WriteLine($"Сумма цифр числа равна {sum}.");
    




        // Задача 29: Напишите программу,
        // которая задаёт массив из 8 элементов
        // и выводит их на экран.

void CreateAndShowArray(int size)
{    
    Write("Сгенерирован массив из 8 элементов:\n[");
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-1000, 1001);
        Write(array[i] + ", ");
    }
    Write("\b\b]");
}

Write("\n\nЗадача 29. Содание массива и вывод его на экран (Press Enter to continue)");
ReadLine();
CreateAndShowArray(8);