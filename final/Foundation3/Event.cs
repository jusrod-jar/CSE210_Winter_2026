abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _eventType;

    public Event(string title, string description, string date, string time, Address address, string eventType) 
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = eventType;
    }

    public string GetStandard()
    {
        return $"\nTitle: {_title}\nEvent Description: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}";
    }

    public virtual string GetFull()
    {
        return GetStandard();
    }

    public string GetShort()
    {
        return $"\nType: {_eventType}\nTitle: {_title}\nDate: {_date}";
    }
}