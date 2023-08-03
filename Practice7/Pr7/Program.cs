// Двухмерный массив с целыми числами.

// int[,] matrix = new int [3, 4];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 10);
//         }
        
//     }

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }

// Двумерный массив, элементы по формуле находятся по формуле Amn=m+n;

// int[,] matrix = new int [3, 4];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = i+j;
//         }
        
//     }

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }

// Замените четные элементы массива на их квадраты

// int[,] matrix = new int [3, 4];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 10);
//         }
        
//     }

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }

//      for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] % 2 == 0)
//             {
//                 matrix[i, j]*= matrix[i, j];
//             }
//         }
        
//     }
//     Console.WriteLine();
//        for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }

    // Найти сумму элементов, находящихся на главной диагонали массива.

    // int[,] matrix = new int [4, 4];
    // int sum = 0;

    // for (int i = 0; i < matrix.GetLength(0); i++)
    // {
    //     for (int j = 0; j < matrix.GetLength(1); j++)
    //     {
    //         matrix[i, j] = new Random().Next(1, 10);
    //     }
        
    // }

    // for (int i = 0; i < matrix.GetLength(0); i++)
    // {
    //     for (int j = 0; j < matrix.GetLength(1); j++)
    //     {
    //         Console.Write(matrix[i, j] + " ");
    //     }
    //     Console.WriteLine();
    // }

    //  for (int i = 0; i < matrix.GetLength(0); i++)
    // {
    //     for (int j = 0; j < matrix.GetLength(1); j++)
    //     {
    //         if (i == j)
    //         {
    //             sum+= matrix[i, j];
    //         }
    //     }
        
    // }
    // Console.WriteLine(sum);

// Поменять местами 1 и 3 строки массива

 int[,] matrix = new int [4, 4];
 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
        
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }

     for (int i = 0; i < matrix.GetLength(1); i++)
    {
                {
            int temp = matrix[0, i];
            matrix [0, i] = matrix[matrix.GetLength(0) - 1, i];
            matrix[matrix.GetLength(0) - 1, i] = temp;

        }
           }

Console.WriteLine();

     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }


