using Microsoft.EntityFrameworkCore;
using restAPI.Models;

namespace restAPI.Context
{
  public class ApiContext : DbContext
  {
    public DbSet<Book> BookEntity { get; set; }

    public ApiContext(DbContextOptions<ApiContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Book>(entity => entity.Property(p => p.ISBN).IsRequired());
    }
  }
}