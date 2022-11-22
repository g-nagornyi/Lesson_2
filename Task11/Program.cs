int number = new Random().Next(100,1000);
Console.WriteLine($"Случайное трёхзначное число из отрезка --> {number}");
int MinusMiddle(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int result = firstDigit*10 + thirdDigit;
    return result;
}
int res = MinusMiddle(number);
Console.WriteLine(res);
