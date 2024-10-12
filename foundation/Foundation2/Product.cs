public class Product
{
    private string _productName;
    private double _price;
    private int _quantity;
    private int _productId;

    public Product(string productName, double price, int quantity, int productId)
    {
        _productName = productName;
        _price = price;
        _quantity = quantity;
        _productId = productId;
    }
    public double GetTotalPrice()
    {
        return _price * _quantity;

    }

    public string GetDisplayText()
    {
        return $"\nProduct: {_productName}\nPrice: {_price}\nQuantity: {_quantity}\nProduct ID: {_productId}\n";
    }
}