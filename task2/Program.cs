// Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива
int[] arr = new int[12]; //Первая часть задания
int sumPos = 0;
int sumOtr = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 10);
    Console.Write($"{arr[i]} ");
    sumPos = sumPos + arr[i];
}
void change(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        arr[i] = -arr[i];
        Console.Write($"{arr[i]} ");
        sumOtr = sumOtr + arr[i];
    }
}

Console.WriteLine($"Сумма положительных элементов массива равна {sumPos}");
change(arr);
Console.WriteLine($"Сумма отрицательных элементов массива равна {sumOtr}");