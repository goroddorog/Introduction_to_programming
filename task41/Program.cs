// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Сколько чисел хотите ввести:");
int M = Convert.ToInt32(Console.ReadLine());
int[] numbers =  new int[M];
int count = 0;
for (int i = 0; i < M; i++)
{
    Console.WriteLine($"Введите {i+1} значение:");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    if (numbers[i] > 0) {count++;}
}
System.Console.WriteLine($"Чисел больше нуля: {count}");