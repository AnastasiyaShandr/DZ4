// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void GetSumNums(int num)
{
    int sum = 0;

    while (Math.Abs(num) >= 1)
    {
        sum = sum + num%10;
        num = (num - num%10)/10;
    }
    Console.WriteLine($"Cумма всех цифр в числе: {Math.Abs(sum)}");
}

Console.Write("Введите любое число:");
GetSumNums(Convert.ToInt32(Console.ReadLine()));
