int ReadInt(string message)
{
System.Console.Write(message); 
int number = Convert.ToInt32(Console.ReadLine()); 
return number; 
}
int day = ReadInt("Введите номер дня недели -> ");

if (day > 7)
{
    System.Console.WriteLine("Этого дня недели не существует");
}
else if (day ==6 || day ==7)
{
    System.Console.WriteLine("Наконец выходной");
}
else 
{
    System.Console.WriteLine("Опять будний день"); 
}