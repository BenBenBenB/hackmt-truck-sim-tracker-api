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
        public static async Task PopulateTables(TruckSimTrackerRepository repo)
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
            new DlcContent() { Id = 0,Name = "Base Game" },
            new DlcContent() { Id = 1,Name = "Arizona" },
            new DlcContent() { Id = 2,Name = "Heavy Cargo Pack" },
            new DlcContent() { Id = 3,Name = "New Mexico" },
            new DlcContent() { Id = 4,Name = "Oregon" },
            new DlcContent() { Id = 5,Name = "Special Transport" },
            new DlcContent() { Id = 6,Name = "Washington" },
            new DlcContent() { Id = 7,Name = "Forest Machinery" },
            new DlcContent() { Id = 8,Name = "Utah" },
            new DlcContent() { Id = 9,Name = "Idaho" },
            new DlcContent() { Id = 10,Name = "Colorado" },
            new DlcContent() { Id = 11,Name = "Montana" },
            new DlcContent() { Id = 12,Name = "Texas" },
            new DlcContent() { Id = 13,Name = "Oklahoma" },
            new DlcContent() { Id = 14,Name = "Kansas" },
            new DlcContent() { Id = 15,Name = "Nebraska" },
            new DlcContent() { Id = 16,Name = "Arkansas" },
            new DlcContent() { Id = 17,Name = "Missouri" },
        };                     
        static List<stte> stteData = new()
        {
            new stte() {Id = 1,Name = "Arizona",DlcId = 1,abrev = "AZ" },
            new stte() {Id = 2,Name = "Arkansas",DlcId = 16,abrev = "AR" },
            new stte() {Id = 3,Name = "California",DlcId = 0,abrev = "CA" },
            new stte() {Id = 4,Name = "Colorado",DlcId = 10 , abrev = "CO"},
            new stte() {Id = 5,Name = "Idaho",DlcId = 9,abrev = "ID" },
            new stte() {Id = 6,Name = "Kansas",DlcId = 14, abrev = "KS"},
            new stte() {Id = 7,Name = "Missouri",DlcId = 17, abrev = "MO"},
            new stte() {Id = 8,Name = "Montana",DlcId = 11,abrev = "MT"},
            new stte() {Id = 9,Name = "Nebraska",DlcId = 15,abrev = "NE" },
            new stte() {Id = 10,Name = "New Mexico",DlcId = 3,abrev = "NM" },
            new stte() {Id = 11,Name = "Nevada ",DlcId = 0,abrev = "NV"},
            new stte() {Id = 12,Name = "Oregon",DlcId = 4,abrev = "OR" },
            new stte() {Id = 13,Name = "Texas ",DlcId = 12,abrev = "TX" },
            new stte() {Id = 14,Name = "Utah",DlcId = 8,abrev = "UT" },
                        
        };              
        static List<city> cityData = new() { 

            
        
        
        
        };
    }
}
