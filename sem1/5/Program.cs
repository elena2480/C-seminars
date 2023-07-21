// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// 5) Напишите программу, которая на вход принимает одно число N(оно может быть отрицательным(!)), а на выходе показывает все целые числа в промежутке от -N до N.



Console.Clear();

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

int i=-1 * Math.Abs(N);
while(i <= Math.Abs(N))
{
   Console.Write($"{i} ");
   i++;
}

