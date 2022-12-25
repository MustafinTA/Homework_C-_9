// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SumNambers(M, N));

int SumNambers(int num1, int num2)
{
    if (num1 == num2) return num1;
    else if (num1 < num2) return num2 + SumNambers (num1, num2 - 1);
    else return num2 + SumNambers(num1, num2 + 1);
}