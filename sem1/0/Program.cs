// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// 0) Напишите программу, которая на вход принимает число и выдает его квадрат
Console.Clear();

Console.Write("Введите число а: ");
int a = int.Parse(Console.ReadLine());
//  Первый метод
int result1 = a * a;
Console.WriteLine($"Способ 1 -> Квадрат числа {a} равен {result1}");
// Второй метод
int result2 = Convert.ToInt32(Math.Pow(a, 2));
Console.WriteLine($"Способ 2 -> Квадрат числа {a} равен {result2}");
