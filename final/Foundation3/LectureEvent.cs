class LectureEvent : Event{
    string _speakerName;
    int _capacity;

    public LectureEvent(string eventType, string eventTitle, string description, string date, string time, string speakerName, int capacity) : base(eventType, eventTitle, description, date, time)
    {   
        _speakerName = speakerName;
        _capacity = capacity;
    }
    public void DisplayLectureEventInfo(){
        Console.WriteLine($"Speaker : {_speakerName}");
        Console.WriteLine($"Max Capacity: {_capacity}");
    }
    public void FullDetails(){
        StandardDetails();
        DisplayLectureEventInfo();
    }
}