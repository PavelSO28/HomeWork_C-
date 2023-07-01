﻿// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4-> 16

int enterNumberA, enterNumberB;

Console.WriteLine("Для формулы A^B");
Console.Write("Введите число A: ");
enterNumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
enterNumberB = Convert.ToInt32(Console.ReadLine());

int result = enterNumberA;

for (int i = 2; i <= enterNumberB; i++)
{
    result *= enterNumberA;
}

Console.WriteLine($"{enterNumberA}^{enterNumberB} = {result}");
