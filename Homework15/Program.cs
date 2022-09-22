Console.WriteLine("Введите число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1) Console.WriteLine ("Понедельник - Будний день");
else if (number == 2) Console.WriteLine ("Вторник - Будний день");
else if (number == 3) Console.WriteLine ("Среда - Будний день");
else if (number == 4) Console.WriteLine ("Четверг - Будний день");
else if (number == 5) Console.WriteLine ("Пятница - Будний день");
else if (number == 6) Console.WriteLine ("Суббота - Выходной день");
else if (number == 7) Console.WriteLine ("Воскресенье - Выходной день");
else Console.WriteLine("введите верное число");

