class OutdoorEvent : Event{
    private int _maxTemperature;
    private int _minTemperature;
    private int _precipitation;
    private int _humidity;
    private int _wind;

    public OutdoorEvent(string eventType, string eventTitle, string description, string date, string time, int maxTemperature, int minTemperature, int precipitation, int humidity, int wind) : base(eventType, eventTitle, description, date, time)
    {
        _maxTemperature = maxTemperature;
        _minTemperature = minTemperature;
        _precipitation = precipitation;
        _humidity = humidity;
        _wind = wind;
    }

    public void DisplayOutdoorForecast(){
        Console.WriteLine($"Today Max Temeperature is {_maxTemperature}°C and min Temperature is {_minTemperature}°C");
        Console.WriteLine($"The Precipitation is {_precipitation}%");
        Console.WriteLine($"The Humity is: {_humidity}%");
        Console.WriteLine($"There is a {_wind}Km/h");
    }

    public void FullDetails(){
        StandardDetails();
        DisplayOutdoorForecast();
    }
}