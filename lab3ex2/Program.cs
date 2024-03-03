/*Scrieti o functie care va determina daca un numar este sau nu patrat perfect. Apelati-o si afisati-i rezultatul
*/

Console.WriteLine("Enter a number:");
int number = int.Parse(Console.ReadLine());
int square = PerfectSquare(number);

static int PerfectSquare(int number)
{
    double result = Math.Sqrt(number);
    bool isSquare = result % 1 == 0;
    if (isSquare == true)
    {
        Console.WriteLine("The number is perfect square number");
        return 1;
    }
    else
    {
        Console.WriteLine("The number is not perfect square number");
        return 0;
    }
}