using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Epidemic.Models;

namespace Epidemic.Models.Repositories
{
    public class EFGameRepo : IGameRepository
    {
        EpidemicDbContext db = new EpidemicDbContext();

        public IQueryable<Game> Games
        { get { return db.Games; } }

        public Game Save(Game game)
        {
            db.Games.Add(game);
            db.SaveChanges();
            return game;
        }

        public Game Edit(Game game)
        {
            db.Entry(game).State = EntityState.Modified;
            db.SaveChanges();
            return game;
        }

        public void Remove(Game game)
        {
            db.Games.Remove(game);
            db.SaveChanges();
        }
    }
}
