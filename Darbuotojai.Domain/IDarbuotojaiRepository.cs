using System.Collections.Generic;
using Darbuotojai.Domain.Models;

namespace Darbuotojai.Domain
{
    public interface IDarbuotojaiRepository
    {
        IEnumerable<Darbuotojas> GetDarbuotojai();
    }
}