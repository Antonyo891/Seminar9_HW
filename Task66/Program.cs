/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
using System;
using static System.Console;
int Enter(string text) // запрос на ввод целого числа
{
    WriteLine(text);
    int result = int.Parse(ReadLine());
    return result;
}
int Sum(int m, int n)
{
    if (m == n) return n;
    return m + Sum(m + 1, n);
}
Clear();
int m = Enter("Введите число  m");
int n = Enter("Введите число  n");
WriteLine(Sum(m, n));