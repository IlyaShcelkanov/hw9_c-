// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int Sum(int M, int N)
{
    if (M == N) return N;
    return Sum(M + 1, N) + M;
}
Console.Write("Введите M = ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите N = ");
int N = int.Parse(Console.ReadLine()!);
Console.Write(Sum(M, N));