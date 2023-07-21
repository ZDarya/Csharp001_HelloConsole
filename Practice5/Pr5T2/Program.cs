int[] nums = new int[12];

for (int i = 0; i < nums.Length; i++)
{
    nums[i] = new Random().Next(-9, 10);
    Console.Write(nums[i] + " ");
}
Console.WriteLine();
for (int j = 0; j < nums.Length; j++)
{

    nums[j] = nums[j] * -1;

    Console.Write(nums[j] + " ");
}