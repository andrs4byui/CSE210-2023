class Order {
    public List<Product> _products = new List<Product>();
    public Customer customer = new Customer();

    int _usaShippingCost = 5;
    int _internationalShippingCost = 35;
    int _totalCost; 

    public void DisplayProductCost(){

    }
    public void PackingLabel(){
        customer.LivesInUSA();
        Console.WriteLine("LIST OF PRODUCTS");
        Console.WriteLine("Product Name     | Product ID    | Product price | Product Quatity   | Product cost");
        for (int i = 0; i < _products.Count(); i++){
            Console.WriteLine($"{_products[i].Name}     {_products[i].ProductID}    {_products[i].Price}$us    {_products[i].Quantity}  {_products[i].ProductPrice()}$us");
            _totalCost += _products[i].ProductPrice();
        }
        Console.WriteLine("---------------------------------");
        if (customer.usaAddress == true){
            Console.WriteLine("USA Shipping Cost: " + _usaShippingCost + "$us");
            Console.WriteLine("Products cost: " + _totalCost + "$us");
            Console.WriteLine($"Total Cost: {_totalCost + _usaShippingCost}$us");
        }
        else {
            Console.WriteLine("International Shipping Cost: " + _internationalShippingCost + "$us");
            Console.WriteLine("Products cost: " + _totalCost + "$us");
            Console.WriteLine($"Total Cost: {_totalCost + _internationalShippingCost}$us");
        }
        Console.WriteLine("---------------------------------");
    }
    public void ShippingLabel(){
        Console.WriteLine("************************************");
        Console.WriteLine("Shipping information");
        Console.WriteLine($"{customer.CustomerName} : {customer.address.DisplayAddress()}");
        Console.WriteLine("************************************");
    }


}