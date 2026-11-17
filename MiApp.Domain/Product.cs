namespace MiApp.Domain;
/* Entidad de negocio*/
public class Product
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public int Stock { get; private set; }

    public Product(){ Name = null!; }

    public Product(Guid id, string name, decimal price, int stock)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new DomainException("El nombre es obligatorio.");
        if (price <= 0)
            throw new DomainException("El precio no puede ser negativo.");
        if (stock <= 0)
            throw new DomainException("La cantidad ingresada no puede ser negativa.");

        Id = id;
        Name = name;
        Price = price;
        Stock = stock;

    }
}
