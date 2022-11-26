// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int FunctionAkkermana(int numberM, int numberN)
{
    if(numberM == 0)
        return numberN + 1;
    else if(numberM > 0 && numberN == 0)
        return FunctionAkkermana(numberM - 1, 1);
    else 
        return FunctionAkkermana(numberM - 1, FunctionAkkermana(numberM, numberN - 1));
}

int userNumberM = GetNumber("Введите число M: ");
int userNumberN = GetNumber("Введите число N: ");

int result = FunctionAkkermana(userNumberM, userNumberN);
Console.WriteLine(result);