// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.Write("Введите число - основание степени: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число - показатель степени: ");
// int B = Convert.ToInt32(Console.ReadLine());
// while (B > 0)
// {
//     Console.WriteLine($"Результат возведения числа А в степень В: {Math.Pow(A, B)}");
//     break;
// }



// Решение цикл

// Console.Write("Введите число A - основание степени: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B - показатель степени: ");
// int B = Convert.ToInt32(Console.ReadLine());

// if (B > 0)
// {
//     int result = 1;
//     for (int count = 1; count <= B; count++)
//     {
//         result = result * A;
//     }
//     Console.WriteLine($"Результат возведения числа A в степень B: {result}");
// }
// else
// {
//     Console.WriteLine($"Результат неопределен, введите B > 0 ");
// }



// Решение функция

int GetDegree(int number, int degree)
{
    int result = 1;
    for (int count = 1; count <= degree; count++)
    {
        result = result * number;
    }
    return result;
}
Console.Write("Введите число A - основание степени: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B - показатель степени: ");
int B = Convert.ToInt32(Console.ReadLine());
if (B > 0)
{
    Console.WriteLine($"Результат возведения числа A в степень B = {GetDegree(A, B)}");
}
else
{
   Console.WriteLine($"Результат неопределен, введите B > 0 "); 
}