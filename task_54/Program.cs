/*
Задача 54.** Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Исходный массив:
1 4 7 2
5 9 2 3
8 4 2 4
*/

using static System.Console;
using MyLib;
using System.Linq;

Clear();
WriteLine("Введите размер матрицы через пробел: ");
string[] sizeS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int m = int.Parse(sizeS[0]);
int n = int.Parse(sizeS[1]);
int[,] mainArray =Ex.GetArray(m, n);
Ex.PrintArray(mainArray);
ArrangeRow (mainArray);
WriteLine("=========");
Ex.PrintArray(mainArray);




void ArrangeRow (int [,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        int [] arr = new int [array.GetLength(1)];
        for (int j=0; j<array.GetLength(1); j++)
        {
            arr [j]=array[i,j];
        }
        arr=arr.OrderBy(x => x).ToArray;
        for (int j=0; j<array.GetLength(1); j++)
        {
            array[i,j]=arr[j];
        }
    }
}