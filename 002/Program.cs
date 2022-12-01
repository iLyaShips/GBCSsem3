// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double FindLen(int[] A, int[] B) //функция расчета расстояния в 3D пространстве
{
    double res = Math.Sqrt(Math.Pow(A[0] - B[0], 2) + Math.Pow(A[1] - B[1], 2) + Math.Pow(A[2] - B[2], 2));
    return res;
}
try
{
    Console.WriteLine("введите координаты точки A");
    int[] A = new int[3];
    for (int i = 0; i <= 2; i++)
        A[i] = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите координаты точки B");
    int[] B = new int[3];
    for (int i = 0; i <= 2; i++)
        B[i] = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Расстояние между точками равно : " + FindLen(A, B).ToString("F" + 2)); //вызов функции с ограничениев цифр после запятой
}
catch
{
    Console.WriteLine("Ошибка! Проверь вводимые данные.");
}
