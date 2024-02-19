using System;

class Program 
{
  public static void Main (string[] args) 
  {
    Console.WriteLine ("Расчёт индекса массы тела");
    Console.WriteLine("Введите ваш возраст ");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите ваш вес: в кг ");
    int weight = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите ваш рост: в см ");
    int height = Convert.ToInt32(Console.ReadLine());
    double bmi = weight / (height * height / 10000);
    Console.WriteLine($"Ваш индекс массы тела: {bmi}");
    Console.WriteLine("Набрать вес: 1, Похудеть: 2, Не менять: 3");
    Console.WriteLine("Введите значение ");
    int value = Convert.ToInt32(Console.ReadLine());
    double kkal = (10 * weight) + (6.25 * height) - (5 * age);
    Console.WriteLine("Введите ваш пол man/women");
    string sex = Console.ReadLine();
    switch (sex)
    {
    case "man":
    kkal = kkal + 5;
      if (value == 3)
      {
        Console.Write($"Норма для мужчин равна  {kkal}");
      }
      else if (value == 1)
      {
        kkal = (kkal * 20 / 100) + kkal;
        Console.Write($"Норма для мужчин равна  {kkal}");
      }
      else kkal = kkal - (kkal * 20 / 100);
      Console.Write($"Норма для мужчин равна  {kkal} .");
      break;
    case "woman":
    kkal = kkal - 161;
      if (value == 3)
      {
        Console.Write($"Норма для женщин равна {kkal}");
      }
      else if (value == 1)
      {
        kkal = (kkal * 20 / 100) + kkal;
        Console.Write($"Норма женщин равна {kkal}");
      }
      else kkal = kkal - (kkal * 20 / 100);
    Console.Write($"Норма для женщин равна  {kkal}");
      break;
    default:
      Console.Write("Ошибка");
      break;
   }
    Console.WriteLine($"Ваша норма ккал равна:  {kkal}");
  }
}

  