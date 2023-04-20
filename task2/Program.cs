//  задача 2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("введите первое число ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите второе число ");
int b = int.Parse(Console.ReadLine());

if (a > b) {
    Console.WriteLine("первое число больше второго");
}else{
    Console.WriteLine("второе число больше первого");
}
