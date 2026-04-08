class Customer
{
    private string _name;
    private Address _address;
    private bool _american = false;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
        if (address.IsAmerican())
        {
            _american = true;
        }
    }

    public (string, string) GetShippingInfo()
    {
        return (_name, _address.GetFullAddress());
    }

    public bool GetAmerican()
    {
        return _american;
    }
}