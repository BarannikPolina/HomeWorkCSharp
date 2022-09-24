// Напишите программу, которая принимает на вход семь чисел
// и находит их среднее арифметическое 

Console.WriteLine ("Введите семь чисел");
int [] array = new int [7];
for (int i = 0; i < 7; i++) 
{
array[i] = Convert.ToInt32(Console.ReadLine());
}
int sum = 0;
for (int i = 0; i < 7; i++) 
{
sum = sum + array[i];
}
int average = sum/7;
Console.WriteLine("Среднее арифметическое = " + average);
    


