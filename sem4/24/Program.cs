// 24. Напишите программу, которая на вход принимает число А 
// и выдаёт сумму чисел от 1 до А

Console.Clear();
Console.Write("ВВедите число: ");
int limit = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел от 1 до {limit} равна {GetSum(limit)}");

int GetSum(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
        sum += i;
    return sum;
}