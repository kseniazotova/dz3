// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 3 -> 1, 8, 27
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine ()!);
int i = 1;
while (i<=N){
    Console.Write (i*i*i);
    Console.Write (" ");
    i=i+1;
}