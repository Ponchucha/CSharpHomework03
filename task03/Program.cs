/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNumberFromConsole (string message) 
{
  Console.WriteLine(message);

  bool IsNumberCorrect = false;
  int number = 0;

  while (!IsNumberCorrect)
    {
        if (int.TryParse(Console.ReadLine()??"", out number))
            IsNumberCorrect = true;
        else 
            Console.WriteLine ("Вы ввели не число. Введите число");

    }

    return number;
}

void PrintCubeTable (int number, int startPosition)
{
    double cube = 0;
    int i = startPosition;
    
    if (number >= startPosition)
{
        while (i <= number) /* пыталась сделать через for, но в этом случае возникает ошибка 
                            (что-то про то, что i не существует в данном контексте). 
                            Я верно поняла, что при использовании конструкции  for (int i = 1; i <= number; i++), 
                            в самом теле цикла i как переменную использовать нельзя?                     */
        {
            cube = Math.Pow(i,3);
            Console.Write($"{cube},");
            i++;
        }
}
    else 
    {
        while (i >= number)
        {
            cube = Math.Pow(i,3);
            Console.Write($"{cube},");
            i--;
        }
    }
}
    


int number = GetNumberFromConsole("Введите число");
PrintCubeTable(number,1);
