
using MiApp.Domain;

namespace MiApp.Aplication.Interfaces;
/* PUERTO: lo que la aplicación necesita del almacenamiento.
 * Lo define Aplicación (quien lo necesita) y lo implementa Infraestructura.
    Así la dependencia de código apunta hacia adentro.*/
public interface IProductRepository
{

    Task AddAsync(Product product);
    Task<Product?> GetByIdAsync(Guid id);
}
