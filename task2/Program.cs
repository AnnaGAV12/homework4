// Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива
int[] arr = new int[12];
int sumPos = 0;
int sumOtr = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-9, 10);
    Console.Write($"{arr[i]} ");
    if (arr[i] > 0) 
    {
        sumPos = sumPos + arr[i];
    }
    else if (arr[i] < 0) 
    {
        sumOtr = sumOtr + arr[i];
    } 
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов массива = {sumPos}");
Console.WriteLine($"Сумма отрицательных элементов массива = {sumOtr}");
