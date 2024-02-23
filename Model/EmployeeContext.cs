using Microsoft.EntityFrameworkCore;

namespace SqlAPI.Model
{
	public class EmployeeContext : DbContext
	{
        public EmployeeContext(DbContextOptions<EmployeeContext> options): base(options)
        {
            
        }
        public DbSet<TblEmployee> TblEmployee { get; set; }
		public DbSet<TblDesignation> TblDesignation { get; set; }

	}
}
