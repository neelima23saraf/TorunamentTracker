using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitilizeConnection(bool database, bool textfile)
        {
            if (database)
            {
                // TODO - setup the connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);

            }
            if (textfile)
            { 
                // TODO -  set up the connector properly
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}
