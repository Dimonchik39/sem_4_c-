// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.WriteLine("Введите число: ");
int dig = Convert.ToInt32(Console.ReadLine());

int Quantity(int dig1)

{
    int i;
    for (i = 0; dig1 > 0; i++)
    {
        dig1 = dig1 / 10;
    }
    return i;
}

int Quantity1 = Quantity(dig);
Console.WriteLine($"В числе {dig} содержится {Quantity1} цифр(ы)");

//Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int CountDigits(int num)
// {
//     if (num != 0)
//     {
//         if (num < 0) num = -num;
//         int count = default;
//         while (num > 0)
//     {
//         num = num / 10;
//         count++;
//     }
//         return count;
//     }
//         return 1;
// }

// int result = CountDigits(number);
// Console.WriteLine(result);