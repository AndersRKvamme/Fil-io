﻿internal class Program
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
        Console.WriteLine("Creating file content...");
   }
   static void ReadFile() {
        Console.WriteLine("Reading file content...");
   }
}

