public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();
    private double _productsPrice;

    public double GetShippingCost()
    {
        if (_customer.IsInUSA())
        {
            return 5.00;
        }
        else
        {
            return 35.00;
        }
    }

    public double GetProductsPrice()
    {
        _productsPrice = 0;
        for (int i = 0; i < _products.Count; i++)
        {
            _productsPrice += _products[i].GetTotalPrice();
        }
        return _productsPrice;
    }

    public double GetTotalPrice()
    {
        return _productsPrice + GetShippingCost();
    }

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetDisplayText()}";
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetDisplayText()}";
        }
        return packingLabel;
    }
}