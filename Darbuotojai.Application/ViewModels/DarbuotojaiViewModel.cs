using System;
using System.Collections.Generic;
using Darbuotojai.Domain.Models;

namespace Darbuotojai.Application.ViewModels
{

    public class DarbuotojasDto
    {
        public int Id { get; set; }
        public string Vardas { get; set; }
        public string Pavardė { get; set; }
        public string AsmensKodas { get; set; }
        public DateTime GimimoData { get; set; }
        public int NamoNumeris { get; set; }
        public string Gatve { get; set; }
        public string Miestas { get; set; }
        public string PastoKodas { get; set; }
        public bool Aktyvus { get; set; }
        
    }

}