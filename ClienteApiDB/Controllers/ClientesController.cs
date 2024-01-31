using ClienteApiDB.DAL;
using ClienteApiDB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClienteApiDB.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ClientesController : ControllerBase
	{
		private readonly Context _context;

		public ClientesController(Context context)
		{
			_context = context;
		}

		[HttpGet("Exist/{id}")]
		public bool Exist(int id)
		{
			return _context.Clientes.Any(c => c.IdCliente == id);
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Clientes>>> GetClientes()
		{
			if (_context.Clientes == null)
			{
				return NotFound();
			}
			return await _context.Clientes.ToListAsync();
		}


		[HttpGet("{id}")]
		public async Task<ActionResult<Clientes>> GetClientes(int id)
		{
			if (_context.Clientes == null)
			{
				return NotFound();
			}
			var Clientes = await _context.Clientes.FindAsync(id);

			if (Clientes == null)
			{
				return NotFound();
			}

			return Clientes;
		}

		[HttpPost]
		public async Task<ActionResult<Clientes>> PostClientes(Clientes clientes)
		{
			_context.Clientes.Add(clientes);
			await _context.SaveChangesAsync();

			return CreatedAtAction("GetClientes", new { id = clientes.IdCliente }, clientes);
		}
	}
}
