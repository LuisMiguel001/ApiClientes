using ClienteApiDB.Models;
using Microsoft.EntityFrameworkCore;

namespace ClienteApiDB.DAL
{
	public class Context :DbContext
	{
		public Context(DbContextOptions<Context> Options)
			: base(Options) { }

		public DbSet<Clientes> Clientes { get; set; }
	}
}
