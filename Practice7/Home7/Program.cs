// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] matrix = new int[3, 4];

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


for (int i = 0; i < matrix.GetLength(1); i++)
{
    double sum = 0;
    double arifm = 0;

    for (int j = 0; j < matrix.GetLength(0); j++)

    {

        sum += matrix[j, i];
        arifm = sum / matrix.GetLength(0);

    }
    Console.Write($"{Math.Round(arifm, 2) + " "}");

}
