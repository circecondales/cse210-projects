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

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double subtotal = 0;

        foreach (Product product in _products)
        {
            subtotal = subtotal + product.GetTotalCost();
        }

        double shippingCost;
        if (_customer.LivesInUSA())
        {
            shippingCost = 5.00;
        }
        else
        {
            shippingCost = 35.00;
        }

        return subtotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "--- PACKING LABEL ---\n";
        foreach (Product p in _products)
        {
            label = label + "Product: " + p.GetName() + " - ID: " + p.GetId() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "--- SHIPPING LABEL ---\n";
        label = label + _customer.GetName() + "\n";
        label = label + _customer.GetFullAddress() + "\n";
        return label;
    }
}