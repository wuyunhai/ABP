using System.Linq;
using SecondABP.EntityFramework;
using SecondABP.MultiTenancy;

namespace SecondABP.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly SecondABPDbContext _context;

        public DefaultTenantCreator(SecondABPDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
