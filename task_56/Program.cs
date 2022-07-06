/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
строку с наименьшей суммой элементов.
Исходный массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Результат:
1-строка
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

WriteLine($"{MinRow(mainArray)} строка с наименьшей суммой элементов");


int MinRow(int [,] array)
{
    int [] sumarray = new int[array.GetLength(0)];
    for (int i=0; i<array.GetLength(0); i++)
    {
        int [] arr = new int [array.GetLength(1)];
        for (int j=0; j<array.GetLength(1); j++)
        {
            arr [j]=array[i,j];
        }
        sumarray [i] = arr.Sum();
    }
    int row=0;
    for(int i=1; i<sumarray.Length; i++)
    {
        if(sumarray[row]>sumarray[i]) row=i;
    }
    row+=1;
    return row;
}