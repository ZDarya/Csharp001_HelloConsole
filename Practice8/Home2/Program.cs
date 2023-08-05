// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] numbers = new int[4, 4];
int minsum = Int32.MaxValue;
int indexLine = 0;

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = new Random().Next(0, 10);
    }
}

void Print(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Print(numbers);
Console.WriteLine();

for (int i = 0; i < numbers.GetLength(0); i++)
{
    int sum = 0;
   
    for (int j = 0; j < numbers.GetLength(1); j++)

    {

        sum += numbers[i, j];
        
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
    Console.Write($"{sum + " "}");
    
    }
    Console.WriteLine();
    Console.WriteLine(minsum);