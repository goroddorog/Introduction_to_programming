// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int save_num = number;
int revers_num = 0;
int last_num = 0;
while (number>0)
{
    last_num = number % 10;
    revers_num = revers_num * 10 + last_num;
    //Console.WriteLine(revers_num);
    number = number/10;
}

if (save_num == revers_num) Console.WriteLine("число является палиндромом");
else Console.WriteLine("число не палиндром");
