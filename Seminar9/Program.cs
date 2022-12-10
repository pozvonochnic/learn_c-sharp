using System;
using static System.Console;



            // Задача 64: Задайте значение N. Напишите программу,
            // которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


void NaturalRow(int n)
{
    if(n > 1)
    {
        Write(n + " ");
        NaturalRow(n - 1);
    }
    else Write(1);
}
Write("Введите целое число: ");
int userNum = Convert.ToInt32(ReadLine());
NaturalRow(userNum);



            // Задача 66: Задайте значения M и N. Напишите программу,
            // которая найдёт сумму натуральных элементов в промежутке от M до N.


int RangeSum (int m, int n)
{
    if (m < n) return m + RangeSum(m+1, n);
    if (m > n) return m + RangeSum(m-1, n);
    else return n;
}


Write("\n\nВведите M: ");
int m = Convert.ToInt32(ReadLine());
Write("Введите N: ");
int n = Convert.ToInt32(ReadLine());
if (m <= 0 && n <= 0)
    Write("В интервале нет натуральных чисел");
else
{
    if (m < 0)
        m = 0;
    if (n < 0)
        n = 0;
    int sum = RangeSum(m, n);
    WriteLine("\nСумма чисел в интервале равна " + sum);
}



            // Задача: Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную


void ToBinary(int n)
{
    if (n / 2 > 0) ToBinary (n / 2);
    Write(n % 2);
}

Write("\nЗадайте число: ");
int number = Convert.ToInt32(ReadLine());
ToBinary(number);