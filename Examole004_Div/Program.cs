Console.Write("Введите Первое число ");

int numberA = Convert.ToInt16(Console.ReadLine());

Console.WriteLine(numberA);

int NumberB = new Random().Next(1,10) ;

Console.WriteLine(NumberB);

Console.Write("Делим первое число на второе. Результатравен ");

Console.WriteLine(numberA / NumberB);
