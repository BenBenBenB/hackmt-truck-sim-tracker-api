using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckSimTracker.Data
{
    public interface ITruckSimTrackerDataModel
    {
        public int Id { get; set; }
        public DateTime Updated { get; set; }
    }
}
