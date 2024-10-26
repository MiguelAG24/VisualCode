using Microsoft.EntityFrameworkCore;

namespace ApiTarea.Models;
public class Conexiones : DbContext {
public Conexiones(DbContextOptions<Conexiones> options)
        : base(options){
    }

    public DbSet<Clientes> Clientes { get; set; } = null!;

}