Console.WriteLine("Введите первое целое число");
string number1 = Console.ReadLine();
Console.WriteLine("Введите второе целое число");
string number2 = Console.ReadLine();
Console.WriteLine("Введите третье целое число");
string number3 = Console.ReadLine();

int num1 = Convert.ToInt32(number1);
int num2 = Convert.ToInt32(number2);
int num3 = Convert.ToInt32(number3);
int max = num1;
if (num1 > max)
{
    Console.WriteLine($"max = {num1}");
}
else if (num2 > max)
{
    Console.WriteLine($"max = {num2}");
}
if (num3 > max)
{
    Console.WriteLine($"max = {num3}");
}
