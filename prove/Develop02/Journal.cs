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
        Console.WriteLine("1. Load Journal");
        Console.WriteLine("2. New Journal Entry");
        Console.WriteLine("3. Display Journal");
        Console.WriteLine("4. Save Journal Entry");
        Console.WriteLine("5. Quit Program");

        string userInputOption = Console.ReadLine();
        int userInput = int.Parse(userInputOption);

        return userInput;
    }

    //Method to trun txt file to list of strings to iterate through
    public List<string> InitializeJournal(string _fileName){
        
        return null;
    }

    // Reloads journal with appended entry
    public void RefreshFile(string _fileName, List<string> _journalEntries){

    }

    // Displays called journal
    public void DisplayJournal(List<string> _journalEntries){

    }
        


}