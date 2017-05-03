using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epidemic.Models.Repositories
{
    public class EFDiseaseRepo : IDiseaseRepository
    {
        EpidemicDbContext db = new EpidemicDbContext();
    }
}
