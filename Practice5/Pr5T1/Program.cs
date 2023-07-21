// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
int[] array1 = new int[12];
int sum_pos = 0;
int sum_neg = 0;
for (int i = 0; i < array1.Length; i++)
{
   array1[i] = new Random().Next(-9,10);
   Console.Write(array1[i] + " ");


if(array1[i]>0)
{
    sum_pos+=array1[i];
}
else
{
    sum_neg+=array1[i];
    }
}
Console.WriteLine ("Сумма положительных чисел:" + sum_pos);
Console.WriteLine ("Сумма отрицательных чисел:" + sum_neg);