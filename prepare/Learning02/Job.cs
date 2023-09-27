public class Job{

    // member variables related to job info
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    // constuctor method
    public Job()
    {
    }


    // method used to display job info
    public void DisplayJobDetails(){
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }


}