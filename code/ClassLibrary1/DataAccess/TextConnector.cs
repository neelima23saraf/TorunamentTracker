﻿using System;
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
        
        private const string PrizesFile = "PrizeModels.csv";
        private const string PersonFile = "PersonModels.csv";

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

        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> person = PersonFile.FullFilePath().LoadFile().ConvertToPersonModels();
            int currentId = 1;
            if (person.Count > 0)
            {
                currentId = person.OrderByDescending(x => x.Id).First().Id + 1;
            }
            //get the max id 
            model.Id = currentId;
            person.Add(model);

            person.SaveToPersonFile(PersonFile);
            return model;
        }
    }
}
