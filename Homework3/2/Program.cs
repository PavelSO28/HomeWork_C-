// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int number = ReadInt("Введите число: ");
for (int i = 1; i <= number; i++)
{  
    System.Console.WriteLine($"{i * i * i}");    
} 



    
  

