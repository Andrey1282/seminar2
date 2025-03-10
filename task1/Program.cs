// Напишите программу, которая принимает на вход трехзначное число 
// и удаляет вторую цифру этого числа.
// Пример
// a = 256 =>26
// a = 891 =>81

Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a >= 100 && a <= 999)
{
    int digit1 = a / 100;
    int digit3 = a % 10;
    int result = digit1 * 10 + digit3;
//Console.Write($"{digit1}{digit3}");
Console.WriteLine(result);
}
else
{
    Console.Write("Некоректный ввод!");
}
