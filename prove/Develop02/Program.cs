using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;
        Journal journal = new Journal();
        while (userChoice != 5)
        {
            System.Console.WriteLine("Choose One of the following:");
            System.Console.WriteLine("1. Write");
            System.Console.WriteLine("2. Display");
            System.Console.WriteLine("3. Load");
            System.Console.WriteLine("4. Save");
            System.Console.WriteLine("5.Quit");
            System.Console.Write("Select option: ");
            userChoice = Convert.ToInt32(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    Entry entry = new Entry();
                    PromptGenerator prompt = new PromptGenerator();
                    DateTime theCurrentTime = DateTime.Now;

                    entry._promptText = prompt.GetRandomPrompt();

                    entry._date = theCurrentTime.ToShortDateString();
                    System.Console.WriteLine(entry._promptText);
                    System.Console.WriteLine("");
                    entry._entryText = Console.ReadLine();

                    journal.AddEntry(entry);
                    break;

                case 2:
                    journal.DisplayAll();
                    break;
                
            }
        }
    }
}