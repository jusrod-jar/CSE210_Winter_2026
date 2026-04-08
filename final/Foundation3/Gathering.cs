class Gathering : Event
{
    private string _weather;

    public Gathering(string title, string description, string date, string time, Address address, string weather) 
        : base(title, description, date, time, address, "Outdoor Gathering")
    {
        _weather = weather;
    }

    public override string GetFull()
    {
        return $"{GetStandard()}\nType: Outdoor Gathering\nWeather Forecast: {_weather}";
    }
}