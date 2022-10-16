// Напишите функцию и запустите ее, которая принимает на вход число и выдает сумму цифр в числе

int Sum(int A)
{
    int sum = 0;
    for (int i = 0; A > 0; i++)
    {
    sum = sum + A%10;
    A = A/10;
    }
return sum;
}
Console.Clear();
Console.Write("введите A: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine(Sum(A));
