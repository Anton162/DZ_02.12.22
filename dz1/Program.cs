Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
if((number >=100) && (number<=1000))
{
    int firstDigit = number % 100;
    int secondDigit = firstDigit/10;
    Console.WriteLine(secondDigit);
}
else 
{
    Console.WriteLine("Введено не допустимое число");

}