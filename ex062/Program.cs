// Напишите программу, которая заполнит спирально массив

Console.WriteLine("Введи количество строк (m): ");
    int row = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Введи количество столбцов (n): ");
    int column = Int32.Parse(Console.ReadLine());
    int[,] array = new int [row, column]; // m=i, n=j
        
    Console.WriteLine("начальный массив: ");
    PrintArray(array);
    int m = 0;
    int n = 0;
    for (int iteration = 0; iteration < array.GetLength(1); iteration++)
        {
        // цикл вправо
    for (int j = n+1; j < array.GetLength(1) - iteration; j++)
    {
        array[m,j] = array[m,j-1]+1;
        n = j;
    }
        // цикл вниз
    for (int i = m+1; i < array.GetLength(0) - iteration; i++)
    {
        array[i,n] = array[i-1,n] + 1;
        m = i;
    }
        // цикл влево
    for (int j = n - 1; j >= iteration; j--)
    {
        array[m, j] = array[m, j+1] + 1;
        n = j;
    }
        //цикл вверх
    for (int i = m -1; i > iteration; i--)
    {
        array[i,n] = array[i+1,n] + 1;
        m = i;
    }
    
    }
        
        
    Console.WriteLine("начинаем заполнять: ");
    PrintArray(array);
    
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

