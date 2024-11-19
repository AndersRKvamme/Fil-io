internal class Program
{

    private static void Main (string[] args){
        //Skriv velckomst melding
        Console.WriteLine ("We welcome to C# File System Input/Output");

        //Ta imot bruker kommando seleksjon
        Console.WriteLine ("Please enter your command.");
        string? userInput = Console.ReadLine();
            if (userInput == null){
                return; //Change later
            }
        // Finne Kommandoen

        Console.WriteLine($"User inputted {userInput}");



    }


}