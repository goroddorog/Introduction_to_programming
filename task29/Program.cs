// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int ReadArray(int count)
// {
//     int[] array = new int[count];
//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine($"Введите значение {i+1} элемента массива:");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void WriteArray(int count, int[] array)
// {
//     Console.Write("Массив: ");
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write(array[i]);
//     }
// }


// Console.WriteLine("Введите количество элементов массива:");
// int count = Convert.ToInt32(Console.ReadLine());

// int[] array = ReadArray(count);
// WriteArray(count, array);


Console.WriteLine("Введите количество элементов массива:");
int count = Convert.ToInt32(Console.ReadLine());

int[] array = new int[count];
for (int i = 0; i < count; i++)
{
    Console.WriteLine($"Введите значение {i+1} элемента массива:");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Массив:");
for (int i = 0; i < count; i++)
{
    Console.Write($" {array[i]}");
}

