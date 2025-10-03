using ApiClientes.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiClientes.Repositories
{
	public class ClienteRepository : IClienteRepository
	{
		private readonly ClientesDbContext _context;

		public ClienteRepository(ClientesDbContext context)
		{
			_context = context;
		}

		public async Task<Cliente?> GetByIdentificacionAsync(string identificacion)
		{
			var clientes = await _context.Clientes
		.FromSqlInterpolated($"EXEC spGetClienteByIdentificacion {identificacion}")
		.AsNoTracking()            
		.ToListAsync();            

			return clientes.FirstOrDefault(); 
		}
	}
}
