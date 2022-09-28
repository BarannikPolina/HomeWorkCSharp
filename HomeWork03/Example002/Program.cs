// Является ли число палиндромом 

int num = 45954;
int[] array = new int[5];
for (int i = 4; i >= 0; i--) 
{
    array[i] = num % 10;
    num = num/10;
}
bool isPolindrom = true;
for(int i = 0; i < 5; i++) 
{
    if(array[i] != array[5-i-1])
{
    isPolindrom=false;
    break;
}
}
    Console.Write( isPolindrom ? "Это полиндром ":" Это не полиндром");