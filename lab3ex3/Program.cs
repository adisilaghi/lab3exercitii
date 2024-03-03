/*Se citeste de la tastatura un vector continant n numere intregi, n fiind si el citit la randul sau citit de la
tastatura. Scrieti functii care vor returna
• Cel mai mare numar din vector
• Cel mai mic numar din vector
• Numerele divizibile cu 3
Dificultate ridicata
• Numerele patrate perfecte din vector
Apelati functiile si afisati-le rezultatele
 */

Console.WriteLine("Enter a vector number:");
int length = Convert.ToInt32(Console.ReadLine());   
int[] vector = ReadVector(length);

int maxValue = FindMaxValue(vector);
int minValue = FindMinValue(vector);

Console.WriteLine("Max Value from the vector is:" + maxValue);
Console.WriteLine("Min Value from the vector is:" + minValue);

int[] divisibleByThree = DivisibleByThree(vector);
Console.WriteLine("Numbers divisible by 3:");
for (int i = 0; i < divisibleByThree.Length; i++)
{
    Console.WriteLine(divisibleByThree[i]);
}

int[] perfectSquares = PerfectSquares(vector);
Console.WriteLine("Perfect square numbers:");
for (int i = 0; i < perfectSquares.Length; i++)
{
    Console.WriteLine(perfectSquares[i]);
}

int[] ReadVector(int length)
{
    int[] vector = new int[length];
    Console.WriteLine("Enter {0} numbers:", length);
    for (int i = 0; i < length; i++)
    {
        Console.Write("Enter number {0}: ", i + 1);
        vector[i] = Convert.ToInt32(Console.ReadLine());
    }
    return vector;
}

int FindMaxValue(int[] vec)
{
    int max = vec[0];
    for (int i = 1; i < vec.Length; i++)
    {
        if (vec[i] > max)
        {
            max = vec[i];
        }
    }
    return max;
}

int FindMinValue(int[] vec)
{
    int min = vec[0];
    for (int i = 1; i < vec.Length; i++)
    {
        if (vec[i] < min)
        {
            min = vec[i];
        }
    }
    return min;
}

int[] DivisibleByThree(int[] vec)
{
    int count = 0;
    for (int i = 0; i < vec.Length; i++)
    {
        if (vec[i] % 3 == 0)
        {
            count++;
        }
    }

    int[] result = new int[count];
    int index = 0;
    for (int i = 0; i < vec.Length; i++)
    {
        if (vec[i] % 3 == 0)
        {
            result[index] = vec[i];
            index++;
        }
    }
    return result;
}

static bool IsPerfectSquare(int num)
{
    int sqrt = (int)Math.Sqrt(num);
    return sqrt * sqrt == num;
}
static int[] PerfectSquares(int[] vec)
{
    int count = 0;
    for (int i = 0; i < vec.Length; i++)
    {
        if (IsPerfectSquare(vec[i]))
        {
            count++;
        }
    }

    int[] result = new int[count];
    int index = 0;
    for (int i = 0; i < vec.Length; i++)
    {
        if (IsPerfectSquare(vec[i]))
        {
            result[index] = vec[i];
            index++;
        }
    }

    return result;
}