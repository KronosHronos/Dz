Console.Write("Введите пятизначное число: ");

int num = Convert.ToInt32(Console.ReadLine());

if (num >= 10000 && num < 100000)
{
  int a = num / 10000;
  int b = num % 10000 / 1000;
  int c = num % 1000 / 100;
  int d = num % 100 / 10;
  int e = num % 10;
   if (a == e && b == d)
   { 
     Console.Write("Палидром");
    }
    else
    {
        Console.Write("не палидром ");
    }
}
    else Console.WriteLine("Введенное число не является пятизначным");
