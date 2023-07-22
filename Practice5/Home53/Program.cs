// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] array = new double[10];
Random rand = new Random();
double max = 0;
double min = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 100) + rand.NextDouble();
    Console.Write(array[i] + " ");
    if (array[i]>max)
    {
        max = array[i];
        min = max;
    }
    if (array[i]<min)
    {
        min = array[i];
    }
}
    double diff = max - min;
    Console.WriteLine();
    Console.WriteLine("Максимальное " + max);
    Console.WriteLine();
    Console.WriteLine("Минимальное " + min);
    Console.WriteLine();
    Console.WriteLine("Разница " + diff);