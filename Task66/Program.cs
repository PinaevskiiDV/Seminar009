Console.WriteLine("Введите M");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNamber(num1, num2));

int PrintNamber(int start, int end)
{
    if (start == end)
    {
        return start;
    }
    return (start + PrintNamber(start + 1, end));
}