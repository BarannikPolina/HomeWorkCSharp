// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.

Console.WriteLine("Введите 12 случайных вещественных чисел");
int [,] array = new int[3, 4];
for (int i = 0; i < 3; i++) 
{
    Console.WriteLine();
    for (int j = 0; j < 4; j++) 
    {
    array[i, j] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(array[i, j] + " ");
    }
}