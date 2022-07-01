// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
int[] InputCoordinates()
{
    int[] result = new int[3];
    Console.WriteLine("Введите координату X точки");
    result[0] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату Y точки");
    result[1] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату Z точки");
    result[2] = Convert.ToInt32(Console.ReadLine());

    return result;
}

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

int [] A = InputCoordinates();
int [] B = InputCoordinates();

Console.WriteLine("Расстояние между точками A и B - " + distance(A, B));