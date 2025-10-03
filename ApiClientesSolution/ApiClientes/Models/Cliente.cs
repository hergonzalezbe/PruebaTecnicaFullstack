﻿using System.ComponentModel.DataAnnotations;

namespace ApiClientes.Models
{
	public class Cliente
	{
		[Key]
		public int IdCliente { get; set; }

		public string Identificacion { get; set; } = string.Empty;
		public string Nombre { get; set; } = string.Empty;
		public string Apellido { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public DateTime FechaCreacion { get; set; }
		public DateTime? FechaActualizacion { get; set; }
	}
}
