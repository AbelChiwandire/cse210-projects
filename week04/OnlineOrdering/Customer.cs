public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Return customer name
    public string GetName()
    {
        return _name;
    }

    // Return whether customer lives in the USA or not
    public bool CustomerInUsa()
    {
        return _address.AddressInUsa();
    }

    // Return full address string
    public string GetAddress()
    {
        return _address.GetFullAddress();
    }
}
