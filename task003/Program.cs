// Напишите программу, которая выводит случайное 
//трёхзначное число и удаляет вторую цифру этого числа.

int number = new Random().Next(100,1000);
Console.WriteLine(number);
int fD = number / 100;
int lastD = number % 10;
Console.WriteLine(fD + lastD);


/*
int index = 1;

string str;

while(index < 4)
    {
    int n = number % 10;
    int number = number / 100;
    
    if (index != 2)
    {
        string str = str + Convert.ToString(n);
        
        index ++;
    }
    else 
    {
        index ++;
    }
    }
    Console.WriteLine(str);
    */