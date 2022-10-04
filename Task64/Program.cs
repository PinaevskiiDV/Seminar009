
Console.WriteLine("Введите N");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNamber(num, 1));

string PrintNamber(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    return (start + "," + PrintNamber(start - 1, end));
}