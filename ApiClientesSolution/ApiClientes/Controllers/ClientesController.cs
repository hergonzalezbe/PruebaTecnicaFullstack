using ApiClientes.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiClientes.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ClientesController : ControllerBase
	{
		private readonly IClienteService _service;

		public ClientesController(IClienteService service)
		{
			_service = service;
		}

		[HttpGet("{identificacion}")]
		public async Task<IActionResult> GetCliente(string identificacion)
		{
			var cliente = await _service.GetClienteByIdentificacionAsync(identificacion);
			if (cliente == null)
				return NotFound(new { message = "Cliente no encontrado" });

			return Ok(cliente);
		}
	}
}
