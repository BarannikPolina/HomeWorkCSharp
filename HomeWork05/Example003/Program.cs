// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double [] array = {-1.1, -1, 2.5, 6.4, 0, -2.55, 54.1, -78, 4.8};
for (int i = 0; i < array.Length; i++) 
{

}
double max = 0;
for (int i = 0; i < array.Length; i++) 
{
    if (max < array [i]) 
    {
    max = array [i];
    }
}


double min = 0;
for (int i = 0; i < array.Length; i++) 
{
    if (min > array [i]) 
    {
    min = array [i];
    }
}


Console.WriteLine(max-min);
