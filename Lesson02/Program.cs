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
Console.Clear();
Console.Write("Введите х: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите y: ");
int y = int.Parse(Console.ReadLine()!);
if (x > 0 && y > 0)
    Console.WriteLine("1");
else if (x < 0 && y > 0)
    Console.WriteLine("2");
else if (x < 0 && y < 0)
    Console.WriteLine("3");
else if (x > 0 && y < 0)
    Console.WriteLine("4");
else
Console.WriteLine("Точка находится на оси координат");