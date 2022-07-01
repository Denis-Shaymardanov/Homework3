// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
using System; 

double distance(int[] A, int[] B)
{
    double result = 0;
    for(int i=0; i<3; i++)
    {  
        result = result + Math.Pow(B[i]-A[i],2);
    }
    result = Math.Sqrt(result);

    return result;
}

int [] A = new int[3];
int [] B = new int[3];

Console.WriteLine("Введите координату X первой точки");
A[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки");
A[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки");
A[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X второй точки");
B[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки");
B[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки");
B[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Расстояние между точками A и B - " + distance(A, B));