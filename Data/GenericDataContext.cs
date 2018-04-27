using Microsoft.EntityFrameworkCore;
using dvcsharp_core_api.Models;

namespace dvcsharp_core_api.Data 
{
   public class GenericDataContext : DbContext
   {
      public GenericDataContext(DbContextOptions<GenericDataContext> options) : base(options)
      {
      }

      public DbSet<User> Users { get; set; }
   }
}