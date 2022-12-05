Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

if (number[0]== '-')
{
    if (number.Length>=4)
    {
        Console.WriteLine(number[3]);
    }
    else
    {
        Console.WriteLine("не трехзначное число");
    }
}
else
{
    if (number.Length >=3)
    {
        Console.WriteLine(number[2]);
    }
    else
    {
        Console.WriteLine("не трехзначное число");
    }
}