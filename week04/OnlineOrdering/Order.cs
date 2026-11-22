using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        double shippingCost = 0;

        if (_customer.IsInNIGERIA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        return total + shippingCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();

        label.AppendLine("PACKING LABEL");
        label.AppendLine("--------------------");

        foreach (Product product in _products)
        {
            label.AppendLine(
                $"{product.GetName()} - ID: {product.GetProductId()}"
            );
        }

        return label.ToString();
    }

    public string GetShippingLabel()
    {
        StringBuilder label = new StringBuilder();

        label.AppendLine("SHIPPING LABEL");
        label.AppendLine("--------------------");
        label.AppendLine(_customer.GetName());
        label.AppendLine(_customer.GetAddressString());

        return label.ToString();
    }
}