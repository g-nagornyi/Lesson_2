int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка --> {number}");
int firstDigit = number / 10;
int secondDigit = number % 10;

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit > secondDigit) return firstDigit;
    return secondDigit;
}
int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра из числа равна : {maxDigit}");

