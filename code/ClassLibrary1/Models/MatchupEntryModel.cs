namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in a Tournamnet 
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represent score for this team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// represent previous matchup that this team won
        /// </summary>
        public MatchupModel ParentModel{ get; set; }
    }
}