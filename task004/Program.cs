// Напишите программу, которая будет принимать на вход два числа 
//и выводить, является ли первое число кратным второму. 
//Если число 1 не кратно числу 2, то программа выводит остаток от деления.

int Input(string output) // метод для ввода чисел
{
    Console.Write("Enter your first number: ");
    return Convert.ToInt32(Console.ReadLine());
}


int num1 = Input("Enter the first number");
int num2 = Input("Enter your second number: ");


Console.WriteLine(num1);
Console.WriteLine(num2);

if (num1 % num2 == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("не кратно");
}





// Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.
/*
Console.Write("Enter your number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine("Кратно");
}
else 
{
    Console.WriteLine(" Не кратно");
}

bool CheckMultiply(int a, int b) // метод проверки кратности
{
    return a % b == 0;
}
*/