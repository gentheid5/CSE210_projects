public class Reference{
//Attributes
    //reference
    public string reference;

//Methods
    //gets reference
    private string GetReference(){
        Console.WriteLine("What is the reference for the phrase? ");
        string reference = Console.ReadLine();
        
        return reference;
    }


    //stores reference in attribute
    private void StoreReference(){
        reference = GetReference();
    }


    //Display reference
    public void DisplayReference(){

    }
    
}