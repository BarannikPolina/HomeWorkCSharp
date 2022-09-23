// Напишите программу, которая принимает на вход трехзначное число 
// и на выходе показывает вторую цифру этого числа 

Console.WriteLine("Введите любое трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
int b = a%100;
int c = b/10;
c = Math.Abs(c);
Console.WriteLine("Вторая цифра числа = " + c);
