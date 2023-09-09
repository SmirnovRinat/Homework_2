// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

namespace Example13  {
class exercise_13 { 

static void Main() { 

Console.Clear();

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void DayWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("Этот день недели - выходной.");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Нет такого дня в неделе.");
  }
  else Console.WriteLine("Этот день рабочий, не выходной.");
}

DayWeek(dayNumber);

}}}