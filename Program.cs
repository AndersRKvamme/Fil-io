internal class Program
{

    private static void Main (string[] args){
        //Skriv velckomst melding
        Console.WriteLine ("We welcome to C# File System Input/Output");

        bool quitProgramme = false;
            while (!quitProgramme)
            {

        //Ta imot bruker kommando seleksjon
        Console.WriteLine ("Please enter your command.");
        Console.WriteLine ("Available commands are as follows:");
        Console.WriteLine ("-read");
        Console.WriteLine ("-create");
        Console.WriteLine ("-quit");
        string? userInput = Console.ReadLine();
            if (userInput == null){
                return; //Change later
            }
        // Finne Kommandoen


        switch (userInput)
        {
            case "create":
                CreateFile();
                break;
            case "read":
                ReadFile();
                break;
            case "quit":
                Console.WriteLine("Exiting programme");
                break;
            default:
                Console.WriteLine("Unknown command.");
                break;
        }
        Console.WriteLine($"User inputted {userInput}");
}

 

    }
   static void CreateFile() {
        Console.WriteLine("What is the name of your new file?");
        string? path = Console.ReadLine();
        if (path == null)
        {
            Console.WriteLine("Could not read from Console (/stdin)");
            return;
        }
        using (System.IO.File.Create())
        {
            Console.WriteLine($"Created file: {path}");
        }
        
       
   }
   static void ReadFile() {
        Console.WriteLine("Please specify file to read.");
        string? path = Console.ReadLine();
            if (path == null)
            {
                Console.WriteLine("Could not read from console (/stdin)");
                return;
            }
     
try
{
             //Les av tekst fil "hello.txt"
        string content = System.IO.File.ReadAllText(path);
       
        // Print til konsollen.

        Console.WriteLine (content);
}
catch (System.Exception)
{
        Console.WriteLine("File not found, please try again.");
}

   }
}

