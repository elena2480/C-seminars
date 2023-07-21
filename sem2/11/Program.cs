// 11 Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46

//  782 -> 72

// 918 -> 98

Console.Clear();
int num = new Random().Next(100,1000);
int num1 = num / 100;


int num3 = num % 10;
Console.WriteLine($"{num}  без второй цифры -> {num1}{num3}");
//совсем математический способ
int result = (num / 100) * 10 + num %10;
Console.WriteLine($"{num} -> {result}");
Console.WriteLine($"{num} -> {result} -> {num / 10 % 10}");

// у Кирилла короче:
// без лишних переменных просто в выводе 
Console.WriteLine($"{num} -> {num/100}{num%10}");


