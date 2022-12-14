// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

minSum(matrix);


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

void minSum(int[,] matr)
{
    int[] result = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
           result[i] +=matr[i, j]; 
        }
}
    int min = result[0];
    int minPos = 0;
    for(int i = 0; i < result.Length; i++)
    {
       if (result[i] < min)
       {
       min = result[i];
       minPos = i;
       }
    }

    Console.WriteLine($"Минимальная сумма элементов в строке: {min}, номер строки (по-нормальному, не с 0): {minPos+1}");

}
