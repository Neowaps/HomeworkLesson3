System.Console.Write("Введите Х1: ");
string Xtxt1 = Console.ReadLine();
int X1 = Convert.ToInt32(Xtxt1);
System.Console.Write("Введите Y1: ");
string Ytxt1 = Console.ReadLine();
int Y1 = Convert.ToInt32(Ytxt1);
System.Console.Write("Введите Z1: ");
string Ztxt1 = Console.ReadLine();
int Z1 = Convert.ToInt32(Ztxt1);
System.Console.Write("Введите Х2: ");
string Xtxt2 = Console.ReadLine();
int X2 = Convert.ToInt32(Xtxt2);
System.Console.Write("Введите Y2: ");
string Ytxt2 = Console.ReadLine();
int Y2 = Convert.ToInt32(Ytxt2);
System.Console.Write("Введите Z2: ");
string Ztxt2 = Console.ReadLine();
int Z2 = Convert.ToInt32(Ztxt2);

double distance = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
System.Console.WriteLine($"Расстояние между точками в 3D пространстве равно: " + Math.Round(distance, 2));


// D=sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2)