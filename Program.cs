int Task10() //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
{
    int num10;
    while (true)
    {
        try
        {
            Console.Write("Type a three-digit number: ");
            num10 = int.Parse(Console.ReadLine()!);
            if (num10 > 99 && num10 <= 999) break;
            else Console.WriteLine("Incorrect number");
        }
        catch (FormatException)
        {
            Console.WriteLine("Incorrect data entered");
        }
    }
    num10 = num10 % 100 / 10;    
    return num10;
}

string Task13() // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
{
    int num13;
    string num3rd;
    while (true)
    {
        try
        {
            Console.Write("Type a number: ");
            num13 = int.Parse(Console.ReadLine()!);
            if (num13 < 0) num13 = num13 * -1;
            break;
        }
        catch (FormatException)
        {
            Console.WriteLine("Incorrect data entered");
        }
    }
    
    num3rd = num13.ToString();
    if (num3rd.Length >= 3) num3rd = num3rd[2].ToString();
    else num3rd = "there is no third digit in your number";
    return num3rd;
}

bool Task15() // Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
{
    int num15;
    while (true)
    {
        try
        {
            Console.Write("Type a day number(Monday-1, Tuesday-2, etc.): ");
            num15 = int.Parse(Console.ReadLine()!);
            if (num15 > 0 && num15 < 8)
            {
                if (num15 > 5) return true;
                else return false;
            }
            else Console.WriteLine("Incorrect number");

        }
        catch (FormatException)
        {
            Console.WriteLine("Incorrect data entered");
        }
    }
}

while (true)
{
    Console.Write("Choose task number to run (10, 13 or 15): ");
    string task = Console.ReadLine() ?? "0";
    if (task == "10")
    {
        Console.WriteLine("Second digit of your number is {0}", Task10());
        break;
    }
    else if (task == "13")
    {
        Console.WriteLine("Third digit of your number is: {0}", Task13());
        break;
    }
    else if (task == "15")
    {
        if (Task15() == true) Console.WriteLine("Your day is a weekend");
        else Console.WriteLine("Your day is a weekday");
        break;
    }
    else Console.WriteLine("Incorrect task number");
}
