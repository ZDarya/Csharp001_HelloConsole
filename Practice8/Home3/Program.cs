// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] firstMatrix = new int [,] {{2, 4}, {3, 2}};
int[,] secondMatrix = new int [,] {{3, 4}, {3, 3}};
int[,] resultMatrix = new int[2, 2];


// for (int i = 0; i < firstMatrix.GetLength(0); i++)
// {
//     for (int j = 0; j < firstMatrix.GetLength(1); j++)
//     {
//         firstMatrix[i, j] = new Random().Next(0, 10);
//     }
//    }

//    for (int i = 0; i < secondMatrix.GetLength(0); i++)
// {
//     for (int j = 0; j < secondMatrix.GetLength(1); j++)
//     {
//         secondMatrix[i, j] = new Random().Next(0, 10);
//     }
//    }


for (int i = 0; i < firstMatrix.GetLength(0); i++)
{
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        for (int k = 0; k < secondMatrix.GetLength(0); k++)
        {
            resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
        }
        // Console.Write(resultMatrix[i, j] + ", ");
    }
    // Console.WriteLine();
}


void Print(int[,] firstMatrix)
{
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            Console.Write(firstMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Print(firstMatrix);
Console.WriteLine();
Print(secondMatrix);
Console.WriteLine();
Print(resultMatrix);