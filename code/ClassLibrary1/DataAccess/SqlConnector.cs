using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

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
            model.Id = 1;
            return model;
            //throw new NotImplementedException();
        }
    }
}
