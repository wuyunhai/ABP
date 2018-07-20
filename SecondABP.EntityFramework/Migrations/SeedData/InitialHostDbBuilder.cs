using SecondABP.EntityFramework;
using EntityFramework.DynamicFilters;

namespace SecondABP.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly SecondABPDbContext _context;

        public InitialHostDbBuilder(SecondABPDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
