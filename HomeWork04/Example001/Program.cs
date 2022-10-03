// Задача по теме функции. Продолжение 

int[] array = {9, 12, 11, 15, 10, 11, 11, 12, 11, 14, 9, 16};
for (int i = 0; i < array.Length; i++) 
{
    //System.out.print(array[i] + " ");
}  // System.out.println();
    
int sumIn = 0;
for (int i = 0; i < array.Length; i++) 
{
    if (i%2 == 0) 
    {
    sumIn = sumIn + array [i];
    }
}
int averIn = sumIn/(array.Length/2);
        
int sumOut = 0;
for (int i = 0; i < array.Length; i++) 
{
    if (i%2 != 0) 
    {
    sumOut = sumOut + array [i];
    }
}
int averOut = sumOut/(array.Length/2);

Console.WriteLine(averIn + "-" + averOut);

