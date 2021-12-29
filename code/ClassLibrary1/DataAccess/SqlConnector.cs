 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using System.Data;
using Dapper;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string db = "Tournaments";

        /// <summary>
        ///Save a new pize to the database 
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns></returns> The prize information including ID
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var prizeModel = new DynamicParameters();
                prizeModel.Add("@PlaceNumber", model.PlaceNumber);
                prizeModel.Add("@PlaceName", model.PlaceName);
                prizeModel.Add("@PrizeAmount", model.PrizeAmount);
                prizeModel.Add("@PrizePercentage", model.PrizePercentage);
                prizeModel.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_insert", prizeModel, commandType: CommandType.StoredProcedure);
                model.Id = prizeModel.Get<int>("@id");
                return model;

            }

        }

        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var personModel = new DynamicParameters();
                personModel.Add("@FirstName", model.FirstName);
                personModel.Add("@LastName", model.LastName);
                personModel.Add("@EmailAddress", model.EmailAddress);
                personModel.Add("@CellphoneNumber", model.CellphoneNumber);
                personModel.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                conn.Execute("[dbo].[spPeople_insert]", personModel, commandType: CommandType.StoredProcedure);
                model.Id = personModel.Get<int>("@id");
                return model;
            }

        }

        public List<PersonModel>  GetAllPerson()
        {
            List<PersonModel> persons = new List<PersonModel>();
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                persons = conn.Query<PersonModel>("[dbo].[spPeople_GetAll]").ToList();
            }
            return persons;
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            //insert into Teams table and get the TeamId
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var teamModel = new DynamicParameters();
                teamModel.Add("@TeamName", model.TeamName);
                teamModel.Add("@id",0, DbType.Int32, direction:ParameterDirection.Output);
                
                conn.Execute("dbo.spTeam_insert",teamModel, commandType: CommandType.StoredProcedure);
                model.Id = teamModel.Get<int>("@id");

                // insert into TeamMembers table with the Team Id and the Person Id
                foreach (PersonModel p in model.TeamMember)
                {
                    teamModel = new DynamicParameters();
                    teamModel.Add("@TeamId", model.Id);
                    teamModel.Add("@PersonId", p.Id);
                    teamModel.Add("@id", 0, DbType.Int32, direction: ParameterDirection.Output);

                    conn.Execute("spTeamMembers_insert", teamModel, commandType: CommandType.StoredProcedure);
                    

                }
            }

            
            return model;
        }

        public List<TeamModel> GetTeams()
        {
            List<TeamModel> teams = new List<TeamModel>();
            
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                teams = connection.Query<TeamModel>("spTeam_GetAll").ToList();

                foreach (var t in teams)
                {
                    var personId = new DynamicParameters();
                    personId.Add("@PersonId", t.Id);

                    t.TeamMember = connection.Query<PersonModel>("spTeamMembers_Get", personId, commandType: CommandType.StoredProcedure).ToList(); 
                }
            }

            return teams;
        }
    }
    
}


