using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Darbuotojai.Domain;
using Darbuotojai.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Darbuotojai.Architecture.Infra.Data.Repositories
{
    public class DarbuotojaiRepository : IDarbuotojaiRepository
    {

        public DarbuotojaiDbContext _context;

        public DarbuotojaiRepository(DarbuotojaiDbContext context)
        {
            _context = context;
        }

        public async Task<List<Darbuotojas>> GetDarbuotojai()
        {
            return await _context.Darbuotojai.ToListAsync();
        }

        public async Task Create(string vardas, string pavarde, string asmensKodas, DateTime gimimoData, int namoNr,
            string gatve, string miestas, string pastoKodas, bool aktyvus)

        {
            var darbuotojas = new Darbuotojas
            {
                Vardas = vardas,
                Pavardė = pavarde,
                AsmensKodas = asmensKodas,
                GimimoData = gimimoData,
                NamoNumeris = namoNr,
                Gatve = gatve,
                Miestas = miestas,
                PastoKodas = pastoKodas,
                Aktyvus = aktyvus
            };

            await _context.Darbuotojai.AddAsync(darbuotojas);
            
           await _context.SaveChangesAsync();
        }

        public async Task<Darbuotojas> GetDetails(int id)
        {
            
            return await _context.Darbuotojai
                .FirstOrDefaultAsync(m => m.Id == id);
            
        }

        public async Task Delete(int id)
        {
            var darbuotojas = await _context.Darbuotojai
                .Where(x => x.Id == id)
                .SingleAsync();

            _context.Darbuotojai.Remove(darbuotojas);

            await _context.SaveChangesAsync();
            
        }

        public async Task Update(int id, string vardas, string pavarde, string asmensKodas, DateTime gimimoData,
            int namoNr,
            string gatve, string miestas, string pastoKodas, bool aktyvus)
        {
            var darbuotojas = await _context.Darbuotojai
                .Where(x => x.Id == id)
                .SingleAsync();

            darbuotojas.Id = id;
            darbuotojas.Vardas = vardas;
            darbuotojas.Pavardė = pavarde;
            darbuotojas.AsmensKodas = asmensKodas;
            darbuotojas.GimimoData = gimimoData;
            darbuotojas.NamoNumeris = namoNr;
            darbuotojas.Gatve = gatve;
            darbuotojas.Miestas = miestas;
            darbuotojas.PastoKodas = pastoKodas;
            darbuotojas.Aktyvus = aktyvus;

            await _context.SaveChangesAsync();
        }

    }
}