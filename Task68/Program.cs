/*Задача 68: Напишите программу вычисления функции 
Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
using System;
using static System.Console;
int Enter(string text) // запрос на ввод целого числа
{
    WriteLine(text);
    int result = int.Parse(ReadLine());
    return result;
}
int Akkerman (int m, int n)
{
if (m==0) return n+1;
if (n==0) return Akkerman(m-1,1);
    return Akkerman(m-1,Akkerman(m,n-1));
}
Clear();
int m = Enter("Введите число неотрицательное число m");
int n = Enter("Введите число неотрицательное число n");
WriteLine(Akkerman(m,n));