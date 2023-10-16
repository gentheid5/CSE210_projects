using System;


class Program
{
    static void Main(string[] args)
    {
        Journal _userJournal = new Journal();
        
        int run = 99;
        while (run != 5){

            // display menu options, call different class methods depending on user responce
            

            int _userOption = _userJournal.DisplayMenu();

            if (_userOption == 1){
                Entry _newEntry = new Entry();
                // prints prompt, stores entry with date and prompt
                _newEntry.SetupEntry();
                _userJournal.StoreEntry(_newEntry);
            }

            else if (_userOption == 2){
                _userJournal.DisplayJournal();
            }

            else if (_userOption == 3){
                _userJournal.InitializeJournal();
            }

            else if (_userOption == 4){
                _userJournal.ConvertList();
            }

            else{
                Console.WriteLine("Keep up the journaling!");
                run = 5;
            }

        }



    }
}