using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMelange.Models;

    public class MelangePurchaseContext : DbContext
    {
        public MelangePurchaseContext (DbContextOptions<MelangePurchaseContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMelange.Models.MelangePurchase> MelangePurchase { get; set; }
    }
