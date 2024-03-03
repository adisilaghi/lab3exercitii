/*Scrieti o functie care va calcula suma cifrelor unui numar.
*/

Console.WriteLine("Write n digit number:");
int number = int.Parse(Console.ReadLine());
int sum = SumOfDigits(number);

static int SumOfDigits(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum += number % 10; 
        number /= 10;
    }
    return sum;
}

Console.WriteLine($"Sum of the digits {number} is: {sum}");