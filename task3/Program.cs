// Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел
int[] arr = new int[5];
int index1=0; // для нечетных чисел
int index2=0; //для четных чисел
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(100, 1000);
    Console.Write($"{arr[i]} ");
    if (arr[i] % 2 == 0) index1++;
    else index2++;
}
Console.WriteLine();
Console.WriteLine($"Количество четных чисел = {index1}");
Console.WriteLine($"Количество нечетных чисел = {index2}");
