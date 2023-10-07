public class Entry{
    //Attributes
    //string for users new entry
    string _newEntry;

    // List of writing prompts
    List<string> _writingPrompts = new List<string>(){
        "What was the best thing that happened to you today?",
        "What is something that made you laugh today?",
        "What steps did you take today toward a goal you're working on?",
        "Who made your day better today? How can you pay that feeling forward?",
        "What made today unique?",
        "What is one thing you want to remember from today?",
        "When did you feel most authentically yourself today?",
        "How can you make tomorrow (even) better than today?",
        "What are three things you're grateful for today?",
        "What musician or song are you grateful for? Why?"
    };



    //Methods
    //Stores new entry
    public List<string> StoreEntry(string _newEntry, List<string> _journalEntries){
        return null;
    }

    //displays a random prompt using list of prompts and random number
    public void DisplayPrompt(List<string> _writingPrompts){
        Random num = new Random();
        int number = num.Next(10);

        Console.WriteLine($"{_writingPrompts[number]}");
        
    }

}