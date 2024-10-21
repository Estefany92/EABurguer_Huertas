using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EABurguer_Huertas.Models;

    public class EABurguer_HuertasContext : DbContext
    {
        public EABurguer_HuertasContext (DbContextOptions<EABurguer_HuertasContext> options)
            : base(options)
        {
        }

        public DbSet<EABurguer_Huertas.Models.Burger> Burger { get; set; } = default!;

public DbSet<EABurguer_Huertas.Models.Promo> Promo { get; set; } = default!;
    }
