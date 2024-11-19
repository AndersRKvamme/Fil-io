internal class Program
{

    private static void Main (string[] args){
        //Skriv velckomst melding
        Console.WriteLine ("We welcome to C# File System Input/Output");

        //Ta imot bruker kommando seleksjon
        Console.WriteLine ("Please enter your command.");
        Console.WriteLine ("Available commands are as follows:");
        Console.WriteLine ("-read");
        Console.WriteLine ("-create");
        string? userInput = Console.ReadLine();
            if (userInput == null){
                return; //Change later
            }
        // Finne Kommandoen


        switch (userInput)
        {
            case "create":
                Console.WriteLine("Creating file content...");
                break;
            case "read":
                Console.WriteLine("Reading file content...");
                break;
            default:
                Console.WriteLine("Unknown command.");
                break;
        }
        Console.WriteLine($"User inputted {userInput}");



    }


}