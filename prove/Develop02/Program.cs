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
            // calling new entry class
            Entry _newEntry = new Entry();
            

            if (_userOption == 1){
                // prints prompt, stores entry with date and prompt
                _newEntry.DisplayEntry();

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