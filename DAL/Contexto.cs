using Microsoft.EntityFrameworkCore;
using Entidades;

namespace DAL
{
    public partial class Contexto : DbContext
    {
        public DbSet<Productos> Productos {get;set;}
        public Contexto(DbContextOptions<Contexto> options) : base (options){}
    }
}