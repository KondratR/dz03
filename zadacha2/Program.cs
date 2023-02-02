// Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int InputDot(string dot)
{
    System.Console.WriteLine(dot);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = InputDot("Введите координату X первой точки");
int y1 = InputDot("Введите координату Y первой точки");
int z1 = InputDot("Введите координату Z первой точки");
int x2 = InputDot("Введите координату X второй точки");
int y2 = InputDot("Введите координату Y второй точки");
int z2 = InputDot("Введите координату Z второй точки");

System.Console.WriteLine(Math.Round(Math.Pow(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2), 0.5), 2));