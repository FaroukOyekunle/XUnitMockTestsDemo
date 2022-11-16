using MockingUnitTestsDemoApp.Implementation.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockingUnitTestsDemoApp.Implementation.Models
{
    public class TeamSearch
    {
        [Required]
        [Range(1, 1000)]
        public int LeagueID { get; set; }
        public DateTime FoundingDate { get; set; }
        public SearchDateDirection Direction { get; set; }
        public List<Team> Results { get; set; }
    }
}
