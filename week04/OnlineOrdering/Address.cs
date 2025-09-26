public class Address
    {
        private string _street;
        private string _city;
        private string _stateOrProvince;
        private string _country;

        public Address(string street, string city, string stateOrProvince, string country)
        {
            _street = street;
            _city = city;
            _stateOrProvince = stateOrProvince;
            _country = country;
        }

        // Check if the address is in the USA
        public bool AddressInUsa()
        {
            return _country.ToUpper() == "USA";
        }

        // Return full address string
        public string GetFullAddress()
        {
            return $"{_street}\n{_city}, {_stateOrProvince}\n{_country}";
        }
    }