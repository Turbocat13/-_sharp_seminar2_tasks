// Напишите программу, которая на вход принимает два числа
// и выводит, является ли второе число кратным первому
// Если второе число не кратно первому, то программа выводит остаток от деления.
int n1;
int n2;
Console.Write("Введите первое число: ");
n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
n2 = Convert.ToInt32(Console.ReadLine());

int xui = n1 % n2;

    if (n1 % n2 == 0)
    {
    Console.WriteLine ("кратно");
    }

    else
       Console.WriteLine ("не кратно");
       Console.WriteLine(xui);
    