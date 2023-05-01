// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void buildIntoCube(int num)
{
    int count = 1;
    while (num != 0)
    {        
        Console.Write($"{Math.Pow(count, 3)} ");
        count++;
        num--;
    }
    Console.WriteLine("");
}

try
{
    int num = Prompt("Enter a number:");
    buildIntoCube(num);
}
catch
{
    Console.WriteLine("Be careful, Enter an integer!");
}
