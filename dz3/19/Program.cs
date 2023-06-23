// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 14212 -> нет
Console.WriteLine ("Введите число");
int N = int.Parse(Console.ReadLine()!);
int a = N%10;
int b = N%100/10;
int c = N/10000;
int d = N/1000%10;
if (a == c){
if (b==d) Console.WriteLine ("Да");
}
else Console.WriteLine ("Нет");