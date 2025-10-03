using ApiClientes.Models;

namespace ApiClientes.Repositories
{
	public interface IClienteRepository
	{
		Task<Cliente?> GetByIdentificacionAsync(string identificacion);
	}
}
