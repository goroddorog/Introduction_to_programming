// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine($"Введите первое неотрицательное значение:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите второе неотрицательное  значение:");
int m = Convert.ToInt32(Console.ReadLine());
// int n = 2;
// int m = 3;
Console.WriteLine($"A(n,m) = {ack(n, m)}");


int ack(int n, int m)
{
    while (n != 0)
    {
        if (m == 0) m = 1;
        else m = ack(n, m - 1);
        n = n - 1;
    }
    return (m + 1);
}

// int ack(int n, int m)
// {
//   if (n == 0)
//     return m + 1;
//   else
//     if ((n != 0) && (m == 0))
//       return ack(n - 1, 1);
//     else
//       return ack(n - 1, ack(n, m - 1));
// }