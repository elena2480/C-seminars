/* Напишите программу, которая выводит массив элементов,
заполненный нулями и единицами в случайном порядке

int[]  это массив
массив создать в самом методе. его же и вернуть

int a = new Random().Next( 0, 2 )
*/

Console.Clear();
Console.WriteLine("Введите число элементов массива: ");
int a = int.Parse(Console.ReadLine());

int[] array = GetBinArr(a);
Console.WriteLine($"{String.Join("; ", array)}");

int[] GetBinArr(int size) {
    int[] result = new int[size];
    for (int i = 0; i < size; i++){
        result[i] = new Random().Next(2);
    }
    return result;
}
//Console.WriteLine($"Массив случайных нулей и единиц из {a} элементов {GetArr()}"); 

//int GetArr(int n)
//{
//    int[] b;
//  int c = 0; //int num = new Random().Next(10,100)
//    for (int i = 0; i <= (n-1); i++)
//        int b[i] = new Random().Next(0,2);
        //b[i] = c;
//    return b;
//}