//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
string Table(int N)
{
    string result = "";
    for(int i=1;i<=N;i++)
    {
        if(i==1) result = Math.Pow(i,3).ToString();
        else result = result + ", " + Math.Pow(i,3).ToString();
    }

    return result;
}

Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Table(N));
