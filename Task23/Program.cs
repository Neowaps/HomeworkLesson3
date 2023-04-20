System.Console.Write("Введите число: ");
string textNumber = Console.ReadLine();
int number = int.Parse(textNumber);

System.Console.WriteLine("Таблица кубов заданного числа: ");
for (int i = 1; i <= number; i++)
{
    System.Console.Write(Math.Pow(i, 3) + " ");
}
