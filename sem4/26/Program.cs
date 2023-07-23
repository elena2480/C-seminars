// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе

// 456 -> 3
// 78 -> 2
//  89126 -> 5



Console.Clear();
Console.Write("ВВедите число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество цифр в числе {a} равно {GetQuantity(a)}");

int GetQuantity(int n)
{   int quan = 0;
    if (n == 0) return 1;
    int num = Math.Abs(n);
    while (num > 0)    
    {
        num = num/10;
        quan ++;
    }     
    return quan;
}