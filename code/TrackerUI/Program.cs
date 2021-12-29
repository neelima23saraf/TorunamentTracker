namespace TrackerUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            TrackerLibrary.GlobalConfig.InitilizeConnection(TrackerLibrary.DataAccess.DatabaseType.Sql);
            Application.Run(new CreateTournament());
            //Application.Run(new CreateTeamForm());
            //Application.Run(new TournamentDashboard());
        }
    }
}