/*Scrieti un program care va inversa elementele unui vector
 Lungimea vectorului va fi citita de la tastatura
 Inversarea elementelor va fi facuta in functia Main (fara o functie dedicate)
 Afisarea vectorului se va face printr-o functie de afisare dedicata*/


Console.Write("Enter a vector number: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] vector = ReadVector(length);

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

for (int i = 0; i < length / 2; i++)
{
    int position = vector[i];
    vector[i] = vector[length - 1 - i];
    vector[length - 1 - i] = position;
}

DisplayVector(vector);

void DisplayVector(int[] vec)
{
    Console.WriteLine("Reversed vector:");
    for (int i = 0; i < vec.Length; i++)
    {
        Console.WriteLine(vec[i] + " ");
    }
}

