// Задача 21 
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координату точки A (x, y, z), x:");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y:");
double y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z:");
double z = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату точки B (x2, y2, z2), x2:");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y:");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z:");
double z2 = Convert.ToDouble(Console.ReadLine());

double s = Math.Sqrt(Math.Pow((x2-x), 2)
                + Math.Pow((y2-y), 2)
                + Math.Pow((z2-z), 2));
s = Math.Round(s, 2);
Console.WriteLine("Расстояние между точками: "+ s);
