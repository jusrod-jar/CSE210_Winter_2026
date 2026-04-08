class Product
{
    private string _name;
    private string _productId;
    private int _pricePerUnit;
    private int _quantity;

    public Product(string name, string id, int ppu, int quantity)
    {
        _name = name;
        _productId = id;
        _pricePerUnit = ppu;
        _quantity = quantity;  
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public int GetCost()
    {
        return _pricePerUnit * _quantity;
    }
}