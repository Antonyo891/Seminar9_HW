//Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
using System;
using static System.Console;
Clear();
int end = Enter("Введите число");
WriteLine(PrintNaturalNumber(end));
int Enter(string text) // запрос на ввод целого числа
{
    WriteLine(text);
    int result = int.Parse(ReadLine());
    return result;
}
string PrintNaturalNumber(int end)
{
    if (end == 1) return $"{end}";
    string s = $"{end}" + ", " + PrintNaturalNumber(end - 1);
    return s;
}
