// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

namespace Example13  {
class exercise_13 { 

static void Main() { 

Console.Clear();

System.Console.WriteLine("Введи число: ");

int Number = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(Number);
if (anyNumberText.Length > 2){
  Console.WriteLine("Третья цифра : " + anyNumberText[2]);
}
else {
  Console.WriteLine("Третьей цифры нет!");
}
}}}