using System;
public class Order{
    private List<Product> _products;
    private Customer _customer;

    public Order( Customer customer){
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product){
        _products.Add(product);
    }

    public decimal TotalCost(){
        decimal totalCost = 0;
        foreach (Product product in _products){
            totalCost += product.getPrice();
        }
        return totalCost;
    }

    public string PackingLabel(){
        string packingLabel = "Packing Label:";
        packingLabel += "\n Name  -  ID";
        foreach (Product product in _products){
            packingLabel += "\n"+ product.GetName() + "  -  " + product.GetId();
        }
        return packingLabel;
    }


    public string ShippingLabel(){
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += _customer.GetName() + "\n";
        shippingLabel += _customer.GetAddress();
        return shippingLabel;
    }

    public decimal ShippingPrice(){
        if(_customer.IsUSCustomer()){
            return 500;
        }
        return 3500;
    }

    public decimal TotalPrice(){
        return (TotalCost() + ShippingPrice())/(decimal)100;    
    }
}