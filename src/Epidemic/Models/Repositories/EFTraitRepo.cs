using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epidemic.Models.Repositories
{
    public class EFTraitRepo : ITraitRepository
    {
        EpidemicDbContext db = new EpidemicDbContext();
    }
}
