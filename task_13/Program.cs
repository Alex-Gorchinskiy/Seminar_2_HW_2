// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number / 100 < 1)
{
    Console.WriteLine("Третьей цифры нет.");
}
else
{
  int k = number;
  while (k / 1000 >= 1)
  {
   k = (k - k % 10) / 10; 
  }
  int thirdDigit = k % 10;
  Console.WriteLine($"Третья цифра числа {number}: {thirdDigit}");
}
