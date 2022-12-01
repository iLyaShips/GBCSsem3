// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


void Cube(int x)  // функция вывода квадратов чисел от 1 до N
{
    for (int i = 1; i <= x; i++)
    Console.Write($"{Math.Pow(i, 3)} ");
}

try
{
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    Cube(num);
}
catch
{
    Console.WriteLine("Ошибка! Проверьте вводимое число.");
}