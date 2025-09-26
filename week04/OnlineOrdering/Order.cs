using System.Collections.Generic;
public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>(); 
    }

    // Add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Calculate total cost => sum of product totals plus shipping
    public double GetTotalCost()
    {
        double total = 0;

        foreach (var product in _products)
        {
            total += product.ProductTotalCost();
        }

        // Determine shipping cost based on customer address
        double shippingCost = _customer.CustomerInUsa() ? 5.0 : 35.0;
        total += shippingCost;

        return total;
    }

    // Return packing label string
    public string GetPackingLabel()
    {
        string label = "\nPacking Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetId()})\n";
        }
        return label;
    }

    // Return shipping label string
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress()}\n";     
    }
}
