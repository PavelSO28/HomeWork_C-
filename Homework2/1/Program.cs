// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. Не использовать строки
// 456 -> 5
// 782 -> 8
// 918 -> 1

/* 
Функция вводит целое значение из консоли
*/
int ReadInt(string message)
{
System.Console.Write(message); 
int number = Convert.ToInt32(Console.ReadLine()); 
return number; 
}
int num = ReadInt("Введите 3-х значное число -> ");
if (num < 100 || num >= 1000)
{
System.Console.WriteLine("Число не 3-х значное");
}
else
{
int digit = num / 10 % 10;
System.Console.WriteLine($"Вторая цифра числа равна {digit}");
}