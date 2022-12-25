// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine($"Введите начальное значение:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите конечное значение:");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
SumNumInterval(M, N);
Console.WriteLine($"Сумма чисел: {sum}");


int SumNumInterval(int Mm, int Nn)
{
    // Console.Write($"{num}, ");
    sum += Nn;
    if (Nn == Mm) return (Nn);
    return SumNumInterval(Mm, Nn -1);
}
