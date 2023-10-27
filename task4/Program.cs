// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
void writer (int n, bool check){
    if (n > 9){
        int n_new = n / 10;
        writer(n_new, false);
        if (check) Console.WriteLine(n % 10);
        else Console.Write(n % 10 + ", ");
    }
    else Console.Write(n + ", ");
}
Console.WriteLine("Add number");
int num = Convert.ToInt32(Console.ReadLine());
bool check = true;
writer(num, check);
