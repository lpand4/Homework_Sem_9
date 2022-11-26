// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfDigitBetween(int numberA,int numberB)
{
    if(numberA>=numberB) return numberA;
    return numberA + SumOfDigitBetween(numberA + 1, numberB);
}


int userNumberM = GetNumber("Введите число M: ");
int userNumberN = GetNumber("Введите число N: ");
int sum = SumOfDigitBetween(userNumberM, userNumberN);
Console.WriteLine(sum);