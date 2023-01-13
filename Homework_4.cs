// // Напишите цикл, который принимает на вход два числа (A и B) и 
// //возводит число A в натуральную степень B.

Console.WriteLine("Введите основание степени: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите показатель степени: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{A} в степени {B} равно {Expo(A, B)}");

int Expo (int bas, int degree)
{
    int Product = 1;
    for (int i = 1; i <= degree; i++)
    {
        Product = Product * bas;
    }
    return Product;
}

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число:");
string num = (Console.ReadLine()!);
int size = GetSize(num);
int[] Array = FillArray(size);
Console.WriteLine($"Сумма цифр числа {num} равна {Sum(Array)}");

// ---------------Methods---------
int GetSize (string num)
{
    int size = num.Length;
    return size;
}

int[] FillArray (int size)
// int[] Array = n.ToString().Select(x => x - '0').ToArray();
{   
    int[] Digits = new int[size];
    for (int i = 0; i < size; i++)
    {
        Digits[i] = int.Parse((num[i]).ToString());
    }
    return Digits;
}
// System.Console.WriteLine($"[{String.Join(";", Digits)}]");

int Sum (int[] Array)
{
    int Sum = 0;
    for(int i = 0; i < size; i++)
    {
        Sum = Sum + Array[i];
    }
    return Sum;
}

//Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран. (числа берете любые)

int[] Array = GetArray(8);
PrintArray (Array);

//-------------Methods------------

int[] GetArray (int size)
{
    int[] Array2 = new int[size];
    for(int i = 0; i < size; i++)
    {
        Array2[i] = new Random().Next(1000);
    }
    return Array2;
}

void PrintArray (int[] Array)
{
    for(int i = 0; i < Array.Length; i++)
    {
    Console.Write($"{Array[i]} ");
    }
}



