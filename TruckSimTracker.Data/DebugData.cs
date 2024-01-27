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
        static List<State> StateData = new()
        {
            new State() {Id = 1,Name = "Arizona",DlcContentId = 1,Abbreviation = "AZ" },
            new State() {Id = 2,Name = "Arkansas",DlcContentId = 16,Abbreviation = "AR" },
            new State() {Id = 3,Name = "California",DlcContentId = 0,Abbreviation = "CA" },
            new State() {Id = 4,Name = "Colorado",DlcContentId = 10 , Abbreviation = "CO"},
            new State() {Id = 5,Name = "Idaho",DlcContentId = 9,Abbreviation = "ID" },
            new State() {Id = 6,Name = "Kansas",DlcContentId = 14, Abbreviation = "KS"},
            new State() {Id = 7,Name = "Missouri",DlcContentId = 17, Abbreviation = "MO"},
            new State() {Id = 8,Name = "Montana",DlcContentId = 11,Abbreviation = "MT"},
            new State() {Id = 9,Name = "Nebraska",DlcContentId = 15,Abbreviation = "NE" },
            new State() {Id = 10,Name = "New Mexico",DlcContentId = 3,Abbreviation = "NM" },
            new State() {Id = 11,Name = "Nevada ",DlcContentId = 0,Abbreviation = "NV"},
            new State() {Id = 12,Name = "Oregon",DlcContentId = 4,Abbreviation = "OR" },
            new State() {Id = 13,Name = "Texas ",DlcContentId = 12,Abbreviation = "TX" },
            new State() {Id = 14,Name = "Utah",DlcContentId = 8,Abbreviation = "UT" },
                        
        };              
        static List<city> cityData = new() { 

            
        
        
        
        };
    }
}
