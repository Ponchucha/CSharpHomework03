/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int GetNumberFromConsole (string message) 
{
  Console.WriteLine(message);

  bool IsNumberCorrect = false;
  int number = 0;

  while (!IsNumberCorrect)
    {
        if (int.TryParse(Console.ReadLine(), out number))
            IsNumberCorrect = true;
        else 
            Console.WriteLine ("Вы ввели не число, либо число некорректно. Введите натуральное число");

    }

    return number;
}

double GetDistance(int x1,int x2,int y1,int y2,int z1,int z2)
{
double distance = Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow((y1-y2), 2) + Math.Pow((z1-z2),2));
return distance;
}

int x1 = GetNumberFromConsole("Введите координату x для первой точки");
int y1 = GetNumberFromConsole("Введите координату y для первой точки");
int z1 = GetNumberFromConsole("Введите координату z для первой точки");

int x2 = GetNumberFromConsole("Введите координату x для второй точки");
int y2 = GetNumberFromConsole("Введите координату y для второй точки");
int z2 = GetNumberFromConsole("Введите координату z для второй точки");

Console.WriteLine($"Расстрояние между двумя точками равно {GetDistance(x1,x2,y1,y2,z1,z2)}");