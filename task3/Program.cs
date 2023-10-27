// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа. 
Console.WriteLine("Add number");
int num = Convert.ToInt32(Console.ReadLine());
int a, b;
if (num < 100 && num > 9){
    a = num / 10;
    b = num % 10;
    if (a > b) Console.WriteLine(a);
    else Console.WriteLine(b);
}
else Console.WriteLine("Wrong number");