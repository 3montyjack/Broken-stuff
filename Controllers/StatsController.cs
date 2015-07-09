using MLB_Basseball_Stats.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using Context = MLB_Basseball_Stats.Models.Context;

namespace MLB_Basseball_Stats.Controllers
{
    public class StatsController : ApiController
    {
        private StatsController()
        {
            Database.SetInitializer<Context>(null);
        }

        [HttpGet]
        [Route("api/Stats/TeamTable")]
        public IEnumerable<Team> GetSTable()
        {
            using (var db = new Context())
            {
                return db.team.ToList();
            }
        }

        [HttpGet]
        [Route("api/Stats/PlayerTable")]
        public IEnumerable<Player> GetPTable()
        {
            using (var db = new Context())
            {
                return db.player.ToList();
                //return new string[] { "value 1", "value2", "value 3" };
            }
        }
    }
}