/* Напииште программу, которая принимает на вход 2 числа и проверяет, является ли
одно число квадратом другого. */

Console.Clear();

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

if (num1==num2*num2 || num2==num1*num1) {   //Math.Pow(a,2) это а*а
    Console.WriteLine($"{num1}, {num2} -> да");
}
else {
    Console.WriteLine($"{num1}, {num2} -> нет");
}