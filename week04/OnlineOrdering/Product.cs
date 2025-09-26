public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Calculate total cost of the product
    public double ProductTotalCost()
    {
        return _price * _quantity;
    }

    // Getter for product name
    public string GetName()
    {
        return _name;
    }

    // Getter for product ID
    public string GetId()
    {
        return _productId;
    }
}
