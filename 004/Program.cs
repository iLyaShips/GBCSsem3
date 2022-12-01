// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в N-мерном пространстве. 
// Сначала задается N с клавиатуры, потом задаются координаты точек.

double FindLen(int[] A, int[] B, int n) //функция расчета расстояния в N -мерном пространстве
{
    double sum = 0;
    for (int i = 0; i <= n - 1; i++)
    {
        sum += Math.Pow(A[i] - B[i], 2); //расчет суммы квадратов разности координат двух точек
    }
    double res = Math.Sqrt(sum); //расчет квадратного корня из sum
    return res;
}
try
{
    Console.WriteLine("введите размерность пространства:");
    int n = Convert.ToInt32(Console.ReadLine()); //N - размерность пространства
    Console.WriteLine("введите координаты точки A");
    int[] A = new int[n];
    for (int i = 0; i <= n - 1; i++)
        A[i] = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите координаты точки B");
    int[] B = new int[n];
    for (int i = 0; i <= n - 1; i++)
        B[i] = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Расстояние между точками равно : " + FindLen(A, B, n).ToString("F" + 2)); //вызов функции с ограничениев цифр после запятой
}
catch
{
    Console.WriteLine("Ошибка! Проверь вводимые данные.");
}
