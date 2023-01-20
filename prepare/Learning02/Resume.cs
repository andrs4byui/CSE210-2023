public class Resume {
    //Keeps track of the person's name and a list of their jobs.
    public String _personName;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume(){
        //Displays the resume wich shows the name first, followed by displayin each one of the jobs.
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs: ");
        foreach (Job job in _jobs){
            job.DisplayJobDetails();
        }

    }

}