using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Darbuotojai.Domain.Models;

namespace Darbuotojai.Application.ViewModels
{

    public class DarbuotojasDto
    {
        public int Id { get; set; }
        public string Vardas { get; set; }
        public string Pavardė { get; set; }
        [Display(Name = "Asmens Kodas", AutoGenerateFilter=false)]
        public string AsmensKodas { get; set; }
        [Display(Name = "Gimimo Data", AutoGenerateFilter=false)]
        public DateTime GimimoData { get; set; }
        [Display(Name = "Namo Nr.", AutoGenerateFilter=false)]
        public int NamoNumeris { get; set; }
        public string Gatve { get; set; }
        public string Miestas { get; set; }
        [Display(Name = "Pašto kodas", AutoGenerateFilter=false)]

        public string PastoKodas { get; set; }
        public bool Aktyvus { get; set; }
        
    }

}