// Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int[] arr = { 12, 50, 10, 3, 7 };
void PrintArray(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);
Console.WriteLine($"Произведение первого и последнего элемента = {arr[0] * arr[4]}");
Console.WriteLine($"Произведение второго и предпоследнего элемента = {arr[1] * arr[3]}");