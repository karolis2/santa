using System;
using System.ComponentModel.DataAnnotations;

namespace Darbuotojai.Domain.Models
{
    public class Darbuotojas
    {
        [Key]
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