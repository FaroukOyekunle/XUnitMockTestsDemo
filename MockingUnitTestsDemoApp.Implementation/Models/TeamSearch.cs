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
        // // Property representing the ID of the league to search for teams
        [Required]
        [Range(1, 1000)]
        public int LeagueID { get; set; } 

        // Property representing the founding date to filter teams
        public DateTime FoundingDate { get; set; } 

        // Property representing the direction of the search (e.g., ascending or descending)
        public SearchDateDirection Direction { get; set; }

        // Property representing the list of teams that match the search criteria
        public List<Team> Results { get; set; } 
    }
}