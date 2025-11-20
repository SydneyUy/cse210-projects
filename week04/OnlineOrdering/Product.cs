class Product
{
    private string _name;
    private int _ID;
    private double _price;
    private int _quantity;

    public Product(string name, int ID, double price, int quantity)
    {
        _name = name;
        _ID = ID;
        _price = price;
        _quantity = quantity;
    }

    public double getTotalCost()
    {
        double totalCost = _price * _quantity;
        return totalCost;
    }
    public string GetName() => _name;
    public int GetProductId() => _ID;
}