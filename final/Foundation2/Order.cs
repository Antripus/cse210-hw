public class Order
{


    private List<Product> _productos = new List<Product>();
    private Customer _cliente;
    private float _totalCost;
    private int _shippingCost;


    public Order (Customer cliente) 
    {
        _cliente = cliente;
        
        
        //If the customer lives in the USA, then the shipping cost is $5. 
        //If the customer does not live in the USA, then the shipping cost is $35.
        if (cliente.getLiveInUSA())
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }
        
    }

    private void calculateTotalCost()
    {
        //Recorro todos los productos y calculo el costo de todos ellos
        foreach (Product p in _productos)
        {
            _totalCost = _totalCost + p.getTotalPrice();
        }

        _totalCost = _totalCost + _shippingCost;
    }

    public List<string> getPackingLabel () //name and product id of each product in the order.
    {
        List<string> packingLabel = new List<string>();

        int x = 0;
        foreach (Product p in _productos)
            {
                x = x+1;
                packingLabel.Add (x + " - " + p.getName() + " / " + p.getProductID());
            }
        return packingLabel;
    }
    public string getShippingLabel () //name and address of the customer
    {
        string shippingLabel;

        string direccion = _cliente.getAddress();
        string nombre = _cliente.getName();
        shippingLabel = nombre + "\n" + direccion;
        
        return shippingLabel;
    }

    public float getTotalCost ()
    {
        calculateTotalCost(); // calculo el costo total antes de devolverlo
        return _totalCost;
    }

    // public void addProducts(string name, string productID, float price, int quantity)
    // {
    //     Product producto = new Product(name, productID,price,quantity);
    //     _productos.Add(producto);
    // }
    public void addProduct(Product producto)
    {
        _productos.Add(producto);
    }
}