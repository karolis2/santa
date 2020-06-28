using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Darbuotojai.Application.ViewModels;
using Darbuotojai.Domain;

namespace Darbuotojai.Application.Services
{
    
    public interface IDarbuotojaiService
    {
        Task<List<DarbuotojasDto>> GetDarbuotojai();

        Task Create(string vardas, string pavarde, string asmensKodas, DateTime gimimoData, int namoNr,
            string gatve, string miestas, string pastoKodas, bool aktyvus);
        
        Task Update(int id, string vardas, string pavarde, string asmensKodas, DateTime gimimoData, int namoNr,
            string gatve, string miestas, string pastoKodas, bool aktyvus);

        Task<DarbuotojasDto> GetDetails(int id);
        
        Task Delete(int id);
    }
    
    public class DarbuotojaiService : IDarbuotojaiService
    {
        
        public IDarbuotojaiRepository _darbuotojaiRepository;
        
        public DarbuotojaiService(IDarbuotojaiRepository darbuotojaiRepository)
        {
            _darbuotojaiRepository = darbuotojaiRepository;
        }

        public async Task<List<DarbuotojasDto>> GetDarbuotojai()
        {
            var darbuotojai = await _darbuotojaiRepository.GetDarbuotojai();

            return darbuotojai
                .Select(x => new DarbuotojasDto
                {
                    Id = x.Id,
                    Vardas = x.Vardas,
                    Pavardė = x.Pavardė,
                    AsmensKodas = x.AsmensKodas,
                    GimimoData = x.GimimoData,
                    NamoNumeris = x.NamoNumeris,
                    Gatve = x.Gatve,
                    Miestas = x.Miestas,
                    PastoKodas = x.PastoKodas,
                    Aktyvus = x.Aktyvus
                })
                .ToList();
        }
        
        public async Task Create(string vardas, string pavarde, string asmensKodas, DateTime gimimoData, int namoNr,
            string gatve, string miestas, string pastoKodas, bool aktyvus)
        {
            await _darbuotojaiRepository.Create(vardas,  pavarde,  asmensKodas,  gimimoData, namoNr,
             gatve,  miestas,  pastoKodas, aktyvus);
        }

        public async Task Update(int id, string vardas, string pavarde, string asmensKodas, DateTime gimimoData,
            int namoNr,
            string gatve, string miestas, string pastoKodas, bool aktyvus)
        {
            await _darbuotojaiRepository.Update(id, vardas,  pavarde,  asmensKodas,  gimimoData, namoNr,
                gatve,  miestas,  pastoKodas, aktyvus);
        }

        public async Task Delete(int id)
        {
            await _darbuotojaiRepository.Delete(id);
        }

        public async Task<DarbuotojasDto> GetDetails(int id)
        {
            var darbuotojas = await _darbuotojaiRepository.GetDetails(id);
            return new DarbuotojasDto
            {
                Id = darbuotojas.Id,
                Vardas = darbuotojas.Vardas,
                Pavardė = darbuotojas.Pavardė,
                AsmensKodas = darbuotojas.AsmensKodas,
                GimimoData = darbuotojas.GimimoData,
                NamoNumeris = darbuotojas.NamoNumeris,
                Gatve = darbuotojas.Gatve,
                Miestas = darbuotojas.Miestas,
                PastoKodas = darbuotojas.PastoKodas,
                Aktyvus = darbuotojas.Aktyvus
            };
        }
        
    }
}