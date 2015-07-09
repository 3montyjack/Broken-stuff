using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLB_Basseball_Stats.Models
{
    [Table("PlayerTable")]
    public class Player
    {
        public int Rank { get; set; }

        [Key]
        public string Name { get; set; }

        public string Team { get; set; }

        public string Position { get; set; }

        public int Runs { get; set; }

        public int Hits { get; set; }

        public int HomeRuns { get; set; }

        public int RunsBattedIn { get; set; }

        public decimal BattingAverage { get; set; }
    }
}