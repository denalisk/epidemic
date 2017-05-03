using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epidemic.Models.Repositories
{
    public interface ICountryRepository
    {
        IQueryable<Country> Countries { get; }
        Country Save(Country country);
    }
}
