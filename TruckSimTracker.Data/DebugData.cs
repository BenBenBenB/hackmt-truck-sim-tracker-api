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
            await PopulateTable(repo, StateData);
            await PopulateTable(repo, CityData);
            await PopulateTable(repo, AchivementsData);
            await PopulateTable(repo, DepotData);
            await PopulateTable(repo, DriverlogData); 
        }

        private static async Task PopulateTable<T>(TruckSimTrackerRepository repo, List<T> data) where T : ITruckSimTrackerDataModel, new()
        {
            foreach (var dataItem in data)
            {
                await repo.InsertAsync(dataItem);
            }
        }

        static List<DlcContent> DlcContentData = new() 
        {
            new DlcContent() { Id = 18,Name = "Base Game" },
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
            new State() {Id =  1, Name = "Arizona",DlcContentId = 1,Abbreviation = "AZ" },
            new State() {Id =  2, Name = "Arkansas",DlcContentId = 16,Abbreviation = "AR" },
            new State() {Id =  3, Name = "California",DlcContentId = 18,Abbreviation = "CA" },
            new State() {Id =  4, Name = "Colorado",DlcContentId = 10 , Abbreviation = "CO"},
            new State() {Id =  5, Name = "Idaho",DlcContentId = 9,Abbreviation = "ID" },
            new State() {Id =  6, Name = "Kansas",DlcContentId = 14, Abbreviation = "KS"},
            new State() {Id =  7, Name = "Missouri",DlcContentId = 17, Abbreviation = "MO"},
            new State() {Id =  8, Name = "Montana",DlcContentId = 11,Abbreviation = "MT"},
            new State() {Id =  9, Name = "Nebraska",DlcContentId = 15,Abbreviation = "NE" },
            new State() {Id = 10, Name = "New Mexico",DlcContentId = 3,Abbreviation = "NM" },
            new State() {Id = 11, Name = "Nevada ",DlcContentId = 18,Abbreviation = "NV"},
            new State() {Id = 12, Name = "Oregon",DlcContentId = 4,Abbreviation = "OR" },
            new State() {Id = 13, Name = "Texas ",DlcContentId = 12,Abbreviation = "TX" },
            new State() {Id = 14, Name = "Utah",DlcContentId = 8,Abbreviation = "UT" },

        };
        static List<City> CityData = new() {
            new City() {Id =  1, StateId = 3, Name = "Backersfield" },
            new City() {Id =  2, StateId = 3, Name = "Barstow" },
            new City() {Id =  3, StateId = 3, Name = "Carlsbad" },
            new City() {Id =  4, StateId = 3, Name = "El Centro" },
            new City() {Id =  5, StateId = 3, Name = "Eureka" },
            new City() {Id =  6, StateId = 3, Name = "Fresno" },
            new City() {Id =  7, StateId = 3, Name = "Hilt" },
            new City() {Id =  8, StateId = 3, Name = "Huron" },
            new City() {Id =  9, StateId = 3, Name = "Los Angeles" },
            new City() {Id = 10, StateId = 3, Name = "Oakland" },
            new City() {Id = 11, StateId = 3, Name = "Oxnard" },
            new City() {Id = 12, StateId = 3, Name = "Redding" },
            new City() {Id = 13, StateId = 3, Name = "Sacramento" },
            new City() {Id = 14, StateId = 3, Name = "San Deigo" },
            new City() {Id = 15, StateId = 3, Name = "San Fransisco" },
            new City() {Id = 16, StateId = 3, Name = "Santa Cruz" },
            new City() {Id = 17, StateId = 3, Name = "Santa Maria" },
            new City() {Id = 18, StateId = 3, Name = "Stockton" },
            new City() {Id = 19, StateId = 3, Name = "Truckee" },
            new City() {Id = 20, StateId = 3, Name = "Ukiah" },
            new City() {Id = 21, StateId = 11, Name = "Carson City" },
            new City() {Id = 22, StateId = 11, Name = "Elko" },
            new City() {Id = 23, StateId = 11, Name = "Ely" },
            new City() {Id = 24, StateId = 11, Name = "Jackpot" },
            new City() {Id = 25, StateId = 11, Name = "Las Vegas" },
            new City() {Id = 26, StateId = 11, Name = "Pioche" },
            new City() {Id = 27, StateId = 11, Name = "Primm" },
            new City() {Id = 28, StateId = 11, Name = "Reno" },
            new City() {Id = 29, StateId = 11, Name = "Tonopah" },
            new City() {Id = 30, StateId = 11, Name = "Winnemucca" }
        };

        static List<Achivement> AchivementsData = new()
        {
            new Achivement() {Id = 1, Name = "Cha-Ching", Description = "Earn $100,000 Delivering Cargo"},
            new Achivement() {Id = 2, Name = "Gas Guzzeler", Description = "Use a Gas Station"},
            new Achivement() {Id = 3, Name = "What's your BMI?", Description = "Use a Weight Station"},
        };

        static List<Depot> DepotData = new()
        {
            new Depot() {Id = 1, CityId = 3, Name = "FedEx"},
            new Depot() {Id = 2, CityId = 15, Name = "SFO Airport" },
        };

        static List<Job> DriverlogData = new()
        {
            new Job() {Id = 1, Company = "FedEx", StartDepotId = 1, EndDepotId = 2 },
        };


    }
}
