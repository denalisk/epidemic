using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Epidemic.Models.Repositories
{
    public class EFGameRepo : IGameRepository
    {
        EpidemicDbContext db = EpidemicDbContext();
    }
}
