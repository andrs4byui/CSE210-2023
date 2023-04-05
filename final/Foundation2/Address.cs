class Address{
    string _streetAddress;
    string _city;
    string _stateOrProvince;
    string _country;
    string fullAddress;

    public string FullAddress { get => fullAddress; set => fullAddress = value; }

    public Address(){

    }
    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }
    public bool LivesInUSA(){
        if (_country == "USA"|| _country == "Unated States"){
            return true;
            }
        else {
            return false;
        }
    }

    public string DisplayAddress(){
        return $"{_streetAddress}, {_city} - {_stateOrProvince}, {_country}";
        //Console.WriteLine(FullAddress);
    }
}