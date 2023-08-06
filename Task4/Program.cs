Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());

for(int imput = 1; imput < number; imput++)
{
if (imput % 2 == 0)

System.Console.Write(imput + ", ");
}