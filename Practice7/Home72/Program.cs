// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("С какой позиции вам вывести значение? Введите номер строки и столбца");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[4, 4];

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

Console.WriteLine();

 if (n > matrix.GetLength(0) || m > matrix.GetLength(1))
        {
        Console.WriteLine("Такого элемента нет");
        }
        else
        {
        Console.WriteLine($"Значение элемента {n} строки и {m} столбца равно {matrix[n-1,m-1]}");
        }