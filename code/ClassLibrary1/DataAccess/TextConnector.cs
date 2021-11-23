using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelprs;



namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        //TODO  - Wire tup the CreatePrize for text file 
        private const string PrizesFile = "PrizeModels.csv";
        public PrizeModel CreatePrize(PrizeModel model)
        {
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            int currentId = 1;
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            //get the max id 
            model.Id = currentId;
            prizes.Add(model);

            prizes.SaveToPrizeFile(PrizesFile);
            return model;
        }
    }
}
