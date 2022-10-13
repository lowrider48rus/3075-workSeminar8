// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Введи количество строк (m): ");
int m = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введи количество столбцов (n): ");
int n = Int32.Parse(Console.ReadLine());

int[,] matrix = new int [m, n];

Console.WriteLine("Введи минимальное значение: ");
int min = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введи максимальное значение: ");
int max = Int32.Parse(Console.ReadLine());

Console.WriteLine();
FillArray(matrix, min, max);
Console.WriteLine("Сформирован массив");
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine("result");

int[,] result = sortRows(matrix);

PrintArray(result);




void PrintArray(int[,] matr){
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    Console.WriteLine();
    }
}

int[,] sortRows(int[,] matr)
{ 
    int[,] res = new int[matr.GetLength(0), matr.GetLength(1)];
    int[] clipboard = new int[matr.GetLength(1)];
    
for (int i = 0; i < matr.GetLength(0); i++)
{

for (int j = 0; j < matr.GetLength(1); j++)
{
    clipboard[j] = matr[i,j];
}
Array.Sort(clipboard);
Array.Reverse(clipboard);
        
for (int j = 0; j < matr.GetLength(1); j++)
{
    res[i,j] = clipboard[j];
}
}       
    return res;
    }
