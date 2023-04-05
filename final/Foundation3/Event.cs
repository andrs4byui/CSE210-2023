class Event{
    public string _eventType;
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    Address address;
    internal Address Address { get => address; set => address = value; }
    protected string EventTitle { get => _eventTitle; set => _eventTitle = value; }
    protected string Description { get => _description; set => _description = value; }
    protected string Date { get => _date; set => _date = value; }
    protected string Time { get => _time; set => _time = value; }

    public Event(string eventTitle, string description, string date, string time)
    {
        EventTitle = eventTitle;
        Description = description;
        Date = date;
        Time = time;
    }
    public Event(string eventType, string eventTitle, string description, string date, string time)
    {
        _eventType = eventType;
        EventTitle = eventTitle;
        Description = description;
        Date = date;
        Time = time;
    }

    public void StandardDetails(){
        Console.WriteLine($"TITLE: {EventTitle}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Date : {Date} - {Time}");
        Console.WriteLine($"{Address.DisplayAddress()}");
    }

    public void ShortDescription(){
        Console.WriteLine($"The {_eventType}");
        Console.WriteLine($"{_eventTitle} this {_date}");
    }


}