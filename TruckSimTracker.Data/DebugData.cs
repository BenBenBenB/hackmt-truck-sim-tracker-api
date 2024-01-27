using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckSimTracker.Data;
using TruckSimTracker.Data.Models;
using TruckSimTracker.Data.Repositories;

namespace TruckSimTracker.Data
{
    public static class DebugData
    {
        public static async void PopulateTables(TruckSimTrackerRepository repo)
        {
            await PopulateTable(repo, DlcContentData);
        }

        private static async Task PopulateTable<T>(TruckSimTrackerRepository repo, List<T> data) where T : ITruckSimTrackerDataModel, new()
        {
            foreach(var dataItem in data)
            {
                await repo.InsertAsync(dataItem);
            }
        }

        static List<DlcContent> DlcContentData = new() {
            new DlcContent() { Name = "California" },
            new DlcContent() { Name = "Nevada" },
            new DlcContent() { Name = "Arizona" },
        };

    }
}
