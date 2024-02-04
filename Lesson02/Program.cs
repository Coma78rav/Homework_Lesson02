// Задача 1:
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// Console.Clear();
// Console.Write("Введите число для проверки: ");
// int n = int.Parse(Console.ReadLine()!);
// if (n % 7 == 0 && n % 23 ==0)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine($"no");

// Задача 2:
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.
// Console.Clear();
// Console.Write("Введите х: ");
// int x = int.Parse(Console.ReadLine()!);
// Console.Write("Введите y: ");
// int y = int.Parse(Console.ReadLine()!);
// if (x > 0 && y > 0)
//     Console.WriteLine("1");
// else if (x < 0 && y > 0)
//     Console.WriteLine("2");
// else if (x < 0 && y < 0)
//     Console.WriteLine("3");
// else if (x > 0 && y < 0)
//     Console.WriteLine("4");
// else
// Console.WriteLine("Точка находится на оси координат");

// Задача 3: 
// Напишите программу, которая принимает на вход целое число из отрезка [10, 99]
// и показывает наибольшую цифру числа.
// Console.Clear();
// Console.Write("Введите число от 10 до 100: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// int maxDigit = firstDigit;
// if (secondDigit > maxDigit)
//     maxDigit = secondDigit;
// Console.WriteLine(maxDigit);

// Задача 4: 
// Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.
Console.Clear();
Console.Write("Введите натуральное число: ");
int n = int.Parse(Console.ReadLine()!);
if (n < 10)
    Console.WriteLine(n);
else{
for(int i = (int)Math.Ceiling(Math.Log(n, 10)) - 1; i >= 0; i--) {
    Console.Write((n / (int)Math.Pow(10, i)) % 10);
    if (i == 0)
        Console.Write("\n");
    else
        Console.Write(",");
}
}