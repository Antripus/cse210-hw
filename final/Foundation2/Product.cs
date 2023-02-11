public class Product 
{

    private string _name;
    private string _productID;
    private float _price;
    private int _quantity;
    private float _totalPrice;

    public Product(string name, string productID, float price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
        _totalPrice = quantity * price;

    }

    public string getName ()
    {
        return _name;
    }

    public string getProductID ()
    {
        return _productID;
    }
    
    public float getPrice ()
    {
        return _price;
    }
    
    public int getQuantity ()
    {
        return _quantity;
    }
    public float getTotalPrice ()
    {
        return _totalPrice;
    }
}
