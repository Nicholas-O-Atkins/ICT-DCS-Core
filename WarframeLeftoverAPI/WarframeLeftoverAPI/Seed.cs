using WarframeLeftoverAPI.Data;
using WarframeLeftoverAPI.Models;

namespace WarframeLeftoverAPI
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!dataContext.Tenno_Task_Items.Any())
            {
                // TODO
                // Add Item
                // Add Material
                // Add Tenno
                // Add Part Types
                // Add Item Types
                // Add Material Types
                // Add Tenno Ranks

                // Add a test tenno task
            }
        }
    }
}
