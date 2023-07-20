// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while(index < length)
//     {
//         collection[index] = new Random().Next(1, 100);
//         index++;
//     }
// }
// void PrintArray(int[] col)
// {
// int count = col.Length;
// int position = 0;
// while(position < count)
// {
//     Console.Write(col[position] + " ");
//     position++;
// }
// }

// int[] array = new int[8];
// FillArray(array);
// PrintArray(array);

Console.Write("Введите  число элементов массива ");
int N = Convert.ToInt32(Console.ReadLine());

int size = N;
int [] a =  new int[size];

for (int i = 0; i < a.Length; i++)
{
    a [i] = new Random().Next(0,100);
    Console.Write(a[i] + " ");
}
