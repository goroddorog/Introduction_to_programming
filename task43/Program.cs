// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//-----------не работающий вариант------
// int b1 = 2; int k1 = 5; int b2 = 4; int k2 = 9;
// Console.WriteLine($"{(b2 - b1) / (k1 - k2)}");

// if (k1 == k2)
// {
//     Console.WriteLine($"Прямые параллельны.");
//     return;
// }
// else
// {
//     double x = Convert.ToDouble((b2 - b1) / (k1 - k2));
//     double y = Convert.ToDouble(k1 * x + b1);
//     Console.WriteLine($"Точка пересечения двух прямых: ({x}; {y})");
// }
//--------------------------------------



// Console.WriteLine($"Введите значение b1:");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"Введите значение k1:");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"Введите значение b2:");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"Введите значение k2:");
// double k2 = Convert.ToDouble(Console.ReadLine());

double b1 = 2;
double k1 = 5;
double b2 = 4;
double k2 = 9;

if (k1 == k2)
{
    Console.WriteLine($"Прямые параллельны.");
    return;
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения двух прямых: ({x}; {y})");
}