// Напишите программу, которая выводит случайное число из 
// отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int number = new Random().Next(10,100);
int max = int.MinValue; // присвает минимальное значение из существующих

Console.WriteLine(number);

int firstDigit = number/10; // вывели первое число двухзначного числа (разделили на 10)
int secondDigit = number % 10; // вывели второе число (остаток от деления на 10)

if (firstDigit > max) max = firstDigit;
else
{
    max = secondDigit;
}

Console.WriteLine(max);
*/

// второй вариант через цикл

int number = new Random().Next(10,100);
int max = int.MinValue; // присвает минимальное значение из существующих

Console.WriteLine(number);

while (number > 0)
{
    int lastDigit = number % 10;
    if (lastDigit > max)
    {
        max = lastDigit;
    }
    number = number / 10;
}

Console.WriteLine(max);