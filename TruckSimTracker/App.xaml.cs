using TruckSimTracker.Data.Repositories;

namespace TruckSimTracker
{
    public partial class App : Application
    {
        public static ITruckSimTrackerRepository Repo { get; private set; }
        public App(ITruckSimTrackerRepository repo)
        {
            InitializeComponent();

            Repo = repo;
            MainPage = new MainPage();
        }
    }
}
