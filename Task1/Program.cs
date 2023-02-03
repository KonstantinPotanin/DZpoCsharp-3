// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


int GetNumber(string message)
{
    int result = 0;
    
    while (true)
    {
        Console.WriteLine(message);
    
        if(int.TryParse(Console.ReadLine(), out result) && result >= 10000 && result <= 99999)
        {
            break;
        }
        else 
        {
            Console.WriteLine("Ввели не пятизначное число либо не число вообще. Повторите ввод");
        }
    }
    return result;
}

int GetReversNumber (int num)
{
    int reversNum = 0;
    while (num > 0)
    {
        reversNum = reversNum * 10 + num % 10;
        num = num / 10;
    }
    return reversNum;
}

int num = GetNumber ("Введите пятизначное число");
int reversNum = GetReversNumber(num);

bool ChackPal (int num, int reversNum)
{   
    if (num == reversNum)
    return true;
    else
    return false;
}
bool result = ChackPal(num, reversNum);
Console.WriteLine($"Введенное число {result} палиндром");
