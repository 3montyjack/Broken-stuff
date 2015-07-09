using MLB_Basseball_Stats.Models;
using System.Linq;

namespace MLB_Baseball_Stats.Models
{
    public interface IRepository
    {
        IQueryable<Team> GetAllTeams();

        IQueryable<Player> GetAllPlayers();

        //Order GetOrder(int Id);

        //string MetaData { get; }

        //SaveResult SaveChanges(JObject saveBundle);

        //IQueryable<Team> Teams();
    }
}