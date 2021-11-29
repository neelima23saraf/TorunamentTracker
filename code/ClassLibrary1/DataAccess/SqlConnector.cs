﻿ using System;
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
        
    

         
    }
    
}


