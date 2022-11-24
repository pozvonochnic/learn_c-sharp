using System;
using static System.Console;

        // Задача 19. Напишите программу, которая принимает на вход пятизначное число
        // и проверяет, является ли оно палиндромом.

int FixNum (int n, int position)
{
    int rem = n % (10 * position);
    int digit = rem / position;
    return digit;
}

Clear();
WriteLine("Задача 19. Является ли число палиндромом?");
Write("Введите пятизначное число: ");
int number = Convert.ToInt32(ReadLine());

if ((number > 9999 && number < 100000) || (number > -100000 && number < -9999))
{
    int a1 = FixNum(number, 1);
    int a2 = FixNum(number, 10);
    int a3 = FixNum(number, 100);
    int a4 = FixNum(number, 1000);
    int a5 = FixNum(number, 10000);
    if (a1 == a5 && a2 == a4)
        Write("да");
    else
        Write ("нет");
}
else
    WriteLine("Число не является пятизначным!");


        // Задача 21. Напишите программу, которая принимает на вход координаты двух точек
        // и находит расстояние между ними в 3D пространстве.

double Distance3D (int x1, int y1, int z1, int x2, int y2, int z2)
{
    int x = x1 - x2;
    int y = y1 - y2;
    int z = z1 - z2;
    double res = Math.Sqrt(x*x + y*y + z*z);
    return res;
}

WriteLine("\n\nЗадача 21. Нахождение расстояния между двумя точками в 3D пространстве.");
Write("Введите координаты первой точки:\nX = ");
int xA = Convert.ToInt32(ReadLine());
Write("Y = ");
int yA = Convert.ToInt32(ReadLine());
Write("Z = ");
int zA = Convert.ToInt32(ReadLine());

Write("Введите координаты второй точки:\nX = ");
int xB = Convert.ToInt32(ReadLine());
Write("Y = ");
int yB = Convert.ToInt32(ReadLine());
Write("Z = ");
int zB = Convert.ToInt32(ReadLine());

double dist = Distance3D(xA, yA, zA, xB, yB, zB);
Write($"Расстояние между точками: {dist:f3}");


        // Задача 23. Напишите программу, которая принимает на вход число (N)
        // и выдаёт таблицу кубов чисел от 1 до N.

void Cube (int num)
{
    for (int current = 1; current <= num; current++)
    {
        int res = current * current * current;
        Write($"{res}, ");
    }
    Write("\b\b.");
}

WriteLine("\n\nЗадача 23. Таблица кубов.");
Write("Введите натуральное число N: ");
int n = Convert.ToInt32(ReadLine());
if (n > 0)
{
    Write (n + " -> ");
    Cube (n);
}
else
    Write("Число не положительно!");