// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
/*
void Palindom (int num)
{
    int num1 = num;
    int num2;
    int num3=0;
    while(num1>0)
    {
        num2=num1%10;
        num3=num3*10+num2;
        num1=num1/10;
    }
    if (num3==num)
    {
        Console.Write("является палидормом");
    }
    else
    {
        Console.Write("неполидорм");
    }
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Palindom(num);
*/ //задачу выполнил с помощь одногрупников, так как совсем не знал как ее сделать


 // не решено

//Задача 21 Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
/*
Console.Clear();
double Sqrt(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt((x2-x1+z1)*(x2-x1+z1) + (y2-y1+z2)*(y2-y1+z2));
}

Console.WriteLine("введите координату X первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату Y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату Z первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату X второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату Y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату Z второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Sqrt(x1,y1,z1,x2,y2,z2));
*/

//Задача 23 Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
/*
void Sqrt(int N)
{
    int Count = 1;
    Console.Write(N + "->");
    while(Count <= N)
    {
        Console.Write( Count*Count*Count + " ");
        Count++;
    }
}
Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 0)
    Sqrt(num);
else
    Console.Write("ввeдите число");
Sqrt(num); 
*/ //Работает, в программу из урока добавил еще одно знаечение Count 