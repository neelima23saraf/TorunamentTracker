using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{/// <summary>
/// This is the class name and the list of team members 
/// </summary>
    public class TeamModel
    {
        public List<PersonModel> TeamMember { get; set; } = new List<PersonModel>();
        public string TeamName { get; set; }
    }
}
