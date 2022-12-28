/* Задача 1: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

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


Console.Write("Число строк массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Число столбцов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [,] array = new int[n,m];
FillArray(array);
PrintArray(array);

for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int k = 0; k < array.GetLength(1)-1; k++)
        {
            if(array[i,k] < array[i,k+1])
            {
                int temp = array[i,k];
                array[i,k] = array[i,k+1];
                array[i,k+1] = temp;
            }
        }
    }
}

PrintArray(array);