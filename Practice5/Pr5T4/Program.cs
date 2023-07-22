// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
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