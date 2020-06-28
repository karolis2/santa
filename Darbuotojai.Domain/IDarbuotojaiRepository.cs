using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Darbuotojai.Domain.Models;

namespace Darbuotojai.Domain
{
    public interface IDarbuotojaiRepository
    {
        Task<List<Darbuotojas>> GetDarbuotojai();

        Task<Darbuotojas> GetDetails(int id);
        
        Task Delete(int id);

        Task Create(string vardas, string pavarde, string asmensKodas, DateTime gimimoData, int namoNr,
            string gatve, string miestas, string pastoKodas, bool aktyvus);
        
        Task Update(int id, string vardas, string pavarde, string asmensKodas, DateTime gimimoData, int namoNr,
            string gatve, string miestas, string pastoKodas, bool aktyvus);

    }
}