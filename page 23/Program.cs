int num;
Console.Write("Введите любое число: ");
num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= num; i++) Console.Write($"{Math.Pow(i, 3)}, ");
Console.WriteLine(" ");