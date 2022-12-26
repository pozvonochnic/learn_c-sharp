using System;
using static System.Console;

//Clear();
// string [] stringArray = new string[6];
// stringArray[0] = "asd;fkjh";
// stringArray[1] = String.Empty;
// stringArray[2] = "hdj";
// stringArray[3] = String.Empty;
// stringArray[4] = "Ээээ";
// stringArray[5] = "hdfjk";
// WriteLine(String.Join(" | ", stringArray));

// int count = 0;
// foreach (string item in stringArray)
// {
//     if (item != String.Empty)
//         count++;
// }
// WriteLine(count);

// int num1 = stringArray[0].Length;
// int num2 = stringArray[1].Length;
// WriteLine(num1 + " " + num2);

// int [] nullArray = new int [0];

// WriteLine("["+String.Join(",", nullArray)+"]");


int CountElements (string [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
            count++;
    return count;
}

string [] FillStringArray(string[]array1, string[]array2)
{
    int index = 0;
    for (int i = 0; i < array1.Length; i++)
            if (array1[i].Length <= 3)
            {    
                array2[index] = array1[i];
                index++;
            }
    return array2;
}

WriteLine("Введите строковые элементы массива через запятую:");
//string elements = ReadLine();
string [] stringArray = ReadLine().Split(',');

// string newString = String.Empty;
// newString = $"{newString}{stringArray[0]}";
// WriteLine(newString);
// newString = $"{newString}{stringArray[1]}";
// WriteLine(newString);

int newSize = CountElements(stringArray);
string [] newStringArray = new string [newSize];
newStringArray = FillStringArray(stringArray, newStringArray);

// Оформить в метод

WriteLine("["+String.Join(", ", newStringArray)+"]");

//Write(newSize);

// 0. Задать массив строкой через разделитель.
// 1. Метод. Сплитонуть. Посчитать количество нужных элементов. Это будет размер нового массива - возвратить.
// 2. Метод (аргументы: исходный массив, размер нового массива). Заполнить новый массив через foreach (возможно) и if.
// 3. Вывести новый массив.