public class Customer
{
    private string _name;
    private Address _address;

    // Nested Address class
    private class Address
    {
        private string street;
        private string city;
        private string stateOrProvince;
        private string country;

        public Address(string street, string city, string stateOrProvince, string country)
        {
            this.street = street;
            this.city = city;
            this.stateOrProvince = stateOrProvince;
            this.country = country;
        }

        // Check if the address is in the USA
        public bool AddressInUsa()
        {
            return country.ToUpper() == "USA";
        }

        // Return full address string
        public string GetFullAddress()
        {
            return $"{street}\n{city}, {stateOrProvince}\n{country}";
        }
    }

    public Customer(string name, string street, string city, string stateOrProvince, string country)
    {
        _name = name;
        _address = new Address(street, city, stateOrProvince, country);
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
