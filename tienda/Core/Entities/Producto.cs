namespace Core.Entities;

public class Producto{
    public int Id { get; set;}
    public int CodInterno{ get; set;}
    public string Nombre { get; set;}
    public int StockMin{ get; set;}
    public int StockMax{ get; set;}
    public int Stock { get; set;}
    public double ValorVta { get; set;}

    public ICollection<Persona> Personas = new HashSet<Persona>();
    public ICollection<ProductoPersona> ProductoPersonas{ get; set;}
    
}   