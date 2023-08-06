// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

int[,,] numbers = new int[2, 2, 2];

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        for (int k = 0; k < numbers.GetLength(2); k++)
        {        
            numbers[i, j, k] = new Random((int)DateTime.Now.Ticks).Next(10, 100);
        }
    }
}

void Print(int[,,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            for (int k = 0; k < numbers.GetLength(2); k++)
            {
            Console.Write($"{numbers[i, j, k]}[{i},{j},{k}] ");
            }
        }
        Console.WriteLine();
    }
}
Print(numbers);