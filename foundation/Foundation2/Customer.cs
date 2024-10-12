public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public bool IsInUSA()
    {
        return _customerAddress.IsInUSA();
    }

    public Customer(string customerName, Address customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
    }
    public string GetDisplayText()
    {
        return $"{_customerName}, {_customerAddress.GetDisplayText()}";
    }
}