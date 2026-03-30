public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUSA()
    {
        // This method calls the address method to check the country
        return _address.IsInUSA();
    }

    public string GetName()
    {
        return _name;
    }

    public string GetFullAddress()
    {
        return _address.GetFullAddress();
    }
}
