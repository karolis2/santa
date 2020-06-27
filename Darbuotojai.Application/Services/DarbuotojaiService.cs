using System;
using Darbuotojai.Application.ViewModels;
using Darbuotojai.Domain;

namespace Darbuotojai.Application.Services
{
    
    public interface IDarbuotojaiService
    {
        DarbuotojaiViewModel GetDarbuotojai(); 
    }
    
    public class DarbuotojaiService : IDarbuotojaiService
    {
        
        public IDarbuotojaiRepository _darbuotojaiRepository;
        
        public DarbuotojaiService(IDarbuotojaiRepository darbuotojaiRepository)
        {
            _darbuotojaiRepository = darbuotojaiRepository;
        }
        
        public DarbuotojaiViewModel GetDarbuotojai()
        {
            return new DarbuotojaiViewModel()
            {
                Darbuotojai = _darbuotojaiRepository.GetDarbuotojai()
            };
        }
    }
}