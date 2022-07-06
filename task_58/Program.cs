/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение
двух матриц.
*/

using static System.Console;
using MyLib;
using System.Linq;

Clear();
WriteLine("Введите размер матрицы А через пробел: ");
string[] sizeA = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int mA = int.Parse(sizeA[0]);
int nA = int.Parse(sizeA[1]);
int[,] array_A =Ex.GetArray(mA, nA, 0, 5);

Clear();
WriteLine("Введите размер матрицы B через пробел: ");
string[] sizeB = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int mB = int.Parse(sizeB[0]);
int nB = int.Parse(sizeB[1]);
int[,] array_B =Ex.GetArray(mB, nB, 0, 5);
Clear();
Ex.PrintArray(array_A);
WriteLine("=========");
Ex.PrintArray(array_B);
WriteLine("Произведение мартиц А и В рано:");
Ex.PrintArray(CompositionArr(array_A, array_B));




int [,] CompositionArr(int [,] arrA, int [,] arrB)
{
   
     int [,] result=new int[arrA.GetLength(0),arrB.GetLength(1)];
    for(int i=0; i<result.GetLength(0); i++)
    {
        for(int j=0; j<result.GetLength(1); j++)
        {
            result[i,j]=array(arrA, arrB, i, j).Sum();
        }
    }
    return result;
}

int [] array(int [,] arrA, int [,] arrB, int k, int j)
{
    int [] result=new int[arrA.GetLength(0)];
    for(int i=0; i<result.Length; i++)
    {
        result[i]=arrA[i,k]*arrB[j,i];
    }
    return result;
}