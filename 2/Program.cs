Console.Clear();
Console.Write($"Введите число ");

int numIn = Convert.ToInt32(Console.ReadLine());
int num = 0;
int BigNum = 0;
while (num <= numIn)
{
    BigNum = num * num * num;
    num++;
    Console.WriteLine(BigNum);
}