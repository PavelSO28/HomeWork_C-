﻿Console.WriteLine("Введите первое целое число");
string number1 = Console.ReadLine();
Console.WriteLine("Введите второе целое число");
string number2 = Console.ReadLine();
int num1 = Convert.ToInt32(number1);
int num2 = Convert.ToInt32(number2);
if (num1 < num2)
{
    Console.WriteLine($"max = {num2}, min = {num1}");
}
if (num2 < num1)
{
    Console.WriteLine($"max = {num1}, min = {num2}");
}
