/* Задача 3: Задайте две квадратные матрицы одинакового размера.
 Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица:
18 20
15 18 */

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


int n = 3;

int [,] array1 = new int[n,n];
FillArray(array1);
PrintArray(array1);
int [,] array2 = new int[n,n];
FillArray(array2);
PrintArray(array2);

int [,] result = new int[n,n];
for(int i=0; i < n; i++)
{
    for(int j=0; j < n; j++)
    {
        // рассчитаем result [i,j]
        for(int k=0; k < n; k++)
        {
            result[i,j] = result[i,j] + array1[i,k]*array2[k,j];
        }
    }
}
PrintArray(result);