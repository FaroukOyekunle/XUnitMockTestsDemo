using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text;
using System.Threading.Tasks; 

namespace MockingUnitTestsDemoApp.Implementation.Models
{
    public class League
    {
        // Property representing the ID of the league
        public int ID { get; set; } 

        // Property representing the name of the league
        public string Name { get; set; }

        // Property representing the founding date of the league 
        public DateTime FoundingDate { get; set; } 
    }
}