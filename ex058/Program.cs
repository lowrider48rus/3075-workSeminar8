// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

Console.WriteLine("Введи количество строк первой матрицы (m): ");
int m = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введи количество столбцов первой матрицы (n): ");
int n = Int32.Parse(Console.ReadLine());

int[,] matrix1 = new int [m, n];

Console.WriteLine("Введи минимальное значение первой матрицы: ");
int min = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введи максимальное значение первой матрицы: ");
int max = Int32.Parse(Console.ReadLine());

Console.WriteLine();
FillArray(matrix1, min, max);
Console.WriteLine("Сформирована первая матрица");
PrintArray(matrix1);
Console.WriteLine();

Console.WriteLine("Введи количество строк второй матрицы (m): ");
int m2 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введи количество столбцов второй матрицы (n): ");
int n2 = Int32.Parse(Console.ReadLine());

int[,] matrix2 = new int [m2, n2];

Thread.Sleep(100);

Console.WriteLine("Введи минимальное значение второй матрицы: ");
int min2 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введи максимальное значение второй матрицы: ");
int max2 = Int32.Parse(Console.ReadLine());

Console.WriteLine();
FillArray(matrix2, min2, max2);
Console.WriteLine("Сформирована вторая матрица");
PrintArray(matrix2);
Console.WriteLine();

if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
    //int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    int[,] result = multiply(matrix1, matrix2);
    Console.WriteLine("Результат перемножения: ");
    PrintArray(result);
}

else
{
Console.WriteLine("Извините, но матрицы не могут быть перемножены между собой :(");
}


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



int[,] multiply(int[,] matr1, int[,] matr2)
{
    int[,] res = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
           for(int k = 0; k < matr2.GetLength(0); k++)
           {
           res[i, j] += matr1[i, k] * matr2[k, j]; 
           }
        }
}
    return res;
}
