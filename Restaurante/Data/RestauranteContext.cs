using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Restaurante.Models;

namespace Restaurante.Data
{
    public class RestauranteContext : DbContext
    {
        public RestauranteContext (DbContextOptions<RestauranteContext> options)
            : base(options)
        {
        }

        public DbSet<Restaurante.Models.Clientes> Clientes { get; set; } = default!;
    }
}
