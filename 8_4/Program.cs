/* Задача 4*. Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел.
Напишите программу, которая будет построчно выводить массив.
 Обратите внимание, что максимальный размер такого массива ограничен. 
 Проверку эл-та на присутствие в массиве можно вынести в отдельную функцию.
Например,
11 22 78
12 47 96
25 87 88 */

bool CheckExist (int [,] arr, int x)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
           if(x == arr[i,j]) return true;
        }
    }
    return false;
}


void FillArray (int [,] arr)
{
    Random random = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            int x;
            do
            {
                x = random.Next(10, 100);
            }
            while(CheckExist(arr, x));
            arr [i,j] = x;
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

int n = 5;

int [,] array = new int[n,n];
FillArray(array);
PrintArray(array);