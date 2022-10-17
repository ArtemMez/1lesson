
//Задача 1.
/*

Console.WriteLine("Привет! Давай сравним числа и выведем на экран максимальное из них");
Console.Write("Введите первое число - "); 
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число - ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1>num2)
    Console.WriteLine (num1);
else
    Console.WriteLine (num2);

*/

// Задача 2
/*

Console.WriteLine("Привет! Давай выберем из 3-х чисел максимальное");
Console.Write("Введите первое число - "); 
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число - ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число - ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2>max)
    max = num2;
    if (num3>max)
        max = num3;
        Console.WriteLine (max);
*/

// Задача 3.

/*

Console.WriteLine("Привет! Давай узнаем, четное ли число ты ввел?");
Console.Write("Введите число - "); 
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 % 2 == 0)
    Console.WriteLine ("Число четное");
else
    Console.WriteLine ("Число нечетное");

*/

// Задача 8.

/*

Console.WriteLine("Привет! Давай посмотрим все четные числа в диапозоне твоего числа?");
Console.Write("Введите число - ");
int n = Convert.ToInt32(Console.ReadLine());
int current = 1;
while (current <= n)
{   
    if (current % 2 == 0)
    Console.Write(current + " ");
    current++;
}

*/