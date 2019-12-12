using Microsoft.EntityFrameworkCore;
using MvcMelange.Models;

namespace MvcMelange.Data
{
	public class MvcMelangePurchaseContext :DbContext
	{
		public MvcMelangePurchaseContext (DbContextOptions<MvcMelangePurchaseContext> options)
		:base(options)
		{

		}
		public DbSet<MelangePurchase> MelangePurchase {get; set;}
	}
}