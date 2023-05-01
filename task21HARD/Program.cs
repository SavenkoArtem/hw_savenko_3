// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними
// в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.

int[] Prompt(string message, int N)
{    
    Console.WriteLine(message);
    int [] point = new int[N];

    for (int i = 0; i < point.Length; i++)
    {
        Console.Write($"Enter coodrdinate: ");
        point[i] = Convert.ToInt32(Console.ReadLine());
    }
    return point; 

}

int getDistancePoint3D(int[] a, int[] b)
{
    int powCoord = 0;
    for (int i = 0; i < a.Length; i++)
    {
        powCoord += Convert.ToInt32(Math.Pow(b[i] - a[i], 2));
    }
    int distance = Convert.ToInt32(Math.Sqrt(powCoord));

    return distance;
}

try{
    Console.Write("Enter a N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int[] A = Prompt("Enter the coordinates of point A", N);
    int[] B = Prompt("Enter the coordinates of point B", N);
    Console.WriteLine($"Distance = {getDistancePoint3D(A, B)}");
}
catch
{
    Console.WriteLine("Be careful, enter only integers");
}


