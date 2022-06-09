// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

int Input(string output) // метод для ввода чисел
{
    Console.Write("Enter your first number: ");
    return Convert.ToInt32(Console.ReadLine());
}

int num1 = Input("Enter the first number");
int num2 = Input("Enter your second number: ");

int sq = num1 * num1;
int sq2 = num2 * num2;

if (sq == num2 || sq2 == num1)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}