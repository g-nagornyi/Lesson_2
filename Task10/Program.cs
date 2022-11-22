// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите любое трёзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int MiddleDigit(int num)
{
    int secondDigit = num / 10 % 10;
    return secondDigit;
}
int res = MiddleDigit(number);
Console.WriteLine(res);

