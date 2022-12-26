using System;
using static System.Console;


Clear();
            //VARIANT 1


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
string [] stringArray = ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);

int newSize = CountElements(stringArray);
string [] newStringArray = new string [newSize];
newStringArray = FillStringArray(stringArray, newStringArray);

WriteLine("["+String.Join(", ", newStringArray)+"]");



            //VARIANT 2

/*
string [] ChoseElements (string [] array)
{
    string newString = String.Empty;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
            newString = $"{newString},{array[i]}";
    string [] newStringArray = newString.Split(',', StringSplitOptions.RemoveEmptyEntries);
    return newStringArray;
}

WriteLine("Введите строковые элементы массива через запятую:");
string [] stringArrayVar2 = ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
string[] newArray = ChoseElements(stringArrayVar2);
WriteLine("["+String.Join(", ", newArray)+"]");
*/
