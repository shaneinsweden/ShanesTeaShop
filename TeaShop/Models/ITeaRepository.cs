using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeaShop.Models
{
    public interface ITeaRepository
    {
        IEnumerable<Tea> Teas { get; }

        IEnumerable<Tea> TeasOfTheWeek { get; }

        Tea GetTeaById(int teaId);
    }
}
