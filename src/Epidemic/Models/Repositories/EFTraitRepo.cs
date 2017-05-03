using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epidemic.Models.Repositories
{
    public class EFTraitRepo : ITraitRepository
    {
        EpidemicDbContext db = new EpidemicDbContext();

        public IQueryable<Trait> Traits
        { get { return db.Traits; } }

        public Trait Save(Trait trait)
        {
            db.Traits.Add(trait);
            db.SaveChanges();
            return trait;
        }

        public Trait Edit(Trait trait)
        {
            db.Entry(trait).State = EntityState.Modified;
            db.SaveChanges();
            return trait;
        }

        public void Remove(Trait trait)
        {
            db.Traits.Remove(trait);
            db.SaveChanges();
        }
    }
}
