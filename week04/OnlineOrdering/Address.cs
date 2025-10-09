public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // properties
    public string Street
    {
        get { return _street; }
        set { _street = value; }
    }
    public string City
    {
        get { return _city; }
        set { _city = value; }
    }
    public string State
    {
        get { return _state; }
        set { _state = value; }
    }
    public string Country
    {
        get { return _country; }
        set { _country = value; }
    }
    public bool IsInUSA()
    {
        return _country != null && _country.Trim().ToLower() == "usa";// takes care of user inputting different versions of USa
    }
  
}