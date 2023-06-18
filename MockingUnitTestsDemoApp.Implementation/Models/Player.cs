using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 

namespace MockingUnitTestsDemoApp.Implementation.Models
{
    public class Player
    {
        // Property representing the ID of the player
        public int ID { get; set; } 

        // Property representing the first name of the player
        public string FirstName { get; set; } 

        // Property representing the last name of the player
        public string LastName { get; set; } 

        // Property representing the date of birth of the player
        public DateTime DateOfBirth { get; set; } 

        // Property representing the ID of the team the player belongs to
        public int TeamID { get; set; } 
    }
}