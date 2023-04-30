int firstNum, endNum;
string numStr;
Console.Write("Введите пятизначное число: ");
numStr = Console.ReadLine();
firstNum = 0;
endNum = numStr.Length - 1;

if (endNum == 4)
{
    while (firstNum < endNum && Char.IsDigit(numStr[firstNum]) && Char.IsDigit(numStr[endNum]))
    {
        if (numStr[firstNum] == numStr[endNum])
        {
            firstNum++;
            endNum = endNum - 1;
        }
        else
        {
            Console.WriteLine($"Число {numStr} не палиндром");
            firstNum = 5;
        }
    }
    if (firstNum == 2) Console.WriteLine($"число {numStr} - палиндром");
    if (firstNum != 2 && firstNum != 5) Console.WriteLine($"{numStr} - не верный ввод");
}
else Console.WriteLine("Значение не пятизначное");
