// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
int[] numbers = new int[8];

for (int i = 0; i < 8; i++)
{
    numbers[i] = new Random().Next(0, 2);
}

for (int i = 0; i < 8; i++)
{
    Console.Write(numbers[i] + " ");
}