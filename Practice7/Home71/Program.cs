// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


double[,] matrix = new double [4, 4];
Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 100) + rand.NextDouble();;
        }
        
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(matrix[i, j],2) + " "}");
        }
        Console.WriteLine();
    }