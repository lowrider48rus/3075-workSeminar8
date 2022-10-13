// 2. нужно отсортировать нечетные столбцы массива по возрастанию

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
Console.WriteLine("result");

int[,] result = sortColumn(matrix);

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

int[,] sortColumn(int[,] matr)
{ 
    int[,] res = new int[matr.GetLength(0), matr.GetLength(1)];
    int[] clipboard = new int[matr.GetLength(0)];
    
for (int j = 0; j < matr.GetLength(1); j++)
{
    if(j % 2 == 0){
for (int i = 0; i < matr.GetLength(0); i++)
{
    clipboard[i] = matr[i,j];
}
Array.Sort(clipboard);
        
for (int i = 0; i < matr.GetLength(0); i++)
{
    res[i,j] = clipboard[i];
}
}
else
{
   for (int i = 0; i < matr.GetLength(0); i++)
{
    res[i,j] = matr[i,j];
} 
}
}       
    return res;
    }