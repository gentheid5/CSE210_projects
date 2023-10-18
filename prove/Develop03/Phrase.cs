public class Phrase{
//Attributes
    // users phrase
    private string _phrase;


    //phrase in list format
    List<string> _phraseList = new List<string>();

//Methods
    //gets phrase that user wants to memorize
    private string GetPhrase(){
        Console.WriteLine("What phrase would you like to memorize? ");
        string phrase = Console.ReadLine();

        return phrase;
    }

    //stores phrase
    public void SetPhrase(){
        _phrase = GetPhrase();
    }

    //converts phrase to list of words
    public void ConvertToList(){
        string[] phraseList = _phrase.Split(" ");
        
            return phraseList;
        }
    }

    //updates scripture with 3 less words using WORD class
    public void UpdatePhrase(){

    }

}