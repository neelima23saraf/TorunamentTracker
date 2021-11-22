using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;


namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connections { get; private set; }
        public static void InitilizeConnection(DatabaseType dbType)
        {
            if (dbType == DatabaseType.Sql)
            {
                // TODO - setup the connector properly
                SqlConnector sql = new SqlConnector();
                Connections = sql;

            }
            else if (dbType == DatabaseType.Textfile)
            { 
                // TODO -  set up the connector properly
                TextConnector text = new TextConnector();
                Connections = text;
            }
        }
        public static string CnnString(string name)
        {
            
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

    }
}
