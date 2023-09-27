public class Resume{
    // variables for name and list of jobs
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    //method to display names and jobs
    public void DisplayResume(){
        Console.WriteLine($"{_name}");

        foreach (Job job in _jobs){
            job.DisplayJobDetails();
        }

    }

}