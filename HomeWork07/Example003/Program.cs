// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] arr = {{1, 4, 7 ,2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
float sum1 = 0;
for (int i = 0; i < 3; i++) 
{
for (int j = 0; j < 1; j++) 
    {
    sum1 = sum1+arr[i,j];
    }
}
float aver = sum1/ 3;
Console.WriteLine(aver);

float sum2 = 0;
for (int i = 0; i < 3; i++) 
{
for (int j = 1; j < 2; j++) 
    {
    sum2 = sum2+arr[i,j];
    }
}
float aver2 = sum2/ 3;
Console.WriteLine(aver2);

float sum3 = 0;
for (int i = 0; i < 3; i++) 
{
for (int j = 2; j < 3; j++) 
    {
    sum3 = sum3+arr[i, j];
    }
}
float aver3 = sum3/ 3;
Console.WriteLine(aver3);

float sum4 = 0;
for (int i = 0; i < 3; i++) 
{
for (int j = 3; j < 4; j++) 
    {
    sum4 = sum4+arr[i,j];
    }
}
float aver4 = sum4/ 3;
Console.WriteLine(aver4);

