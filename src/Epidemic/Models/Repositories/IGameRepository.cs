using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epidemic.Models.Repositories
{
    public interface IGameRepository
    {
        IQueryable<Game> Games { get; }
        Game Save(Game game);
    }
}
