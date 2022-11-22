Console.WriteLine("Введите два любых числа:");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num = num1 % num2;
int Multiplicity(int num)
{
    return num;

}
int res = Multiplicity(num);
if (res == 0)
{
    Console.WriteLine("Кратно");
}
else
    Console.WriteLine($"не кратно, отстаток равен {res}");