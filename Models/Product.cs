namespace ProductStore.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double UnitPrice { get; set; }
    public int Quantity { get; set; }

     
    public Product(int Id, String Name, Double UnitPrice, int Quantity) 
    {
        this.Id = Id;
        this.Name = Name;
        this.UnitPrice = UnitPrice;
        this.Quantity = Quantity;
    }
}