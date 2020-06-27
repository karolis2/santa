using System.Collections.Generic;
using Darbuotojai.Domain.Models;

namespace Darbuotojai.Application.ViewModels
{
    public class DarbuotojaiViewModel
    {
        public IEnumerable<Darbuotojas> Darbuotojai { get; set; }
    }
}