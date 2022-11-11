// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/* Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

            // Дополнительно можно провести проверку на равенство чисел.
            // В случае равенства - предупредить пользователя и запросить ввод разных чисел.
            // Также это можно реализовать с помощью бесконечного цикла.

if(number1 > number2)
{
    Console.WriteLine($"Число {number1} больше числа {number2}");
}
else
{
    Console.WriteLine($"Число {number2} больше числа {number1}");
} */




// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/* Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

            // Дополнительно можно провести проверку на равенство чисел.
            // В случае равенства - предупредить пользователя и запросить ввод разных чисел.
            // Также это можно реализовать с помощью бесконечного цикла.

if (number1 > number2 && number1 > number3)
{
    Console.WriteLine("Максимальное число - " + number1);
}
else
    if (number2 > number1 && number2 > number3)
    {
        Console.WriteLine("Максимальное число - " + number2);
    }
    else
        if (number3 > number1 && number3 > number2)
        {
            Console.WriteLine("Максимальное число - " + number3);
        }
*/



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.

/* Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Число " + number + " является чётным.");
}
else
{
    Console.WriteLine("Число " + number + " является нечётным.");
} */




// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

            // Дополнительно можно провести проверку на положительность числа.
            // В случае, если число не является положительным, запросить ввод положительного числа.
            // Также это можно реализовать с помощью бесконечного цикла.

int result = 2;

while(result <= number)
{
    Console.Write(result + "  ");
    result = result + 2;
}