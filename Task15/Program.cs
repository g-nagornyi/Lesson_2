// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите любую цифру: ");
// int number = Convert.ToInt32(Console.ReadLine());
// bool DayOfWeek (int num)
// {
//     return num >= 1 && num <=7;
// }
// bool res = DayOfWeek(number);
// if (number < 1 || number > 7 )
// {
//     Console.WriteLine("Такого дня не существует");
// }
// else 
// {
//     string resultStr = res ? "Нет": "Да";
//     Console.WriteLine(resultStr);
// }

Console.WriteLine("Введите любую цифру: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1 && number <= 5)
{
    Console.WriteLine("Нет");
}
else if (number >= 6 && number <= 7)
{
Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Такого дня не существует");
}