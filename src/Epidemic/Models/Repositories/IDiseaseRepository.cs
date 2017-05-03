using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epidemic.Models.Repositories
{
    public interface IDiseaseRepository<Disease>
    {
        IQueryable<Disease> ReturnedObjects { get; }
        Disease Save(Disease disease);
    }
}
