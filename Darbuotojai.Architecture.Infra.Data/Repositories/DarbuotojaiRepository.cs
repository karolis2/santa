using System;
using System.Collections.Generic;
using Darbuotojai.Domain;
using Darbuotojai.Domain.Models;

namespace Darbuotojai.Architecture.Infra.Data.Repositories
{
    public class DarbuotojaiRepository : IDarbuotojaiRepository
    {
        
        public DarbuotojaiDbContext _context;

        public DarbuotojaiRepository(DarbuotojaiDbContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Darbuotojas> GetDarbuotojai()
        {
            return _context.Darbuotojai;
        }
        
    }
}