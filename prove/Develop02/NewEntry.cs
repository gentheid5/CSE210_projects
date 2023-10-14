public class Entry{
//Attributes

    //string to store current prompt
    public string _chosenPrompt;

    public string _currentEntry;

    public string _date;


    //diplay prompt and return new entry
    public void SetupEntry(){
        ChoosePrompt();
        Console.Write($"{_chosenPrompt}\n>");
        string _newWrite = Console.ReadLine();

        _currentEntry = _newWrite;

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        _date = dateText;
    }


    //displays a random prompt using list of prompts and random number
    public void ChoosePrompt(){
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
        _chosenPrompt = _writingPrompts[number];
    }
        
}