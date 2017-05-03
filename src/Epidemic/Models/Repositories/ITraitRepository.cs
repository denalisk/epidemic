using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epidemic.Models.Repositories
{
    public interface ITraitRepository
    {
        IQueryable<Trait> Traits { get; }
        Trait Save(Trait trait);
    }
}
