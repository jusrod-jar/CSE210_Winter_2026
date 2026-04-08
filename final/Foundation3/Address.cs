class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string address, string city, string stateprovince, string country)
    {
        _streetAddress = address;
        _city = city;
        _stateOrProvince = stateprovince;
        _country = country;
    }

    public string GetFullAddress()
    {
        return $"{_country}, {_stateOrProvince}, {_city}, {_streetAddress}, ";
    }
}