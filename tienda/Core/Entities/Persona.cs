namespace Core.Entities;

public class Persona {

    public int Id { get; set;}
    public string Documento{ get; set;}//idPersona
    public string NombrePersona { get; set;}
    public DateTime FechaNac{ get; set;}
    public int IdTipoPerFk { get; set;}
    public TipoPersona TipoPersona{ get; set;}
    public int IdRegionFk{ get; set;}
    public Region Region { get; set;}
    public ICollection<Producto> Productos{ get; set;}= new HashSet<Producto>();
    public ICollection<ProductoPersona> ProductoPersonas{ get; set;}


    
}