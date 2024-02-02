using TruckSimTracker.Data.Model;

namespace TruckSimTracker.Services.BusinessLogic
{
    public static class RequirementHelper
    {
        public static bool CalculateCompletion(Achievement achievement, List<Job> deliveryLog)
        {
            foreach (var req in achievement.Requirements)
            {
                if (!CalculateCompletion(req, deliveryLog)) return false;
            }
            return achievement.Requirements.All(r => r.Fulfilled);
        }

        private static bool CalculateCompletion(Requirement requirement, List<Job> deliveryLog)
        {
            return true; // congrats you won
        }
    }
}
