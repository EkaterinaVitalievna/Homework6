//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите числа через пробел: ");
int countPositive(int[] numseries)
{
   int count = numseries.Count(i => i > 0);
   return count;
}
int[] Numbers = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
Console.WriteLine("Количество чисел больше нуля: " + countPositive(Numbers));