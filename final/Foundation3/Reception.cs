class Reception : Event
{
    private string _email;

    public Reception(string title, string description, string date, string time, Address address, string email) 
        : base(title, description, date, time, address, "Reception")
    {
        _email = email;
    }

    public override string GetFull()
    {
        return $"{GetStandard()}\nType: Reception\nRSVP Email: {_email}";
    }  
}