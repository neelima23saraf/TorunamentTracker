using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                TextConnction text = new TextConnction();
                Connections.Add(text);
            }
        }
    }
}
