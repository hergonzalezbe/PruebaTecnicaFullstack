using Microsoft.EntityFrameworkCore;

namespace ApiClientes.Models
{
	public class ClientesDbContext : DbContext
	{
		public ClientesDbContext(DbContextOptions<ClientesDbContext> options) : base(options) { }

		public DbSet<Cliente> Clientes { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Cliente>(entity =>
			{
				entity.HasKey(e => e.IdCliente);
			});
		}

	}
}
