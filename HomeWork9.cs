/*//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void ShowNumbers(int n)
{
    Console.Write($"{n} ");
    if (n > 1)
    {
        n--;
        ShowNumbers(n);
    }
}

Console.WriteLine("Input a number N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
ShowNumbers(n);
*/

/*//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.(не включительно)

int SumOfNumbers(int m, int n)
{
    int current = m+1;
    int sum = current;
    if (current < n-1)
    {
        sum+= SumOfNumbers(current, n);
    }

    return sum;
}

Console.WriteLine("Imput a number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput a number: ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = SumOfNumbers(m ,n);
Console.WriteLine($"Sum is {sum}");
*/