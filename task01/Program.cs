/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

int GetNumberFromConsole (string message) 
{
  Console.WriteLine(message);

  bool IsNumberCorrect = false;
  int number = 0;

  while (!IsNumberCorrect)
    {
        if (int.TryParse(Console.ReadLine(), out number) && ((number >= 10000 && number < 100000) || (number <= -10000 && number > -100000)))
            IsNumberCorrect = true;
        else 
            Console.WriteLine ("Вы ввели не число, либо число некорректно. Введите пятизначное число");

    }

    return number;
}


int MakeNumberPositive (int someNumber)
{
if (someNumber < 0)
    someNumber = - someNumber;
return someNumber;
}

void IsItPalindrome (int number)
{
    if ((number / 10000 == number %10) && ((number % 10000) / 1000 == (number % 100 / 10)))
        Console.WriteLine("Введённое число является палиндромом");
    else 
        Console.WriteLine ("Введённое число НЕ является палиндромом");
}

int number = GetNumberFromConsole ("Введите пятизначное число");
number = MakeNumberPositive (number);
IsItPalindrome (number);
