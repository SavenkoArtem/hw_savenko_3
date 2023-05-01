// Задача 19 и 19 HARD. Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// Напишите программу, которая принимает на вход целое число
// любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.

int Promt(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool isNotShort(int count)
{
    if (count < 3)
        return false;

    return true;
}

int LenghtNum(int num)
{
    int count = 0;
    while (num != 0)
    {
        count++;
        num = num / 10;
    }

    return count;
}

void isPalindrom(int num)
{
    int count = LenghtNum(num);
    if (!isNotShort(count))
    {
        Console.WriteLine("Please enter a long number");
        return;
    }   

    int rightPart = 0;
    int leftPart = 0;
    int rightPartRevers = 0;
    int mid = count / 2;
    if (count % 2 == 0)
    {
        rightPart = num % (Convert.ToInt32(Math.Pow(10, mid)));
        leftPart = num / (Convert.ToInt32(Math.Pow(10, mid)));
        int counter = mid;
        while (rightPart != 0)
        {
            rightPartRevers = rightPartRevers + ((rightPart % 10)*Convert.ToInt32(Math.Pow(10, counter - 1)));
            counter--;
            rightPart /= 10;
        }
    }
    else
    {
        rightPart = num % (Convert.ToInt32(Math.Pow(10, mid)));
        leftPart = num / (Convert.ToInt32(Math.Pow(10, mid + 1)));
        int counter = mid;
        while (rightPart != 0)
        {
            rightPartRevers = rightPartRevers + ((rightPart % 10)*Convert.ToInt32(Math.Pow(10, counter - 1)));
            counter--;
            rightPart /= 10;
        }
    }    

    if (leftPart == rightPartRevers)
    {
        Console.WriteLine("This is palindrome");
    }
    else
    {
        Console.WriteLine("This is not palindrome");
    }

}


int num = Promt("Enter a number");
isPalindrom(num);


