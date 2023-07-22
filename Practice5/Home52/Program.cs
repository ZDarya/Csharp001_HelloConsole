// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] array = new int[10];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
    Console.Write(array[i] + " ");
}
for (int j = 0; j < array.Length; j = j+2)
{
    sum+=array[j];
}
Console.WriteLine ();
Console.WriteLine ("Сумма равна: " + sum);