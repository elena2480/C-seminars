/* Напишите программу, которая принимает на вход число N
и выдаёт произведение чисел от 1 до N

4=> 24
5-> 120
*/

Console.Clear();
Console.Write("ВВедите число N: ");
int limit = int.Parse(Console.ReadLine());
Console.WriteLine($"Факториал числа {limit} равен {GetFact(limit)}");

int GetFact(int n)
{
    int sum = 1;
    for (int i = 2; i <= n; i++)
        sum *= i;
 
   return sum;
}