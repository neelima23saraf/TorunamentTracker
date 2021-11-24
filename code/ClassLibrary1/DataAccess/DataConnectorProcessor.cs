using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelprs { 
    //load the text file 
    //read the text file in a list <PrizeModel>

    //insert new record with the max id + 1
    //conver  PrizeModel to List<strings>
    //save the  list <stirngs> to text files
    public static class DataConnectorProcessor
    {
        //load the text file 
        public static string FullFilePath(this string fileName)
        {
            return $"{ ConfigurationManager.AppSettings["filePath"] }\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        //read the text file in a list <PrizeModel>
        /// <summary>
        /// Conver PrizeModel to list of strings
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        { 
            List<PrizeModel> prizeModels = new List<PrizeModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PrizeModel p = new PrizeModel();

                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);

                prizeModels.Add(p);
            }
            return prizeModels;
        }

        public static void SaveToPrizeFile(this List<PrizeModel> prizeModel, string fileName)
        {
            List<string> line = new List<string>();
            foreach (PrizeModel p in prizeModel)
            {
                line.Add($"{p.Id},{ p.PlaceNumber },{ p.PlaceName },{p.PrizeAmount},{p.PrizePercentage}");
                
            }
            File.WriteAllLines(fileName.FullFilePath(), line);
        }
        /// <summary>
        /// conver  Person Model to List of strings
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> personModels = new List<PersonModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PersonModel p = new PersonModel();

                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellphoneNumber = cols[4];

                personModels.Add(p);
                
            }
            return personModels;
        }

        public static void SaveToPersonFile(this List<PersonModel> personModel, string fileName)
        {
            List<string> line = new List<string>();
            foreach (PersonModel p in personModel)
            {
                line.Add($"{p.Id},{ p.FirstName},{ p.LastName},{p.EmailAddress},{p.CellphoneNumber}");

            }
            File.WriteAllLines(fileName.FullFilePath(), line);
        }
    }
}
