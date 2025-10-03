using ApiClientes.DTOs;

namespace ApiClientes.Services
{
	public interface IClienteService
	{
		Task<ClienteDto?> GetClienteByIdentificacionAsync(string identificacion);
	}
}
