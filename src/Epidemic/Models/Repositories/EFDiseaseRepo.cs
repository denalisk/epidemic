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

        public IQueryable<Disease> Diseases
        { get { return db.Diseases; } }

        public Disease Save(Disease disease)
        {
            db.Diseases.Add(disease);
            db.SaveChanges();
            return disease;
        }

        public Disease Edit(Disease disease)
        {
            db.Entry(disease).State = EntityState.Modified;
            db.SaveChanges();
            return disease;
        }

        public void Remove(Disease disease)
        {
            db.Diseases.Remove(disease);
            db.SaveChanges();
        }
    }
}
