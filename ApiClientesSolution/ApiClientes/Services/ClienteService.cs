using ApiClientes.DTOs;
using ApiClientes.Repositories;

namespace ApiClientes.Services
{
	public class ClienteService : IClienteService
	{
		private readonly IClienteRepository _repo;

		public ClienteService(IClienteRepository repo)
		{
			_repo = repo;
		}

		public async Task<ClienteDto?> GetClienteByIdentificacionAsync(string identificacion)
		{
			var cliente = await _repo.GetByIdentificacionAsync(identificacion);
			if (cliente == null) return null;

			return new ClienteDto
			{
				Identificacion = cliente.Identificacion,
				Nombre = cliente.Nombre,
				Apellido = cliente.Apellido,
				Email = cliente.Email
			};
		}
	}
}
