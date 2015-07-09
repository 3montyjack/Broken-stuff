using MLB_Baseball_Stats.Models;
using System.Linq;

namespace MLB_Basseball_Stats.Models
{
    public class Repository : IRepository
    {
        private Context db;
        private Context db2;

        public IQueryable<Team> GetAllTeams()
        {
            return db.team;
        }

        public IQueryable<Player> GetAllPlayers()
        {
            return db2.player;
        }

        /*internal List<Team> Retrieve()
        {
            var SQL = db.
        }

        internal Team Save(int id, Team team)
        {
        }*/

        /*public string Metadata
        {
            get { return db.Metadata()}
        }*/

        //public
    }
}