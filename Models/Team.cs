using System.ComponentModel.DataAnnotations.Schema;

namespace MLB_Basseball_Stats.Models
{
    [Table("TeamTable")]
    public class Team
    {
        public int Rank { get; set; }

        public string Name { get; set; }

        public string TeamID { get; set; }

        public string League { get; set; }

        public int Games { get; set; }

        public int HomeRuns { get; set; }

        public int RunsBattedIn { get; set; }

        public int Runs { get; set; }

        public int Hits { get; set; }

        public decimal AverageBattingAverage { get; set; }
    }
}