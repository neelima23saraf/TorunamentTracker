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
     // TODO  - implement Create Prize   
     /// <summary>
     ///Save a new pize to the database 
     /// </summary>
     /// <param name="model">The prize information</param>
     /// <returns></returns> The prize information including ID
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
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
    }
}
