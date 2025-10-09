public class Product
{
    private string _name;
    private double _price;
    private int _quantity;
    private int _productId;

    public Product(string name, double price, int productId, int quantity)
    {
        _name = name;
        _price = price;
        _quantity = quantity;
        _productId = productId;
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public double Price
    {
        get { return _price; }
        set { _price = value; }
    }
    public int Quantity
    {
        get { return _quantity; }
        set { _quantity = value; }
    }
    public int ProductId
    {
        get { return _productId; }
        set { _productId = value; }
    }

    public double GetTotalPrice()
    {
        return Price * Quantity;// This is the total price of the product
    }

}