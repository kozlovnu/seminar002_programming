void Procedure()
{
    Console.WriteLine("hi!");
}

int numb1 = 10;
int numb2 = 100;

int sum = Sum(numb1, numb2);
Console.WriteLine(sum);

int Sum(int a, int b)
{
    return a + b;
}