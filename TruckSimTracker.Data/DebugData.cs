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
            await PopulateTable(repo, AchievementsData);
            await PopulateTable(repo, DepotData);
            await PopulateTable(repo, DriverlogData);
            await PopulateTable(repo, CargoData);
            await PopulateTable(repo, CargoTypeData);
            

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
            new City() {Id = 15, StateId = 3, Name = "San Francisco" },
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

        static List<Achievement> AchievementsData = new()
        {            
            new Achievement() {Id = 1, Name = "Cha-Ching", Description = "Earn $100,000 Delivering Cargo", ImageUrl = "../images/achievements/Cha-Ching.webp"},
            new Achievement() {Id = 2, Name = "Gas Guzzeler", Description = "Use a Gas Station", ImageUrl = "../images/achievements/GasGuzzler.webp"},
            new Achievement() {Id = 3, Name = "What's your BMI?", Description = "Use a Weight Station", ImageUrl = "../images/achievements/Bmi.webp"},
            new Achievement() {Id = 4, StateId = 3, Name = "California Dreamin'", Description = "Discover Every City in California", ImageUrl = "../images/achievements/california.webp"},
            new Achievement() {Id = 5, StateId = 3, CityId = 15, Name = "Sea Dog", Description = "Deliver Cargo to a Port in Oakland and a Port in San Francisco", ImageUrl = "../images/achievements/SeaDog.webp"},
            new Achievement() {Id = 6, StateId = 3, Name = "Cheers!", Description = "Discover Three Vineyards in California", ImageUrl = "../images/achievements/Cheers.webp"},
            new Achievement() {Id = 7, Name = "Warming Up", Description = "Drive 10,000 Miles During Deliveries", ImageUrl = "../images/achievements/Warming up.webp"},
            new Achievement() {Id = 8, Name = "Rig Master", Description = "Own Your Own Truck", ImageUrl = "../images/achievements/Rig Master.webp"},
            new Achievement() {Id = 9, Name = "Company Collector", Description = "Preform Deliveries for at Least Fifteen Different Companies", ImageUrl = "../images/achievements/CompanyCollector.webp" },
            new Achievement() {Id = 10, Name = "High Five", Description = "Complete a Perfect Delivery (no damage, no fines, in-time) For a Job That is at Least 600 Miles", ImageUrl = "../images/achievements/HighFive.webp"},
            new Achievement() {Id = 11, Name = "Final Makeover", Description = "Fully Upgrade one of your Garages", ImageUrl = "../images/achievements/FinalMakeover.webp"}, 
            new Achievement() {Id = 12, Name = "Not a Problem", Description = "Successfully Park a Trailer at a Delivery Point", ImageUrl = "../images/achievements/NotAProblem.webp"},
            new Achievement() {Id = 13, Name = "Like a Boss", Description = "Successfully Park a Trailer at a Hard Delivery Point", ImageUrl = "../images/achievements/LikeABoss.webp"},
            new Achievement() {Id = 14, Name = "I Think I Like It", Description = "Finish 50 Deliveries", ImageUrl = "../images/achievements/IThink.webp"},
            new Achievement() {Id = 15, Name = "Pimp MY Truck", Description = "Buy and Apply a Custom Paint Job", ImageUrl = "../images/achievements/PimpMy.webp"},
            new Achievement() {Id = 16, StateId = 11, Name = "Silver State", Description = "Discover Every City in Nevada", ImageUrl = "../images/achievements/SilverState.webp"},
            new Achievement() {Id = 17, StateId = 11, Name = "Gold Fever", Description = "Deliver Cargo to Both Quarries in Nevada",ImageUrl = "../images/achievements/Gold Fever.webp"},
            new Achievement() {Id = 18, Name = "Parking Challenge", Description = "Complete Twenty Deliveries Choosing the Trailer Delivery Option Which Requires Reversing", ImageUrl = "../images/achievements/ParkingChallenge.webp"}
        
        };

        static List<Depot> DepotData = new()
        {
            new Depot() {Id = 1, CityId = 9, Name = "42 Print"},
            new Depot() {Id = 2, CityId = 14, Name = "42 Print" },
            new Depot() {Id = 3, CityId = 25, Name = "42 Print" },
            new Depot() {Id = 4, CityId = 1, Name = "Bitumen" },
            new Depot() {Id = 5, CityId = 2, Name = "Bitumen" },
            new Depot() {Id = 6, CityId = 9, Name = "Bitumen" },
            new Depot() {Id = 7, CityId = 11, Name = "Bitumen" },
            new Depot() {Id = 8, CityId = 14, Name = "Bitumen" },
            new Depot() {Id = 9, CityId = 17, Name = "Bitumen" },
            new Depot() {Id = 10, CityId = 19, Name = "Bitumen" },
            new Depot() {Id = 11, CityId = 20, Name = "Bitumen" },
            new Depot() {Id = 12, CityId = 25, Name = "Bitumen" },
            new Depot() {Id = 13, CityId = 30, Name = "Bitumen" },
            new Depot() {Id = 14, CityId = 6, Name = "Bushnell Farms" },
            new Depot() {Id = 15, CityId = 12, Name = "Bushnell Farms" },
            new Depot() {Id = 16, CityId = 13, Name = "Charged" },
            new Depot() {Id = 17, CityId = 15, Name = "Charged" },
            new Depot() {Id = 18, CityId = 21, Name = "Charged" },
            new Depot() {Id = 19, CityId = 25, Name = "Charged" },
            new Depot() {Id = 20, CityId = 1, Name = "Chemso" },
            new Depot() {Id = 21, CityId = 11, Name = "Chemso" },
            new Depot() {Id = 22, CityId = 12, Name = "Chemso" },
            new Depot() {Id = 23, CityId = 27, Name = "Charged" },
            new Depot() {Id = 24, CityId = 2, Name = "Coastline Mining" },
            new Depot() {Id = 25, CityId = 16, Name = "Coastline Mining" },
            new Depot() {Id = 26, CityId = 13, Name = "Coastline Mining" },
            new Depot() {Id = 27, CityId = 12, Name = "Coastline Mining" },
            new Depot() {Id = 28, CityId = 17, Name = "Coastline Mining" },
            new Depot() {Id = 29, CityId = 18, Name = "Coastline Mining" },
            new Depot() {Id = 30, CityId = 21, Name = "Coastline Mining" },
            new Depot() {Id = 31, CityId = 22, Name = "Coastline Mining" },
            new Depot() {Id = 32, CityId = 26, Name = "Coastline Mining" },
            new Depot() {Id = 33, CityId = 3, Name = "Darchelle Uzau" },
            new Depot() {Id = 34, CityId = 5, Name = "Deepgrove" },
            new Depot() {Id = 35, CityId = 19, Name = "Deepgrove" },
            new Depot() {Id = 36, CityId = 5, Name = "Drake Car Dealer" },
            new Depot() {Id = 37, CityId = 12, Name = "Drake Car Dealer" },
            new Depot() {Id = 38, CityId = 2, Name = "Eddy's" },
            new Depot() {Id = 39, CityId = 9, Name = "Eddy's" },
            new Depot() {Id = 40, CityId = 11, Name = "Eddy's" },
            new Depot() {Id = 41, CityId = 14, Name = "Eddy's" },
            new Depot() {Id = 42, CityId = 15, Name = "Eddy's" },
            new Depot() {Id = 43, CityId = 22, Name = "Eddy's" },
            new Depot() {Id = 44, CityId = 25, Name = "Eddy's" },
            new Depot() {Id = 45, CityId = 28, Name = "Eddy's" },
            new Depot() {Id = 46, CityId = 6, Name = "Gallon Oli" },
            new Depot() {Id = 47, CityId = 9, Name = "Gallon Oli" },
            new Depot() {Id = 48, CityId = 11, Name = "Gallon Oli" },
            new Depot() {Id = 49, CityId = 23, Name = "Gallon Oli" },
            new Depot() {Id = 50, CityId = 30, Name = "Gallon Oli" },

        };

        static List<Job> DriverlogData = new()
        {
            new Job() {Id = 1, Company = "FedEx", StartDepotId = 1, EndDepotId = 2},
        };

        static List<CargoType> CargoTypeData = new()
        {
            new CargoType() {Id = 1, Name = "Massive Bomb", DlcContentId = 5},
            new CargoType() {Id = 2, Name = "Heavy Machinery", DlcContentId = 7},
        };

        static List<Cargo> CargoData = new()
        {
            new Cargo() {Id = 1, Name = "Weapon of Mass Destruction", CargoTypeId = 1},
            new Cargo() {Id = 2, Name = "Backloader", CargoTypeId = 2}, 
        };

    }
}
