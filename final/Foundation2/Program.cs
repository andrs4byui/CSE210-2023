using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        order1._products.Add(new Product("Skincream", 1215, 12, 3));
        order1._products.Add(new Product("Shampoo", 1523, 15, 2));
        order1._products.Add(new Product("Soap", 1054, 6, 2));
        order1.customer.CustomerName = "Andres Soruco";
        order1.customer.address = new Address("3068 north", "Lake Havasu", "Arizona", "USA");
        order1.PackingLabel();
        order1.ShippingLabel();
        
        Order order2 = new Order();
        order2._products.Add(new Product("Cellphone", 16542, 300, 2));
        order2._products.Add(new Product("Tablet", 15243, 500, 5));
        order2._products.Add(new Product("Laptoc", 11054, 1200, 4));
        order2.customer.CustomerName = "Nazir Reynoso";
        order2.customer.address = new Address("2511 Oruro Street", "Tarija", "Tarija", "Bolivia");
        order2.PackingLabel();
        order2.ShippingLabel();

        Order order3 = new Order();
        order3._products.Add(new Product("Chair", 542, 25, 10));
        order3._products.Add(new Product("Table", 243, 70, 5));
        order3._products.Add(new Product("Couch", 110, 200, 7));
        order3.customer.CustomerName = "Alcira Mamani";
        order3.customer.address = new Address("1415 Valdivia Street", "Calama", "Antofagasta", "Chile");
        order3.PackingLabel();
        order3.ShippingLabel();
    }
}