using BlazorCrudDotNet8.Components.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudDotNet8.Components.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
         : base(options)
        {
        
        }

        public DbSet<Game> Games {  get; set; }
    }
}
