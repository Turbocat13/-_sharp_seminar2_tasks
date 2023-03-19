// напишите программу, кот. выводит случайное трёхзначное число и удаляет вторую цифру этого числа
Console.Clear();
int n = new Random().Next(100, 1000); 
Console.WriteLine($"Случайно сгенированное число {n}");
int n1 = n / 100;
int n2 = (n % 100) / 10;
int n3 = (n % 100) % 10;

Console.Write(n1);
Console.Write(n3);






