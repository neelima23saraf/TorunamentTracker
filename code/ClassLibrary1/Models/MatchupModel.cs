namespace TrackerLibrary.Models
{/// <summary>
/// This class holds information about the Matches between two teams, winner and the round
/// </summary>
    public class MatchupModel
    {
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }

    }
}