public class Entry{
//Attributes
    //string for users new entry
    public string _newWrite = "";


//Methods
    //Stores new entry
    public List<string> StoreEntry(string _newEntry, string _newPrompt){
        // creates new list called _entries that stores the date, prompt, and entry
        List<string> _entries = new List<string>();
        //returns current date
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        _entries.Add($"{dateText}: {_newPrompt} \n{_newEntry}");

        return _entries;
    }

    //displays a random prompt using list of prompts and random number
    public string DisplayPrompt(){
        Random num = new Random();
        int number = num.Next(10);

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
        string prompt = _writingPrompts[number];
        return prompt;
    }

}