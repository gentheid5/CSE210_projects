using System.IO;
public class Journal{

    Entry _newEntries = new Entry();

// member variables
    //List of journal entries
    List<Entry> _datedEntry = new List<Entry>();


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

    // stores entry in current list
    public void StoreEntry(Entry entry){
        _datedEntry.Add(entry);
    }


    //appends txt to filename form user
    public string FileNameTxt(){
        Console.Write("What would you like to name your Journal? ");
        string _fileName = Console.ReadLine();
        string _txtFileName = ($"{_fileName}.txt");

        return _txtFileName;
    } 


    //creates a new txt file with given list
    public void ConvertList(){
        string _txtFileName = FileNameTxt();
        
        using StreamWriter outputFile = new StreamWriter(_txtFileName);
        foreach (Entry entry in _datedEntry){
            outputFile.WriteLine($"{entry._date}, {entry._chosenPrompt}, {entry._currentEntry}");
        }

    }


    // asks user for journal name to open
    public string GetJournalName(){
        Console.Write("Which journal would you like to open? (just type the name, not doc type) ");
        string _journalName = Console.ReadLine();

        string _journalNameType = ($"{_journalName}.txt");
        return _journalNameType;
    }


    //convert txt file to list
    public void InitializeJournal(){
        string _fileToOpen = GetJournalName();
        string[] lines = System.IO.File.ReadAllLines(_fileToOpen);

        foreach (string line in lines){
            Entry _loadedEntry = new Entry();
            string[] parts = line.Split(",");

            _loadedEntry._date = parts[0];
            _loadedEntry._chosenPrompt = parts[1];
            _loadedEntry._currentEntry = parts[2];

            StoreEntry(_loadedEntry);

        }
    }


    // Displays called journal
    public void DisplayJournal(){
        foreach (Entry entry in _datedEntry){
            Console.WriteLine($"{entry._date}  {entry._chosenPrompt}\n  {entry._currentEntry}");
        }
    }
        


}