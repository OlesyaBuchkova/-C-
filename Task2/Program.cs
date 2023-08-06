Console.WriteLine("Первое число");

int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Второе число");

int SecondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Третье число");

int LastNumber = Convert.ToInt32(Console.ReadLine());

int max = firstNumber;

if (SecondNumber > max) max = SecondNumber;

if (LastNumber > max) max = LastNumber;

Console.WriteLine(max);