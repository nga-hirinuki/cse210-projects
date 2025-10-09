public class Customer
{
    private string _name;
    private Address _address;

  public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // properties
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public Address Address
    {
        get { return _address; }
        set { _address = value; }
    }
    public bool LivesInUSA()
    {
        return _address != null && _address.IsInUSA();//returns true
    }
}
