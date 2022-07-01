//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
string IsPalindrom(int number)
{
    string result = "Нет";
    int[] d = new int[5];

    for(int i = 0; i<d.Length; i++)
    {
        d[i] = number%10;
        number = number/10;
    }

    if ((d[0]==d[4])&&(d[1]==d[3])) result = "Да";

    return result;
}

bool numIsCorrect(int number)
{
    bool result = (number > 9999) && (number < 100000);
    return result;
}

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (numIsCorrect(num)) Console.WriteLine("Это палиндром - " + IsPalindrom(num));
else Console.WriteLine("Вы ввели некорректное число");

