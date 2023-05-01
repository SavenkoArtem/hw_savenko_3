// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] Prompt(string message)
{    
    Console.WriteLine(message);
    int [] point = new int[3];
    Console.Write("X: ");
    point[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Y: ");
    point[1] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Z: ");
    point[2] = Convert.ToInt32(Console.ReadLine());

    return point; 

}

int getDistancePoint3D(int[] a, int[] b)
{
    int distance = Convert.ToInt32(Math.Sqrt(
            Convert.ToInt32(Math.Pow(b[0] - a[0], 2)) +
            Convert.ToInt32(Math.Pow(b[1] - a[1], 2)) +
            Convert.ToInt32(Math.Pow(b[2] - a[2], 2))
        ));

    return distance;
}

try{
    int[] A = Prompt("Enter the coordinates of point A");
    int[] B = Prompt("Enter the coordinates of point B");
    Console.WriteLine($"Distance = {getDistancePoint3D(A, B)}");
}
catch
{
    Console.WriteLine("Be careful, enter only integers");
}



