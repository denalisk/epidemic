using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Epidemic.Models.Repositories
{
    public class EFCountryRepo : ICountryRepository
    {
        EpidemicDbContext db = new EpidemicDbContext();

        public IQueryable<Country> Countries
        { get { return db.Countries; } }

        public Country Save(Country country)
        {
            db.Countrys.Add(country);
            db.SaveChanges();
            return country;
        }

        public Country Edit(Country country)
        {
            db.Entry(country).State = EntityState.Modified;
            db.SaveChanges();
            return country;
        }

        public void Remove(Country country)
        {
            db.Countrys.Remove(country);
            db.SaveChanges();
        }
    }
}
