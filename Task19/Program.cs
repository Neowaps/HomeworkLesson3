System.Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();

if (number.Length != 5)
{
    System.Console.WriteLine("Вы ввели не пятизначное число!");
}
else
    if (number[0] == number[4] && number[1] == number[3])
    {
        System.Console.WriteLine("Да, число является палиндромом");
    }
    else
    {
        System.Console.WriteLine("Нет, число не является палиндромом");
    }
