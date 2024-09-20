//Tim Lappalainen NET2024
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Välj en siffra");
int number;

while (!int.TryParse(Console.ReadLine(), out number)) //checking if value is a number
{
    Console.WriteLine("Skriv en siffra eller ett tal, tack!");
}

Console.WriteLine("Vad för tecken vill du att vit ska vara"); //user chooses what the white squares should be
var white = Console.ReadLine();

Console.WriteLine("Vad för tecken vill du att svart ska vara"); //user chooses what the black squares should be
var black = Console.ReadLine();
for (int t = 0; t < number; t++)
{

    for (int i = 0; i < number; i++) //loop to print out the chessboard.
    {
        if ((i + t) % 2 == 0 )
        {
            Console.Write(white);
        }
        else 
        {
            Console.Write(black);
        }
    }
    Console.WriteLine();

}

