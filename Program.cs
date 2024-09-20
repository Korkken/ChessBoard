// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Välj en siffra");
int number;

while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("Skriv en siffra eller ett tal, tack!");
}

for (int t = 0; t < number; t++)
{

    for (int i = 0; i < number; i++)
    {
        if ((i + t) % 2 == 0 )
        {
            Console.Write("\u25A0 ");
        }
        else 
        {
            Console.Write("\u25A1 ");
        }
    }
    Console.WriteLine();

}

