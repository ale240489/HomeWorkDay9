// Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
//N = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int SumOfNaturalNumFromMToN(int m, int n)
{
if(n == m)
    return n ;
else
    return n+SumOfNaturalNumFromMToN(m, n-1);
}
Console.WriteLine(SumOfNaturalNumFromMToN(4, 8));
