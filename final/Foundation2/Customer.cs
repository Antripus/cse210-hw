public class Customer
{
    
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _address = address;
        _name = name;
    }

    public bool getLiveInUSA()
    {
        return _address.getLiveInUSA();
    }

    public string getAddress()
    {
        return _address.getFullAddress();
    }
    public string getName()
    {
        return _name;
    }
}