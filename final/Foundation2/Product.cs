class Product {
    string _name;
    int _productID;
    int _price;
    private int _quantity;

    public int Quantity { get => _quantity; set => _quantity = value; }
    public int Price { get => _price; set => _price = value; }
    public int ProductID { get => _productID; set => _productID = value; }
    public string Name { get => _name; set => _name = value; }

    public Product(string name, int productID, int price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public int ProductPrice(){
        return _price * _quantity;
    }
}