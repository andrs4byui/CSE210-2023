public class Job {
    //Keeps track of the company, job title, start year, and end year.
    public String _jobTitle;
    public String _companyName;
    public int _startYear;
    public int _endYear;


    public void DisplayJobDetails() {
        //Display the job information in the format "@_jobTitle, (@company) @startyear-@endyear"
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
    }
}