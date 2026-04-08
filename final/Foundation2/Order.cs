class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public int CalculateTotalPrice()
    {
        int totalPrice = 0;

        foreach (Product product in _products)
        {
            totalPrice += product.GetCost();
        }

        if (_customer.GetAmerican())
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";

        foreach (Product product in _products)
        {
            packingLabel += $"Product: {product.GetName()} ~ ID: {product.GetProductId()}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        (string name, string address) = _customer.GetShippingInfo();
        return $"Shipping Label:\nCustomer: {name} ~ Address: {address}";
    }
}