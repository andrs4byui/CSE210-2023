class Customer{ 
    string _customerName;
    public Address address;
    public bool usaAddress;
    public Customer(){

    }

    public string CustomerName { get => _customerName; set => _customerName = value; }

    public void LivesInUSA(){
        if (address.LivesInUSA()){
            usaAddress = true;
        }
        else {
            usaAddress = false;
        } 
    }
}