public class Address
{

    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public string getFullAddress()
    {
        string fullAddress= _streetAddress + ", " + _city + ", " + _stateOrProvince + ", " + _country + ". ";
        // Direccion, Ciudad, Provicia, Pais.
        return fullAddress;
    }

    public bool getLiveInUSA()
    {
        if (_country == "USA" || _country == "United State"){
            return true;
        }
        else
        {
            return false;
        }
    }
}