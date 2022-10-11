// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int [,] arr = {{1, 4, 7 ,2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int flag = 0;
for (int i = 0; i < 3; i++) 
{
    for (int j = 0; j < 4; j++) 
    {
    if (arr[i, j] == N) 
        {
        flag = 1;
        }
    }
}
if (flag==1) 
{
    Console.WriteLine(N);
}
else
    Console.WriteLine("Такого числа в массиве нет");
 
