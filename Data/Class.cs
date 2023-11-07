using Microsoft.EntityFrameworkCore;
using MinimalAPIPostgreSQL_EntityFrame.Models;

namespace MinimalAPIPostgreSQL_EntityFrame.Data
{
  public class OfficeDb : DbContext
  {
    public OfficeDb(DbContextOptions<OfficeDb> options) : base(options)
    {

    }
  public DbSet<Employee> Employees => Set<Employee>();
  }
}
