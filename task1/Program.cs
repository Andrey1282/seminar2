﻿Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a >= 99 && a <= 99)
{
int digit1 = a/100;
int digit3 = a%10;
Console.Write(digit1+digit3);
}
else
{
    Console.Write("Ошибка! Это не трехзначное число!");
}
