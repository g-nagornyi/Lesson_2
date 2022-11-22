Console.Write("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
bool MultiplicityTwoDigits (int num) 
{
    return num % 7 == 0 && num % 23 == 0;
        
}
bool result = MultiplicityTwoDigits(number);
string resultStr = result ? "Да": "Нет";
Console.WriteLine($"{number} --> {resultStr}");