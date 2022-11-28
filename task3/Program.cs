// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите значение а:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение c:");
int c = Convert.ToInt32(Console.ReadLine());

if (a >= b && a >= c)
{
    Console.WriteLine("max = " + a);
}
else
if (b > a && b >= c)
{
    Console.WriteLine("max = " + b);
}
else
{
    Console.WriteLine("max = " + c);
}