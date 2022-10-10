// Задача № 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь


Console.WriteLine("Введите числа");
String str = Console.ReadLine();
String [] arrFromString = str.Split(" ");
for (int i = 0 ;  i < arrFromString.Length; i++) 
{

}

int count = 0;
int [] arr = new int [arrFromString.Length];
for (int i = 0; i < arrFromString.Length; i++) 
{
    arr [i] = Int32.Parse(arrFromString[i]);
    if (arr[i] > 0) 
    {
        count++;
    }
}
Console.WriteLine(count);
    
