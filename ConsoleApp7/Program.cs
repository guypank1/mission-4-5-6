Console.WriteLine();
Console.WriteLine("משימה 4");
Console.WriteLine("enter the time: ");
int time = int.Parse(Console.ReadLine());
int hour = time / 100;
int minute = time % 100;
if (hour > 12 && minute < 10)
{
    hour = hour - 12;
    Console.WriteLine($".P.M {hour}:0{minute}");
}
else if (hour == 12)
{
    Console.WriteLine($".P.M {hour}:{minute}");
}
else if (hour < 12 && minute < 10)
{
    Console.WriteLine($".A.M 0{hour}:0{minute}");
}
else if (hour > 12 && minute > 10)
{
    hour = hour - 12;
    Console.WriteLine($".P.M {hour}:{minute}");
}
else if (hour < 12 && minute> 10)
{
    Console.WriteLine($".A.M {hour}:{minute}");
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("משימה 5");
Console.WriteLine();
Console.WriteLine("put a number (negetive or positive)");
int num = int.Parse(Console.ReadLine());
if (num < 0)
{
    num = num / -1;
    Console.WriteLine(num);
}
else
{
    Console.WriteLine(num);
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("משימה 6");
Console.WriteLine();
Console.WriteLine("enter a number");
int num2 = int.Parse(Console.ReadLine());
if (num2 % 2 ==0)
{
    Console.WriteLine($"{num2} EVEN");
}
else
{
    Console.WriteLine($"{num2} NOT EVEN");
}