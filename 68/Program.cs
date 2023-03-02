// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkermanFunction(int a, int b)
{
    if (a == 0) return b + 1;
    if (b == 0) return AkkermanFunction(a - 1, 1);
    return AkkermanFunction(a - 1, AkkermanFunction(a, b-1));
}


Console.Write("Введите M = ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите N = ");
int N = int.Parse(Console.ReadLine()!);
Console.Write(AkkermanFunction(M, N));