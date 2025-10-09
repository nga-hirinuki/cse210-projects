using System.Text;

public class Order
{
   private List<Product> _product;
   private Customer _customer;
   private int _orderId;

   public Order(Customer customer)
   {
    _customer = customer;
    _product = new List<Product>();
    _orderId = 0;
    }

    public void AddProduct(Product product)
    {
        _product.Add(product);
    }

    public string GetPackingLabel() // method for packing label
    {
        StringBuilder pl = new StringBuilder();// concatenating strings together
        pl.AppendLine("Packing Label:");//add title 

        foreach (var product in _product) // foreach product in _product
        {
            pl.AppendLine($"{product.Name} (ID: {product.ProductId})");// concatenate pl with product name and productid
        }

        return pl.ToString();
    }
    public string GetShippingLabel()
    {
        var address = _customer.Address;
        return $"Shipping Label:\n{_customer.Name}\n{address.Street}\n{address.City}, {address.State}\n{address.Country}";
    }
    public double GetTotalCost()// method
    {
        double productTotal = 0; //declare variable

        foreach (var product in _product) 
        {
            productTotal += product.GetTotalPrice();// grab price and quantity from product class
        }

        double shippingCost = _customer.LivesInUSA() ? 5.0 : 35.0;// declare variable and if customer lives in the USA, charge $5, if not, charge $35

        return productTotal + shippingCost;// 

    }
}