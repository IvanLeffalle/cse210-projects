public class Address
{
    private string _street;
    private string _city;
    private string _stateCity;
    private string _country;

    public Address(string street, string city, string stateCity, string country)
    {
        _street = street;
        _city = city;
        _stateCity = stateCity;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country == "USA";
    }

    public string GetDisplayText()
    {
        return $"{_street}, {_city}, {_stateCity}, {_country}"; 
    }   
}