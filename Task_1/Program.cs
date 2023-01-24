// Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом.

Console.Clear();

string InputNumber(string message)
{
    System.Console.Write(message + " > ");
    string? number = Console.ReadLine();
    return number;
}

string number = InputNumber("Введите любое целое натуральное число");
Console.WriteLine(Palindrom(number));

string Palindrom(string number)
{
    int variable = 0;
    int temp = 0;
    int index = 0;
    if (int.TryParse(number, out variable))
    {
        if (number[0] == '0')
        {
            return "Ошибка, введенное Вами число - ненатуральное!";
        }
        else
        {
            temp = variable;
            while (temp > 0)
            {
                index = index * 10;
                index = index + temp % 10;
                temp = temp / 10;
            }
            if (variable == index)
            {
                return $"Введенное число {number} ЯВЛЯЕТСЯ палиндромом.";
            }
            else
            {
                return $"Введенное число {number} НЕ ЯВЛЯЕТСЯ палиндромом.";
            }
        }
    }
    else
    {
        return "Ошибка, введенные Вами данные НЕ ЯВЛЯЮТСЯ числом!";
    }
}