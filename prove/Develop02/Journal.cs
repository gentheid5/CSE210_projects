public class Journal{

// member variables
    //List of journal entries
    public List<string> _journalEntries = new List<string>();

    //string of filename user will want to open
    public string _fileName = "";

// Methods

    //Displays a list of menu options and asks for user selection
    public int DisplayMenu(){
        Console.WriteLine("Welcome! Please input a number the correlates with the following menu options:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        string userInputOption = Console.ReadLine();
        int userInput = int.Parse(userInputOption);

        return userInput;
    }

    //run txt file to list of strings to iterate through
    public List<string> InitializeJournal(string _fileName){
        return null;
    }

    // Reloads journal with appended entry
    public void RefreshFile(string _fileName, List<string> _journalEntries){

    }

    // Displays called journal
    public void DisplayJournal(List<string> _journalEntries){
        foreach (string Entry in _journalEntries){
            Console.WriteLine($"{Entry}");
        }
    }
        


}