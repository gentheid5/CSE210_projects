using System;

class Program
{
    static void Main(string[] args)
    {

        int run = 99;
        while (run != 5){

            // display menu options, call different class methods depending on user responce
            Journal _userJournal = new Journal();
            int _userOption = _userJournal.DisplayMenu();

            if (_userOption == 1){
                // calling new entry class
                Entry _newEntry = new Entry();

                // prints prompt, stores entry with date and prompt
                string prompt = _newEntry.DisplayPrompt();
                Console.Write($"{prompt}\n>");
                string entry = _newEntry._newWrite = Console.ReadLine();

                _newEntry.StoreEntry(entry, prompt);
            }

            else if (_userOption == 2){
            }

            else if (_userOption == 3){
            }

            else if (_userOption == 4){
            }

            else{
                Console.WriteLine("Keep up the journaling!");
                run = 5;
            }

        }



    }
}