Console.WriteLine("Введите m");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FunctionA(num1, num2));
int FunctionA(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return FunctionA(n - 1, 1);
    else
      return FunctionA(n - 1, FunctionA(n, m - 1));
}