using System;

class Program
{
    static void Main(string[] args)
    {

        int run = 99;
        while (run != 5){

            // display menu options, call different class methods depending on user responce
            Journal _userJournal = new Journal();
            Entry _newEntry = new Entry();

            int _userOption = _userJournal.DisplayMenu();

            if (_userOption == 1){
                // prints prompt, stores entry with date and prompt
                _newEntry.DisplayEntry();

            }

            else if (_userOption == 2){
                _userJournal.DisplayJournal();
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