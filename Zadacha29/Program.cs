// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}

Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Обозначьте диапазон чисел, входящих в массив: от ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("до ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"[{String.Join(", ", GetArray(n, a, b))}]");