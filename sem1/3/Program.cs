// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// 3) напишите программу, которая будет выдавать название дня недели по заданному номеру



Console.Clear();

Console.Write("Введите номер дня недели: ");
int a = int.Parse(Console.ReadLine());

if(a<1 || a>7)
{
    Console.WriteLine($"Номера дня недели {a} не существует");
    return;
}

if(a==1)
{
     Console.WriteLine($"Номер {a} соответствует дню недели ПОНЕДЕЛЬНИК");
}

if(a==2)
{
     Console.WriteLine($"Номер {a} соответствует дню недели ВТОРНИК");
}

if(a==3)
{
     Console.WriteLine($"Номер {a} соответствует дню недели СРЕДА");
}

if(a==4)
{
     Console.WriteLine($"{a} -> ЧЕТВЕРГ");
}

if(a==5)
{
     Console.WriteLine($"Номер {a} соответствует дню недели ПЯТНИЦА");
}

if(a==6)
{
     Console.WriteLine($"Номер {a} соответствует дню недели СУББОТА");
}

if(a==7)
{
     Console.WriteLine($"Номер {a} соответствует дню недели ВОСКРЕСЕНЬЕ");
}

