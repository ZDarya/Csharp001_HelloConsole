int[] numbers = new int[10];
int t = 0;

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(0, 151);
    Console.Write(numbers[i] + " ");
}

for (int j = 0; j < numbers.Length; j++)
{
    if (numbers[j] > 10 && numbers[j] < 100)
    {
        t += 1;
    }
}
Console.WriteLine();
Console.Write($"Общее количество чисел в данном диапозоне {t}");