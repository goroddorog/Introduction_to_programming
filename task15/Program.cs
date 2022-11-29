// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите номер дня недели:");
int day = Convert.ToInt32(Console.ReadLine());
switch (day)
{
    case 1: case 2: case 3: case 4: case 5:
        Console.Write("будний день");
        break;
    case 6: case 7:
        Console.Write("выходной день");
        break;

    default:
        Console.Write("неверный номер");
        break;
}
