﻿/* 12 Напишите программу, которая будет принимать на вход 2 числа и выводить,
является ли второе число кратным первому. Если второе число не кратно первому числу,
то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/
Console.Clear();

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if(b%a==0)
{
    Console.WriteLine($"{b} кратно {a}");
}
else
{
    Console.WriteLine($"{b} не кратно {a}, остаток {b%a}");
}