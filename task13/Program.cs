// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    string num_to_str = Convert.ToString(number);
    Console.WriteLine(num_to_str[2]);
}
else Console.WriteLine("третьей цифры нет");