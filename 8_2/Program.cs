/* Задача 2: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

void FillArray (int [,] arr)
{
    Random random = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr [i,j] = random.Next(1, 10);
        }
    }
}

void PrintArray (int [,] arr)
{
    for(int i=0; i < arr.GetLength(0); i++)
    {
        for(int j=0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int [,] array = new int[5,4];
int [] su = new int[5];
FillArray (array);
PrintArray (array);


for(int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i,j];
    }
    su [i] = sum;
    Console.Write(su[i] + " ");
      
}
int minPosition = 0;
for(int j = 0; j < su.Length; j++)
{
    if(su[j]<su[minPosition]) minPosition=j;
}
Console.WriteLine();
Console.WriteLine(minPosition +1 + " строка");
