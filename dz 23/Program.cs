Console.Clear();
int i= 1;
int N = UserInt("Введите число N: ");
 Cube(N);
 
void Cube(int Number)
{
    while ( i<= Number)
    {
    Console.WriteLine($"{i}^3 = {i*i*i}");
    i= i + 1;
    }
}
static int UserInt(string messageToUser)
{
    Console.Write(messageToUser);
    try
    {
        return int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return 0;
    }
}