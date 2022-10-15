using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{

/// <summary>
/// Interface to be implemented by different type of data connections lik SQL or csv
/// </summary>
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
    }
}
