using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 

namespace MockingUnitTestsDemoApp.Implementation.Models
{
    public class Team
    {
        // Property representing the ID of the team
        public int ID { get; set; } 

        // Property representing the name of the team
        public string Name { get; set; } 

        // Property representing the ID of the league the team belongs to
        public int LeagueID { get; set; } 

        // Property representing the founding date of the team
        public DateTime FoundingDate { get; set; } 
    }
}