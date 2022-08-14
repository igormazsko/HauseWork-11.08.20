// Задача 23. Напишите программу, которая принимает на вход число (N)и выдаёт таблиц кубов чисел от 1 до N.
using static System.Console;
Clear();
Console.WriteLine("Введите число");
double n = Convert.ToDouble(ReadLine());
double i = 1;
while (i <= n)
{
    Write($"{i*i*i} ");
    i++;
}
WriteLine();