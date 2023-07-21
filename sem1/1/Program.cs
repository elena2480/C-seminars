// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// 1) Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго



Console.Clear();

Console.Write("Введите число а: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
if(b*b == a) 
{
    Console.WriteLine($"Да, число {a} является квадратом числа {b}");
}
else
{
    Console.WriteLine($"Нет, число {a} не является квадратом числа {b}");
}

