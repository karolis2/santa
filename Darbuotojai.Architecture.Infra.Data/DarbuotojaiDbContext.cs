using Microsoft.EntityFrameworkCore;
using System.Linq;
using Darbuotojai.Domain.Models;

namespace Darbuotojai.Architecture.Infra.Data
{
    public class DarbuotojaiDbContext : DbContext
    {
        public DarbuotojaiDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public virtual DbSet<Darbuotojas> Darbuotojai { get; set; }
    }
}