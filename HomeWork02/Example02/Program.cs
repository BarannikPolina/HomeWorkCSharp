// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру, обозначающую день недели");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 && day < 6) 
{
Console.WriteLine ("Это рабочий день");
}
else if (day >= 6 && day < 8) 
{
Console.WriteLine ("Это выходной день");
}
else
{
Console.WriteLine ("Нет такого дня недели");   
}


