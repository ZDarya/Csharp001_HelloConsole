// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите несколько чисел через пробел и нажмите Enter");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
    count++;
    }
}
Console.WriteLine($"Количество элементов > 0: {count}");