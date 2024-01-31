using System.ComponentModel.DataAnnotations;

namespace ClienteApiDB.Models
{
	public class Clientes
	{
		[Key]

        public int IdCliente { get; set; }

		public string Nombre { get; set; }

		public string Apellido { get; set; }

		public string Email { get; set; }

    }
}
