using static System.Console;  // Строки 1-2 применяются для всех трёх задач.
using System;                 // Проверкаа работы всех трёх программ возможна без закомментирования.


        // Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
        // и на выходе показывает вторую цифру этого числа. (без пеобразования типов)

Clear();

int Div10 (int decNumber)
{
    int divResult = decNumber / 10;
    return divResult;
}

int Rem (int decNumber)
{
    int remResult = decNumber % 10;
    return remResult;
}

Write("Задача 10. Введите трёхзначное число: ");
int number = Convert.ToInt32(ReadLine());

if ((number > -1000) && (number < -99) || (number > 99) && (number < 1000))
{
    if (number < 0)
    {
        int negNumber = number *(-1);
        number = negNumber;
    }
    number = Rem (Div10(number));
    WriteLine("Вторая цифра числа: " + number);
}
else WriteLine("Число не трёхзначное");



        // Задача 13: Напишите программу, которая выводит третью цифру заданного числа
        // или сообщает, что третьей цифры нет. (без пеобразования типов)



int FindThirdDigit (int decNumber)
{
    while (decNumber / 10 >= 100)
        decNumber = decNumber / 10;

    int thirDigit = decNumber % 10;
    return thirDigit;
}

WriteLine();
Write ("Задача 13. Введите целое число: ");
int number1 = Convert.ToInt32(ReadLine());

if (number1 < 0)
{
    int negNumber = number1 *(-1);
    number1 = negNumber;
}

if (number1 >= 100)
{
    WriteLine("Третья цифра числа: " + FindThirdDigit(number1));
}

else WriteLine("Третьей цифры нет");


            // Задача 15: Напишите программу, которая принимает на вход цифру,
            // обозначающую день недели, и проверяет, является ли этот день выходным.



WriteLine();
Write("Задача 15. Введите номер дня недели: ");
string? day = ReadLine();

if (day == "6" || day == "7")
    WriteLine(day + " -> выходной день");
else WriteLine(day + " -> не выходной день");

