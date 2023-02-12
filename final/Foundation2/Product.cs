using System;
public class Product{
    private string _name;
    private string _productid;
    private int _price;
    private int _quantity;

    public Product(string name, string id, int unitPriceCents, int quantity){
        _name = name;
        _productid = id;
        _price = unitPriceCents;
        _quantity = quantity;
    }

    public string GetName(){
        return _name;
    }

    public string GetId(){
        return _productid;
    }
    public decimal getPrice(){
        return _price * _quantity;
    } 
}